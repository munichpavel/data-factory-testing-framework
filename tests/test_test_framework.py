import json
import pathlib

import pytest
from data_factory_testing_framework import TestFramework, TestFrameworkType
from data_factory_testing_framework.exceptions import (
    DataflowNotFoundError,
    NoRemainingPipelineActivitiesMeetDependencyConditionsError,
)
from data_factory_testing_framework.models import DataFactoryElement, Pipeline
from data_factory_testing_framework.models.activities import FailActivity, SetVariableActivity


def test_circular_dependency_between_activities_should_throw_error() -> None:
    # Arrange
    test_framework = TestFramework(TestFrameworkType.Fabric)
    pipeline = Pipeline(
        pipeline_id="some-id",
        name="main",
        parameters={},
        variables={},
        activities=[
            SetVariableActivity(
                name="setVariable1",
                variable_name="variable",
                typeProperties={
                    "variableName": "variable",
                    "value": DataFactoryElement("'1'"),
                },
                dependsOn=[
                    {
                        "activity": "setVariable2",
                        "dependencyConditions": [
                            "Succeeded",
                        ],
                    }
                ],
            ),
            SetVariableActivity(
                name="setVariable2",
                variable_name="variable",
                typeProperties={
                    "variableName": "variable",
                    "value": DataFactoryElement("'1'"),
                },
                dependsOn=[
                    {
                        "activity": "setVariable1",
                        "dependencyConditions": [
                            "Succeeded",
                        ],
                    }
                ],
            ),
        ],
    )
    test_framework._repository.pipelines.append(pipeline)

    # Act & Assert
    with pytest.raises(NoRemainingPipelineActivitiesMeetDependencyConditionsError):
        next(test_framework.evaluate_pipeline(pipeline, []))


def test_fail_activity_halts_further_evaluation() -> None:
    # Arrange
    test_framework = TestFramework(TestFrameworkType.Fabric)
    pipeline = Pipeline(
        pipeline_id="some-id",
        name="main",
        parameters={},
        variables={},
        activities=[
            SetVariableActivity(
                name="setVariable1",
                variable_name="variable",
                typeProperties={
                    "variableName": "variable",
                    "value": DataFactoryElement("'1'"),
                },
                dependsOn=[
                    {
                        "activity": "failActivity",
                        "dependencyConditions": [
                            "Succeeded",
                        ],
                    }
                ],
            ),
            FailActivity(
                name="failActivity",
                typeProperties={
                    "message": DataFactoryElement("@concat('Error code: ', '500')"),
                    "errorCode": "500",
                },
                dependsOn=[],
            ),
        ],
    )
    test_framework._repository.pipelines.append(pipeline)

    # Act
    activities = test_framework.evaluate_pipeline(pipeline, [])

    # Assert
    activity = next(activities)
    assert activity is not None
    assert activity.name == "failActivity"
    assert activity.type == "Fail"
    assert activity.status == "Failed"
    assert activity.type_properties["message"].result == "Error code: 500"
    assert activity.type_properties["errorCode"] == "500"

    # Assert that there are no more activities
    with pytest.raises(StopIteration):
        next(activities)


def test_test_factory_loads_dataflows(tmp_path: pathlib.Path) -> None:
    # Arrange
    dataflow_content = """{
	"name": "SampleDataflow",
	"properties": {
		"type": "MappingDataFlow",
		"typeProperties": {
			"sources": [
				{
					"dataset": {
						"referenceName": "adls_test_source_example",
						"type": "DatasetReference"
					},
					"name": "source"
				}
			],
			"sinks": [
				{
					"dataset": {
						"referenceName": "adls_test_sink_example",
						"type": "DatasetReference"
					},
					"name": "sink"
				}
			],
			"transformations": [],
			"scriptLines": [
				"source(output(",
				"          Vorname as string,",
				"          Name as string,",
				"          Adresse as string",
				"     ),",
				"     allowSchemaDrift: true,",
				"     validateSchema: false,",
				"     ignoreNoFilesFound: false) ~> source",
				"source sink(allowSchemaDrift: true,",
				"     validateSchema: false,",
				"     input(",
				"          Vorname as string,",
				"          Name as string,",
				"          Adresse as string",
				"     ),",
				"     umask: 0022,",
				"     preCommands: [],",
				"     postCommands: [],",
				"     skipDuplicateMapInputs: true,",
				"     skipDuplicateMapOutputs: true) ~> sink"
			]
		}
	}
}
"""

    dataflow_dict = json.loads(dataflow_content)
    dataflow_name = dataflow_dict["name"]

    repo_dir = tmp_path / "test-repo"
    repo_dir.mkdir()

    for folder_name in ["pipeline", "dataflow"]:
        subfolder = repo_dir / folder_name
        subfolder.mkdir(parents=True)

    with open(repo_dir / "dataflow" / (dataflow_name + ".json"), "w") as fp:
        fp.write(dataflow_content)
    framework = TestFramework(framework_type=TestFrameworkType.DataFactory, root_folder_path=repo_dir)
    print((repo_dir / "dataflow"))
    print(framework._repository.dataflows)

    # Act
    dataflow_name = "SampleDataflow"
    dataflow = framework.get_dataflow_by_name(dataflow_name)

    # Assert
    expected_dataflow_type = "MappingDataFlow"
    assert dataflow.type == expected_dataflow_type

    with pytest.raises(DataflowNotFoundError):
        # Act and assert
        framework.get_dataflow_by_name("nonexistent-data-schlepping-dataflow")

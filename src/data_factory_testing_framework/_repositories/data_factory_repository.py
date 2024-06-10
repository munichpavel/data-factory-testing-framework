from typing import List

from data_factory_testing_framework.exceptions import DataflowNotFoundError, PipelineNotFoundError
from data_factory_testing_framework.models import Dataflow, Pipeline


class DataFactoryRepository:
    def __init__(self, pipelines: List[Pipeline], dataflows: List[Dataflow]) -> None:
        """Initializes the repository with pipelines, dataflows, linkedServices, datasets and triggers.

        Args:
            pipelines: List of pipelines.
            dataflows: List of dataflows.
        """
        self.pipelines = pipelines
        self.dataflows = dataflows

    def get_pipeline_by_id(self, pipeline_id: str) -> Pipeline:
        """Get a pipeline by id. Throws an exception if the pipeline is not found.

        Args:
            pipeline_id: The identifier of the pipeline to get.

        Returns:
            The pipeline with the given id.
        """
        for pipeline in self.pipelines:
            if pipeline.pipeline_id == pipeline_id:
                return pipeline

        raise PipelineNotFoundError(f"Pipeline with pipeline_id: '{pipeline_id}' not found")

    def get_pipeline_by_name(self, name: str) -> Pipeline:
        """Get a pipeline by name. Throws an exception if the pipeline is not found.

        Args:
            name: Name of the pipeline.
        """
        for pipeline in self.pipelines:
            if pipeline.name == name:
                return pipeline

        raise PipelineNotFoundError(f"Pipeline with name: '{name}' not found")

    def get_dataflow_by_name(self, name: str) -> Dataflow:
        """Get a dataflow by name. Throws an exception if the dataflow is not found.

        Args:
            name: Name of the dataflow.
        """
        for dataflow in self.dataflows:
            if dataflow.name == name:
                return dataflow

        raise DataflowNotFoundError(f"Dataflow with name: '{name}' not found")

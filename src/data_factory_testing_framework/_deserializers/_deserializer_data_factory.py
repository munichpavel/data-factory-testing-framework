import json

from data_factory_testing_framework._deserializers._deserializer_base import (
    _parse_dataflow_from_json,
    _parse_pipeline_from_json,
)
from data_factory_testing_framework.models import Dataflow, Pipeline


def parse_data_factory_pipeline_from_pipeline_json(pipeline_json: str) -> Pipeline:
    json_data = json.loads(pipeline_json)
    name = json_data["name"]

    # The name is used as the id, because this is how Azure Data Factory uniquely identifies pipelines
    return _parse_pipeline_from_json(name, name, json_data)


def parse_data_factory_dataflow_from_dataflow_json(dataflow_json: str) -> Dataflow:
    json_data = json.loads(dataflow_json)
    name = json_data["name"]

    # The name is used as the id, because this is how Azure Data Factory uniquely identifies pipelines
    return _parse_dataflow_from_json(name, json_data)

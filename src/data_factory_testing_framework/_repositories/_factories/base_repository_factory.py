from abc import ABC, abstractmethod

from data_factory_testing_framework._repositories.data_factory_repository import DataFactoryRepository
from data_factory_testing_framework.models import Dataflow, Pipeline


class BaseRepositoryFactory(ABC):
    def parse_from_folder(self, folder_path: str) -> DataFactoryRepository:
        pipelines = self._get_data_factory_pipelines_by_folder_path(folder_path)
        dataflows = self._get_data_factory_dataflows_by_folder_path(folder_path)
        return DataFactoryRepository(pipelines, dataflows)

    @abstractmethod
    def _get_data_factory_pipelines_by_folder_path(self, folder_path: str) -> list[Pipeline]:
        pass

    @abstractmethod
    def _get_data_factory_dataflows_by_folder_path(self, folder_path: str) -> list[Dataflow]:
        pass

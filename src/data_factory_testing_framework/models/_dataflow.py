from typing import Any


class Dataflow:
    def __init__(
        self,
        name: str,
        **kwargs: Any,  # noqa: ANN401
    ) -> None:
        """This is the class that represents a dataflow.

        Args:
            name: Name of the dataflow.
            **kwargs: Dataflow properties coming directly from the json representation of the dataflow.
        """
        self.name = name
        self.type = kwargs["type"]
        self.type_properties = kwargs["typeProperties"]

from typing import List

from data_factory_testing_framework.exceptions.function_call_invalid_arguments_count_error import \
    FunctionCallInvalidArgumentsCountError
from data_factory_testing_framework.exceptions.unsupported_function_error import UnsupportedFunctionError
from data_factory_testing_framework.functions.functions_repository import FunctionsRepository


class FunctionCall:
    function_names_with_all_arguments_as_list = ["concat"]

    def __init__(self, name: str, arguments: List):
        self.name = name
        self.arguments = arguments

    def evaluate(self, state):
        function = FunctionsRepository.functions.get(self.name)
        if not function:
            raise UnsupportedFunctionError(self.name)

        evaluated_arguments = []
        for argument in self.arguments:
            evaluated_arguments.append(argument.evaluate(state))

        if self.name in FunctionCall.function_names_with_all_arguments_as_list:
            return function(evaluated_arguments)

        # Validate that the number of arguments is correct
        if len(evaluated_arguments) != function.__code__.co_argcount:
            raise FunctionCallInvalidArgumentsCountError(self.name, evaluated_arguments, function.__code__.co_varnames)

        return function(*evaluated_arguments)
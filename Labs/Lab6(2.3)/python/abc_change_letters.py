from abc import ABC, abstractmethod

#interface for the class that will change letters in a string
class ABC_ChangeText(ABC):
    @property
    @abstractmethod
    def length(self) -> int:
        pass

    @abstractmethod
    def replace(self, old_char: str, new_char: str) -> None:
        pass

    @abstractmethod
    def contains(self, substring: str) -> bool:
        pass

    @abstractmethod
    def get_content(self) -> str:
        pass
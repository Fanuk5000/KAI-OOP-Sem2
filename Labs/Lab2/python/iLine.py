from abc import ABC, abstractmethod #Abstract Base Class

class ILine(ABC):
    @abstractmethod
    def __init__(self, *args):
        pass
    
    # @abstractmethod
    # def copy_line(self):
    #     pass
    
    @abstractmethod
    def get_line(self):
        pass
    
    @abstractmethod
    def sort_descending(self):
        pass
    
    @abstractmethod
    def get_lenght(self):
        pass
    
    @abstractmethod
    def __del__(self):
        pass

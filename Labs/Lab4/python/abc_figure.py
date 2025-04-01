from abc import ABC, abstractmethod

class ABC_Figure(ABC):
    
    @abstractmethod
    def __init__(self, *args):
        pass
    
    @abstractmethod
    def get_side(self):
        pass
        
    @abstractmethod
    def get_cords(self):
        pass
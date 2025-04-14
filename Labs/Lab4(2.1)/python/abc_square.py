from abc_figure import ABC_Figure, abstractmethod

class ABC_square(ABC_Figure):
    @abstractmethod
    def area(self):
        pass
    
    @abstractmethod
    def perimetr(self):
        pass
    
    @abstractmethod
    def get_side_length(self):
        pass

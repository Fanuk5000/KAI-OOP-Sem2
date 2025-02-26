from abc import ABC, abstractmethod

class ABS_Triangle(ABC):
    
    @abstractmethod
    def __init__(self):
        pass
    
    @abstractmethod
    def calculate_area(self):
        pass
    
    @abstractmethod
    def calculate_perimeter(self):
        pass
    
    @abstractmethod
    def __add__(self, other):
        pass
    
    @abstractmethod
    def __mul__(self, other):
        pass
    
    @abstractmethod
    def x(self):
        pass
    
    @abstractmethod
    def x(self, new_x):
        pass
    
    @abstractmethod
    def y(self):
        pass
    
    @abstractmethod
    def y(self, new_y):
        pass    
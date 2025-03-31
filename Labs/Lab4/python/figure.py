from abc_figure import ABC_Figure
from string import ascii_uppercase

class Figure(ABC_Figure):
    def __init__(self, *args):
        if not args:
            self.__line = tuple()
        elif all(type(x) == tuple and len(x) == 2 and all(type(cord) == int for cord in x) for x in args):
            cords_amount = len(args)
            
            self.__cords = {ascii_uppercase[i]:args[i] for i in range(cords_amount)}
        elif len(args) == 1 and type(args[0]) == Figure:   
            self.__cords = args[0].get_cords()
    
    def get_cords(self):
        return self.__cords
    
    def get_side(self, side1, side2):
        return ((side1[0] - side2[0])**2 + (side1[1] - side2[1])**2)**0.5
    
    
    

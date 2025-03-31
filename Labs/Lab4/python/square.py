from abc_square import ABC_square
from figure import Figure

class Square(Figure):
    def __init__(self, vertex, side_len):
        
        if len(vertex) == 2 and all(type(num) == int for num in vertex) and type(side_len) == int:
            x, y = vertex
            super().__init__((x,y), (x+side_len, y), (x+side_len, y-side_len), (x, y - side_len))
            self.side_len_value = side_len
        else:
            super().__init__((0,0))
            self.side_len_value = 0
        
    def area(self):
        if self.side_len_value:
            return self.side_len_value*4
    
    def perimetr(self):
        if self.side_len_value:
            return self.side_len_value**2
    
    def get_side_length(self):
        return self.side_len_value
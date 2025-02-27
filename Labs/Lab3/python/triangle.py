from abc_triangle import ABS_Triangle

class Triangle(ABS_Triangle):
    __PERIMETER = None
    def __new__(cls, *args, **kwargs):
        if cls.__PERIMETER:
            cls.__PERIMETER = None
        instance = super().__new__(cls)
        return instance    
    
    def __init__(self, *args):
        
        if not bool(args):
            self.__x = self.__y = 0
        elif len(args) == 2 and all(type(temp) in (int, float) for temp in args):
            self.__x = args[0]
            self.__y = args[1]
        elif type(args[0]) == Triangle:
            t = args[0]
            self.__x = t.x
            self.__y = t.y
    
    @property
    def x(self)->float:
        return self.__x
    
    @x.setter
    def x(self, new_x:float):
        self.__x = new_x
        
    @property    
    def y(self)->float:
        return self.__y
    
    @y.setter
    def y(self, new_y:float):
        self.__y = new_y
        
    def __add__(self, other):
        if type(other) == Triangle:
            x = self.x + other.x
            y = self.y + other.y
        else:
            x = self.x + other
            y = self.y + other
        return Triangle(x, y)
    
    def __mul__(self, other):
        if type(other) == Triangle:
            x = self.x * other.x
            y = self.y * other.y
        else:
            x = self.x * other
            y = self.y * other
        return Triangle(x, y)
    
    @staticmethod
    def __calculate_sides(a, b, c):
        side_ab = ((a.x-b.x)**2+(a.y-b.y)**2)**0.5
        side_ac = ((a.x-c.x)**2+(a.y-c.y)**2)**0.5
        side_bc = ((b.x-c.x)**2+(b.y-c.y)**2)**0.5
        
        return side_ab, side_ac, side_bc
    
    @classmethod
    def calculate_area(cls, a, b, c):
        side_ab, side_ac, side_bc = cls.__calculate_sides(a, b, c)
        
        if cls.__PERIMETER:
            p = cls.__PERIMETER/2
            print("used")
        else:
            p = (side_ab+side_ac+side_bc)/2
        
        s = (p*(p-side_ab)*(p-side_ac)*(p-side_bc))**0.5
        cls.__PERIMETER = None
        return round(s, 2)
    
    @classmethod
    def calculate_perimeter(cls, a, b, c):
        side_ab, side_ac, side_bc = cls.__calculate_sides(a, b, c)
        cls.__PERIMETER = round(side_ab+side_ac+side_bc, 2)
        return cls.__PERIMETER
        
    


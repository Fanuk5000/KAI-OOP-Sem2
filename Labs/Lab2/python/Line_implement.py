from Line import Line

class Line(Line):
    def __init__(self, text = ""):
        self.__text = text
    
    def copy_line(self)->Line:
        return Line(self.__text)
    
    def get_line(self)->str:
        return self.__text
    
    def sort_descending(self):
        self.__text = "".join(sorted(self.__text, reverse=True))
    
    def get_lenght(self):
        return len(self.__text)
    
    def __del__(self):
        print("Destructor called")
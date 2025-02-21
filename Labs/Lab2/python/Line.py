from iLine import ILine

class Line(ILine):
    def __init__(self, *args):
        "Analog of overloading"
        if not bool(args):
            self.__text = ""
            print(args, "args")
        elif type(args[0]) == str:
            self.__text = args[0]
        else:
            self.__text = args[0].get_line()
    
    # def copy_line(self)->Line:
    #     return Line(self.__text)
    
    def get_line(self)->str:
        return self.__text
    
    def sort_descending(self):
        self.__text = "".join(sorted(self.__text, reverse=True))
    
    def get_lenght(self):
        return len(self.__text)
    
    def __del__(self):
        print("Destructor called")
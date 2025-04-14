from abc_symbols import ABC_symbol
from line import Line

class Symbols(Line, ABC_symbol):
    def __init__(self, symbols):
        if type(symbols) == Symbols:
            self.__line = Symbols(symbols.get_symbols())
        elif type(symbols) == str: 
            self.__line:str = symbols
        else:
            self.__line = ''
    
    def get_len(self):
        return super().get_len(self.__line)
    
    def get_symbol_amount(self) -> str:
        return super().get_symbol_amount(self.__line, '*')
    
    def get_symbols(self):
        return self.__line
    
    def __str__(self):
        return f"Symbols: {self.__line}, Length: {self.get_len()}, Amount of '*': {self.get_symbol_amount()}"
from abc_big_letters import ABC_BigLetters
from line import Line

class BigLetters(Line, ABC_BigLetters):
    def __init__(self, symbols):
        if type(symbols) == BigLetters:
            self.__line = BigLetters(symbols.get_symbols())
        elif type(symbols) == str: 
            self.__line:str = symbols.upper()
        else:
            self.__line = ''
    
    def get_len(self):
        return super().get_len(self.__line)
    
    def get_symbol_amount(self) -> str:
        return super().get_symbol_amount(self.__line, 'B')
    
    def get_symbols(self) -> str:
        return self.__line.upper()
    
    def __str__(self):
        return f"BigLetters: {self.__line}, Length: {self.get_len()}, Symbol 'B' Amount: {self.get_symbol_amount()}"
from abc_line import ABC_line, abstractmethod, virtual_abstractmethod

class ABC_BigLetters(ABC_line):
    @abstractmethod
    def __init__(self, symbols:str):
        pass
    
    @virtual_abstractmethod
    def get_symbols(self) -> str:
        pass
    
    
    
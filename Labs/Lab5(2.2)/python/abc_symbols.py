from abc_line import ABC_line, abstractmethod, virtual_abstractmethod

class ABC_symbol(ABC_line):
    @abstractmethod
    def __init__(self, symbols):
        pass
    
    @virtual_abstractmethod
    def get_symbols(self) -> str:
        pass
    
    @virtual_abstractmethod
    def get_symbol_amount(self) -> str:
        pass
    
    @virtual_abstractmethod
    def get_len(self) -> int:
        pass
    


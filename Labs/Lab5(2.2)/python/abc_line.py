from abc import ABC, abstractmethod

def virtual(func):
    func._is_virtual = True
    return func

def virtual_abstractmethod(func):
    func = abstractmethod(func)
    func = virtual(func)
    return func

class ABC_line(ABC):
    @virtual_abstractmethod
    def get_len() -> int:
        pass
    
    @virtual_abstractmethod
    def get_symbol_amount(line, symbol:str) -> int:
        pass

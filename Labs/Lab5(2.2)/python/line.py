from abc_line import ABC_line

class Line(ABC_line):
    
    @staticmethod
    def get_len(line) -> int:
        return len(line)
    
    @staticmethod
    def get_symbol_amount(line, symbol:str) -> int:
        return line.count(symbol)

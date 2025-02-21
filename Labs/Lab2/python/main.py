from line import Line

if __name__ == "__main__":
    text:str = input("Enter some text: ")
    
    line = Line(text)
    line2 = Line(line)
    
    # print(line2.__text)
    
    print(f"\nLine:{line.get_line()}\nLen: {line.get_lenght()}\nID: {id(line)}\n")
    print(f"Copy of line: {line2.get_line()}\nID: {id(line2)}")
    
    
    line.sort_descending()
    print(f"\nLine after sort: {line.get_line()}")
from Line_implement import Line

if __name__ == "__main__":
    text:str = input("Enter some text: ")
    
    line = Line(text)
    line2 = Line.copy_line(line)

    print(f"\nLine:{line.get_line()}\nLen: {line.get_lenght()}\nID: {id(line)}\n")
    print(f"Copy of line: {line2.get_line()}\nID: {id(line2)}")
    
    
    line.sort_descending()
    print("\nLine after sort:",line.get_line())
from square import Square

square = Square((0,0), 5)
square2 = Square(square)
print(f"Squre area: {square.area()}\nSquare perimetr: {square.perimetr()}")
print(f"Squre area: {square2.area()}\nSquare perimetr: {square2.perimetr()}")
print(square.get_cords(), square2.get_cords())

# f = Figure((4, 5), (1, 1))
# cords = f.get_cords()
# res = f.get_side(cords['A'], cords['B'])
# print(res)
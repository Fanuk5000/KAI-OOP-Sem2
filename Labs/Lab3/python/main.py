from triangle import Triangle

if __name__ == "__main__":
    t1 = Triangle(0, 5)
    t2 = Triangle(-3, -2)
    t3 = Triangle(8, 3)
    
    t3 = t3*2
    t1 = t2+t3
    print(t3.x, t3.y)
    
    # print(Triangle.calculate_area(t1, t2, t3))
    # t4 = Triangle(t1)
    # t3 = t1+t2
    # print(t3.x, t3.y)
from triangle import Triangle

if __name__ == "__main__":
    t1 = Triangle(0, 5)
    t2 = Triangle(-3, -2)
    t3 = Triangle(8, 3)
    
    t3 = t3*2
    t1 = t2+t3
    
    print(f"t1: {t1.x}, {t1.y}")
    print(f"t2: {t2.x}, {t2.y}")
    print(f"t3: {t3.x}, {t3.y}")
    
    print(Triangle.calculate_perimeter(t1, t2, t3))
    print(Triangle.calculate_area(t1, t2, t3)) 

       

    
    # t11 = Triangle(0, 5)
    # t22 = Triangle(-3, -2)
    # t33 = Triangle(8, 3)
    # print(Triangle.calculate_area(t11, t22, t33))

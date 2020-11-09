def ejercicio1():
    a = 3
    b = 4
    print(a + b)

def ejercicio2():
    prod = 100
    print("iva: " + str(prod * 21 / 100) + "€")
    print("PVP: " + str((prod * 21 / 100) + prod) + "€")

def ejercicio3():
    a = 5
    b = 3
    if (a > b):
        print("El mayor es " + str(a))
    else:
        print("El mayor es ", b)

def ejercicio4():
    a = 14
    if a >= 0 or a <= 10:
        print("Está entre 0 y 10")

def ejercicio5():
    a = 14
    if a >= 0 or a <= 10:
        print("Está entre 0 y 10")
    elif a > 10 or a <= 20:
        print("Está entre 11 y 20")
    else:
        print("Guau q grande")

def ejercicio6():
    i = 1
    while i <= 100:
        print(i)
        i += 1

def ejercicio7():
    for i in range(0,101, 2):
        print(i)

#ejercicio1()
#ejercicio2()
#ejercicio3()
#ejercicio4()
#ejercicio6()
ejercicio7()
def Ejercicio2():
    year = input("Introduzca un año: ")
    year = int(year)
    r = "Año común"
    if (year % 4 == 0):
        if (year % 100 == 0):
            if (year % 400 == 0):
                r = "Año bisiesto"
        else:
            r = "Año bisiesto"
    print(r)
    if(year < 1582):
        print("No dentro del periodo gregoriano")
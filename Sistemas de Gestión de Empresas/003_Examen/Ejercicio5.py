def Ejercicio5():
    num = int(input("Introduce un número del 1000 al 9999"))

    ocurrences = {}
    ocurrences[1] = 1

    while num % 10 > 0:

        num = num % 10
        if ocurrences.items(num):
            print("ey")
            ocurrences[num] = ocurrences[num] + 1
        else:
            print("o")
            ocurrences[num] = 1

    print(ocurrences)
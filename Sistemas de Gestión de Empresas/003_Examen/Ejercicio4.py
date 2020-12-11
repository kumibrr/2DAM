def Ejercicio4():
    blocks = int(input("Introduzca el número de bloques: "))

    i = 0 #Índice de bloques.
    filas = 0
    j = 0 #Índice de bloques por fila

    while i < blocks:
        i = i + 1
        j = j + 1
        if (j >= filas):
            filas = filas + 1
            j = 0
    print(filas)


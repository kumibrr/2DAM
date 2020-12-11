def Ejercicio1():
    ingreso = input("Introduzca sus ingresos")
    ipi = 0
    if ingreso < 85528:
        ipi = ingreso * 18 / 100
        ipi = ipi + 0.2
    elif ingreso > 85528:
        ipi = 14839.2
        ipi = ipi + (ingreso - 85528 * 32 / 100)
    else:
        ipi = 0
    print(round(ipi))
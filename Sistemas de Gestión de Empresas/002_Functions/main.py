import Ejercicio1
import Ejercicio2

print(Ejercicio1.Ejercicio1('hola que tal estamos'))

i = 0
while i < len(Ejercicio2.listaMes):
    year = Ejercicio2.listaAnnos[i]
    month = Ejercicio2.listaMes[i]
    print("En el mes " + str(month) + " del año " + str(year) + " hay " + str(Ejercicio2.diasEnMes(year, month)) + " días")
    i += 1
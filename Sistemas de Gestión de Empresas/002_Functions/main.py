import Ejercicio1
import Ejercicio2
import Ejercicio3
import Ejercicio4

print(Ejercicio1.Ejercicio1('hola que tal estamos'))

i = 0
while i < len(Ejercicio2.listaMes):
    year = Ejercicio2.listaAnnos[i]
    month = Ejercicio2.listaMes[i]
    print("En el mes " + str(month) + " del año " + str(year) + " hay " + str(Ejercicio2.diasEnMes(year, month)) + " días")
    i += 1

print(Ejercicio3.l100kmtompg(3.9))
print(Ejercicio3.l100kmtompg(7.5))
print(Ejercicio3.l100kmtompg(10.))
print(Ejercicio3.mpgtol100km(60.3))
print(Ejercicio3.mpgtol100km(31.4))
print(Ejercicio3.mpgtol100km(23.5))

Ejercicio4.phoneAgenda()
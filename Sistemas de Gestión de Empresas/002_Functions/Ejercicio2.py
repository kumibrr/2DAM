listaAnnos = [1900, 2000, 2016, 1987]
listaMes = [2, 2, 1, 11]

def esBisiesto(year):
    isLeap = False
    if year % 4 == 0:
        if year % 100 != 0:
            isLeap = True
        else:
            if year % 400 == 0:
                isLeap = True
    return isLeap

def diasEnMes(year, month):
    if month == 2 and esBisiesto(year):
        return 29
    elif month == 2:
        return 28
    elif month % 2 == 0:
        return 30
    else:
        return 31

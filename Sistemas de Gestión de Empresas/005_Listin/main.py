import ast

dict = {}

def menu():
    print("Listín telefónico\n============================")
    print("1 - Consultar un teléfono")
    print("2 - Añadir un teléfono")
    print("3 - Eliminar un teléfono")
    print("4 - Crear el listín")
    print("0 - Terminar")

def main():
    canExit = False
    try:
        readFile()
    except:
        print("No hay listín creado.")

    while canExit == False:
        clear()
        menu()
        try:
            option = int(input("Elija una opción: "))
            if 5 > option and option >= 0:
                if option == 0:
                    canExit = True
                elif option == 1:
                    clear()
                    queryPhone()
                elif option == 2:
                    clear()
                    addContact()
                elif option == 3:
                    clear()
                    deleteContact()
                elif option == 4:
                    clear()
                    createContactList()
                else:
                    raise Exception()
            else:
                raise Exception()
        except Exception as e:
            print(e)

def queryPhone():
    checkListin()
    name = input("Introduzca el nombre a consultar: ")
    phoneNum = dict.get(name)
    print("El número de " + name + " es: " + phoneNum)

def addContact():
    print("Añadir contacto\n============================")
    name = input("Introduzca el nombre del contacto: ")
    phoneNumber = input("Introduzca su número de teléfono: ")
    dict[name] = phoneNumber
    writeFile()

def deleteContact():
    print("Borrar contacto\n============================")
    name = input("Introduzca el nombre del contacto a eliminar: ")
    dict.pop(name)
    writeFile()

def createContactList():
    f = open('listin.txt', 'w')
    f.close()

def readFile():
    with open("listin.txt", "r") as data:
        nonlocal dict = ast.literal_eval(data.read())

def writeFile():
    f = open('listin.txt', 'w')
    f.write(str(dict))
    f.close()

def checkListin():
    try:
        readFile()
    except FileNotFoundError:
        r = input("No se ha encontrado el listín. ¿Desea crear uno nuevo?\n Introduzca 'Y' o 'YES' para aceptar."
                  " Introduzca otra tecla para cancelar: ")
        if r == 'Y' or 'YES':
            createContactList()

def clear():
    print("\n")

main()
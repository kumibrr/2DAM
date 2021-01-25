import pyodbc
import os
from colorama import Fore, Style

server = 'localhost'
database = 'RestaurantePepe'
username = 'sa'
password = '2DAM2dam#'

try:
    connection = pyodbc.connect(
        'DRIVER={ODBC Driver 17 for SQL Server};SERVER=' + server + ';DATABASE=' + database + ';UID=' + username + ';PWD=' + password, timeout=5)
    cursor = connection.cursor()
except:
    print(Fore.RED + "No se ha podido establecer la conexión. Inténtelo de nuevo más tarde")
    print(Style.RESET_ALL)
    exit()

def main():
    option = mostrar_menu()
    if option == 0:
        connection.close()
        exit()
    if option == 1:
        add_category()
    elif option == 2:
        add_dish()
    elif option == 3:
        delete_dish()
    elif option == 4:
        delete_category()
    elif option == 5:
        daily_weekdays()
    elif option == 6:
        daily_weekend()
    elif option == 9:
        create_table()
    else:
        connection.close()
        exit()


def mostrar_menu():
    hasInput = False

    while not hasInput:
        print("RESTAURANTE LO MEJOR DE PEPE\n")
        print("[0] Salir del programa")
        print("[1] Agregar una categoría")
        print("[2] Agregar un plato")
        print("[3] Eliminar un plato")
        print("[4] Eliminar una categoría")
        print("[5] Mostrar el menú L-V")
        print("[6] Mostrar el menú fin de semana")
        print("---------------------------------")
        print("[9] Crear tablas")
        option = int(input("Introduce una opción: " + Fore.BLUE))
        print(Style.RESET_ALL)
        if (0 <= option <= 6 or option == 9):
            hasInput = True
            return option
        else:
            clear()
            print(Fore.RED + "Opción no válida. Por favor inténtelo de nuevo.")
            print(Style.RESET_ALL)


def clear():
    os.system('cls' if os.name == 'nt' else 'clear')


def add_category():
    selected = False
    while not selected:
        try:
            print("[1] Primeros\n[2] Segundos\n[3]Postres")
            option = int(input("Introduzca la categoría a añadir: " + Fore.BLUE))
            if option == 1:
                name = 'Primeros'
                selected = True
            elif option == 2:
                name = 'Segundos'
                selected = True
            elif option == 3:
                name = 'Postres'
                selected = True
            else:
                clear()
                print(Fore.RED + "Opción no válida. Por favor inténtelo de nuevo.")
                print(Style.RESET_ALL)
        except:
            clear()
            print(Fore.RED + "Opción no válida. Por favor inténtelo de nuevo.")
            print(Style.RESET_ALL)

    try:
        cursor.execute("INSERT INTO dbo.categoria(nombre) VALUES ('"+name+"')")
        connection.commit()
        print(Fore.GREEN + "Añadida categoría '" +name+ "' correctamente.")
    except:
        print(Fore.RED + "La categoría '" +name+ "' ya existe. No se ha realizado ninguna acción.")
    print(Style.RESET_ALL)


def add_dish():
    try:
        categories = []
        cursor.execute("SELECT * FROM dbo.categoria")

        selected = False
        while not selected:
            try:
                for row in cursor.fetchall():
                    categories.append(row)
                i = 1
                for category in categories:
                    print("[" + str(i) + "] " + category[1])
                    i = i + 1
                option = int(input("Introduzca la categoría del plato: "))

                if 0 < option <= len(categories):
                    selectedCategory = categories[option - 1]
                    selected = True
                else:
                    clear()
                    print(Fore.RED + "Opción no válida. Por favor inténtelo de nuevo.")
                    print(Style.RESET_ALL)
            except:
                clear()
                print(Fore.RED + "Opción no válida. Por favor inténtelo de nuevo.")
                print(Style.RESET_ALL)
        name = input("Introduzca el nombre del plato: ")

        cursor.execute(f"INSERT INTO dbo.plato(categoria_id, nombre) VALUES ({selectedCategory[0]}, '{name}')")
        cursor.commit()
        print(Fore.GREEN + "Plato '" + name + "' añadido  correctamente.")
        print(Style.RESET_ALL)
    except:
        print(Fore.RED + "Ha ocurrido un error inesperado, vuelva a intentarlo más tarde.")
        print(Style.RESET_ALL)


def delete_dish():
    try:
        dishes = []
        cursor.execute("SELECT nombre FROM dbo.plato")

        selected = False
        while not selected:
            try:
                for row in cursor.fetchall():
                    dishes.append(row[0])
                i = 1
                for dish in dishes:
                    print(f"[{i}] {dish}")
                    i = i + 1
                option = int(input("Introduzca el plato a eliminar: "))
                if 0 < option <= len(dishes):
                    selectedDish = dishes[option - 1]
                    selected = True
                else:
                    clear()
                    print(Fore.RED + "Opción no válida. Por favor inténtelo de nuevo.")
                    print(Style.RESET_ALL)
            except:
                clear()
                print(Fore.RED + "Opción no válida. Por favor inténtelo de nuevo.")
                print(Style.RESET_ALL)

            cursor.execute(f"DELETE FROM dbo.plato WHERE nombre='{selectedDish}'")
            cursor.commit()
    except:
        print(Fore.RED + "Ha ocurrido un error inesperado, vuelva a intentarlo más tarde.")
        print(Style.RESET_ALL)

def delete_category():
    try:
        categories = []
        cursor.execute("SELECT * FROM dbo.categoria")

        selected = False
        while not selected:
            try:
                for row in cursor.fetchall():
                    categories.append(row)
                i = 1
                for category in categories:
                    print("[" + str(i) + "] " + category[1])
                    i = i + 1
                option = int(input("Introduzca la categoría a eliminar: "))

                if 0 < option <= len(categories):
                    selectedCategory = categories[option - 1]
                    selected = True
                else:
                    clear()
                    print(Fore.RED + "Opción no válida. Por favor inténtelo de nuevo.")
                    print(Style.RESET_ALL)
            except:
                clear()
                print(Fore.RED + "Opción no válida. Por favor inténtelo de nuevo.")
                print(Style.RESET_ALL)

        try:
            cursor.execute(f"DELETE FROM dbo.plato WHERE categoria_id='{selectedCategory[0]}'")
            cursor.commit()
        finally:
            cursor.execute(f"DELETE FROM dbo.categoria WHERE id='{selectedCategory[0]}'")
            cursor.commit()
            print(Fore.GREEN + "Categoría eliminada satisfactoriamente.")
            print(Style.RESET_ALL)
    except:
        print(Fore.RED + "Ha ocurrido un error inesperado, vuelva a intentarlo más tarde.")
        print(Style.RESET_ALL)


def daily_weekdays():
    try:
        print("RESTAURANTE LO MEJOR DE PEPE\nMENU SEMANAL")

        cursor.execute(
            "SELECT dbo.plato.nombre FROM dbo.plato INNER JOIN dbo.categoria ON dbo.plato.categoria_id=dbo.categoria.id AND dbo.categoria.nombre='Primeros'")
        print("PRIMEROS PLATOS")
        for row in cursor.fetchall():
            print(f"*{row[0]}")
        cursor.execute(
            "SELECT dbo.plato.nombre FROM dbo.plato INNER JOIN dbo.categoria ON dbo.plato.categoria_id=dbo.categoria.id AND dbo.categoria.nombre='Segundos'")
        print("SEGUNDOS PLATOS")
        for row in cursor.fetchall():
            print(f"*{row[0]}")
        cursor.execute(
            "SELECT dbo.plato.nombre FROM dbo.plato INNER JOIN dbo.categoria ON dbo.plato.categoria_id=dbo.categoria.id AND dbo.categoria.nombre='Postres'")
        print("POSTRES")
        for row in cursor.fetchall():
            print(f"*{row[0]}")
    except:
        print(Fore.RED + "Ha ocurrido un error inesperado, vuelva a intentarlo más tarde.")
        print(Style.RESET_ALL)
def daily_weekend():
    try:
        print("RESTAURANTE LO MEJOR DE PEPE\nMENU SEMANAL")

        cursor.execute(
            "SELECT TOP 1 dbo.plato.nombre FROM dbo.plato INNER JOIN dbo.categoria ON dbo.plato.categoria_id=dbo.categoria.id AND dbo.categoria.nombre='Primeros' ORDER BY NEWID()")
        print("PRIMEROS PLATOS")
        for row in cursor.fetchall():
            print(f"*{row[0]}")
        cursor.execute(
            "SELECT TOP 1 dbo.plato.nombre FROM dbo.plato INNER JOIN dbo.categoria ON dbo.plato.categoria_id=dbo.categoria.id AND dbo.categoria.nombre='Segundos' ORDER BY NEWID()")
        print("SEGUNDOS PLATOS")
        for row in cursor.fetchall():
            print(f"*{row[0]}")
        cursor.execute(
            "SELECT TOP 1 dbo.plato.nombre FROM dbo.plato INNER JOIN dbo.categoria ON dbo.plato.categoria_id=dbo.categoria.id AND dbo.categoria.nombre='Postres' ORDER BY NEWID()")
        print("POSTRES")
        for row in cursor.fetchall():
            print(f"*{row[0]}")
    except:
        print(Fore.RED + "Ha ocurrido un error inesperado, vuelva a intentarlo más tarde.")
        print(Style.RESET_ALL)


def create_table():
    try:
        cursor.execute("CREATE TABLE categoria( id INT NOT NULL IDENTITY PRIMARY KEY, nombre VARCHAR(100) UNIQUE NOT NULL)")
        connection.commit()
        print(Fore.GREEN + "La tabla 'Categoría' ha sido creada correctamente.")
    except:
        print(Fore.RED + "La tabla 'Categoría' ya existe. No se ha realizado ninguna acción.")

    try:
        cursor.execute("CREATE TABLE plato( id INTEGER PRIMARY KEY IDENTITY, nombre VARCHAR(100) UNIQUE NOT NULL, categoria_id INTEGER NOT NULL, FOREIGN KEY(categoria_id) REFERENCES categoria(id))")
        connection.commit()
        print(Fore.GREEN + "La tabla 'Plato' ha sido creada correctamente.")
    except:
        print(Fore.RED + "La tabla 'Plato' ya existe. No se ha realizado ninguna acción.")
    print(Style.RESET_ALL)

while 1 == 1:
    clear()
    main()
    input("Pulse una tecla para continuar...")

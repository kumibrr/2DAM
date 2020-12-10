def phoneAgenda():
    agenda = {
    }
    print("********** Agenda telefónica **********")
    print("Escriba 'salir' para dejar de introducir contactos.")
    while (1 == 1):
        name = input("Introduzca nombre a añadir: ")
        if (name == "salir"): break
        phone = input("Introduzca el número a añadir: ")
        if (phone == "salir"): break
        agenda[name] = phone;
    print("Escriba 'salir' para salir del programa.")
    while (1 == 1):
        phone = input("Introduzca el número de teléfono a consular: ")
        if phone == "salir": break

        oc = 0
        for name, savedPhone in agenda.items():
            if savedPhone == phone:
                r = "El teléfono " + savedPhone + " es de " + name
                oc = oc + 1
        if oc > 0:
            print(r)
        else:
            print("No se ha encontrado ninguna coincidencia :S")




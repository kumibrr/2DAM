with open("empleados.xml") as empleado:
    for node in empleado:
        node = node.rstrip();
        node = node.lstrip();
        if (node.startswith("<nombre>")):
            node = node.replace("<nombre>", "")
            node = node.replace("</nombre>", "")
            nombre = node + " "
        if (node.startswith("<apellidos>")):
            node = node.replace("<apellidos>", "")
            node = node.replace("</apellidos>", "")
            nombre += node

            print(nombre)

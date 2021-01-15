with open("cotizacion.csv") as table:
    i = 0
    rowsArr = []
    for row in table:
        print(row)

        rowDict = {}
        word = ""
        if i == 0:
            for char in row:
                if (char == ";"):
                    rowsArr.append(word)
                    word = ""
                else:
                    word += char
            print(rowsArr)
        else:
            for char in row:
                if (char == ";"):
                    print(word)
                    word = ""
                else:
                    word += char
        i = i + 1
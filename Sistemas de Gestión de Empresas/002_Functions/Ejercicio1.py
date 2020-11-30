def Ejercicio1(string):
    strLength = len(string)
    word = ''
    for char in string:
        if (char != ' '):
            word += char
        else:
            word = ''

    return word, strLength
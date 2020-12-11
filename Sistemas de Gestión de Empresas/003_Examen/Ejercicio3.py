def Ejercicio3():
    string = input("Introduzca una frase: ")
    vowelArr = ["A", "a", "E", "e", "I", "i", "O", "o", "U", "u"]

    for vowel in vowelArr:
        string = string.replace(vowel, "")

    print(string.upper())
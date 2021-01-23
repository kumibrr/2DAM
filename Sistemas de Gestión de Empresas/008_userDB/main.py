import pyodbc

server = 'localhost'
username = 'sa'
password = '2DAM2dam#'
database= 'BDPasaje'


try:
    connection = pyodbc.connect(
        'DRIVER={ODBC Driver 17 for SQL Server};SERVER=' + server + ';DATABASE=' + database + ';UID=' + username + ';PWD=' + password)

    cursor = connection.cursor()

except:
    print('La base de datos no está disponible en estos momentos')
    exit()

username = input('Introduzca su nombre de usuario: ')
id = input('Introduca la id del usuario: ')

cursor.execute("SELECT * FROM Usuario WHERE NOMBREUSUARIO ='"+username+"' AND IIDUSUARIO ="+id)

if cursor.fetchone():
    print("Usuario conectado.")
else:
    print("Usuario o contraseña incorrectos.")

connection.close()
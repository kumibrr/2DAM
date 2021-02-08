import pyodbc, smtplib
from colorama import Fore, Style

server = 'localhost'
database = 'BDPasaje'
username = 'sa'
password = '2DAM2dam#'

smtpServer = smtplib.SMTP('smtp.gmail.com', 587)

try:
    connection = pyodbc.connect(
        'DRIVER={ODBC Driver 17 for SQL Server};SERVER=' + server + ';DATABASE=' + database + ';UID=' + username + ';PWD=' + password,
        timeout=5)
    cursor = connection.cursor()

except:
    print(Fore.RED + "No se ha podido establecer la conexión. Inténtelo de nuevo más tarde")
    print(Style.RESET_ALL)
    exit()


def main():
    tries = 3;
    email = input('INTRODUZCA SU EMAIL: ' + Fore.GREEN)
    passwordOk = False
    while not passwordOk and tries > 0:
        userPassword = input(Style.RESET_ALL + 'INTRODUZA SU CONTRASEÑA: ')

        try:
            row = cursor.execute(
                f"SELECT IIDUSUARIO FROM Usuario WHERE NOMBREUSUARIO = '{email}' AND CONTRA = '{userPassword}'").fetchone()
            if row != None:
                passwordOk = True
                print('Bienvenido!')
            else:
                raise
        except:
            tries -= 1
            if tries > 0:
                print(f'Inténtelo de nuevo, te quedan {tries} intento(s)')
    if not passwordOk:
        try:
            passw = cursor.execute(f"SELECT CONTRA FROM Usuario WHERE NOMBREUSUARIO = '{email}'").fetchone()
            if passw[0] != None:
                smtpServer.starttls()
                smtpServer.login('*******@gmail.com', '*******')
                smtpServer.sendmail('*******@gmail.com', email, f'Subject:Contraseña\n\n Su contraseña de recuperación es {passw[0]}')
                smtpServer.quit()
                print("Se ha enviado un correo electrónico con tu clave de acceso.")
            else:
                raise
        except:
            print(Fore.RED + 'No se ha encontrado ningún email que corresponda a los registrados.')


main()

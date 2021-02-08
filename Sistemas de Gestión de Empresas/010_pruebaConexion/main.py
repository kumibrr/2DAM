import pyodbc

Cadenaconexion = "DRIVER={MariaDB ODBC 3.1 Driver};\
SERVER=localhost;\
DATABASE=angularMail;\
PORT=3306;\
USER=angularmail;\
stmt=SET NAMES 'utf8';\
PASSWORD=JxPDuDPXCqccxD-_M2CX"
cnxn = pyodbc.connect(Cadenaconexion)
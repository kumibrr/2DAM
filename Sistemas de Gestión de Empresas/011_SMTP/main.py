import smtplib

server = smtplib.SMTP('smtp.gmail.com', 587)
server.starttls()
server.login('**********@gmail.com', '********************')
server.sendmail('**********@gmail.com', '********************', 'Subject:EY\n\n Hola que tal')
server.quit()

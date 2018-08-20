import smtplib
server = smtplib.SMTP('smtp.guerrillamail.com', 587)

fromaddr = "e3rrq9+fcsjghbi754vg@sharklasers.com"
toaddr = "csnedden982@gmail.com"
msg = MIMEMulitpart()
msg['From'] = fromaddr
msg['To'] = toaddr
msg['Subject'] = "Python email"

server.login("jif-1asjaf_2=nv","")
server.ehlo()
server.starttls()
server.ehlo()
server.login("e3rrq9+fcsjghbi754vg@sharklasers.com","")
text = msg.as_string()

#Send the mail
msg = "Hello!" #The /n separates the message from the headers 

server.sendmail(fromaddr, toaddr, text)




import socket
import time


# address of receive point
# You can change IP address and port number 
IPADDRESS = '192.168.1.1'
PORTNUM = 5600

# the data which will be send.
# Data must be object so we transform the data from string to object.
DATAPACK = "15a13c5252351".encode()

# open a socket, 
soc = socket.socket(socket.AF_INET, socket.SOCK_DGRAM, 0)

# connect the socket,,, 
soc.connect((IPADDRESS, PORTNUM))

while(True):
    s.send(PACKETDATA)
    time.sleep(1)
    print("Data has been sent.")
   
   
# close the socket
soc.close()

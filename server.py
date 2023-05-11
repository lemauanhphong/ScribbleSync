import socket
import threading

class ThreadedServer(object):
    def __init__(self, host, port):
        self.host = host
        self.port = port
        self.sock = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
        self.sock.setsockopt(socket.SOL_SOCKET, socket.SO_REUSEADDR, 1)
        self.sock.bind((self.host, self.port))

    def listen(self):
        self.sock.listen()
        while True:
            client, address = self.sock.accept()
            threading.Thread(target = self.listenToClient, args = (client, address)).start()
    
    def listenToClient(self, client, address):
        size = 1024

        while True:
            try:
                data = client.recv(size).decode()

                if (data):
                    
                        pass    
                else:
                    raise Exception('Client disconnected')
            except Exception as ex:
                client.close()
                return False

if __name__ == "__main__":
    port_num = int(input("[*] Enter port number: "))
    if (port_num < 1 or port_num > 65535):
        print("0 < port < 65536")
        exit(0)

    print(f"Server is running on port {port_num}")
    ThreadedServer('', port_num).listen()
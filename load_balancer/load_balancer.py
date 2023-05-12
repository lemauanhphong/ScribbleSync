import json
import socket
import threading
from itertools import cycle

from traceback import print_exception

PORT_NUM = 8028
SERVER_POOL = [('127.0.0.1', 2808)]
ITER = cycle(SERVER_POOL)

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
            threading.Thread(target=self.listenToClient, args=(client, address)).start()

    def listenToClient(self, client, address):
        size = 1024

        try:
            data = client.recv(size)
            if data:
                server = next(ITER)
                with socket.socket(socket.AF_INET, socket.SOCK_STREAM) as socket_connection:
                    socket_connection.connect(server)
                    socket_connection.send(data)
                    recv_data = socket_connection.recv(size)
                client.send(recv_data)
            else:
                raise Exception("Client disconnected")
        except Exception as e:
            print_exception(e)
        finally:
            client.close()


if __name__ == "__main__":    
    print(f"Server is running on port {PORT_NUM}")
    ThreadedServer("", PORT_NUM).listen()

import json
import socket
import threading
from traceback import print_exception

from database import Database


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

        while True:
            try:
                data = client.recv(size).decode()

                if (data):
                    try:
                        data = json.loads(data)
                        
                        if (data['action'].startswith('/api/auth')):
                            apiAuth.route(data)

                    except Exception as ex:
                        pass

                else:
                    raise Exception("Client disconnected")
            except Exception as e:
                print_exception(e)
                client.close()
                return False


if __name__ == "__main__":
    db = Database()
    db.connect()

    port_num = int(input("[*] Enter port number: "))
    if port_num < 1 or port_num > 65535:
        print("0 < port < 65536")
        exit(0)

    db = Database()
    print(f"Server is running on port {port_num}")
    ThreadedServer("", port_num).listen()

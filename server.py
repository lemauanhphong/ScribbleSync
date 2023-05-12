import json
import socket
import threading

from api import *
from traceback import print_exception
from database import Database

db = Database()
db.connect()

from api import authApi, fileApi, noteApi, profileApi, templateApi
from helpers import responseHelper

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
            data = client.recv(size).decode()

            if (data):
                data = json.loads(data)
                
                if (data['action'].startswith('/api/auth')):
                    response = authApi.route(data)
                # add more

                if (response[0] == 1):
                    client.send(json.dumps(response[1]).encode())

                else:
                    client.send(json.dumps(responseHelper.response(500)).encode())
            else:
                raise Exception("Client disconnected")
        except Exception as e:
            print_exception(e)
        finally:
            client.close()


if __name__ == "__main__":
    port_num = 2808
    print(f"Server is running on port {port_num}")
    ThreadedServer("", port_num).listen()

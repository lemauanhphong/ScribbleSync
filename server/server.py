import json
import socket
import threading
from traceback import print_exception

from api import auth_api, file_api, note_api, profile_api, template_api
from helpers import response_helper

PORT_NUM = 2808


class ThreadedServer:
    def __init__(self, host, port):
        self.host = host
        self.port = port
        self.sock = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
        self.sock.setsockopt(socket.SOL_SOCKET, socket.SO_REUSEADDR, 1)
        self.sock.bind((self.host, self.port))

    def listen(self):
        self.sock.listen()
        while True:
            client = self.sock.accept()[0]
            threading.Thread(target=self.listen_to_client, args=(client,)).start()

    def listen_to_client(self, client):
        size = 1024

        try:
            data = client.recv(size).decode().strip()
            if data:
                data = json.loads(data)
                if "action" not in data:
                    response = (1, response_helper.response(503))
                elif data["action"].startswith("/api/auth"):
                    response = auth_api.route(data)

                # TODO: JWT middleware

                elif data["action"].startswith("/api/template"):
                    response = template_api.route(data)
                elif data["action"].startswith("/api/note"):
                    response = note_api.route(data)
                elif data["action"].startswith("/api/profile"):
                    response = profile_api.route(data)
                elif data["action"].startswith("/api/file"):
                    response = file_api.route(data)
                else:
                    response = (1, response_helper.response(503))

                client.send(json.dumps(response[1]).encode())
            else:
                raise Exception("Client disconnected")
        except Exception as e:
            client.send(json.dumps(response_helper.response(500)).encode())
            print_exception(e)
        finally:
            client.close()


if __name__ == "__main__":
    print(f"Server is running on port {PORT_NUM}")
    ThreadedServer("", PORT_NUM).listen()

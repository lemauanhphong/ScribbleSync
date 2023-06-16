import json
import socket
import threading
from traceback import print_exception

from api import auth_api, note_api, profile_api, template_api
from helpers.response_helper import response
from middlewares import jwt_middleware

PORT_NUM = 2808

api_routes = {
    "/api/auth": auth_api,
    "/api/template": template_api,
    "/api/note": note_api,
    "/api/profile": profile_api,
}


def parse_route(data):
    api = None
    action = data.get("action", "")

    for path, value in api_routes.items():
        if action.startswith(path):
            api = value
            break

    if api is None:
        return (1, response(503))

    if api is auth_api or action.startswith("/api/profile/avatar"):
        return api.route(data)

    token = data.get("token", "")
    token = jwt_middleware.jwt_validator(token)
    if not token:
        return (1, response(401))

    data["token"] = token
    return api.route(data)


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
            client.settimeout(5)
            threading.Thread(target=self.listen_to_client, args=(client,)).start()

    def listen_to_client(self, client):
        size = 1024

        try:
            data = b""
            while True:
                recv_data = client.recv(size)
                data += recv_data
                if data[-1] == 10:
                    break

            data = data.decode().strip()
            if not data:
                raise Exception("Client disconnected")

            r = parse_route(json.loads(data))
            client.send(json.dumps(r[1]).encode() + b"\n")
        except Exception as e:
            client.send(json.dumps(response(500)).encode())
            print_exception(e)
        finally:
            client.close()


if __name__ == "__main__":
    print(f"Server is running on port {PORT_NUM}")
    ThreadedServer("", PORT_NUM).listen()

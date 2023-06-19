import socket
import ssl
import threading
from itertools import cycle
from traceback import print_exc

PORT_NUM = 8028
SERVER_POOL = [("cloudsashd.duckdns.org", 2808), ("cloudsbshd.duckdns.org", 2808)]
ITER = cycle(SERVER_POOL)


class ThreadedServer(object):
    def __init__(self, host, port):
        self.host = host
        self.port = port
        context = ssl.create_default_context(ssl.Purpose.CLIENT_AUTH)
        context.load_cert_chain(
            certfile="./cert/trust-authority.duckdns.org/certificate.crt",
            keyfile="./cert/trust-authority.duckdns.org/ec-private-key.pem",
        )
        self.sock = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
        self.sock.setsockopt(socket.SOL_SOCKET, socket.SO_REUSEADDR, 1)
        self.sock.bind((self.host, self.port))
        self.sock = context.wrap_socket(self.sock, server_side=True)

    def listen(self):
        self.sock.listen()
        while True:
            client = self.sock.accept()[0]
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

            if data:
                server = next(ITER)
                
                with socket.socket(socket.AF_INET, socket.SOCK_STREAM) as socket_connection:
                    context_client = ssl.create_default_context(ssl.Purpose.SERVER_AUTH)
                    socket_connection = context_client.wrap_socket(socket_connection, server_hostname = server[0])
                    socket_connection.connect(server)
                    socket_connection.send(data)

                    forwarded_data = b""
                    while True:
                        recv_data = socket_connection.recv(size)
                        forwarded_data += recv_data
                        if forwarded_data[-1] == 10:
                            break
                        

                client.send(forwarded_data)
            else:
                raise Exception("Client disconnected")
        except Exception as e:
            print_exc(e)
        finally:
            client.close()


if __name__ == "__main__":
    print(f"Server is running on port {PORT_NUM}")
    while True:
        try:
            ThreadedServer("", PORT_NUM).listen()
        except:
            pass

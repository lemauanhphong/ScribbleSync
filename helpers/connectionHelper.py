def send(connection, data):
    connection.send(data.encode())
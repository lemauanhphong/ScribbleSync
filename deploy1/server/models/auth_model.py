import bcrypt

from database import db


def login(username, password):
    data = db.query("SELECT id, username, password FROM users WHERE username = %s", (username,))
    if len(data) != 0:
        if bcrypt.checkpw(password.encode(), data[0]["password"].encode()):
            return (1, (data[0]["id"], data[0]["username"]))
        else:
            return (0, 401)
    else:
        return (0, 401)


def register(username, password):
    data = db.query("SELECT COUNT(1) from users WHERE username = %s", (username,))
    if data[0]["COUNT(1)"] != 0:
        return (0, 409)
    hash_password = bcrypt.hashpw(password.encode(), bcrypt.gensalt()).decode()
    status = db.update("INSERT INTO users (username, password) VALUES (%s, %s)", (username, hash_password))
    if status:
        return (1, 200)
    return (0, 500)

from server import db
from helpers import responseHelper
import bcrypt

def login(username, password):
    data = db.query('SELECT username, password FROM users WHERE username = %s', (username,))
    if (len(data) != 0):
        if (bcrypt.checkpw(password.encode(), data[0][1].encode())):
            return (1, data[0][1])
        else:
            return (0, 401)
    else:
        return (0, 401)
    

def register(username, password):
    data = db.query('SELECT COUNT(1) from users WHERE username = %s', (username,))
    if (data[0][0] != 0):
        return (0, 409)
    else:
        hashPassword = bcrypt.hashpw(password.encode(), bcrypt.gensalt()).decode()
        status = db.update('INSERT INTO users (username, password) VALUES (%s, %s)', (username, hashPassword))
        if (status):
            return (1, 200)
        else:
            return (0, 500)
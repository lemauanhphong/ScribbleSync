from server import db
from helpers import responseHelper
import bcrypt

def login(username, password):
    data = db.query('SELECT username, password FROM users WHERE username = %s', (username,))
    if (len(data) != 0):
        if (bcrypt.checkpw(password.encode(), data[0][1].encode())):
            return (1, data[0][1])
        else:
            return (0, responseHelper.response(401, -1, {"app_message": "Invalid username or password"}))
    else:
        return (0, responseHelper.response(401, -1, {"app_message": "Invalid username or password"}))
    

def register(username, password):
    data = db.query('SELECT COUNT(1) from users WHERE username = %s', (username,))
    if (data[0][0] != 0):
        return (0, responseHelper.response(409, -1, {"app_message": "Username is already taken"}))
    else:
        hashPassword = bcrypt.hashpw(password.encode(), bcrypt.gensalt()).decode()
        status = db.update('INSERT INTO users (username, password) VALUES (%s, %s)', (username, hashPassword))
        if (status):
            return (1, responseHelper.response(200, -1, {"app_message": "Registration sucessfully"}))
        else:
            return (0, responseHelper.response(500))
import re
import time
from models import auth_model
from helpers import jwt_helper, response_helper


def register(data):
    if ('username' not in data or 'password' not in data):
        return (0, response_helper.response(400))
    if len(data['password']) < 8:
        return (0, response_helper.response(400, 'Short password'))
    if not re.match(r'^[0-9a-zA-Z_]{6,40}$', data["username"]):
        return (0, response_helper.response(400, 'Invalid username'))
    res = auth_model.register(data['username'], data['password'])
    if res[0] == 1:
        return (1, response_helper.response(200, -1, {'app_message': 'Registration successfully'}))
    if res[0] == 0:
        if res[1] == 409:
            return (0, response_helper.response(
                409, -1, {'app_message': 'Username is already taken'}))
        return (0, response_helper.response(res[1], -1))
    return res

def login(data):
    if ('username' not in data or 'password' not in data):
        return (0, response_helper.response(400))
    res = auth_model.login(data['username'], data['password'])
    if res[0] == 0:
        if res[1] == 401:
            return (0, response_helper.response(
                401, -1, {'app_message': 'Invalid username or password'}))
    else:
        accesstoken = jwt_helper.sign(
            {'id': res[1][0], 'username': res[1][1], 'exp': int(time.time() + 24 * 60 * 60)})
        return (1, response_helper.response(
            200, -1, {'app_message': 'Login successfully', 'accesstoken': accesstoken}))

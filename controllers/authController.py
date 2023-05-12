from models import authModel
from helpers import responseHelper, jwtHelper
import re
import time

def register(data):
    if ('username' not in data or 'password' not in data):
        return (0, responseHelper.response(400))
    
    if len(data['password']) < 8:
        return (0, responseHelper.response(400, 'Short password'))

    if (not re.match(r'^[0-9a-zA-Z_]{6,40}$', data["username"])):
        return (0, responseHelper.response(400, 'Invalid username'))
    
    res = authModel.register(data['username'], data['password'])

    if (res[0] == 1):
        return (1, responseHelper.response(200, -1, {'app_message': 'Registration successfully'}))
    elif (res[0] == 0):
        if (res[1] == 509):
            return (0, responseHelper.response(509, -1, {'app_message': 'Username is already taken'}))
        else:
            return (0, responseHelper.response(res[1], -1))
    return res
        
def login(data):
    if ('username' not in data or 'password' not in data):
        return (0, responseHelper.response(400))
    
    res = authModel.login(data['username'], data['password'])
    if (res[0] == 0):
        if (res[1] == 409):
            return (0, responseHelper(409, -1, {'app_message': 'Invalid username or password'}))
    else:
        accesstoken = jwtHelper.sign({'username': res[1], 'exp': int(time.time() + 24 * 60 * 60)})
        return (1, responseHelper.response(200, -1, {'app_message': 'Login successfully', 'accesstoken': accesstoken}))
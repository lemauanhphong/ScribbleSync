from models import authModel
from helpers import responseHelper, jwtHelper

import re
import time

def register(data):
    if ('username' not in data or 'password' not in data):
        return responseHelper.response(400)
    
    if len(data['password']) < 8:
        return responseHelper.response(400, 'Short password')

    if (not re.match(r'^[0-9a-zA-Z_]{6,40}$', data["username"])):
        return responseHelper.response(400, 'Invalid username')
    
    res = authModel.register(data['username'], data['password'])

    return res
        
def login(data):
    if ('username' not in data or 'password' not in data):
        return responseHelper.response(400)
    
    res = authModel.login(data['username'], data['password'])
    if (res[0] == 0):
        return res
    else:
        accesstoken = jwtHelper.sign({'username': res[1], 'exp': int(time.time() + 24 * 60 * 60)})
        return (1, responseHelper.response(200, -1, {'app_message': 'Login successfully', 'accesstoken': accesstoken}))
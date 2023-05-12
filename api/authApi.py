from controllers.authController import *
from helpers import *

def route(data):
    try:
        if data['action'] == '/api/auth/register':
            return authController.register(data['data'])
        elif data['action'] == '/api/auth/login':
            return authController.login(data['data'])
        else: 
            return (0, {"statuscode": 405, "message": "Method Not Allowed"})
    except:
        return (0, {"statuscode": 500})


from controllers import authController
from helpers import responseHelper

def route(data):
    try:
        if data['action'] == '/api/auth/register':
            return authController.register(data['data'])
        elif data['action'] == '/api/auth/login':
            return authController.login(data['data'])
        else: 
            return (0, responseHelper.response(405))
    except:
        return (0, responseHelper.response(500))


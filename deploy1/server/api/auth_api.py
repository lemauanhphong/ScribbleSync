from controllers import auth_controller
from helpers import response_helper

def route(data):
    if data['action'] == '/api/auth/register':
        return auth_controller.register(data['data'])
    if data['action'] == '/api/auth/login':
        return auth_controller.login(data['data'])
    return (0, response_helper.response(503))

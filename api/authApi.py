from controllers import authController
from helpers import responseHelper


def route(data):
    if data["action"] == "/api/auth/register":
        return authController.register(data["data"])
    if data["action"] == "/api/auth/login":
        return authController.login(data["data"])
    return (0, responseHelper.response(503))

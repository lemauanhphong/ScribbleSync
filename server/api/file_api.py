import re

from controllers import file_controller
from helpers.response_helper import response


def route(body):
    action = body["action"]
    data = body["data"]
    token = body["token"]

    if action == "/api/file":
        return file_controller.get_list(token)
    if action == "/api/file/upload":
        return file_controller.upload(data, token)
    if re.match(r"^/api/file/\d+$", action):
        return file_controller.get(action)
    if re.match(r"^/api/file/delete/\d+$", action):
        return file_controller.detele(action)

    return (0, response(503))

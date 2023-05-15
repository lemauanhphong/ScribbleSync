import re

from controllers import note_controller
from helpers.response_helper import response


def route(data):
    action = data["action"]
    data = data["data"]
    token = data["token"]

    if action == "/api/note/new":
        return note_controller.new(data, token)

    if action == "/api/note":
        return note_controller.get_list(token)

    if re.match(r"^/api/note/\d+$", action):
        return note_controller.get(action)

    if re.match(r"^/api/note/edit/\d+$", action):
        return note_controller.edit(action, data)

    if re.match(r"^/api/note/delete/\d+$", action):
        return note_controller.delete(action)

    return (0, response(503))

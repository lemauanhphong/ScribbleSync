import re

from controllers import note_controller
from helpers import response_helper


def route(data):
    action = data["action"]
    data = data["data"]
    token = data["token"]

    if action == "/api/note/new":
        return note_controller.new_note(data, token)

    if action == "/api/note":
        return note_controller.get_list_of_note_id(token)

    if re.match(r"^/api/note/\d+$", action):
        return note_controller.get_note(action)

    if re.match(r"^/api/note/edit/\d+$", action):
        return note_controller.edit_note(action, data)

    if re.match(r"^/api/note/delete/\d+$", action):
        return note_controller.delete_note(action)

    return (0, response_helper.response(503))

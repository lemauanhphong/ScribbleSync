import re

from controllers import note_controller
from helpers.response_helper import response


def route(body):
    if body["action"] == "/api/note":
        return note_controller.get_note_ids(body)

    if body["action"] == "/api/note/new":
        return note_controller.new_note(body)

    if re.match(r"^/api/note/[0-9a-z-]+$", body["action"]):
        return note_controller.get_note(body)

    if re.match(r"^/api/note/edit/\d+$", body["action"]):
        return note_controller.update_note(body)

    if re.match(r"^/api/note/delete/\d+$", body["action"]):
        return note_controller.delete_note(body)

    if re.match(r"^/api/note/get_share_token/\d+$", body["action"]):
        return note_controller.get_share_token(body)

    print(body)

    return (0, response(503))

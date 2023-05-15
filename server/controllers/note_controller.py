from helpers import response_helper
from models import note_model


def new_note(data, token):
    if note_model.new_note(token["id"], data["name"], data["content"]):
        return (1, response_helper.response(200))
    return (0, response_helper.response(500))


def get_list_of_note_id(token):
    list_of_id = note_model.get_list_of_note_id(token["id"])
    return (1, response_helper.response(200, -1, {"id", list_of_id}))


def get_note(action):
    note_id = action.split("/")[-1]
    note = note_model.get_note(note_id)
    if note:
        return (1, response_helper.response(200, -1, {"content": note[0]}))
    return (0, response_helper.response(404))


def edit_note(action, data):
    note_id = action.split("/")[-1]

    share = ""
    if data["share_all"]:
        share = "*"
    elif data["share_add"] or data["share_remove"]:
        share = note_model.get_note_share(note_id)[0].split(",")
        for username in data["share_remove"]:
            share.remove(username)
        for username in data["share_add"]:
            share.append(username)

    if note_model.update_note(note_id, data["name"], data["content"], share):
        return (1, response_helper.response(200))
    return (0, response_helper.response(500))


def delete_note(action):
    note_id = int(action.split("/"))
    if note_model.delete_note(note_id):
        return (1, response_helper.response(200))
    return (0, response_helper.response(500))

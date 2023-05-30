from helpers.response_helper import response
from models import note_model


def new(data, token):
    if not note_model.new(token["id"], data["name"], data["content"]):
        return (0, response(500))

    id_list = note_model.get_last_insert_id()
    return (1, response(200, -1, {"id_list": id_list}))


def get_list(token):
    list_id = note_model.get_list(token["id"])
    return (1, response(200, -1, {"id": list_id}))


def get(action):
    note_id = action.split("/")[-1]
    note = note_model.get(note_id)
    if note:
        return (1, response(200, -1, {"content": note[0]}))
    return (0, response(404))


def edit(action, data):
    note_id = action.split("/")[-1]

    share = ""
    if data["share_all"]:
        share = "*"
    elif data["share_add"] or data["share_remove"]:
        share = note_model.get_share(note_id)[0].split(",")
        for username in data["share_remove"]:
            share.remove(username)
        for username in data["share_add"]:
            share.append(username)

    if note_model.update(note_id, data["name"], data["content"], share):
        return (1, response(200))
    return (0, response(500))


def delete(action):
    note_id = int(action.split("/"))
    if note_model.delete(note_id):
        return (1, response(200))
    return (0, response(500))

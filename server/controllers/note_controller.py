import uuid

from helpers.response_helper import response
from models import note_model


def new_note(body):
    if not note_model.new_note(body["token"]["id"], body["data"].get("name"), body["data"].get("content")):
        return (0, response(500))
    return (1, response(200, -1, {"id": note_model.get_last_insert_id()}))


def get_note_ids(body):
    uid = body["token"]["id"]

    id_list = note_model.get_note_ids(uid)
    result = {"share": [], "private": []}

    for note_id in id_list:
        share_token = note_model.get_share_token(note_id, uid)
        shares = note_model.get_shares(note_id, uid)

        if share_token or shares[0][0]:
            result["share"].append(note_id)
        else:
            result["private"].append(note_id)

    return (1, response(200, -1, {"id_list": result}))


def get_note(body):
    note_id = body["action"].split("/")[-1]
    if "-" in note_id:
        note = note_model.get_shared_note(note_id)
    else:
        note = note_model.get_note(note_id, body["token"]["id"])
    if note:
        return (1, response(200, -1, {"name": note[0][0], "content": note[0][1]}))
    return (0, response(404))


def update_note(body):
    note_id = body["action"].split("/")[-1]
    uid = body["token"]["id"]
    name = body["data"].get("name")
    content = body["data"].get("content")

    if not note_model.belong_to(note_id, uid):
        return (0, response(401))

    if name or content:
        if not note_model.update_note(note_id, uid, name, content):
            return (0, response(500))

    share_all = body["data"].get("share_all")
    if share_all != "":
        note_model.clear_shares(note_id)
        if share_all:
            note_model.set_share_token(note_id, str(uuid.uuid4()), uid)
        else:
            note_model.set_share_token(note_id, None, uid)

    if body["data"].get("share_add"):
        note_model.add_shares(note_id, note_model.get_uid(body["data"].get("share_add")))
    elif body["data"].get("share_remove"):
        note_model.remove_shares(note_id, note_model.get_uid(body["data"].get("share_remove")))

    return (1, response(200))


def get_share_token(body):
    note_id = body["action"].split("/")[-1]
    return (1, response(200, -1, {"share_token": note_model.get_share_token(note_id, body["token"]["id"])}))


def delete_note(body):
    note_id = int(body["action"].split("/")[-1])
    if note_model.delete_note(note_id, body["token"]["id"]):
        return (1, response(200))
    return (0, response(500))

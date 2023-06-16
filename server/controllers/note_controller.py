import uuid

from helpers.response_helper import response
from models import note_model


def new_note(body):
    content = body["data"].get("content")
    if content and len(content) / 1024**3 > 26.7:
        return (0, "The note size must be smaller than 20MB", response(413))

    if not note_model.new_note(body["token"]["id"], body["data"].get("name"), content):
        return (0, response(500))
    return (1, response(200, -1, {"id": note_model.get_last_insert_id()}))


def get_note_ids(body):
    uid = body["token"]["id"]

    id_list = note_model.get_note_ids(uid)
    result = {"share": [], "priv": []}

    for note_id in id_list:
        share_token = note_model.get_share_token(note_id, uid)
        shares = note_model.get_shares(note_id, uid)

        if share_token or shares[0]["uid"]:
            result["share"].append(note_id)
        else:
            result["priv"].append(note_id)

    return (1, response(200, -1, {"id_list": result}))


def get_note(body):
    note_id = body["action"].split("/")[-1]
    if "-" in note_id:
        note = note_model.get_shared_note(note_id)
    else:
        note = note_model.get_note(note_id, body["token"]["id"])
    if note:
        return (1, response(200, -1, {"name": note[0]["name"], "content": note[0]["content"]}))
    return (0, response(404))


def update_note(body):
    note_id = body["action"].split("/")[-1]
    uid = body["token"]["id"]
    name = body["data"].get("name")
    content = body["data"].get("content")

    if content and len(content) / 1024**3 > 26.7:
        return (0, "The note size must be smaller than 20MB", response(413))

    if not note_model.belong_to(note_id, uid):
        return (0, response(401))

    if name or content:
        if not note_model.update_note(note_id, uid, name, content):
            return (0, response(500))

    if isinstance((share_all := body["data"].get("share_all")), bool):
        note_model.clear_shares(note_id)
        note_model.set_share_token(note_id, str(uuid.uuid4()) if share_all else None, uid)

    if username := body["data"].get("share_add"):
        if uid := note_model.get_uid(username):
            if not note_model.add_shares(note_id, uid[0]["id"]):
                return (0, response(500))
        else:
            return (0, response("User not found", 404))

    if username := body["data"].get("share_remove"):
        if uid := note_model.get_uid(username):
            if not note_model.remove_shares(note_id, uid[0]["id"]):
                return (0, response(500))
        else:
            return (0, response("User not found", 404))

    return (1, response(200))


def get_share_token(body):
    note_id = body["action"].split("/")[-1]
    return (1, response(200, -1, {"share_token": note_model.get_share_token(note_id, body["token"]["id"])}))


def delete_note(body):
    note_id = body["action"].split("/")[-1]
    if note_model.delete_note(note_id, body["token"]["id"]):
        return (1, response(200))
    return (0, response(500))

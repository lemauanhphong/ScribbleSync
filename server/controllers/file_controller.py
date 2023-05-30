from helpers.response_helper import response
from models import file_model


def get_list(token):
    id_list = file_model.get_list(token["id"])
    return (1, response(200, -1, {"id_list": id_list}))


def get(action):
    file_id = action.split("/")[-1]
    file = file_model.get(file_id)
    if file:
        return (1, response(200, -1, {"name": file[0][0], "content": file[0][1]}))
    return (0, response(404))


def upload(data, token):
    if not file_model.upload(token["id"], data["name"], data["content"]):
        return (0, response(500))
    file_id = file_model.get_last_insert_id()
    return (1, response(200, -1, {"id": file_id}))


def detele(action):
    file_id = action.split("/")[-1]
    if file_model.delete(file_id):
        return (1, response(200))
    return (0, response(500))

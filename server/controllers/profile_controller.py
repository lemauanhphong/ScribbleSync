from helpers.response_helper import response
from models import profile_model


def get_profile(body):
    profile = profile_model.get_profile(body["token"]["id"])
    return (1, response(200, -1, {"avatar": profile}))


def update_profile(body):
    if profile_model.update_profile(body["token"]["id"], body["data"]["new_password"], body["data"]["new_avatar"]):
        return (1, response(200))
    return (0, response(500))

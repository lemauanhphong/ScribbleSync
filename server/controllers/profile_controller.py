from helpers.response_helper import response
from models import profile_model


def get_profile(body):
    profile = profile_model.get_profile(body["token"]["id"])
    return (1, response(200, -1, {"avatar": profile[0]["avatar"] if profile else None}))


def get_avatar(body):
    username = body["action"].split("/")[-1]
    avatar = profile_model.get_avatar(username)
    return (1, response(200, -1, {"avatar": avatar[0]["avatar"] if avatar else None}))


def update_profile(body):
    new_avatar = body["data"].get("new_avatar")
    if new_avatar and len(new_avatar) / 1024**3 > 2.7:
        return (0, response("The image size must be smaller than 2MB", 413))

    new_password = body["data"].get("new_password")
    if new_password and len(new_password) < 8:
        return (0, response("Short password", 400))

    if profile_model.update_profile(body["token"]["id"], new_password, new_avatar):
        return (1, response(200))

    return (0, response(500))

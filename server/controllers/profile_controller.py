from helpers.response_helper import response
from models import profile_model


def get_profile(body):
    avatar = profile_model.get_profile(body["token"]["id"])
    return (1, response(200, -1, {"avatar": avatar[0][0] if avatar else None}))


def update_profile(body):
    new_avatar = body["data"]["new_avatar"]
    if new_avatar and len(new_avatar) / 1024**3 > 2.7:
        return (0, response("The image size must be smaller than 2MB", 413))

    if profile_model.update_profile(body["token"]["id"], body["data"]["new_password"], new_avatar):
        return (1, response(200))
    return (0, response(500))

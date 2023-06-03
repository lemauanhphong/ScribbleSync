from helpers.response_helper import response
from models import profile_model


def get_profile(token):
    profile = profile_model.get_profile(token["id"])
    return (1, response(200, -1, {"avatar": profile}))


def update_profile(data, token):
    if profile_model.update_profile(
        token["id"], data["new_password"], data["new_avatar"]
    ):
        return (1, response(200))
    return (0, response(500))

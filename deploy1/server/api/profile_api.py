import re

from controllers import profile_controller
from helpers.response_helper import response


def route(body):
    if body["action"] == "/api/profile":
        return profile_controller.get_profile(body)
    if body["action"] == "/api/profile/update":
        return profile_controller.update_profile(body)
    if re.match(r"^/api/profile/avatar/[\w.]+$", body["action"]):
        return profile_controller.get_avatar(body)
    return (0, response(503))

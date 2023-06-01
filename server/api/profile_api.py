from controllers import profile_controller


def route(body):
    action = body["action"]
    data = body["data"]
    token = body["token"]

    if action == "/api/profile":
        return profile_controller.get_profile(token)
    if action == "/api/profile/update":
        return profile_controller.update_profile(data, token)

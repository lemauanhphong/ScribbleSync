from controllers import profile_controller


def route(body):
    if body["action"] == "/api/profile":
        return profile_controller.get_profile(body)
    if body["action"] == "/api/profile/update":
        return profile_controller.update_profile(body)

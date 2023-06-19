import re

from controllers import template_controller
from helpers import response_helper


def route(data):
    if data["action"] == "/api/template":
        return template_controller.get_list_of_templates()
    if re.match(r"^\/api\/template/\d+$", data["action"]):
        return template_controller.get_template(data["action"])
    return (0, response_helper.response(503))

from helpers import response_helper
from models import template_model


def get_list_of_templates():
    items = template_model.get_list_of_templates()
    return (1, response_helper.response(200, -1, {"items": items}))


def get_template(data):
    template_id = int(data.split("/")[-1])
    template = template_model.get_template(template_id)
    if len(template) == 0:
        return (0, response_helper.response(404, -1))
    return (1, response_helper.response(200, -1, {"template": template[0]}))

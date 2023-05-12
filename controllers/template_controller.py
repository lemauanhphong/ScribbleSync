from models import template_model
from helpers import response_helper

def get_list_of_template_id():
    list_of_id = template_model.get_list_of_template_id()
    return (1, response_helper.response(200, -1, {'id': list_of_id}))

def get_template(data):
    template_id = int(data.split('/')[-1])
    template = template_model.get_template(template_id)
    if len(template) == 0:
        return (0, response_helper.response(404, -1))
    return (1, response_helper.response(200, -1, {'template': template[0]}))

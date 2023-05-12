from controllers import templateController
from helpers import responseHelper
import re

def route(data):
    if (data['action'] == '/api/template'):
        return templateController.getListOfTemplateId()
    elif (re.match(r'^\/api\/template/\d+$', data['action'])):
        return templateController.getTemplate(data['action'])
    else: 
        return (0, responseHelper.response(503))
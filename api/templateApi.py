from controllers import templateController
from helpers import responseHelper
import re

def route(data):
    if (data['action'] == '/api/template'):
        pass
    elif (re.match(r'^\/api\/template/\d+$', data['action'])):
        pass
    else: 
        return (0, responseHelper.response(503))
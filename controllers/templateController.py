from models import templateModel
from helpers import responseHelper

def getListOfTemplateId():
    listOfId = templateModel.getListOfTemplateId()
    return (1, responseHelper.response(200, -1, {'id': listOfId}))

def getTemplate(data):
    tempalteId = int(data.split('/')[-1])
    template = templateModel.getTemplate(tempalteId)
    if (len(template) == 0):
        return (0, responseHelper.response(404, -1))
    return (1, responseHelper.response(200, -1, {'template': template[0]}))
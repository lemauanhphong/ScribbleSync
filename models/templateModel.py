from server import db
from helpers import responseHelper

def getListOfTemplateId():
    return db.query('SELECT id FROM templates') 
    
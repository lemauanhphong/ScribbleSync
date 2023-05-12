from server import db
from helpers import responseHelper

def getListOfTemplateId():
    return db.query('SELECT id FROM templates')

def getTemplate(id):
    return db.query('SELECT * FROM templates WHERE id = %d', (id,))
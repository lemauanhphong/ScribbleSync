from database import db


def get_list_of_template_id():
    list_id = db.query("SELECT id FROM templates")
    return [x[0] for x in list_id]


def get_template(template_id):
    return db.query("SELECT * FROM templates WHERE id = %d", (template_id,))

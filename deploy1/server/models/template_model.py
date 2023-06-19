from database import db


def get_list_of_templates():
    return db.query("SELECT id, name FROM templates")


def get_template(template_id):
    return db.query("SELECT * FROM templates WHERE id = %d", (template_id,))

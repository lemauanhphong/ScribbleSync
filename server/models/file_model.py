from database import db


def get_list(uid):
    return db.query("SELECT id FROM files WHERE uid = %s", (uid,))


def get(file_id):
    return db.query("SELECT name, data FROM files WHERE id = %s", (file_id,))


def upload(uid, name, data):
    return db.update("INSERT INTO files (uid, name, data) VALUES (%s, %s, %s)", (uid, name, data))


def delete(file_id):
    return db.update("DELETE * FROM files WHERE id = %s", (file_id,))

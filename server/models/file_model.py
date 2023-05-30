from database import db


# TODO: check uid, share permission
def get_list(uid):
    id_list = db.query("SELECT id FROM files WHERE uid = %d", (uid,))
    return [x[0] for x in id_list]


def get_last_insert_id():
    return db.query("SELECT LAST_INSERT_ID()")[0][0]


def get(file_id):
    res = db.query("SELECT name, content FROM files WHERE id = %d", (file_id,))
    print("get", res)
    return res


def upload(uid, name, content):
    print("upload", name, content)
    return db.update(
        "INSERT INTO files (uid, name, content) VALUES (%d, %s, %s)",
        (uid, name, content),
    )


def delete(file_id):
    return db.update("DELETE * FROM files WHERE id = %d", (file_id,))

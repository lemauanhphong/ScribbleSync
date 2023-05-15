from database import db


def get_list(uid):
    return db.query("SELECT id FROM notes WHERE uid = %s", (uid,))


def get(note_id):
    return db.query("SELECT name, content FROM notes WHERE id = %s", (note_id,))


def get_share(note_id):
    return db.query("SELECT share FROM notes WHERE id = %s", (note_id,))


def new(uid, name, content):
    return db.update(
        'INSERT INTO notes (uid, name, content, share) VALUES (%s, %s, %s, "")',
        (uid, name, content),
    )


# share = '*' -> share all
# share = 'tom,jerry' -> share to tom and jerry
# share = '' -> no share
def update(note_id, name, content, share):
    return db.update(
        "UPDATE notes SET name = %s, content = %s, share = %s WHERE id = %s",
        (name, content, share, note_id),
    )


def delete(note_id):
    return db.query("DELETE * FROM notes WHERE id = %s", (note_id,))

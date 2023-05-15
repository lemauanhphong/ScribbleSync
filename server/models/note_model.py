from database import db


def get_list_of_note_id(uid):
    return db.query("SELECT id FROM notes WHERE uid = %s", (uid,))


def get_note(note_id):
    return db.query("SELECT * FROM notes WHERE id = %s", (note_id,))


def get_note_share(note_id):
    return db.query("SELECT * FROM notes WHERE id = %s", (note_id,))


def new_note(uid, name, content):
    return db.update(
        'INSERT INTO notes (uid, name, content, share) VALUES (%s, %s, %s, "")',
        (uid, name, content),
    )


# share = '*' -> share all
# share = 'tom,jerry' -> share to tom and jerry
# share = '' -> no share
def update_note(note_id, name, content, share):
    return db.update(
        "UPDATE notes SET name = %s, content = %s, share = %s WHERE id = %s",
        (name, content, share, note_id),
    )


def delete_note(note_id):
    return db.query("DELETE * FROM notes WHERE id = %s", (note_id,))

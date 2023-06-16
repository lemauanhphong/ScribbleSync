from database import db


def get_uid(username):
    return db.query("SELECT id FROM users WHERE username=?", (username,))


def get_last_insert_id():
    return db.query("SELECT LAST_INSERT_ID()")[0]["LAST_INSERT_ID()"]


def get_note(note_id, uid):
    return db.query(
        """
        SELECT
            name, content
        FROM
            notes a LEFT JOIN shares b ON a.id=b.id
        WHERE
            a.id=? AND (a.uid=? OR b.uid=?)""",
        (note_id, uid, uid),
    )


def get_shared_note(share_token):
    return db.query("SELECT name, content FROM notes WHERE share_token=?", (share_token,))


def get_note_ids(uid):
    list_id = db.query("SELECT id FROM notes WHERE uid=?", (uid,))
    return [x["id"] for x in list_id]


def new_note(uid, name, content):
    return db.update("INSERT INTO notes (uid, name, content) VALUES (?, ?, ?)", (uid, name, content))


def update_note(note_id, uid, name, content):
    placeholders = []
    params = ()

    if name:
        placeholders.append("name")
        params += (name,)
    if content:
        placeholders.append("content")
        params += (content,)

    return db.update(f"UPDATE notes SET {'=?,'.join(placeholders)}=? WHERE id=? AND uid=?", params + (note_id, uid))


def delete_note(note_id, uid):
    return db.update("DELETE FROM notes WHERE id=? AND uid=?", (note_id, uid))


def get_share_token(note_id, uid):
    return db.query("SELECT share_token FROM notes WHERE id=? AND uid=? LIMIT 1", (note_id, uid))[0]["share_token"]


def set_share_token(note_id, share_token, uid):
    return db.update("UPDATE notes SET share_token=? WHERE id=? AND uid=?", (share_token, note_id, uid))


def get_share_list(note_id):
    result = db.query(
        "SELECT username FROM shares LEFT JOIN users ON shares.uid=users.id WHERE shares.id=?",
        (note_id,),
    )
    return [x["username"] for x in result]


def share_add(note_id, uid):
    return db.update("INSERT INTO shares(id, uid) VALUES (?, ?)", (note_id, uid))


def share_remove(note_id, uid):
    return db.update("DELETE FROM shares WHERE id=? AND uid=?", (note_id, uid))


def clear_shares(note_id):
    return db.update("DELETE FROM shares WHERE id=?", (note_id,))


def get_shared_note_ids(uid):
    ids = db.query("SELECT id FROM shares WHERE uid=?", (uid,))
    return [x["id"] for x in ids]


def belong_to(note_id, uid):
    return db.query("SELECT id FROM notes WHERE id=? AND uid=?", (note_id, uid)) != []

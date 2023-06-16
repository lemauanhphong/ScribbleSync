import bcrypt

from database import db


def get_profile(uid):
    return db.query("SELECT avatar FROM users WHERE id=?", (uid,))


def update_profile(uid, new_password, new_avatar):
    placeholders = []
    params = ()

    if new_password:
        placeholders.append("password=?")
        params += (bcrypt.hashpw(new_password.encode(), bcrypt.gensalt()).decode(),)
    if new_avatar:
        placeholders.append("avatar=?")
        params += (new_avatar,)

    return not placeholders or db.update(f'UPDATE users SET {",".join(placeholders)} WHERE id=?', params + (uid,))

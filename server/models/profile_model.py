import bcrypt

from database import db


def get_profile(uid):
    result = db.query("SELECT avatar FROM users WHERE id = %d", (uid,))
    return result[0][0] if result else result


def update_profile(uid, new_password, new_avatar):
    stmt = []
    param = ()

    if new_password:
        stmt.append("password = %s")
        param += (bcrypt.hashpw(new_password.encode(), bcrypt.gensalt()).decode(),)
    if new_avatar:
        stmt.append("avatar = %s")
        param += (new_avatar,)

    return not stmt or db.update(f'UPDATE users SET {",".join(stmt)} WHERE id = %d', param + (uid,))

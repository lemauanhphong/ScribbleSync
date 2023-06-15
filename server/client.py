import json
import random
import string

from pwn import remote


def pew(action, data={}):
    body = {"action": action, "data": data, "token": token}
    content = json.dumps(body).encode() + b"\n"

    r = remote("localhost", 2808)
    r.send(content)

    resp = json.loads(r.recv())
    print(resp)

    return resp


# acc = {"username": "".join(random.choices(string.ascii_letters, k=6)), "password": "12345$%%^)(_)IIJMA"}
acc = {"username": "meomeo13", "password": "12345$%%^)(_)IIJMA"}
token = ""

pew("/api/auth/register", acc)
resp = pew("/api/auth/login", acc)
token = resp["token"]

# note_id = pew("/api/note/new", {"name": "hehe", "content": "lmao"})["id"]
# pew(f"/api/note/delete/{note_id}")
# pew("/api/note")
# pew(f"/api/note/{note_id}")
#
# pew(f"/api/note/edit/{note_id}", {"name": "ohno", "content": "burh", "share_all": True})
# pew(f"/api/note/{note_id}")
#
# share_token = pew(f"/api/note/get_share_token/{note_id}")["share_token"]
# pew(f"/api/note/{share_token}")
#
# pew(f"/api/note/edit/{note_id}", {"name": "", "content": "", "share_all": False})
# pew(f"/api/note/{share_token}")
note_id = 84
pew(f"/api/note/edit/{note_id}", {"share_add": "meomeo12"})
pew(f"/api/note/edit/{note_id}", {"share_add": "IQwZFV"})
pew(f"/api/note/edit/{note_id}", {"share_add": "tljgVa"})
pew(f"/api/note/edit/{note_id}", {"share_add": "rkxHuQ"})


# pew("/api/profile")
# pew("/api/profile/update", {"new_password": "abcdef", "new_avatar": "lmaobro"})
# pew("/api/profile")

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


token = ""

# acc = {"username": "".join(random.choices(string.ascii_letters, k=6)), "password": "12345$%%^)(_)IIJMA"}
acc = {"username": "meomeo14", "password": "12345$%%^)(_)IIJMA"}
pew(f"/api/profile/avatar/{acc['username']}")

pew("/api/auth/register", acc)

token = pew("/api/auth/login", acc)["token"]

pew("/api/template")

note_id = pew("/api/note/new", {"name": "hehe", "content": "lmao"})["id"]
pew("/api/note")
pew(f"/api/note/{note_id}")
pew(f"/api/note/delete/{note_id}")
pew(f"/api/note/{note_id}")

# pew("/api/note/new", {"name": "hehe", "content": "lmao"})["id"]
note_id = 47
pew(f"/api/note/edit/{note_id}", {"name": "ohno", "content": "burh", "share_all": True})
pew(f"/api/note/{note_id}")

# share_token = pew(f"/api/note/get_share_token/{note_id}")["share_token"]
# pew(f"/api/note/{share_token}")

# pew(f"/api/note/edit/{note_id}", {"name": "", "content": "", "share_all": False})
# pew(f"/api/note/{share_token}")

pew(f"/api/note/edit/{note_id}", {"share_add": "meomeo13"})
pew(f"/api/note/edit/{note_id}", {"share_add": "bxZItX"})
pew(f"/api/note/edit/{note_id}", {"share_add": "UZmEqg"})
pew(f"/api/note/edit/{note_id}", {"share_add": "evsska"})
# pew(f"/api/note/edit/{note_id}", {"share_remove": "meomeo13"})


# pew(f"/api/note/get_share_list/{note_id}")

pew("/api/profile")
pew("/api/profile/update", {"new_avatar": "bro"})

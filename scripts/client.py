import json
import random
import string

from pwn import remote


def pew(action, data={}):
    body = {"action": action, "data": data, "token": token}
    content = json.dumps(body).encode() + b"\n"

    r = remote("192.168.244.173", 8028)
    r.send(content)

    resp = json.loads(r.recv())
    print(resp)

    return resp


token = ""

acc = {"username": "".join(random.choices(string.ascii_letters, k=6)), "password": "12345$%%^)(_)IIJMA"}
# acc = {"username": "meomeo14", "password": "12345$%%^)(_)IIJMA"}

pew("/api/auth/register", acc)
token = pew("/api/auth/login", acc)["token"]

pew("/api/profile")
pew("/api/profile/update", {"new_avatar": "bro"})
pew(f"/api/profile/avatar/{acc['username']}")

pew("/api/profile/update", {"new_avatar": "hehe"})
pew(f"/api/profile/avatar/{acc['username']}")

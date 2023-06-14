import jwt

with open('key/ed25519key.pem', 'rb') as file:
    private_key = file.read()

with open('key/ed25519pubkey.pem', 'rb') as file:
        public_key = file.read()

def sign(data):
    enc = jwt.encode(data, private_key, algorithm="EdDSA")
    if type(enc) == "bytes":
        enc = enc.decode()
    return enc

def verify(token):
    return jwt.decode(token, public_key, algorithms=["EdDSA"])

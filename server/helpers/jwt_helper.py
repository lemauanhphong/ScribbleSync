import jwt

def sign(data, private_key_location = 'key/jwtRS512.key'):
    private_key = open(private_key_location, 'rb').read()
    return jwt.encode(data, private_key, algorithm="RS512").decode()

def verify(token, public_key_location = 'key/jwtRS512.key.pub'):
    public_key = open(public_key_location, 'rb').read()
    return jwt.decode(token, public_key, algorithms=["RS512"])

import jwt

def sign(data, private_key_location = 'key/jwtRS512.key'):
    with open(private_key_location, 'rb') as file:
        private_key = file.read()
    return jwt.encode(data, private_key, algorithm="RS512").decode()

def verify(token, public_key_location = 'key/jwtRS512.key.pub'):
    with open(public_key_location, 'rb') as file:
        public_key = file.read()
    return jwt.decode(token, public_key, algorithms=["RS512"])

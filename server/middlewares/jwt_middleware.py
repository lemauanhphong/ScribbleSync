from helpers import jwt_helper, key_helper

def jwt_validator(token):
    data = jwt_helper.verify(token)
    return key_helper.key_validator(data, ['username', 'exp'])

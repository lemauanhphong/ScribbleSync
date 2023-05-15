from traceback import print_exception

from helpers import jwt_helper, key_helper


def jwt_validator(token):
    try:
        data = jwt_helper.verify(token)
        if key_helper.key_validator(data, ["id", "username", "exp"]):
            return data
    except Exception as e:
        print_exception(e)
    return False
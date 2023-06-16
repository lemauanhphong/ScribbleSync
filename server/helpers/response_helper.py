statusMessage = {
    200: "OK",
    400: "Bad Request",
    401: "Unauthorized",
    403: "Forbidden",
    404: "Not Found",
    409: "Conflict",
    500: "Internal Server Error",
    503: "Method Not Allowed",
}


def response(statuscode, message=-1, more=None):
    return_message = message
    if message == -1:
        try:
            return_message = statusMessage[statuscode]
        except KeyError:
            return_message = "-1"
    return_dict = {"statuscode": statuscode, "message": return_message}
    if more is not None:
        return_dict.update(more)
    return return_dict

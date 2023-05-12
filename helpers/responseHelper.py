import json

statusMessage = {
    200: "OK",
    400: "Bad Request",
    409: "Conflit",
    500: "Internal Server Error",
    503: "Method Not Allowed"
}

def response(statuscode, message=-1, more={}):
    returnMessage = message
    if (message == - 1):
        returnMessage = statusMessage[statuscode]
    returnDict = {'statuscode': statuscode, 'message': message}
    returnDict.update(more)
    return returnDict
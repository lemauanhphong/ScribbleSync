def key_validator(data, key_dict):
    for key in key_dict:
        if not isinstance(key, str):
            return False
        components = key.split('/')
        tmp = data
        try:
            for component in components:
                tmp = tmp[component]
        except KeyError:
            return False
        if not isinstance(tmp, key_dict[key]):
            return False
    return True
    
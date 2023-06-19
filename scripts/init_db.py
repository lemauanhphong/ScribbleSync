import os

import sqlparse
from database import db

if __name__ == "__main__":
    with open("schema.sql") as f:
        for stmt in sqlparse.split(f.read()):
            db.update(stmt)

    for file_name in os.listdir("templates"):
        with open("templates/" + file_name, "r") as f:
            db.update("INSERT INTO templates(name, content) VALUES (?, ?)", (os.path.splitext(file_name)[0], f.read()))

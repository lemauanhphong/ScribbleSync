import os
import sys
from traceback import print_exc

import mariadb
import sqlparse


class Database:
    _instance = None

    def __new__(cls):
        if cls._instance is None:
            cls._instance = super().__new__(cls)
        return cls._instance

    def connect(self):
        try:
            self.conn = mariadb.connect(
                user="root",
                password="123456",
                host="127.0.0.1",
                port=3306,
                database="scribble_sync",
            )
            self.conn.autocommit = True
            self.cursor = self.conn.cursor(dictionary=True)
        except mariadb.Error:
            print_exc()
            sys.exit(1)

    def query(self, stmt, param=None):
        try:
            if param:
                self.cursor.execute(stmt, param)
            else:
                self.cursor.execute(stmt)
            return True
        except Exception:
            self.conn.rollback()
            print_exc()
            return False


if __name__ == "__main__":
    db = Database()
    db.connect()

    with open("../database/schema.sql") as f:
        for stmt in sqlparse.split(f.read()):
            db.query(stmt)

    for file_name in os.listdir("templates"):
        with open("templates/" + file_name, "r") as f:
            db.query("INSERT INTO templates(name, content) VALUES (?, ?)", (os.path.splitext(file_name)[0], f.read()))

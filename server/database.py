import sys
from traceback import print_exc

import mariadb


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
                ssl_ca="key/server-ca.pem",
                ssl_cert="key/client-cert.pem",
                ssl_key="key/client-key.pem",
            )
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
            return self.cursor.fetchall()
        except Exception:
            print_exc()
            return []

    def update(self, stmt, param=None):
        try:
            if param:
                self.cursor.execute(stmt, param)
            else:
                self.cursor.execute(stmt)
            self.conn.commit()
            return True
        except Exception:
            self.conn.rollback()
            print_exc()
            return False


db = Database()
db.connect()

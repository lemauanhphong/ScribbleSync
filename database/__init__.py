import sys
from traceback import print_exception

import mariadb


class Database:
    def connect(self):
        try:
            self.conn = mariadb.connect(
                user="root",
                password="123456",
                host="172.21.0.2",
                port=3306,
                database="scribble_sync",
            )
            self.cursor = self.conn.cursor()
        except mariadb.Error as e:
            print(f"Error connecting to MariaDB Platform: {e}")
            sys.exit(1)

    def query(self, stmt, param=None):
        try:
            if param:
                self.cursor.execute(stmt, param)
            else:
                self.cursor.execute(stmt)
            return self.cursor.fetchall()
        except Exception as e:
            print_exception(e)
            return []

    def update(self, stmt, param=None):
        try:
            if param:
                self.cursor.execute(stmt, param)
            else:
                self.cursor.execute(stmt)
            self.conn.commit()
            return True
        except Exception as e:
            print_exception(e)
            return False

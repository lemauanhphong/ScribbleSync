import sys
import traceback

import mariadb


class Database:
    def connect(self):
        try:
            self.conn = mariadb.connect(
                user="root",
                password="123456",
                host="172.23.0.2",
                port=3306,
                database="scribble_sync",
            )
            self.cursor = self.conn.cursor()
        except mariadb.Error as e:
            print(f"Error connecting to MariaDB Platform: {e}")
            sys.exit(1)

    def query(self, stmt: str, param: tuple):
        try:
            self.cursor.execute(stmt, param)
            return self.cursor.fetchall()
        except Exception as e:
            traceback.print_exception(e)
            return []

    def commit(self):
        try:
            self.conn.commit()
            return True
        except Exception as e:
            traceback.print_exception(e)
            return False

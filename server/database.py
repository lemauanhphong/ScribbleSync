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

    def register(self, user, passwd):
        try:
            stmt = 'INSERT INTO users (username, password, avatar) VALUES (%s, %s, "default.jpg")'
            self.cursor.execute(stmt, (user, passwd))
            self.conn.commit()
            return True
        except Exception as e:
            traceback.print_exception(e)
            return False

    def login(self, user, passwd):
        try:
            stmt = "SELECT * FROM users WHERE username = %s and password = %s"
            self.cursor.execute(stmt, (user, passwd))
            return self.cursor.fetchall() != []
        except Exception as e:
            traceback.print_exception(e)
            return False

    def get_user(self, user):
        try:
            stmt = "SELECT * FROM users WHERE username = %s"
            self.cursor.execute(stmt, (user,))
            return self.cursor.fetchall()
        except Exception as e:
            traceback.print_exception(e)
            return None

    def check_user(self, user):
        try:
            stmt = "SELECT username FROM users WHERE username = %s"
            self.cursor.execute(stmt, (user,))
            return self.cursor.fetchall() != []
        except Exception as e:
            traceback.print_exception(e)
            return False

    def update_avatar(self, user, avatar):
        try:
            stmt = "UPDATE users SET avatar = %s WHERE username = %s"
            self.cursor.execute(stmt, (avatar, user))
            self.conn.commit()
            return True
        except Exception as e:
            traceback.print_exception(e)
            return False

DROP DATABASE IF EXISTS scribble_sync;

CREATE DATABASE scribble_sync;

USE scribble_sync;

DROP TABLE IF EXISTS users;

DROP TABLE IF EXISTS notes;

DROP TABLE IF EXISTS templates;

DROP TABLE IF EXISTS shares;

CREATE TABLE
  users (
    id INT NOT NULL AUTO_INCREMENT,
    username VARCHAR(255) NOT NULL,
    password VARCHAR(255) NOT NULL,
    avatar LONGTEXT,
    UNIQUE (username),
    PRIMARY KEY (id)
  );

CREATE TABLE
  notes (
    id INT NOT NULL AUTO_INCREMENT,
    uid INT NOT NULL,
    name VARCHAR(255) NOT NULL,
    content LONGTEXT,
    share_token VARCHAR(255),
    PRIMARY KEY (id),
    FOREIGN KEY (uid) REFERENCES users (id)
  );

CREATE TABLE
  templates (
    id INT NOT NULL AUTO_INCREMENT,
    name VARCHAR(255),
    content LONGTEXT,
    PRIMARY KEY (id)
  );

CREATE TABLE
  shares (
    id INT NOT NULL,
    uid INT NOT NULL,
    PRIMARY KEY (id, uid),
    FOREIGN KEY (id) REFERENCES notes (id),
    FOREIGN KEY (uid) REFERENCES users (id)
  );

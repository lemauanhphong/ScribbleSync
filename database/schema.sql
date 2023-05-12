CREATE DATABASE scribble_sync;

USE scribble_sync;

DROP TABLE IF EXISTS users;

CREATE TABLE
  users (
    INT NOT NULL AUTO_INCREMENT,
    username VARCHAR(255) NOT NULL,
    password VARCHAR(255) NOT NULL,
    avatar VARCHAR(255) NOT NULL,
    UNIQUE (username),
    PRIMARY KEY (id)
  );

DROP TABLE IF EXISTS notes;

CREATE TABLE
  notes (
    id INT NOT NULL AUTO_INCREMENT,
    uid INT NOT NULL,
    location VARCHAR(255) NOT NULL,
    share INT NOT NULL,
    PRIMARY KEY (id),
    FOREIGN KEY (uid) REFERENCES users (id)
  );

DROP TABLE IF EXISTS files;

CREATE TABLE
  files (
    id INT NOT NULL AUTO_INCREMENT,
    uid INT NOT NULL,
    name VARCHAR(255) NOT NULL,
    location VARCHAR(255) NOT NULL,
    PRIMARY KEY (id),
    FOREIGN KEY (uid) REFERENCES users (id)
  );

DROP TABLE IF EXISTS temples;

CREATE TABLE
  templates (
    id INT NOT NULL AUTO_INCREMENT,
    name VARCHAR(255) NOT NULL,
    location VARCHAR(255) NOT NULL,
    PRIMARY KEY (id)
  );

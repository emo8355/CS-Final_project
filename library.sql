DROP DATABASE IF EXISTS Library
GO

CREATE DATABASE Library
GO

USE Library
GO

CREATE TABLE [admin] (
    admin_id INTEGER PRIMARY KEY IDENTITY(1,1),
	firstname NVARCHAR(50) NOT NULL,
	lastname NVARCHAR(50) NOT NULL,
    email NVARCHAR(255) NOT NULL,
    password NVARCHAR(64) NOT NULL,
    phonenumber CHAR(25),
    created_at DATETIME DEFAULT CURRENT_TIMESTAMP,
	CONSTRAINT admin_indentify UNIQUE(email)
)
GO

CREATE TABLE [category] (
    category_id INTEGER PRIMARY KEY IDENTITY(1,1),
	name NVARCHAR(50) NOT NULL
	CONSTRAINT category_indentify UNIQUE(name)
)
GO

CREATE TABLE [author] (
    author_id INTEGER PRIMARY KEY IDENTITY(1,1),
	firstname NVARCHAR(50) NOT NULL,
	lastname NVARCHAR(50) NOT NULL,
    created_at DATETIME DEFAULT CURRENT_TIMESTAMP,
	CONSTRAINT author_indentify UNIQUE(firstname,lastname)
)
GO

CREATE TABLE [books] (
    book_id INTEGER PRIMARY KEY IDENTITY(1,1),
	title NVARCHAR(180) NOT NULL,
	language NVARCHAR(50) NOT NULL,
	isBorrowed BIT DEFAULT 0,
	category_id INTEGER NOT NULL DEFAULT 0,
	author_id INTEGER NOT NULL DEFAULT 0,
	published_date DATETIME NOT NULL,
	FOREIGN KEY (category_id) REFERENCES category(category_id),
    FOREIGN KEY (author_id) REFERENCES author(author_id),
)
GO


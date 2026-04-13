CREATE DATABASE BookStoreDB

CREATE TABLE Books
(
Id INT PRIMARY KEY IDENTITY(1,1),
Name NVARCHAR(20),
Price DECIMAL(10,2),
StockCount INT
)

CREATE TABLE Authors
(
Id INT PRIMARY KEY IDENTITY(1,1),
FullName NVARCHAR(20)
)

ALTER TABLE Books
ADD AuthorId INT

INSERT INTO Books(Name,Price,StockCount,AuthorId)
VALUES 
('Sefiller', 15.50, 120, 1),
('Cinayet ve Ceza', 12.00, 85, 2),
('Kurk Mantolu Madonna', 8.50, 200, 3),
('1984', 14.00, 150, 4),
('Kimyager', 10.00, 300, 5),
('Eli ve Nino', 9.50, 90, 6);

INSERT INTO Authors(FullName)
VALUES 
('Viktor Huqo'),
('Fyodor Dostoyevski'),
('Sebaheddin Eli');

SELECT * FROM Books
SELECT * FROM Books WHERE Price > 20
SELECT * FROM Books WHERE StockCount > 0
SELECT * FROM Books WHERE Name LIKE '%a%'
SELECT * FROM Books WHERE Price >10 AND Price < 30
SELECT Name,Price FROM Books
SELECT * FROM Books WHERE Price=(SELECT MAX(Price) FROM Books)
CREATE DATABASE UserDB

CREATE TABLE Users (
	Id INT PRIMARY KEY IDENTITY(1,1),
	Name NVARCHAR(50) NOT NULL,
	Email NVARCHAR(255) NOT NULL,
);

CREATE TABLE Movies (
	ID INT PRIMARY KEY IDENTITY(1,1),
	Title NVARCHAR(50) NOT NULL,
	Duration INT NOT NULL,
);

CREATE TABLE Tickets (
	ID INT PRIMARY KEY IDENTITY(1,1),
	UserId INT NOT NULL,
	MovieId INT NOT NULL,
	FOREIGN KEY (UserId) REFERENCES Users(Id),
	FOREIGN KEY (MovieId) REFERENCES Movies(ID),
	SeatNumber NVARCHAR(20) NOT NULL,
	Price DECIMAL(10, 2) NOT NULL
);

INSERT INTO Users (Name, Email) VALUES 
('Omar','omer@gmail.com'),
('Laman','laman@gmail.com'),
('Kanan','kanan@gmail.com'),
('Roshen','roshen@gmail.com'),
('emin','emin@gmail.com');

INSERT INTO Movies (Title, Duration) VALUES
('Inception', 148),
('Interstellar', 169),
('Titanic', 195),
('Avatar', 162),
('Joker', 122);

INSERT INTO Tickets (UserId, MovieId, SeatNumber, Price) VALUES
(1, 1, 'A1', 10.00),
(1, 2, 'A2', 12.00),
(2, 1, 'B1', 10.00),
(2, 3, 'B2', 11.00),
(3, 1, 'C1', 10.00),
(3, 4, 'C2', 13.00),
(4, 2, 'D1', 12.00),
(4, 2, 'D2', 12.00),
(5, 5, 'E1', 9.00),
(5, 1, 'E2', 10.00);

SELECT u.Name, m.Title, t.SeatNumber, t.Price
FROM Tickets t
JOIN Users u ON t.UserId = u.Id
JOIN Movies m ON t.MovieId = m.Id;

SELECT u.Name, m.Title, t.SeatNumber, t.Price
FROM Tickets t
INNER JOIN Users u ON t.UserId = u.Id
INNER JOIN Movies m ON t.MovieId = m.Id;

SELECT u.Name
FROM Users u
LEFT JOIN Tickets t ON u.Id = t.UserId
WHERE t.Id IS NULL;

SELECT TOP 1 u.Name, m.Title, t.SeatNumber, t.Price
From Tickets t
JOIN Users u ON t.UserId = u.Id
Join Movies m ON t.MovieId = m.Id
ORDER BY t.Price DESC;

SELECT 
u.Name AS UserName,
m.Title AS MovieName,
t.Price AS TicketPrice
FROM Tickets t
JOIN Users u ON t.UserId = u.Id
Join Movies m ON t.MovieId = m.Id
WHERE t.Price > 10.00;
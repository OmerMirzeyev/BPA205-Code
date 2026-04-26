CREATE TABLE Students
(
Id int PRIMARY KEY IDENTITY(1,1),
Name nvarchar(100) NOT NULL,
Email nvarchar(100) NOT NULL UNIQUE
)
SELECT * FROM Students
CREATE TABLE Courses
(
Id int PRIMARY KEY IDENTITY(1,1),
Duration int NOT NULL,
Title nvarchar(100) NOT NULL,
)
SELECT * FROM Courses
CREATE TABLE Enrollments
(
Id INT PRIMARY KEY IDENTITY(1,1),
StudentId INT,
CourseId INT,
Progress DECIMAL(5,2) DEFAULT 0,CHECK (Progress >= 0 AND Progress <= 100),  
Price DECIMAL(10,2)  CHECK (Price >= 0),
FOREIGN KEY (StudentId) REFERENCES Students(Id),
FOREIGN KEY (CourseId) REFERENCES Courses(Id)
)
SELECT * FROM Enrollments
INSERT INTO Students (Name, Email) VALUES
('Omar','omer@gmail.com'),
('Laman','laman@gmail.com'),
('Kanan','kanan@gmail.com'),
('Roshen','roshen@gmail.com'),
('Ravan','ravan@gmail.com')

INSERT INTO Courses (Duration, Title) VALUES
(30, 'Code Academy'),
(45, 'Holberton'),
(60, 'Iron Hack'),
(90, 'Matrix'),
(120, 'Div Academy')

INSERT INTO Enrollments (StudentId, CourseId, Progress, Price) VALUES
(1, 1, 100, 100.00),
(2, 1, 50.0, 150.00),
(3, null, null, null),
(4, 4, 10.0, 250.00),
(5, 5, 90.0, 300.00)

SELECT e.StudentId, e.CourseId, e.Progress, e.Price FROM Enrollments e
--Name Title Progress Price cixarir
SELECT s.Name , c.Title, e.Progress, e.Price
FROM Enrollments e
INNER JOIN Students s ON e.StudentId = s.Id
INNER JOIN Courses c ON e.CourseId = c.Id
--Hec kursa yazilmayan telebelerin adlari
SELECT s.Name, c.Title, e.Progress, e.Price 
FROM Enrollments e
JOIN Students s ON e.StudentId = s.Id
LEFT JOIN Courses c ON e.CourseId = c.Id
WHERE e.CourseId is null
--En bahali kursa yazilan telebe ve kursun adi
SELECT  TOP(1) s.Name, c.Title, e.Price
FROM Enrollments e
LEFT JOIN Students s ON e.StudentId = s.Id
LEFT JOIN Courses c ON e.CourseId = c.Id
ORDER BY e.Price DESC
--50% ve daha cox irəliləmiş telebe ve kursun adi
SELECT  s.Name, c.Title, e.Progress 
FROM Enrollments e
JOIN Students s ON e.StudentId = s.Id
JOIN Courses c ON e.CourseId = c.Id
WHERE e.Progress >= 50
ORDER BY e.Progress DESC

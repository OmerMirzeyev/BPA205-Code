CREATE DATABASE CompanyDB
 
CREATE TABLE Employees
(
Id INT PRIMARY KEY IDENTITY(1,1),
FullName NVARCHAR(20),
Salary DECIMAL(10,2)
)
CREATE TABLE Departments 
(
Id INT PRIMARY KEY IDENTITY(1,1),
DepartmentName NVARCHAR(20)
)

ALTER TABLE Employees
ADD DepartmentId INT

INSERT INTO Employees(FullName,Salary,DepartmentId)
VALUES 
('Omer Bayramov', 1000, 1),
('Kenan Murselizade', 250, 2),
('Laman Mirzeyeva', 700, 1),
('Emin Sadiqov', 300, 3),
('Roshen Ibrahimzade', 100, 2),
('Mammad Chiraqzade', 500, 3);

INSERT INTO Departments(DepartmentName)
VALUES 
('KFC'),
('MC'),
('POPOYES');

SELECT * FROM Employees

SELECT * FROM Employees WHERE Salary > 1000

SELECT * FROM Employees WHERE Salary > 500 AND Salary < 2000

SELECT * FROM Employees 
WHERE FullName LIKE '%r%';

SELECT * FROM Departments 
WHERE DepartmentName IS null;


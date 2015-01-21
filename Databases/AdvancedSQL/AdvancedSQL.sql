-- 1.Write a SQL query to find the names and salaries of the employees that take the minimal salary in the company. 
-- Use a nested SELECT statement.
-- Poor guys 
SELECT Firstname + ' ' + Lastname AS [Full Name], Salary
FROM Employees 
WHERE Salary =
(SELECT MIN(Salary) FROM Employees)

-- 2.Write a SQL query to find the names and salaries of the employees that have a salary 
-- that is up to 10% higher than the minimal salary for the company.
SELECT FirstName + ' ' + LastName AS [Full Name], Salary
FROM Employees
WHERE Salary > (SELECT MIN(Salary) FROM Employees) * 1.1

--3.Write a SQL query to find the full name, salary and department of the employees that 
-- take the minimal salary in their department.Use a nested SELECT statement.
SELECT e.FirstName + ' ' + e.LastName AS [Full Name], e.Salary, d.Name  
FROM Employees e 
	JOIN Departments d
		ON e.DepartmentID = d.DepartmentID
WHERE e.Salary = (
	SELECT MIN(m.Salary)
	FROM Employees m
	WHERE m.DepartmentID = d.DepartmentID
)

-- 4.Write a SQL query to find the average salary in the department #1.
SELECT AVG(e.Salary)
FROM Employees e
WHERE e.DepartmentID = 1

-- 5.Write a SQL query to find the average salary  
-- in the "Sales" department.
SELECT AVG(e.Salary)
FROM Employees e
	JOIN Departments d
		ON e.DepartmentID = d.DepartmentID
WHERE d.Name = 'Sales'

-- 6.Write a SQL query to find the number of employees in the "Sales" department.
SELECT COUNT(e.EmployeeID)
FROM Employees e
WHERE e.DepartmentID = (SELECT d.DepartmentID
	FROM Departments d WHERE d.Name = 'Sales')

-- 7.Write a SQL query to find the number of all employees that have manager.
SELECT COUNT(e.EmployeeID)
FROM Employees e
WHERE e.ManagerID is NOT NULL

-- 8.Write a SQL query to find the number of all employees that have no manager.
SELECT COUNT(e.EmployeeID)
FROM Employees e
WHERE e.ManagerID is NULL

-- 9. Write a SQL query to find all departments and the average salary for each of them.
SELECT e.DepartmentID, AVG(e.Salary) AS AverageSalary
FROM Employees e
GROUP BY e.DepartmentID

--10.Write a SQL query to find the count of all employees in each department and for each town
SELECT COUNT(e.EmployeeID) AS CountOfEmployees,
e.DepartmentID, t.Name
FROM Employees e
	JOIN Addresses a
		ON e.AddressID = a.AddressID
	JOIN Towns t
		ON t.TownID = a.TownID
GROUP BY DepartmentID, t.Name

--11.Write a SQL query to find all managers that have exactly 5 employees. Display their first name and last name.
SELECT m.EmployeeID, COUNT(e.EmployeeID) AS NumEmployees,
	   m.FirstName, m.LastName
FROM Employees e
	JOIN Employees m
		ON m.EmployeeID = e.ManagerID
GROUP BY m.EmployeeID, m.FirstName, m.LastName
HAVING COUNT(e.EmployeeID) = 5; 

--12.Write a SQL query to find all employees along with their managers. For employees that do not have manager display the value "(no manager)".
SELECT e.LastName AS Employee, ISNULL(m.LastName, '(no manager)') AS Manager
FROM Employees e
	LEFT OUTER JOIN Employees m
		ON m.EmployeeID = e.ManagerID

--13. Write a SQL query to find the names of all employees whose last name is exactly 5 characters long. Use the built-in LEN(str) function.
SELECT e.LastName, LEN(e.LastName) AS NameLength
FROM Employees e
WHERE LEN(e.LastName) = 5;

--14.Write a SQL query to display the current date and time in the following format "day.month.year hour:minutes:seconds:milliseconds". Search in  
--Google to find how to format dates in SQL Server. This was awful!
SELECT FORMAT(GETDATE(),'dd.MM.yyyy hh:mm:ss:ff');

--15.Write a SQL statement to create a table Users. Users should have username, password, full name and last login time. Choose appropriate data types for 
--the table fields. Define a primary key column with a primary key constraint. Define the primary key column as identity to facilitate inserting records. 
--Define unique constraint to avoid repeating usernames. Define a check constraint to ensure the password is at least 5 characters long.
CREATE TABLE [Users](
	[User_ID] INT IDENTITY(1,1) NOT NULL,
	[Username] VARCHAR(20) NOT NULL,
    [Password] VARCHAR(20) NOT NULL,
    [FullName] VARCHAR(40) NOT NULL,
    [LastLogin] DateTime, 
)
GO 

ALTER TABLE [dbo].[Users] WITH CHECK ADD CONSTRAINT PK_Users PRIMARY KEY(User_ID) 
GO

ALTER TABLE [dbo].[Users] WITH CHECK ADD CONSTRAINT UK_Users_Username UNIQUE(Username) 
GO

ALTER TABLE [dbo].[Users] WITH CHECK ADD CONSTRAINT [Username] CHECK (LEN(Username) >= 3)
GO

ALTER TABLE [dbo].[Users] WITH CHECK ADD CONSTRAINT [PASSWORD] CHECK (LEN(Password) >= 5)
GO

--16.Write a SQL statement to create a view that displays the users from the Users table that have been in the system today. Test if the view works correctly.
CREATE VIEW AllUsersFromToday AS
SELECT *
FROM Users
GO

INSERT Users
VALUES ('Pesho', 'Petrov', 'Goshov', '09.09.2099');
GO
 
SELECT *
FROM AllUsersFromToday
GO
 
--17.Write a SQL statement to create a table Groups. Groups should have unique name 
--(use unique constraint). Define primary key and identity column.

--DROP TABLE [dbo].[Groups]

--ALTER TABLE [dbo].[Users] DROP FK_Users_Groups
--GO
--ALTER TABLE [dbo].[Users] DROP COLUMN Group_ID
--GO

CREATE TABLE Groups
(
	Group_ID INT IDENTITY,
	Name VARCHAR(50) NOT NULL
)
GO

ALTER TABLE [dbo].[Groups] WITH CHECK ADD CONSTRAINT PK_Groups PRIMARY KEY(Group_ID) 
GO

ALTER TABLE [dbo].[Groups] WITH CHECK ADD CONSTRAINT UK_Groups_Name UNIQUE(Name) 
GO

--SELECT g.Group_ID
--FROM Groups g
--GROUP BY g.Group_ID
--HAVING g.Group_ID % 2 = 0 

--18.Write a SQL statement to add a column GroupID to the table Users. 
--Fill some data in this new column and as well in the Groups table. 
--Write a SQL statement to add a foreign key constraint between tables 
--Users and Groups tables.

--ALTER TABLE [dbo].[Users] DROP COLUMN Group_ID
--GO

ALTER TABLE [dbo].[Users] WITH CHECK ADD Group_ID INT
GO

INSERT INTO Groups (Name)
VALUES
	('Telerik Academy'),
    ('Trainee'),
    ('Trainers'),
    ('Developers'),
    ('Support'),
    ('QA')

--DELETE FROM Groups
--WHERE (Group_ID > 0) AND (Group_ID < 100);

UPDATE Users
SET Group_ID = 1
WHERE Group_ID IS NULL

INSERT INTO Users (Username, Password, FullName, LastLogin, Group_ID)
VALUES
		('Kolio','12346','Kolio Kolev','2005-5-5 03:00:15',1),
		('Petio','qwerty','Petio Petkov','2008-7-5 05:00:15',2),
		('Kolio2','Bai Koluo2','Kolio Kolev2','2009-1-1 07:00:15',3),
		('Ianica','kaka123','Ianica Petrova','2013-5-5 12:00:15',4),
		('Ivan','Ivan555','Ivan Ivanov','2009-5-5 13:00:15',5),
		('Valentin','Valeto333','Valentin Vladov','2009-5-5 13:00:15',6)

--DELETE FROM [dbo].[Users]
--WHERE (User_ID > 0) AND (User_ID< 100);

ALTER TABLE [dbo].[Users] WITH CHECK 
ADD CONSTRAINT FK_Users_Groups
FOREIGN KEY(Group_ID)
REFERENCES Groups(Group_ID)

--19. Write SQL statements to insert several records in the Users and Groups tables.

--DELETE FROM Groups
--WHERE (Group_ID > 0) AND (Group_ID < 100);
--GO
--DELETE FROM [dbo].[Users]
--WHERE (User_ID > 0) AND (User_ID< 100);
--GO

INSERT INTO Groups(Name)
VALUES
	('Telerik Academy2'),
	('Some Other Group')
GO

INSERT INTO Users(Username, Password, FullName, LastLogin, Group_ID)
VALUES 
	('Tihomir', 'tishkata', 'Tihomir Kolev', GETDATE(),1),
	('U2D2Mi2', 'shosho', 'Tjeodor Kolev', GETDATE(),1)
GO

--20.Write SQL statements to update some of the records in the 
--Users and Groups tables.

UPDATE [dbo].[Users]
SET Group_ID = (
			SELECT Group_ID
			FROM Groups
			WHERE Name = 'Telerik Academy2')
WHERE username = 'Tihomir' OR username = 'U2D2Mi2'

UPDATE [dbo].[Groups]
SET Name = 'Some Changed Name Group'
WHERE Name = 'Some Other Group'

--21.Write SQL statements to delete some of the records from the Users and Groups tables.
DELETE FROM Users
WHERE Username LIKE ('%%')
GO

DELETE FROM Groups
WHERE Name LIKE ('%%')
GO


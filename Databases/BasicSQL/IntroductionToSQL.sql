--About 1, 2 and 3, well yes I started the Studio.
--When you run them all You'll see a second scroll ;) so you can go through all tasks. 
--Also if you want to run them one by one, you can mark just the query that you want to run and press Execute(alt + x)

--4.Write a SQL query to find all information about all departments (use "TelerikAcademy" database).
SELECT DepartmentID, Name AS DepartmentName, ManagerID 
FROM TelerikAcademy.dbo.Departments 

--5.Write a SQL query to find all department names.
SELECT Name AS DepartmentName 
FROM TelerikAcademy.dbo.Departments 

--6.Write a SQL query to find the salary of each employee.
SELECT e.FirstName + ' ' + e.LastName AS [Full Name], Salary
FROM TelerikAcademy.dbo.Employees e

--7.Write a SQL to find the full name of each employee.
SELECT e.FirstName + ' ' + e.LastName AS [Full Name]
FROM TelerikAcademy.dbo.Employees e

--8.Write a SQL query to find the email addresses of each employee (by his first and last name). 
--Consider that the mail domain is telerik.com. Emails should look like “John.Doe@telerik.com". 
--The produced column should be named "Full Email Addresses".
SELECT  e.FirstName + ' ' + e.LastName AS [Full Name],
		e.FirstName + '.' + e.LastName + '@telerik.com' AS [Full Email Addresses]
FROM TelerikAcademy.dbo.Employees e

--9.Write a SQL query to find all different employee salaries.
SELECT  DISTINCT  e.Salary
FROM TelerikAcademy.dbo.Employees e 

--10.Write a SQL query to find all information about the employees whose job title is “Sales Representative“.
SELECT e.FirstName + ' ' + e.LastName AS [Full Name], e.JobTitle  
FROM TelerikAcademy.dbo.Employees e
WHERE e.JobTitle = 'Sales Representative'

--11.Write a SQL query to find the names of all employees whose first name starts with "SA".
SELECT e.FirstName + ' ' + e.LastName AS [Full Name]  
FROM TelerikAcademy.dbo.Employees e
WHERE e.FirstName LIKE 'SA%'

--12.Write a SQL query to find the names of all employees whose last name contains "ei".
SELECT e.FirstName + ' ' + e.LastName AS [Full Name]  
FROM TelerikAcademy.dbo.Employees e
WHERE e.LastName LIKE '%ei%'

--13.Write a SQL query to find the salary of all employees whose salary is in the range [20000…30000].
SELECT e.FirstName + ' ' + e.LastName AS [Full Name], e.Salary AS [Range 20000-30000]  
FROM TelerikAcademy.dbo.Employees e 
WHERE e.Salary BETWEEN 20000 AND 30000 
ORDER BY e.Salary

--14.Write a SQL query to find the names of all employees whose salary is 25000, 14000, 12500 or 23600.
SELECT e.FirstName + ' ' + e.LastName AS [Full Name], e.Salary
FROM TelerikAcademy.dbo.Employees e 
	WHERE e.Salary IN (12500, 14000, 23600, 25000)
ORDER BY e.Salary

--15.Write a SQL query to find all employees that do not have manager.
SELECT e.FirstName + ' ' + e.LastName AS [Full Name]
FROM TelerikAcademy.dbo.Employees e 
WHERE e.ManagerID IS NULL

--16.Write a SQL query to find all employees that have salary more than 50000.
--Order them in decreasing order by salary.
SELECT e.FirstName + ' ' + e.LastName AS [Full Name], e.Salary
FROM TelerikAcademy.dbo.Employees e 
WHERE e.Salary >= 50000
ORDER BY e.Salary DESC 

--17.Write a SQL query to find the top 5 best paid employees.
SELECT TOP 5 e.FirstName + ' ' + e.LastName AS [Full Name], e.Salary
FROM TelerikAcademy.dbo.Employees e 
ORDER BY e.Salary DESC -- If you know something like bottom 5, please do share. Thanks 

--18.Write a SQL query to find all employees along with their address. Use inner join with ON clause.
SELECT e.FirstName + ' ' + e.LastName AS [Full Name], a.AddressText
FROM TelerikAcademy.dbo.Employees e 
INNER JOIN TelerikAcademy.dbo.Addresses a
	on e.AddressID = a.AddressID

--19.Write a SQL query to find all employees and their address. Use equijoins (conditions in the WHERE clause).
SELECT e.FirstName + ' ' + e.LastName AS [Full Name], a.AddressText
FROM TelerikAcademy.dbo.Employees e, TelerikAcademy.dbo.Addresses a
WHERE e.AddressID = a.AddressID

--20.Write a SQL query to find all employees along with their manager.
SELECT  m.FirstName + ' ' + m.LastName AS [Manager Name], e.FirstName + ' ' + e.LastName AS [Employ Name] 
FROM TelerikAcademy.dbo.Employees e 
INNER JOIN TelerikAcademy.dbo.Employees m
	on e.ManagerID = m.EmployeeID

--21.Write a SQL query to find all employees, along with their manager and their address.
--Join the 3 tables: Employees e, Employees m and Addresses a.
SELECT e.FirstName + ' ' + e.LastName AS [Employe Name],
	   m.FirstName + ' ' + m.LastName AS [Manager Name], 
	   a.AddressText AS [Employe Address] -- Here I wasn't sure which Address should be shown
FROM TelerikAcademy.dbo.Employees e 
INNER JOIN TelerikAcademy.dbo.Employees m
	ON e.ManagerID = m.EmployeeID
INNER JOIN TelerikAcademy.dbo.Addresses a 
	ON e.AddressID = a.AddressID

--22.Write a SQL query to find all departments and all town names as a single list. Use UNION.
SELECT 'Department: ' + d.Name AS [The Name]
FROM dbo.Departments d
UNION
SELECT 'Town: ' + t.Name
FROM TelerikAcademy.dbo.Towns t

--23.Write a SQL query to find all the employees and the manager for each of them along with the
--employees that do not have manager. Use right outer join. Rewrite the query to use left outer join.
SELECT e.FirstName, e.LastName, m.LastName AS 'Manager'
FROM TelerikAcademy.dbo.Employees AS m
	RIGHT JOIN dbo.Employees AS e
		ON e.ManagerID = m.EmployeeID

SELECT e.FirstName, e.LastName, m.LastName as 'Manager'
FROM TelerikAcademy.dbo.Employees AS e
	LEFT JOIN dbo.Employees AS m
		ON e.ManagerID = m.EmployeeID

--24.Write a SQL query to find the names of all employees from the departments "Sales" and "Finance" whose hire year is between 1995 and 2005.
SELECT e.FirstName + ' ' + e.LastName AS [Employe Name], e.HireDate, e.Salary, d.Name AS [Depatment Name]
FROM TelerikAcademy.dbo.Employees AS e
	INNER JOIN TelerikAcademy.dbo.Departments AS d
		ON e.DepartmentID = d.DepartmentID
WHERE (d.Name = 'Sales' OR d.Name='Finance') AND (e.HireDate <= '2005-12-31' AND e.HireDate >= '1995-01-01')
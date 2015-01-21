--1. Create a database with two tables:
--Persons(Id(PK), FirstName, LastName, SSN) and Accounts(Id(PK), PersonId(FK), Balance).
--Insert few records for testing. Write a stored procedure that selects the full names of all persons.
CREATE DATABASE Customers
GO
 
USE Customers
 
CREATE TABLE Persons
(
        PersonId INT IDENTITY,
                CONSTRAINT PK_Persons PRIMARY KEY(PersonId),
        FirstName VARCHAR(30),
        LastName VARCHAR(30),
        SSN VARCHAR(10),
)
 
CREATE TABLE Accounts
(
        AccountId INT IDENTITY,
                CONSTRAINT PK_Accounts PRIMARY KEY(AccountId),
        Balance MONEY NOT NULL,
        PersonId INT NOT NULL,
                CONSTRAINT FK_Accounts_Persons FOREIGN KEY (PersonId)
                        REFERENCES Persons(PersonId)
)
 
INSERT INTO Persons (FirstName, LastName, SSN)
VALUES
        ('Svetlin', 'Nakov', '1234123456'),
        ('Doncho', 'Minkov', '5511235796'),
        ('Nikolay', 'Kostov', '2984179551'),
        ('George', 'Georgiev', '9180041249')
 
INSERT INTO Accounts (Balance, PersonId)
VALUES
        (30000, 1),
        (60000, 1),
        (50000, 2),
        (77000.99, 3)
 
CREATE PROCEDURE usp_SelectPersonsFullName AS
SELECT FirstName + ' ' + LastName AS [Full Name]
FROM Persons
GO
 
EXEC usp_SelectPersonsFullName
 
--2. Create a stored procedure that accepts a number as a parameter and returns
--all persons who have more money in their accounts than the supplied number.
GO
 
CREATE PROCEDURE usp_PersonsWithMoreMoneyThan @minBalance MONEY
AS
        SELECT FirstName + ' ' + LastName AS [Full Name], SUM(Balance) AS [Money]
        FROM Persons p JOIN Accounts a ON p.PersonId = a.PersonId
        GROUP BY p.PersonId,  FirstName + ' ' + LastName
        HAVING SUM(Balance) > @minBAlance
GO
 
EXEC usp_PersonsWithMoreMoneyThan 50000
 
--3. Create a function that accepts as parameters – sum, yearly interest rate and number of months.
--It should calculate and return the new sum. Write a SELECT to test whether the function works as expected.
CREATE FUNCTION usf_CalcInterestRate (@sum FLOAT, @interestRate float, @numberOfMonths INT)
RETURNS FLOAT
AS
BEGIN
        DECLARE @newSum FLOAT
        SET @newSum = @sum + @sum * @interestRate * @numberOfMonths
        RETURN @newSum
END
 
SELECT dbo.usf_CalcInterestRate(150, 0.1, 5)
 
--4. Create a stored procedure that uses the function from the previous example
--to give an interest to a person's account for one month.
--It should take the AccountId and the interest rate as parameters.
GO
CREATE PROCEDURE usf_AccountInterestRateForOneMonth
        @accountId INT, @interestRate FLOAT
AS
        DECLARE @accountMoney MONEY = (
                SELECT Balance
                FROM Accounts
                WHERE AccountId = @accountId)
 
        SELECT dbo.usf_CalcInterestRate(@accountMoney, @interestRate, 1)
GO
 
EXEC usf_AccountInterestRateForOneMonth 1, 0.5
 
--5. Add two more stored procedures WithdrawMoney( AccountId, money) and
--DepositMoney (AccountId, money) that operate in transactions.
GO
 
--WithdrawMoney( AccountId, money)
CREATE PROCEDURE usp_WithdrawMoney
        @accountId INT, @moneyToDraw MONEY
AS
        BEGIN TRANSACTION
        DECLARE @availableMoney MONEY =
                (Select Balance
                From Accounts
                WHERE AccountId = @accountId)
 
        IF (@availableMoney >= @moneyToDraw)
        BEGIN
                UPDATE Accounts
                SET Balance = Balance - @moneyToDraw
                WHERE AccountId = @accountId
                COMMIT
        END
        ELSE
        BEGIN
                RAISERROR ('Not enough money in account.', 16, 1)
                ROLLBACK TRAN
        END
GO
 
EXEC usp_WithdrawMoney 1, 20000
 
--DepositMoney (AccountId, money)
GO
 
CREATE PROCEDURE usp_DepositMoney
        @accountId INT, @moneyToDeposit MONEY
AS
        BEGIN TRANSACTION
        IF (@moneyToDeposit >= 0)
        BEGIN
                UPDATE Accounts
                SET Balance = Balance + @moneyToDeposit
                WHERE AccountId = @accountId
                COMMIT
        END
        ELSE
        BEGIN
                RAISERROR('Deposit money cannott be negative.', 16, 1)
                ROLLBACK TRAN
        END
GO
 
EXEC usp_DepositMoney 1, 20000
 
--6.Create another table – Logs(LogID, AccountID, OldSum, NewSum).
--Add a trigger to the Accounts table that enters a new entry into
--the Logs table every time the sum on an account changes.
CREATE TABLE Logs
(
        LogId INT IDENTITY,
                CONSTRAINT PK_Logs PRIMARY KEY(LogId),
        OldSum MONEY,
        NewSum MONEY,
        AccountId INT,
                CONSTRAINT FK_Logs_Accounts FOREIGN KEY(AccountId)
                        REFERENCES Accounts(AccountId)
)
 
GO
 
CREATE TRIGGER tr_AccountUpdate ON Accounts FOR UPDATE
AS
        DECLARE deletedCursor CURSOR READ_ONLY FOR
                SELECT Balance, AccountId FROM deleted
        DECLARE insertedCursor CURSOR READ_ONLY FOR
                SELECT Balance FROM inserted
 
        OPEN deletedCursor
        OPEN insertedCursor
 
        DECLARE @oldSum MONEY, @accountId INT
        FETCH NEXT FROM deletedCursor INTO @oldSum, @accountId
 
        DECLARE @newSum MONEY
        FETCH NEXT FROM insertedCursor INTO @newSum
 
        WHILE @@FETCH_STATUS = 0
        BEGIN
                INSERT INTO Logs (OldSum, NewSum, AccountId)
                VALUES (@oldSum, @newSum, @accountId)
                FETCH NEXT FROM deletedCursor INTO @oldSum, @accountId
                FETCH NEXT FROM insertedCursor INTO @newSum
        END
 
        CLOSE deletedCursor
        DEALLOCATE deletedCursor
        CLOSE insertedCursor
        DEALLOCATE insertedCursor
GO
 
UPDATE Accounts
SET Balance = Balance + Balance * 0.1
WHERE AccountId = 1 OR AccountId = 2
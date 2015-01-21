CREATE TABLE [dbo].[DateLogs](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Text] [nvarchar](50) NOT NULL,
	[LogDate] [date] NOT NULL
) ON [PRIMARY]

GO

CREATE PROCEDURE [dbo].[uspAddLogs](@count int = 10000, @text nvarchar(50) = 'SeedText')
AS
DECLARE @index int = 0;
WHILE (@index < @count)
	BEGIN
		INSERT INTO [dbo].[DateLogs] ([LogDate], [Text])
		VALUES (DATEADD(day, @index, getdate()), @text + CAST(@index AS nvarchar))
		SET @index += 1
	END
GO

EXECUTE [dbo].[uspAddLogs] 10000000 , N'Testis'

--This clears the cache
CHECKPOINT; DBCC DROPCLEANBUFFERS;
 
-- 1.Create a table in SQL Server with 10 000 000 log entries (date + text). Search in the table by date range. Check the speed (without caching).
SELECT * FROM DateLogs as dt
WHERE YEAR(dt.LogDate) > 2002 AND YEAR(dt.LogDate) < 2015

-- 2.Add an index to speed-up the search by date. Test the search speed (after cleaning the cache).
--creates index
CREATE INDEX IDX_Logs_LogDate ON DateLogs(LogDate)

CHECKPOINT; DBCC DROPCLEANBUFFERS;

SELECT * FROM DateLogs as dt
WHERE YEAR(dt.LogDate) > 2002 AND YEAR(dt.LogDate) < 2015

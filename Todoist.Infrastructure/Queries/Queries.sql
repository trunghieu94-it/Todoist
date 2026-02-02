-- Queries Tasks Table
SELECT Id, WorkId, TaskName, [Status] FROM Tasks
SELECT Id, WorkId, TaskName, [Status] FROM Tasks WHERE Id = @Id
DBCC CHECKIDENT ('dbo.Tasks', RESEED, 5);

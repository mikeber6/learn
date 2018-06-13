/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/


IF NOT EXISTS (SELECT * FROM dbo.Status WHERE Name = 'Not Started')
	INSERT INTO dbo.Status(Name, Ordinal) VALUES ('Not Started',0);

IF NOT EXISTS (SELECT * FROM dbo.Status WHERE Name = 'In Progress')
	INSERT INTO dbo.Status(Name, Ordinal) VALUES ('In Progress',1);

IF NOT EXISTS (SELECT * FROM dbo.Status WHERE Name = 'Completed')
	INSERT INTO dbo.Status(Name, Ordinal) VALUES ('Completed',2);
DECLARE @statusId INT,
	@taskId INT,
	@userId INT

IF NOT EXISTS (SELECT * FROM [User] WHERE Username = 'bhogg')
	INSERT INTO [dbo].[User]([Firstname], [Lastname], [Username])
		VALUES (N'Boss', N'Hogg', N'bhogg')

IF NOT EXISTS (SELECT * FROM [User] WHERE Username = 'jbob')
	INSERT INTO [dbo].[User]([Firstname], [Lastname], [Username])
		VALUES (N'Jim', N'Bob', N'jbob')
		
IF NOT EXISTS (SELECT * FROM [User] WHERE Username = 'jdoe')
	INSERT INTO [dbo].[User]([Firstname], [Lastname], [Username])
		VALUES (N'John', N'Doe', N'jdoe')

IF NOT EXISTS (SELECT * FROM dbo.Task WHERE Subject = 'Test Task')
BEGIN
	SELECT TOP 1 @statusId = StatusId FROM Status ORDER BY StatusId;
	SELECT TOP 1 @userId = UserId FROM [User] ORDER BY UserId;

	INSERT INTO dbo.Task(Subject, StartDate, StatusId, CreatedDate, CreatedUserId)
		VALUES ('Test Task', GETDATE(), @statusId, GETDATE(), @userId);

	SET @taskId = SCOPE_IDENTITY();

	INSERT [dbo].[TaskUser] ([TaskId], [UserId])
		VALUES (@taskId, @userId)

END

GO

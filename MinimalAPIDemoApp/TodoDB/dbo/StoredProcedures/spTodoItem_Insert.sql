CREATE PROCEDURE [dbo].[spTodoItem_Insert]
	@Title nvarchar(50),
	@IsDone bit
AS
	INSERT INTO dbo.[TodoItem] (Title, IsDone)
	VALUES (@Title, @IsDone);
RETURN 0

CREATE PROCEDURE [dbo].[spTodoItem_Update]
	@Id int,
	@Title nvarchar(50),
	@IsDone bit
AS
	UPDATE dbo.[TodoItem] 
	SET Title = @Title, IsDone = @IsDone
	WHERE Id = @Id;
RETURN 0

CREATE PROCEDURE [dbo].[spTodoItem_Delete]
	@Id int
AS
	DELETE 
	FROM dbo.[TodoItem]
	WHERE Id = @Id;
RETURN 0

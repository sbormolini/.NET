CREATE PROCEDURE [dbo].[spTodoItem_Get]
	@Id int
AS
	SELECT * 
	FROM dbo.[TodoItem]
	WHERE Id = @Id;
RETURN 0

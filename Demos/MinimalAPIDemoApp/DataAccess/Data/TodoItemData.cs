using DataAccess.DbAccess;
using DataAccess.Models;

namespace DataAccess.Data;

public class TodoItemData : ITodoItemData
{
    private readonly ISqlDataAccess _database;

    public TodoItemData(ISqlDataAccess database) => _database = database;

    public Task<IEnumerable<TodoItemModel>> GetTodoItems() =>
        _database.LoadData<TodoItemModel, dynamic>("dbo.spTodoItem_GetAll", new { });

    public async Task<TodoItemModel?> GetTodoItem(int id)
    {
        var results = await _database.LoadData<TodoItemModel, dynamic>("dbo.spTodoItem_Get", new { Id = id });
        return results.FirstOrDefault();
    }

    public Task InsertTodoItem(TodoItemModel todoItem) =>
        _database.SaveData("dbo.spTodoItem_Insert", new { todoItem.Title, todoItem.IsDone });

    public Task UpdateTodoItem(TodoItemModel todoItem) =>
         _database.SaveData("dbo.spTodoItem_Update", todoItem);

    public Task DeleteTodoItem(int id) =>
        _database.SaveData("dbo.spTodoItem_Delete", new { Id = id });
}

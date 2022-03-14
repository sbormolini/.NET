using DataAccess.Models;

namespace DataAccess.Data;

public interface ITodoItemData
{
    Task DeleteTodoItem(int id);
    Task<TodoItemModel?> GetTodoItem(int id);
    Task<IEnumerable<TodoItemModel>> GetTodoItems();
    Task InsertTodoItem(TodoItemModel todoItem);
    Task UpdateTodoItem(TodoItemModel todoItem);
}
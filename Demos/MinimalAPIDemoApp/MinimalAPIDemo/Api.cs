using DataAccess.Data;
using DataAccess.Models;

namespace MinimalAPIDemo;

public static class Api
{
    public static void ConfigureApi(this WebApplication app)
    {
        // All API endpoint mapping
        app.MapGet("/ToDo", GetTodoItems);
        app.MapGet("/ToDo/{id}", GetTodoItem);
        app.MapPost("/Todo", InsertTodoItem);
        app.MapPut("/Todo", UpdateTodoItem);
        app.MapDelete("/Todo", DeleteTodoItem);
    }

    private static async Task<IResult> GetTodoItems(ITodoItemData data)
    {
        try
        {
            return Results.Ok(await data.GetTodoItems());
        }
        catch (Exception ex)
        {
            // add logger?
            return Results.Problem(ex.Message);
        }
    }

    private static async Task<IResult> GetTodoItem(int id, ITodoItemData data)
    {
        try
        {
            var results = await data.GetTodoItem(id);

            if (results == null) 
                return Results.NotFound();
            
            return Results.Ok(await data.GetTodoItems());
        }
        catch (Exception ex)
        {
            // add logger?
            return Results.Problem(ex.Message);
        }
    }

    private static async Task<IResult> InsertTodoItem(TodoItemModel todoItem, ITodoItemData data)
    {
        try
        {
            await data.InsertTodoItem(todoItem);
            return Results.Ok();
        }
        catch (Exception ex)
        {
            // add logger?
            return Results.Problem(ex.Message);
        }
    }

    private static async Task<IResult>UpdateTodoItem(TodoItemModel todoItem, ITodoItemData data)
    {
        try
        {
            await data.UpdateTodoItem(todoItem);
            return Results.Ok();
        }
        catch (Exception ex)
        {
            // add logger?
            return Results.Problem(ex.Message);
        }
    }

    private static async Task<IResult> DeleteTodoItem(int id, ITodoItemData data)
    {
        try
        {
            await data.DeleteTodoItem(id);
            return Results.Ok();
        }
        catch (Exception ex)
        {
            // add logger?
            return Results.Problem(ex.Message);
        }
    }
}

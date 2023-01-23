using System.Collections.Generic;

using CraftLR.Exercice7.Models;

namespace CraftLR.Exercice7.Services;

public class TodoService
{
    public IEnumerable<TodoItem> GetItems() => new[]
    {
        new TodoItem { Description = "Walk the dog" },
        new TodoItem { Description = "Buy some milk" },
        new TodoItem { Description = "Learn Avalonia", IsChecked = true },
    };
}
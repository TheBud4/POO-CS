
using Avalonia.Controls;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrabalhoAvalonia.Model;
public class ToDoManager {
    private List<ToDoItem> _toDoItem;

    public ToDoManager() {
        _toDoItem = new();
    }

    public void AddTodoItem(ToDoItem todoItem) {
        _toDoItem.Add(todoItem);
    }

    public void RemoveTodoItem(ToDoItem todoItem) {
        _toDoItem.Remove(todoItem);
    }

    public List<ToDoItem> GetAllTodoItems() {
        return _toDoItem.ToList();

    }
    //public Task<IEnumerable<ToDoItem>> SearchAsync(string searchTerm) {
    //    var result = _toDoItem.Where(todo => todo.Title.Contains(searchTerm)).ToList();
    //    return Task.FromResult<IEnumerable<ToDoItem>>(result);
    //}

}

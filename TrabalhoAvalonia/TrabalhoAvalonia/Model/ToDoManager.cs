
using Avalonia.Controls;
using System.Collections.Generic;
using System.Linq;

namespace TrabalhoAvalonia.Model;
public class ToDoManager {
    private List<ToDoItem> _toDoItem;

    public ToDoManager() {
        _toDoItem = new List<ToDoItem>();
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

}

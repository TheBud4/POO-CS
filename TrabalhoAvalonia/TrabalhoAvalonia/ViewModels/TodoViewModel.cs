
using TrabalhoAvalonia.Model;
using TrabalhoAvalonia.Views;

namespace TrabalhoAvalonia.ViewModels;
public class TodoViewModel : TodoView {
    private readonly ToDoItem _todo;
    public TodoViewModel(ToDoItem todo) {
        _todo = todo;
    }

    public string Title => _todo.Title;

    public string Description => _todo.Description;
}

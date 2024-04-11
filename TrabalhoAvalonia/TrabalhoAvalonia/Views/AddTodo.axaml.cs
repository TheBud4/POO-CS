using Avalonia.Controls;
using TrabalhoAvalonia.Model;
using Avalonia.Interactivity;
using System.Diagnostics;

namespace TrabalhoAvalonia.Views;
public partial class AddTodo : Window {

    public ToDoManager manager = new();
    public AddTodo() {
        InitializeComponent();
    }
    public void CloseDialog() {
        Close();
    }
    public void SaveTodo(object? sender, RoutedEventArgs e) {

        var title = Name.Text;
        var description = Description.Text;

        var todo = new ToDoItem {
            Title = title,
            Description = description,
        };
        manager.AddTodoItem(todo);
        Debug.WriteLine("Todo adicionado", todo);
        CloseDialog();

    }

}

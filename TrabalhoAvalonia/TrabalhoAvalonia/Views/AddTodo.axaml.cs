using Avalonia.Controls;
using TrabalhoAvalonia.Model;
using Avalonia.Interactivity;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

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

        var todo = new ToDoItem(title, description);
        manager.AddTodoItem(todo);
        CloseDialog();

    }


}

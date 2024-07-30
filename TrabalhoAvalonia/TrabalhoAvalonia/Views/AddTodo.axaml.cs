using Avalonia.Controls;
using TrabalhoAvalonia.Model;
using Avalonia.Interactivity;
using System.Diagnostics;

namespace TrabalhoAvalonia.Views;
public partial class AddTodo : Window {

    public ToDoManager manager = new();
    public AddTodo() {
        Debug.WriteLine("Mensagem de depuração");
        InitializeComponent();
    }
    public void CloseDialog() {
        Close();
    }

    public void SaveTodo(object? sender, RoutedEventArgs e) {

        var title = Name.Text;
        var description = Description.Text;

        ToDoItem todo = new(title, description);
        manager.AddTodoItem(todo);

        Debug.WriteLine("Mensagem de depuração", todo);
        CloseDialog();

    }


}

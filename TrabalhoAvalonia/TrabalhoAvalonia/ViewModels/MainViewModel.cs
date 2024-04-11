using ReactiveUI;
using System.Collections.ObjectModel;
using System.Reactive.Linq;
using System.Windows.Input;
using TrabalhoAvalonia.Model;

namespace TrabalhoAvalonia.ViewModels;

public class MainViewModel : ViewModelBase {

    public MainViewModel() {

        ShowDialog = new Interaction<AddTodoViewModel, TodoViewModel>();

        AddTodo = ReactiveCommand.Create(async () => {
            var todo = new AddTodoViewModel();
            var result = await ShowDialog.Handle(todo);
        });

        GetTodos.Add(new TodoViewModel());
        GetTodos.Add(new TodoViewModel());
        GetTodos.Add(new TodoViewModel());
        GetTodos.Add(new TodoViewModel());
        GetTodos.Add(new TodoViewModel());
        GetTodos.Add(new TodoViewModel());
        GetTodos.Add(new TodoViewModel());
        GetTodos.Add(new TodoViewModel());
        GetTodos.Add(new TodoViewModel());
        GetTodos.Add(new TodoViewModel());
        GetTodos.Add(new TodoViewModel());
        GetTodos.Add(new TodoViewModel());
        GetTodos.Add(new TodoViewModel());
        GetTodos.Add(new TodoViewModel());
        GetTodos.Add(new TodoViewModel());
        GetTodos.Add(new TodoViewModel());
        GetTodos.Add(new TodoViewModel());

    }
    public ICommand AddTodo { get; }
    public Interaction<AddTodoViewModel, TodoViewModel> ShowDialog { get; }

    // Search Todo 
    private string? _searchText;
    private bool _isBusy;
    private TodoViewModel? _selectedTodo;

    public string? SearchText {
        get => _searchText;
        set => this.RaiseAndSetIfChanged(ref _searchText, value);
    }

    public bool IsBusy {
        get => _isBusy;
        set => this.RaiseAndSetIfChanged(ref _isBusy, value);
    }

    public ObservableCollection<TodoViewModel> GetTodos { get; } = new();

    public TodoViewModel? SelectedTodo {
        get => _selectedTodo;
        set => this.RaiseAndSetIfChanged(ref _selectedTodo, value);
    }


}

using ReactiveUI;
using System.Diagnostics;
using System.Reactive.Linq;
using System.Windows.Input;


namespace TrabalhoAvalonia.ViewModels;

public class MainViewModel : ViewModelBase {

    public MainViewModel() {
        Debug.WriteLine("Mensagem de depuração");

        ShowDialog = new Interaction<AddTodoViewModel, TodoViewModel>();

        AddTodo = ReactiveCommand.Create(async () => {
            var todo = new AddTodoViewModel();
            var result = await ShowDialog.Handle(todo);
        });

        //this.WhenAnyValue(x => x.SearchText)
        //        .Throttle(TimeSpan.FromMilliseconds(400))
        //        .ObserveOn(RxApp.MainThreadScheduler)
        //        .Subscribe(DoSearch!);

    }
    public ICommand AddTodo { get; }
    public Interaction<AddTodoViewModel, TodoViewModel> ShowDialog { get; }
    //// Search Todo 
    //private string? _searchText;
    //private bool _isBusy;
    //private TodoViewModel? _selectedTodo;

    //public string? SearchText {
    //    get => _searchText;
    //    set => this.RaiseAndSetIfChanged(ref _searchText, value);
    //}

    //public bool IsBusy {
    //    get => _isBusy;
    //    set => this.RaiseAndSetIfChanged(ref _isBusy, value);
    //}

    //public ObservableCollection<TodoViewModel> GetTodos { get; } = new ObservableCollection<TodoViewModel>();


    //public TodoViewModel? SelectedTodo {
    //    get => _selectedTodo;
    //    set => this.RaiseAndSetIfChanged(ref _selectedTodo, value);
    //}
    //public ToDoManager manager = new();

    //private async void DoSearch(string? s) {
    //    IsBusy = true;
    //    GetTodos.Clear();
    //    if (!string.IsNullOrWhiteSpace(s)) {
    //        var todos = await manager.SearchAsync(s);

    //        foreach (var todo in todos) {
    //            var vm = new TodoViewModel(todo);
    //            GetTodos.Add(vm);
    //        }
    //    }

    //    IsBusy = false;
    //}

}

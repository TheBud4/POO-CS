using Avalonia;
using Avalonia.Controls;
using Avalonia.ReactiveUI;
using ReactiveUI;
using System;
using System.Reactive.Disposables;
using System.Threading.Tasks;
using TrabalhoAvalonia.ViewModels;

namespace TrabalhoAvalonia.Views;

public partial class MainWindow : ReactiveWindow<MainViewModel> {

    public MainWindow() {
        InitializeComponent();

        this.WhenActivated(action =>
         action(ViewModel!.ShowDialog.RegisterHandler(DoShowDialogAsync)));
    }

    private async Task DoShowDialogAsync(InteractionContext<AddTodoViewModel, TodoViewModel> interaction) {

        var dialog = new AddTodo();
        dialog.DataContext = interaction.Input;

        var result = await dialog.ShowDialog<TodoViewModel?>(this);
        interaction.SetOutput(result);
    }


}

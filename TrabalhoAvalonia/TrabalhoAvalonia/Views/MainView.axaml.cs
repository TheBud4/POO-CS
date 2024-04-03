using Avalonia.Controls;
using Avalonia.Interactivity;
using System.Diagnostics;
using System.Diagnostics.Metrics;


namespace TrabalhoAvalonia.Views;

public partial class MainView : UserControl {

    private TextBlock counterText;
    private int counter = 0;
    public MainView(){
        counterText = this.FindControl<TextBlock>("displayText");
        InitializeComponent();
    }

    public void Button_Click(object? sender, RoutedEventArgs e) {
       
        counter++;
        counterText.Text =counter.ToString();
    }
    
}

using Avalonia.Controls;
using AvaloniaSystem1002.Pages;
using static AvaloniaSystem1002.Classes.Helper;

namespace AvaloniaSystem1002.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        MainMainFrame = MainFrame;
        MainFrame.Content = new StartPage();
        ExitBtn.Click += ExitBtn_Click;
    }

    private void ExitBtn_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        MainMainFrame.Content = new StartPage();
    }
}

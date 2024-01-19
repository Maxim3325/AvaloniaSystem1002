using Avalonia.Controls;
using static AvaloniaSystem1002.Classes.Helper;

namespace AvaloniaSystem1002.Pages
{
    public partial class StartPage : UserControl
    {
        public StartPage()
        {
            InitializeComponent();

            CurseBtn.Click += CurseBtn_Click;
            DatabaseBtn.Click += DatabaseBtn_Click;
            AutchBtn.Click += AutchBtn_Click;
        }

        private void AutchBtn_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            MainMainFrame.Content = new AutchPages();
        }

        private void DatabaseBtn_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            MainMainFrame.Content = new DataBasePage();
        }

        private void CurseBtn_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            MainMainFrame.Content = new AccecessibleCourses();
        }
    }
}

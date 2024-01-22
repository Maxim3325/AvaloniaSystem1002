using Avalonia.Controls;
using static AvaloniaSystem1002.Classes.Helper;

namespace AvaloniaSystem1002.Pages
{
    public partial class AccecessibleTeacher : UserControl
    {
        public AccecessibleTeacher()
        {
            InitializeComponent();
            AdminExit.Click += AdminExit_Click;
        }

        private void AdminExit_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            MainMainFrame.Content = new AdminPage();
        }

        private void LoadData()
        {
            
        }
    }
}

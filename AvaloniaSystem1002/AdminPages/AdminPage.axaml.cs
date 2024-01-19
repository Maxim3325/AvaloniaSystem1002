using Avalonia.Controls;
using static AvaloniaSystem1002.Classes.Helper;

namespace AvaloniaSystem1002.Pages
{
    public partial class AdminPage : UserControl
    {
        public AdminPage()
        {
            InitializeComponent();
            CoursCategoryBtn.Click += CoursCategoryBtn_Click;
            TeacherBtn.Click += TeacherBtn_Click;
            CoursBtn.Click += CoursBtn_Click;
        }

        private void CoursBtn_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            MainMainFrame.Content = new ListCourses();
        }

        private void TeacherBtn_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            MainMainFrame.Content = new AccecessibleTeacher();
        }

        private void CoursCategoryBtn_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            MainMainFrame.Content = new listCategoryCourses();
        }
    }
}

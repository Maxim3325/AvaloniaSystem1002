using Avalonia.Controls;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using static AvaloniaSystem1002.Classes.Helper;

namespace AvaloniaSystem1002.Pages
{
    public partial class ListCourses : UserControl
    {
        public ListCourses()
        {
            InitializeComponent();
            AdminExit.Click += AdminExit_Click;
            LoadData();
        }

        private void AdminExit_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            MainMainFrame.Content = new AdminPage();
        }

        private void LoadData()
        {
            context.Courses.Load();

            var ListCourses = context.Courses.ToList();

            CoursesDG.ItemsSource = ListCourses;
        }
    }
}

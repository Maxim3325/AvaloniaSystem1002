using Avalonia.Controls;
using AvaloniaSystem1002.AdminPages;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using static AvaloniaSystem1002.Classes.Helper;

namespace AvaloniaSystem1002.Pages
{
    public partial class listCategoryCourses : UserControl
    {
        public listCategoryCourses()
        {
            InitializeComponent();
            AdminExit.Click += AdminExit_Click;
            AddBtn.Click += AddBtn_Click;
            EditBtn.Click += EditBtn_Click;
            DeleteBtn.Click += DeleteBtn_Click;
            LoadData();
        }

        private void DeleteBtn_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {

        }

        private void EditBtn_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            
        }

        private void AddBtn_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            MainMainFrame.Content = new EditCategoryCourses();
        }

        private void AdminExit_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            MainMainFrame.Content = new AdminPage();
        }

        private void LoadData()
        {
            context.Categories.Load();

            var ListCategoryes = context.Categories.ToList();

            CoursesCategoryDG.ItemsSource = ListCategoryes;
        }
    }
}

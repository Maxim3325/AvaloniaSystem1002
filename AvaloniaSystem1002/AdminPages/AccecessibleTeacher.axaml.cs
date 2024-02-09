using Avalonia.Controls;
using AvaloniaSystem1002.AdminPages;
using AvaloniaSystem1002.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using static AvaloniaSystem1002.Classes.Helper;

namespace AvaloniaSystem1002.Pages
{
    public partial class AccecessibleTeacher : UserControl
    {
        public AccecessibleTeacher()
        {
            InitializeComponent();
            AdminExit.Click += AdminExit_Click;
            DeleteBtn.Click += DeleteBtn_Click;
            AddBtn.Click += AddBtn_Click;
            EditBtn.Click += EditBtn_Click;
            LoadData();
        }

        private void EditBtn_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            var selectedTeacher = TeacherDG.SelectedItem as User;
            if (selectedTeacher != null)
            {
                MainMainFrame.Content = new EditTeacher(selectedTeacher.Id);
            }
        }

        private void AddBtn_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            MainMainFrame.Content = new EditTeacher(-1);
        }

        private void DeleteBtn_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            try
            {
                var selectedTeacher = TeacherDG.SelectedItem as User;
                if (selectedTeacher != null)
                {
                    context.Users.Remove(selectedTeacher);
                    context.SaveChanges();
                    MainMainFrame.Content = new AccecessibleCourses();
                }
            }
            catch { }
        }

        private void AdminExit_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            MainMainFrame.Content = new AdminPage();
        }

        private void LoadData()
        {
            try
            {
                context.Courses.Load();

                if (string.IsNullOrEmpty(SearchTb.Text))
                {
                    TeacherDG.ItemsSource = context.Users.Where(el => el.RoleId == 3).OrderBy(el => el.Surname).ToList();
                }
                else
                {
                    TeacherDG.ItemsSource = context.Users.Where(el => el.RoleId == 3 && (el.Name.Contains(SearchTb.Text) || el.Surname.Contains(SearchTb.Text))).OrderBy(el => el.Surname).ToList();
                }
                

            }
            catch { }
        }
    }
}

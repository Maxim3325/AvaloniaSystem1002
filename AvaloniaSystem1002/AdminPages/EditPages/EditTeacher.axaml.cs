using Avalonia.Controls;
using AvaloniaSystem1002.Data;
using AvaloniaSystem1002.Pages;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using static AvaloniaSystem1002.Classes.Helper;

namespace AvaloniaSystem1002.AdminPages
{
    public partial class EditTeacher : UserControl
    {
        private int _id;
        private User user;
        public EditTeacher(int id)
        {
            _id = id;
            InitializeComponent();
            BackBtn.Click += BackBtn_Click;
            OkBtn.Click += OkBtn_Click;
            LoadData();
        }

        private void OkBtn_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            try
            {
                if (_id == -1)
                {
                    LoginTb.IsVisible = true;
                    LoginLabel.IsVisible = true;
                    PasswordLabel.IsVisible = true;
                    PasswordTb.IsVisible = true;
                    context.Users.Add(user);
                }
                context.SaveChanges();
                MainMainFrame.Content = new AccecessibleTeacher();
            }
            catch { }
        }

        private void BackBtn_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            MainMainFrame.Content = new AccecessibleTeacher();
        }

        private void LoadData()
        {
            try
            {
                context.Users.Load();
                if (_id != -1)
                {
                    LoginTb.IsVisible = false;
                    LoginLabel.IsVisible = false;
                    PasswordLabel.IsVisible = false;
                    PasswordTb.IsVisible = false;
                    user = context.Users.Where(el => el.Id == _id).First();
                }
                else
                {
                    LoginTb.IsVisible = true;
                    LoginLabel.IsVisible = true;
                    PasswordLabel.IsVisible = true;
                    PasswordTb.IsVisible = true;
                    user = new User();
                }
                TeacherGrid.DataContext = user;
            }
            catch { }
        }
    }
}

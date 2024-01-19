using Avalonia.Controls;
using AvaloniaSystem1002.Pages;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;
using static AvaloniaSystem1002.Classes.Helper;

namespace AvaloniaSystem1002.AdminPages
{
    public partial class EditCategoryCourses : UserControl
    {
        public EditCategoryCourses()
        {
            InitializeComponent();
            OkBtn.Click += OkBtn_Click;
            BackBtn.Click += BackBtn_Click;
        }

        private void BackBtn_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            MainMainFrame.Content = new listCategoryCourses();
        }

        private void OkBtn_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            context.SaveChanges();
        }

        private void loadData()
        {
            try
            {
                context.Categories.Load();

                //CategoryGrid.DataContext = ;
            }
            catch { }
        }
    }
}

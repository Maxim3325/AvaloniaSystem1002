using Avalonia.Controls;
using AvaloniaSystem1002.Data;
using AvaloniaSystem1002.Pages;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Security.Cryptography;
using static AvaloniaSystem1002.Classes.Helper;

namespace AvaloniaSystem1002.AdminPages
{
    public partial class EditCategoryCourses : UserControl
    {
        private int _id;
        private Category category;
        public EditCategoryCourses(int id)
        {
            _id = id;
            InitializeComponent();
            OkBtn.Click += OkBtn_Click;
            BackBtn.Click += BackBtn_Click;
            LoadData();
        }

        private void BackBtn_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            MainMainFrame.Content = new listCategoryCourses();
        }

        private void OkBtn_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            try
            {
                if (_id == -1)
                {
                    context.Categories.Add(category);
                }
                context.SaveChanges();
                MainMainFrame.Content = new listCategoryCourses();
            }
            catch { }
        }

        private void LoadData()
        {
            try
            {
                context.Categories.Load();
                if (_id != -1)
                {
                    category = context.Categories.Where(el => el.Id == _id).First();
                }
                else
                {
                    category = new Category();
                }
                CategoryGrid.DataContext = category;
            }
            catch { }
        }
    }
}

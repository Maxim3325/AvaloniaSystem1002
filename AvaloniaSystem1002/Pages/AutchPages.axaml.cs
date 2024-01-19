using Avalonia.Controls;
using System.Linq;
using static AvaloniaSystem1002.Classes.Helper;

namespace AvaloniaSystem1002.Pages
{
    public partial class AutchPages : UserControl
    {
        public AutchPages()
        {
            InitializeComponent();
            AutchBtn.Click += AutchBtn_Click;
            PasswordBtn.Click += PasswordBtn_Click;
        }

        private void PasswordBtn_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            
            if (PasswordTb.PasswordChar == '*')
            {
                PasswordTb.PasswordChar = '\0';
            }
            else
            {
                PasswordTb.PasswordChar = '*';
            }
            
        }

        private void AutchBtn_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            try
            {
                var user = context.Users.First(el => el.Login == LoginTb.Text && el.Password == PasswordTb.Text);
                if (user.RoleId == 2)
                {
                    MainMainFrame.Content = new AdminPage();
                }
            }
            catch { }
            
        }
    }
}

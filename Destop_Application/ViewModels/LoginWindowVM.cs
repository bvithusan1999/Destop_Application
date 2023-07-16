using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Destop_Application.Data;
using Destop_Application.Models;
using Destop_Application.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Destop_Application.ViewModels
{
    public partial class LoginWindowVM : ObservableObject
    {
        [ObservableProperty]
        public string userName;

        [ObservableProperty]
        public string password;

        [ObservableProperty]
        ObservableCollection<User> people;

        [RelayCommand]
        public void LogInUser()
        {
            User u = new User()
            {
                Username = UserName,
                Password = Password,
            };

            using (var db = new DataBaseContext())
            {
                bool successlogin = false;
                var User = db.Users;
                foreach (var Item in User)
                {
                    if (Item.Username == UserName && Item.Password == Password && Item.IsAdmin == true)
                    {

                        successlogin = true;
                        AdminWindow adminWindow = new AdminWindow();
                        adminWindow.Show();

                        Window? loginWindow = Application.Current.Windows.OfType<LoginWindow>().FirstOrDefault();
                        if (loginWindow != null)
                        {
                            loginWindow.Close();
                        }
                        //MessageBox.Show("You successfully login as Admin");
                        return;
                    }
                    else if (Item.Username == UserName && Item.Password == Password && Item.IsAdmin == false)
                    {
                        StaffWindow staffWindow = new StaffWindow();
                        staffWindow.Show();
                        //MessageBox.Show("You successfully login as Staff");
                        successlogin = true;

                        Window? loginWindow = Application.Current.Windows.OfType<LoginWindow>().FirstOrDefault();
                        if (loginWindow != null)
                        {
                            loginWindow.Close();
                        }
                        return;
                    }

                }
                if (!successlogin)
                {
                    MessageBox.Show("Invalid username and Password");
                }
            }
        }

    }
}

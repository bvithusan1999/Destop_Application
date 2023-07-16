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
    public partial class AdminWindowVM : ObservableObject
    {
        [ObservableProperty]
        public string userName;

        [ObservableProperty]
        public string password;

        [ObservableProperty]
        public bool isAdmin;

        [ObservableProperty]
        public ObservableCollection<User> users;

        [ObservableProperty]
        public User selecteduser;

        [RelayCommand]
        public void Delete()
        {
            if (selecteduser == null)
            {
                return;
            }
            else
            {
                using (var db = new DataBaseContext())
                {
                    var originalPerson = db.Users.FirstOrDefault(p => p.Id == selecteduser.Id);
                    if (originalPerson != null)
                    {
                        db.Users.Remove(originalPerson);
                        db.SaveChanges();
                    }
                }
                
                
                Users.Remove(selecteduser);

            }
            LoadPerson();
        }

        public void LoadPerson()
        {
            using (var db = new DataBaseContext())
            {
                var list = db.Users.OrderByDescending(p => p.Username).ToList();
                users.Clear();
                foreach (var student in list)
                {
                    users.Add(student);
                }
            }
        }

        [RelayCommand]
        public void InsertUser()
        {
            User u = new User()
            {
                Username = userName,
                Password = Password,
                IsAdmin = IsAdmin
            };
            users.Add(u);

            using (var db = new DataBaseContext())
            {
                bool insertuser = false;

                var user = db.Users;
                foreach (var item in user)
                {
                    if (item.Username == u.Username)
                    {
                        insertuser = false;
                        MessageBox.Show("Username already exist");
                        break;
                    }
                    else
                    {
                        insertuser = true;
                    }
                }

                if (insertuser)
                {
                    db.Users.Add(u);
                    db.SaveChanges();
                    MessageBox.Show("Account successfully created");
                    
                    
                }

            }

        }

        public AdminWindowVM()
        {
            users = new ObservableCollection<User>();
            LoadPerson();
        }
    }
}

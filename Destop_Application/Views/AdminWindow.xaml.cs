using Destop_Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Destop_Application.Data;
using Destop_Application.ViewModels;

namespace Destop_Application.Views
{
    
    public partial class AdminWindow : Window
    {
        public AdminWindow()
        {

            InitializeComponent();


            DataContext = new  AdminWindowVM();
        }

        
        

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var window = new AddUserWindow();
            window.Show();
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            
            var window = new LoginWindow();
            window.Show();
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {

        }
    }
}

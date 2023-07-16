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
using Destop_Application.ViewModels;

namespace Destop_Application.Views
{
    /// <summary>
    /// Interaction logic for AddStudentWindow.xaml
    /// </summary>
    public partial class AddStudentWindow : Window
    {
        public AddStudentWindow()
        {
            InitializeComponent();
            DataContext = new StaffWindowVM();

        }

        private void textFirstName_MouseDown(object sender, MouseButtonEventArgs e)
        {
            txtFirstName.Focus();
            textFirstName.Visibility = Visibility.Collapsed;
        }

        private void txtFirstName_LostFocus(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(textFirstName.Text) && txtFirstName.Text.Length > 0)
            {
                textFirstName.Visibility = Visibility.Collapsed;
            }
            else
            {
                textFirstName.Visibility = Visibility.Visible;
            }
        }

        private void textLastName_MouseDown(object sender, MouseButtonEventArgs e)
        {
            txtLastName.Focus();
            textLastName.Visibility = Visibility.Collapsed;
        }

        private void txtLastName_LostFocus(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(textLastName.Text) && txtLastName.Text.Length > 0)
            {
                textLastName.Visibility = Visibility.Collapsed;
            }
            else
            {
                textLastName.Visibility = Visibility.Visible;
            }
        }

        private void textNic_MouseDown(object sender, MouseButtonEventArgs e)
        {
            txtNic.Focus();
            textNic.Visibility = Visibility.Collapsed;
        }

        private void txtNic_LostFocus(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(textNic.Text) && txtNic.Text.Length > 0)
            {
                textNic.Visibility = Visibility.Collapsed;
            }
            else
            {
                textNic.Visibility = Visibility.Visible;
            }
        }

        private void textMaths_MouseDown(object sender, MouseButtonEventArgs e)
        {
            txtMaths.Focus();
            textMaths.Visibility = Visibility.Collapsed;
        }

        private void txtMaths_LostFocus(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(textMaths.Text) && txtMaths.Text.Length > 0)
            {
                textMaths.Visibility = Visibility.Collapsed;
            }
            else
            {
                textMaths.Visibility = Visibility.Visible;
            }
        }

        private void textPhysics_MouseDown(object sender, MouseButtonEventArgs e)
        {
            txtPhysics.Focus();
            textPhysics.Visibility = Visibility.Collapsed;
        }

        private void txtPhysics_LostFocus(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(textPhysics.Text) && txtPhysics.Text.Length > 0)
            {
                textPhysics.Visibility = Visibility.Collapsed;
            }
            else
            {
                textPhysics.Visibility = Visibility.Visible;
            }
        }

        private void textChemistry_MouseDown(object sender, MouseButtonEventArgs e)
        {
            txtChemistry.Focus();
            textChemistry.Visibility = Visibility.Collapsed;
        }

        private void txtChemistry_LostFocus(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(textChemistry.Text) && txtChemistry.Text.Length > 0)
            {
                textChemistry.Visibility = Visibility.Collapsed;
            }
            else
            {
                textChemistry.Visibility = Visibility.Visible;
            }
        }


        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}

using KoiFarmShop.AdminManager;
using KoiFarmShop.BLL.Interface;
using KoiFarmShop.BLL.Service;
using KoiFarmShop.Customer;
using KoiFarmShop.DAL.Models;
using KoiFarmShop.Staff;
using Microsoft.Identity.Client.NativeInterop;
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

namespace KoiFarmShop
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        private readonly IUserService service;
        public LoginWindow()
        {
            InitializeComponent();
            service = new UserService();
        }
        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(txtUser.Text) || string.IsNullOrEmpty(txtPassword.Password))
            {
                System.Windows.MessageBox.Show("Email address or Password are required",
                    "Required fields",
                    MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            User? account = service.GetUserByAccount(txtUser.Text,
                txtPassword.Password);
            if (account == null)
            {
                System.Windows.MessageBox.Show("Invalid email address or wrong password",
                    "Wrong credentials",
                    MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (account.Status == 0)
            {
                System.Windows.MessageBox.Show("This account is banned",
                    "This account is banned",
                    MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (account.Role == "Admin" || account.Role == "Manager")
            {
                ManageUserWindow manageUserWindow = new ManageUserWindow();
                manageUserWindow.Show();
                this.Hide();
            }
            if (account.Role == "Employee")
            {
                CurrentUserService.Instance.CurrentAccount = account;
                ExecuteShippingProgressWindow executeShippingProgressWindow = new ExecuteShippingProgressWindow();
                executeShippingProgressWindow.Show();
                this.Hide();
            }
            if(account.Role == "Customer")
            {
                CurrentUserService.Instance.CurrentAccount = account;
                CustomerMainWindow m = new CustomerMainWindow();
                m.Show();
                this.Hide();
            }
        }

        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void txtForgotPassword_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            MessageBox.Show("Please contact support to reset your password.", "Forgot Password", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            RegisterWindow registerWindow = new RegisterWindow();
            registerWindow.Show();
        }
    }
}

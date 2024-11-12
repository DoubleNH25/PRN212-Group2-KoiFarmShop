using KoiFarmShop.BLL.Interface;
using KoiFarmShop.BLL.Service;
using KoiFarmShop.DAL.Models;
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

namespace KoiFarmShop.Customer
{
    /// <summary>
    /// Interaction logic for CustomerProfileWindow.xaml
    /// </summary>
    public partial class CustomerProfileWindow : Window
    {
        private readonly IUserService _userService;
        public CustomerProfileWindow()
        {
            InitializeComponent();
            _userService = new UserService();
            User currentUser = CurrentUserService.Instance.CurrentAccount;
            txtUserId.Text = currentUser.UserId.ToString();
            txtName.Text = currentUser.Name;
            txtEmail.Text = currentUser.Email;
            txtPhone.Text = currentUser.Phone;
            txtAddress.Text = currentUser.Address;
            txtPassword.Password = currentUser.Password;
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var updatedUser = new User
                {
                    UserId = int.Parse(txtUserId.Text),
                    Name = txtName.Text,
                    Email = txtEmail.Text,
                    Phone = txtPhone.Text,
                    Address = txtAddress.Text,
                    Password = txtPassword.Password, 
                };
                _userService.UpdateUser(updatedUser);

                CurrentUserService.Instance.CurrentAccount = updatedUser;

                MessageBox.Show("User profile updated successfully!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to update user profile: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }


        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}

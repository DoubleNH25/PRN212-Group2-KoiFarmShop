using KoiFarmShop.AdminManager.SaveWindow;
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

namespace KoiFarmShop.AdminManager
{
    /// <summary>
    /// Interaction logic for ManageUserWindow.xaml
    /// </summary>
    public partial class ManageUserWindow : Window
    {
        private readonly IUserService userService;
        public ManageUserWindow()
        {
            InitializeComponent();
            userService = new UserService();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            LoadUser();
        }

        private void LoadUser()
        {
            try
            {
                lvUserData.ItemsSource = null;
                lvUserData.ItemsSource = userService.GetAllUsers();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error loading user");
            }
        }

        private void Logout_Click(object sender, RoutedEventArgs e)
        {
            LoginWindow loginWindow = new LoginWindow();
            loginWindow.Show();
            this.Close();
        }

        private void btnOrder_Click(object sender, RoutedEventArgs e)
        {
            ManageOrderWindow mow = new ManageOrderWindow();
            mow.Show();
            this.Close();
        }

        private void btnProduct_Click(object sender, RoutedEventArgs e)
        {
            ManageProductWindow mpw = new ManageProductWindow();
            mpw.Show();
            this.Close();
        }

        private void btnSupplier_Click(object sender, RoutedEventArgs e)
        {
            ManageSupplierWindow msw = new ManageSupplierWindow();
            msw.Show();
            this.Close();
        }

        private void btnKoiBreeds_Click(object sender, RoutedEventArgs e)
        {
            ManageKoiBreedsWindow mkbw = new ManageKoiBreedsWindow();
            mkbw.Show();
            this.Close();
        }

        private void btnOrderDetail_Click(object sender, RoutedEventArgs e)
        {
            ManageOrderDetailWindow manageOrderDetailWindow = new ManageOrderDetailWindow();
            manageOrderDetailWindow.Show();
            this.Close();
        }

        private void btnShipping_Click(object sender, RoutedEventArgs e)
        {
            ManageShippingWindow manageShippingWindow = new ManageShippingWindow();
            manageShippingWindow.Show();
            this.Close();
        }

        private void btnUser_Click(object sender, RoutedEventArgs e)
        {
            ManageUserWindow manageUserWindow = new ManageUserWindow();
            manageUserWindow.Show();
            this.Close();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            var saveUserWindow = new SaveUserWindow(false);
            saveUserWindow.ShowDialog();
            LoadUser();
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            var selectedUser = lvUserData.SelectedItem as User; // Assuming you have a User model
            if (selectedUser != null)
            {
                var saveUserWindow = new SaveUserWindow(true, selectedUser);
                saveUserWindow.ShowDialog();
                LoadUser();
            }
            else
            {
                MessageBox.Show("Please select a user to edit.");
            }
        }
        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            var selectedUser = lvUserData.SelectedItem as User;
            if (selectedUser != null)
            {
                var result = MessageBox.Show($"Are you sure you want to delete {selectedUser.Name}?", "Confirm Delete", MessageBoxButton.YesNo);
                if (result == MessageBoxResult.Yes)
                {
                    userService.DeleteUser(selectedUser);
                    LoadUser();
                }
                
            }
            else
            {
                MessageBox.Show("Please select a user to delete.");
            }
        }

        private void Refresh_Click(object sender, RoutedEventArgs e)
        {
                LoadUser();
        }
    }
}

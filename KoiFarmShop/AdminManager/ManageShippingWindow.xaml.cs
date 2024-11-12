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
    /// Interaction logic for ManageShippingWindow.xaml
    /// </summary>
    public partial class ManageShippingWindow : Window
    {
        private readonly IOrderService _orderService;
        private readonly IUserService userService;
        public ManageShippingWindow()
        {
            InitializeComponent();
            _orderService = new OrderService();
            userService = new UserService();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            LoadShipping();
            LoadEmployee();
            LoadOrder();
        }

        private void LoadShipping()
        {
            try
            {
                lvShippingData.ItemsSource = null;
                lvShippingData.ItemsSource = _orderService.GetAllShipping();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error loading product");
            }
        }
        private void LoadEmployee()
        {
            try
            {
                cmbEmployee.ItemsSource = null;
                cmbEmployee.ItemsSource = userService.GetAllEmployee();
                cmbEmployee.DisplayMemberPath = "Name";
                cmbEmployee.SelectedValuePath = "UserId";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error loading Employee");
            }
        }
        private void LoadOrder()
        {
            try
            {
                cmbOrderId.ItemsSource = null;
                cmbOrderId.ItemsSource = _orderService.GetOrdersByStatus(1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error loading Employee");
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
        private void lvShippingData_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (lvShippingData.SelectedItem != null)
            {
                var selectedShipping = (Shipping)lvShippingData.SelectedItem;
                cmbOrderId.SelectedValue = selectedShipping.OrderId;
                cmbEmployee.SelectedValue = selectedShipping.EmployeeId;
            }
        }

        private void Update_Click(object sender, RoutedEventArgs e)
        {
            if (lvShippingData.SelectedItem != null)
            {
                var selectedShipping = (Shipping)lvShippingData.SelectedItem;

                selectedShipping.OrderId = (int)cmbOrderId.SelectedValue;
                selectedShipping.EmployeeId = (int)cmbEmployee.SelectedValue;
                try
                {
                    _orderService.UpdateShipping(selectedShipping);
                    MessageBox.Show("Shipping information updated successfully", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
                    LoadShipping();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error updating shipping: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a shipping record to edit.", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void Refresh_Click(object sender, RoutedEventArgs e)
        {
            LoadEmployee();
            LoadOrder();
            LoadShipping();
        }
    }
}

using KoiFarmShop.BLL.Interface;
using KoiFarmShop.BLL.Service;
using KoiFarmShop.Customer;
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

namespace KoiFarmShop.Staff
{
    /// <summary>
    /// Interaction logic for ExecuteShippingProgressWindow.xaml
    /// </summary>
    public partial class ExecuteShippingProgressWindow : Window
    {
        private readonly IOrderService _orderService;
        private readonly IUserService userService;
        private readonly User currentUser;
        public ExecuteShippingProgressWindow()
        {
            InitializeComponent();
            _orderService = new OrderService();
            userService = new UserService();
            currentUser = CurrentUserService.Instance.CurrentAccount;
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            LoadShipping();
            LoadEmployee();
        }
        private void LoadShipping()
        {
            try
            {
                lvShippingData.ItemsSource = null;
                lvShippingData.ItemsSource = _orderService.GetShippingByEmployee(currentUser.UserId);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error loading Shipping");
            }
        }
        private void LoadEmployee()
        {
            try
            {
                cmbEmployee.ItemsSource = null;
                cmbEmployee.ItemsSource = userService.GetAllEmployee();
                cmbEmployee.DisplayMemberPath = "Name";
                cmbEmployee.SelectedValuePath = "EmployeeId";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error loading Employee");
            }
        }
        private void Ellipse_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            CustomerProfileWindow profileWindow = new CustomerProfileWindow();
            profileWindow.Show();
        }
        private void Logout_Click(object sender, RoutedEventArgs e)
        {
            LoginWindow loginWindow = new LoginWindow();
            loginWindow.Show();
        }

        private void InTranSit_Click(object sender, RoutedEventArgs e)
        {
            var selectedShipping = lvShippingData.SelectedItem as Shipping;

            if (selectedShipping != null)
            {
                if (selectedShipping.Status == "In Transit")
                {
                    MessageBox.Show("Shipping is already in transit", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
                else if (selectedShipping.Status == "Delivered")
                {
                    MessageBox.Show("This shipping has delivered before that", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
                else if (selectedShipping.Status == "Prepared")
                {
                    try
                    {
                        selectedShipping.Status = "In Transit";
                        selectedShipping.ShippingDate = DateOnly.FromDateTime(DateTime.Now);
                        _orderService.UpdateShipping(selectedShipping);
                        MessageBox.Show("Ordered cancel successfull.", "Noti", MessageBoxButton.OK, MessageBoxImage.Information);
                        LoadShipping();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a order to cancel", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void Delivered_Click(object sender, RoutedEventArgs e)
        {
            var selectedShipping = lvShippingData.SelectedItem as Shipping;

            if (selectedShipping != null)
            {
                if (selectedShipping.Status == "Prepared")
                {
                    MessageBox.Show("The progress must be in transit first after prepared", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
                else if (selectedShipping.Status == "Delivered")
                {
                    MessageBox.Show("This shipping has delivered before that", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
                else if (selectedShipping.Status == "In Transit")
                {
                    try
                    {
                        selectedShipping.Status = "Delivered";
                        selectedShipping.DeliveryDate = DateOnly.FromDateTime(DateTime.Now);
                        _orderService.UpdateShipping(selectedShipping);
                        Order order = _orderService.GetOrderById(selectedShipping.OrderId);
                        if (order != null)
                        {
                            order.Status = 3; 
                            _orderService.UpdateOrder(order);
                        }
                        MessageBox.Show("Ordered cancel successfull.", "Noti", MessageBoxButton.OK, MessageBoxImage.Information);
                        LoadShipping();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a order to cancel", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}

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
    /// Interaction logic for OrdersWindow.xaml
    /// </summary>
    public partial class OrdersWindow : Window
    {
        private readonly User currentUser;
        private readonly IOrderService orderService;
        private readonly IUserService userService;
        public OrdersWindow()
        {
            InitializeComponent();
            currentUser = CurrentUserService.Instance.CurrentAccount;
            orderService = new OrderService();
            userService = new UserService();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            LoadOrder();
            LoadUser();
        }

        private void LoadOrder()
        {
            try
            {
                lvOrderData.ItemsSource = null;
                lvOrderData.ItemsSource = orderService.GetOrderWithUserId(currentUser.UserId);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error loading order");
            }
        }
        private void LoadUser()
        {
            try
            {
                var userList = userService.GetAllUsers();
                cmbUser.ItemsSource = userList;
                cmbUser.DisplayMemberPath = "Name";
                cmbUser.SelectedValuePath = "UserId";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error loading user");
            }
        }
        private void Ellipse_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            CustomerProfileWindow profileWindow = new CustomerProfileWindow();
            profileWindow.Show();
        }
        private void btnProduct_Click(object sender, RoutedEventArgs e)
        {
            ViewProductWindow productWindow = new ViewProductWindow();
            productWindow.Show();
            this.Close();
        }

        private void btnOrder_Click(object sender, RoutedEventArgs e)
        {
            OrdersWindow ordersWindow = new OrdersWindow();
            ordersWindow.Show();
            this.Close();
        }

        private void btnOrderDetail_Click(object sender, RoutedEventArgs e)
        {
            OrderDetailsWindow orderDetailsWindow = new OrderDetailsWindow();
            orderDetailsWindow.Show();
            this.Close();
        }

        private void btnShipping_Click(object sender, RoutedEventArgs e)
        {
            ShippingDetailWindow shippingDetailWindow = new ShippingDetailWindow();
            shippingDetailWindow.Show();
            this.Close();
        }

        private void Logout_Click(object sender, RoutedEventArgs e)
        {
            LoginWindow loginWindow = new LoginWindow();
            loginWindow.Show();
            this.Close();
        }

        private void btnHome_Click(object sender, RoutedEventArgs e)
        {
            CustomerMainWindow cusWindow = new CustomerMainWindow();
            cusWindow.Show();
            this.Close();
        }

        private void btnCancelOrder_Click(object sender, RoutedEventArgs e)
        {
            var selectedOrder = lvOrderData.SelectedItem as Order;

            if (selectedOrder != null)
            {
                if (selectedOrder.Status == 1 || selectedOrder.Status == 3)
                {
                    MessageBox.Show("You cannot cancel this order", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
                else if (selectedOrder.Status == 2)
                {
                    MessageBox.Show("This order is already canceled before that", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
                else if (selectedOrder.Status == 0)
                {
                    try
                    {
                        orderService.DeleteOrder(selectedOrder);
                        MessageBox.Show("Ordered cancel successfull.", "Noti", MessageBoxButton.OK, MessageBoxImage.Information);
                        LoadOrder();
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

using KoiFarmShop.BLL.Interface;
using KoiFarmShop.BLL.Service;
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
    /// Interaction logic for ShippingDetailWindow.xaml
    /// </summary>
    public partial class ShippingDetailWindow : Window
    {
        private readonly IOrderService _orderService;
        private readonly IUserService userService;
        public ShippingDetailWindow()
        {
            InitializeComponent();
            _orderService = new OrderService();
            userService = new UserService();
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
                lvShippingData.ItemsSource = _orderService.GetAllShipping();
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
                cmbEmployee.SelectedValuePath = "UserId";
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
    }
}

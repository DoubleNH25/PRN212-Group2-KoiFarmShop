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
    /// Interaction logic for OrderDetailsWindow.xaml
    /// </summary>
    public partial class OrderDetailsWindow : Window
    {
        private readonly User currentUser;
        private readonly IOrderService orderService;
        private readonly IProductService productService;
        public OrderDetailsWindow()
        {
            InitializeComponent();
            currentUser = CurrentUserService.Instance.CurrentAccount;
            orderService = new OrderService();
            productService = new ProductService();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            LoadOrderDetail();
            LoadProduct();
        }

        private void LoadOrderDetail()
        {
            try
            {
                lvOrderDetailData.ItemsSource = null;
                lvOrderDetailData.ItemsSource = orderService.GetOrderDetailWithUserId(currentUser.UserId);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error loading order detail");
            }
        }
        private void LoadProduct()
        {
            try
            {
                var productList = productService.GetAllProducts();
                cmbProduct.ItemsSource = productList;
                cmbProduct.DisplayMemberPath = "Name";
                cmbProduct.SelectedValuePath = "ProductId";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error loading product");
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

        private void btnCancelOrderDetail_Click(object sender, RoutedEventArgs e)
        {
            var selectedOrderDetail = lvOrderDetailData.SelectedItem as OrderDetail;

            if (selectedOrderDetail != null)
            {
                if (selectedOrderDetail.Status == 1)
                {
                    MessageBox.Show("You cannot cancel this order", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
                else if (selectedOrderDetail.Status == 0)
                {
                    MessageBox.Show("This order is already canceled before that", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
                else if (selectedOrderDetail.Status == 2)
                {
                    try
                    {
                        orderService.DeleteOrderDetail(selectedOrderDetail);
                        MessageBox.Show("Ordered Detail cancel successfull.", "Noti", MessageBoxButton.OK, MessageBoxImage.Information);
                        LoadOrderDetail();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a order detail to cancel", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}

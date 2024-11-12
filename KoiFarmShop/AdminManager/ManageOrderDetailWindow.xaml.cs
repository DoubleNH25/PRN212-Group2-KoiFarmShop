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
    /// Interaction logic for ManageOrderDetailWindow.xaml
    /// </summary>
    public partial class ManageOrderDetailWindow : Window
    {
        private readonly IOrderService orderService;
        private readonly IProductService productService;
        public ManageOrderDetailWindow()
        {
            InitializeComponent();
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
                lvOrderDetailData.ItemsSource = orderService.GetAllOrdersDetail();
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
        private void Accept_Click(object sender, RoutedEventArgs e)
        {
            var selectedOrderDetail = lvOrderDetailData.SelectedItem as OrderDetail;

            if (selectedOrderDetail != null)
            {
                if (selectedOrderDetail.Status == 1)
                {
                    MessageBox.Show("This order detail is accepted", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
                else if (selectedOrderDetail.Status == 0)
                {
                    MessageBox.Show("This order detail is already canceled before that", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
                else if (selectedOrderDetail.Status == 2)
                {
                    try
                    {
                        selectedOrderDetail.Status = 1;
                        orderService.UpdateOrderDetail(selectedOrderDetail);
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

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            var selectedOrderDetail = lvOrderDetailData.SelectedItem as OrderDetail;

            if (selectedOrderDetail != null)
            {
                if (selectedOrderDetail.Status == 1)
                {
                    MessageBox.Show("This order detail is accepted", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
                else if (selectedOrderDetail.Status == 0)
                {
                    MessageBox.Show("This order detail is already canceled before that", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
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

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
    /// Interaction logic for ManageOrderWindow.xaml
    /// </summary>
    public partial class ManageOrderWindow : Window
    {
        private readonly IOrderService orderService;
        private readonly IUserService userService;
        public ManageOrderWindow()
        {
            InitializeComponent();
            orderService = new OrderService();
            userService = new UserService();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            LoadOrder();
            LoadEmployee();
            LoadUser();
        }

        private void LoadOrder()
        {
            try
            {
                lvOrderData.ItemsSource = null;
                lvOrderData.ItemsSource = orderService.GetAllOrders();
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
                MessageBox.Show(ex.Message, "Error loading User");
            }
        }
        private void LoadEmployee()
        {
            try
            {
                var empList = userService.GetAllEmployee();
                cmbEmployee.ItemsSource = empList;
                cmbEmployee.DisplayMemberPath = "Name";
                cmbEmployee.SelectedValuePath = "UserId";
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
        

        private void Accept_Click(object sender, RoutedEventArgs e)
        {
            var selectedOrder = lvOrderData.SelectedItem as Order;

            if (selectedOrder != null)
            {
                if (selectedOrder.Status == 1)
                {
                    MessageBox.Show("This order is already accepted", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
                else if (selectedOrder.Status == 2)
                {
                    MessageBox.Show("This order is already canceled before that", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
                if (selectedOrder.Status == 3)
                {
                    MessageBox.Show("This order is already completed", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
                else if (selectedOrder.Status == 0)
                {
                    try
                    {
                        selectedOrder.Status = 1;
                        orderService.UpdateOrder(selectedOrder);
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
        

        private void Cancel_Click(object sender, RoutedEventArgs e)
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
        private void Complete_Click(object sender, RoutedEventArgs e)
        {
            var selectedOrder = lvOrderData.SelectedItem as Order;

            if (selectedOrder != null)
            {
                if (selectedOrder.Status == 0)
                {
                    MessageBox.Show("You must accept this order before it completed", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
                else if (selectedOrder.Status == 2)
                {
                    MessageBox.Show("This order is already canceled before that", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
                if (selectedOrder.Status == 3)
                {
                    MessageBox.Show("This order is already completed", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
                else if (selectedOrder.Status == 1)
                {
                    try
                    {
                        selectedOrder.Status = 3;
                        orderService.UpdateOrder(selectedOrder);
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

        private void Shipping_Click(object sender, RoutedEventArgs e)
        {
            var selectedOrder = lvOrderData.SelectedItem as Order;
            var selectedEmployee = cmbEmployee.SelectedItem as User;
            if (selectedOrder == null)
            {
                MessageBox.Show("Please select an order first.", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            if (selectedEmployee == null)
            {
                MessageBox.Show("Please select an employee for the shipping.", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            if (selectedOrder.Status != 1)
            {
                MessageBox.Show("Invalid Order!!!! Please select order that has 'Accepted' status!!!!", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            try
            {
                Shipping newShipping = new Shipping
                {
                    OrderId = selectedOrder.OrderId,
                    EmployeeId = selectedEmployee.UserId,
                    ShippingDate = null,
                    DeliveryDate = null,
                    ShippingMethod = "KoiFarmExpress",
                    Status = "Prepared"
                };

                orderService.AddShipping(newShipping);

                MessageBox.Show("Shipping created successfully.", "Noti", MessageBoxButton.OK, MessageBoxImage.Information);
                LoadOrder();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

    }
}

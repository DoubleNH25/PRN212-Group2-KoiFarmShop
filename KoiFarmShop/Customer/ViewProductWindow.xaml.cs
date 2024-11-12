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
    /// Interaction logic for ViewProductWindow.xaml
    /// </summary>
    public partial class ViewProductWindow : Window
    {
        private readonly IProductService productService;
        private readonly IKoiBreedService breedService;
        private readonly ISupplierService supplierService;
        private readonly IOrderService orderService;
        private readonly IUserService userService;
        private readonly Product currentProduct;
        private readonly User currentUser;
        public ViewProductWindow()
        {
            InitializeComponent();
            supplierService = new SupplierService();
            breedService = new KoiBreedService();
            productService = new ProductService();
            orderService = new OrderService();
            userService = new UserService();
            currentUser = CurrentUserService.Instance.CurrentAccount;

        }
        private void Ellipse_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            CustomerProfileWindow profileWindow = new CustomerProfileWindow();
            profileWindow.Show();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            LoadProduct();
            LoadBreed();
            LoadSupplier();
        }

        private void LoadProduct()
        {
            try
            {
                lvProductData.ItemsSource = null;
                lvProductData.ItemsSource = productService.GetAllProducts();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error loading product");
            }
        }
        private void LoadBreed()
        {
            try
            {
                var breedList = breedService.GetAllKoiBreed();
                cmbBreed.ItemsSource = breedList;
                cmbBreed.DisplayMemberPath = "BreedName";
                cmbBreed.SelectedValuePath = "BreedId";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error loading koi breed");
            }
        }
        private void LoadSupplier()
        {
            try
            {
                var supplierList = supplierService.GetAllSupplier();
                cmbSupplier.ItemsSource = supplierList;
                cmbSupplier.DisplayMemberPath = "Name";
                cmbSupplier.SelectedValuePath = "SupplierId";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error loading supplier");
            }
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
        private void btnCompare_Click(object sender, RoutedEventArgs e)
        {
            if (lvProductData.SelectedItems.Count != 2)
            {
                MessageBox.Show("Please select exactly two products for comparison.");
                return;
            }

            Product selectedProduct1 = lvProductData.SelectedItems[0] as Product;
            Product selectedProduct2 = lvProductData.SelectedItems[1] as Product;

            if (selectedProduct1 != null && selectedProduct2 != null)
            {
                string comparisonDetails = CompareProducts(selectedProduct1, selectedProduct2);
                comparisonText.Text = comparisonDetails;
                comparisonPanel.Visibility = Visibility.Visible;
            }
        }

        private string CompareProducts(Product product1, Product product2)
        {
            string comparison = $"{product1.Name} vs {product2.Name}\n\n";
            comparison += $"{product1.Gender} - {product2.Gender}\n";
            comparison += $"{product1.Breed.BreedName} - {product2.Breed.BreedName}\n";
            comparison += $"{product1.Supplier.Name} - {product2.Supplier.Name}\n";
            comparison += $"{product1.Origin}  - {product2.Origin}\n";
            comparison += $"Size: {product1.Size} vs {product2.Size}\n";
            comparison += $"{product1.Price:C}  - {product2.Price:C}\n";
            comparison += $"{product1.Stock}  - {product2.Stock}\n";
            comparison += $"{product1.FeedAmountPerDay}  - {product2.FeedAmountPerDay}\n";

            return comparison;
        }
        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string searchKeyword = txtSearch.Text.Trim().ToLower();
                var selectedBreed = cmbBreed.SelectedItem as KoiBreed;
                var selectedSupplier = cmbSupplier.SelectedItem as Supplier;
                var filteredProducts = productService.GetAllProducts().Where(p =>
                    (string.IsNullOrEmpty(searchKeyword) || p.Name.ToLower().Contains(searchKeyword)) &&
                    (selectedBreed == null || p.Breed.BreedId == selectedBreed.BreedId) &&
                    (selectedSupplier == null || p.Supplier.SupplierId == selectedSupplier.SupplierId)
                ).ToList();

                // Bind filtered products to ListView
                lvProductData.ItemsSource = filteredProducts;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error searching products", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnOrderProduct_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (lvProductData.SelectedItem is Product selectedProduct && int.TryParse(txtQuantity.Text, out int quantity) && quantity > 0)
                {
                    int? orderId = null;
                    if (!string.IsNullOrEmpty(txtOrderId.Text) && int.TryParse(txtOrderId.Text, out int enteredOrderId))
                    {
                        orderId = enteredOrderId;
                    }

                    if (orderId.HasValue)
                    {
                        var existingOrder = orderService.GetOrderById(orderId.Value); 
                        if (existingOrder == null)
                        {
                            MessageBox.Show("Order ID not found.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                            return;
                        }

                        if (existingOrder.UserId != currentUser.UserId)
                        {
                            MessageBox.Show("Your Order ID does not existing.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                            return;
                        }
                    }
                    else
                    {
                        var newOrder = new Order
                        {
                            UserId = currentUser.UserId,
                            OrderDate = DateOnly.FromDateTime(DateTime.Now),
                            TotalPrice = 0,
                            ShippingAddress = currentUser.Address,
                            Status = 0
                        };

                        orderService.AddOrder(newOrder);
                        orderId = newOrder.OrderId; 
                    }

                    var newOrderDetail = new OrderDetail
                    {
                        OrderId = orderId.Value,
                        ProductId = selectedProduct.ProductId,
                        Quantity = quantity,
                        Price = selectedProduct.Price,
                        Status = 2
                    };

                    orderService.AddOrderDetail(newOrderDetail);

                    MessageBox.Show("Order placed successfully!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
                    LoadProduct();
                }
                else
                {
                    MessageBox.Show("Please select a product and enter a valid quantity.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error placing order", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnRefresh_Click(object sender, RoutedEventArgs e)
        {
            comparisonText.Text = "";
            comparisonPanel.Visibility = Visibility.Collapsed;
            cmbBreed.SelectedIndex = -1;
            cmbSupplier.SelectedIndex = -1;
            txtSearch.Clear();
            txtQuantity.Clear();
            txtOrderId.Clear();
            LoadProduct();
        }
    }
}

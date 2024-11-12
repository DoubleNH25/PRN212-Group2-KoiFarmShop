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
    /// Interaction logic for ManageProductWindow.xaml
    /// </summary>
    public partial class ManageProductWindow : Window
    {
        private readonly IProductService productService ;
        private readonly IKoiBreedService breedService;
        private readonly ISupplierService supplierService ;
        public ManageProductWindow()
        {
            InitializeComponent();
            supplierService = new SupplierService();
            breedService = new KoiBreedService();
            productService = new ProductService();
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
                MessageBox.Show(ex.Message, "Error loading room type");
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
            SaveProductWindow saveProductWindow = new SaveProductWindow();
            saveProductWindow.ShowDialog();
            LoadProduct();  // Refresh the list after adding a product
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            if (lvProductData.SelectedItem == null)
            {
                MessageBox.Show("Please select a product to edit.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            var selectedProduct = (Product)lvProductData.SelectedItem;
            SaveProductWindow saveProductWindow = new SaveProductWindow(selectedProduct);
            saveProductWindow.ShowDialog();
            LoadProduct();  // Refresh the list after editing a product
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            if (lvProductData.SelectedItem is Product selectedProduct)
            {
                var result = MessageBox.Show($"Are you sure you want to delete {selectedProduct.Name}?", "Confirm Delete", MessageBoxButton.YesNo);
                if (result == MessageBoxResult.Yes)
                {
                    productService.DeleteProduct(selectedProduct);
                    LoadProduct();
                }
            }
            else
            {
                MessageBox.Show("Please select a product to delete.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
        }

        private void Refresh_Click(object sender, RoutedEventArgs e)
        {
            LoadProduct();
        }
    }
}

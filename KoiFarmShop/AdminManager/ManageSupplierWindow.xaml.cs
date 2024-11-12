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
    /// Interaction logic for ManageSupplierWindow.xaml
    /// </summary>
    public partial class ManageSupplierWindow : Window
    {
        private readonly ISupplierService supplierService;
        public ManageSupplierWindow()
        {
            InitializeComponent();
            supplierService = new SupplierService();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            LoadSupplier();
        }

        private void LoadSupplier()
        {
            try
            {
                lvSupplierData.ItemsSource = null;
                lvSupplierData.ItemsSource = supplierService.GetAllSupplier();
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
            var saveSupplierWindow = new SaveSupplierWindow();
            saveSupplierWindow.ShowDialog();
            LoadSupplier();
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            if (lvSupplierData.SelectedItem is Supplier selectedSupplier)
            {
                var saveSupplierWindow = new SaveSupplierWindow(selectedSupplier);
                saveSupplierWindow.ShowDialog();
                LoadSupplier(); 
            }
            else
            {
                MessageBox.Show("Please select supplier before your editing");
            }
        }

        private void Refresh_Click(object sender, RoutedEventArgs e)
        {
            LoadSupplier(); 
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            if (lvSupplierData.SelectedItem is Supplier selectedSupplier)
            {
                var result = MessageBox.Show($"Are you sure you want to delete {selectedSupplier.Name}?", "Confirm Delete", MessageBoxButton.YesNo);
                if (result == MessageBoxResult.Yes)
                {
                    supplierService.DeleteSupplier(selectedSupplier);
                    LoadSupplier();
                }  
            }
            else
            {
                MessageBox.Show("Please select supplier before your deleting");
            }
        }
    }
}

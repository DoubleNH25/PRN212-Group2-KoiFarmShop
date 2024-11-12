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
    /// Interaction logic for ManageKoiBreedsWindow.xaml
    /// </summary>
    public partial class ManageKoiBreedsWindow : Window
    {
        private readonly IKoiBreedService breedService;
        public ManageKoiBreedsWindow()
        {
            InitializeComponent();
            breedService = new KoiBreedService();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            LoadBreed();
        }

        private void LoadBreed()
        {
            try
            {
                lvBreedData.ItemsSource = null;
                lvBreedData.ItemsSource = breedService.GetAllKoiBreed();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error loading koi breed ");
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
            var saveKoiBreedWindow = new SaveKoiBreedWindow();
            saveKoiBreedWindow.Owner = this; // Set the owner for modal behavior
            if (saveKoiBreedWindow.ShowDialog() == true) // Check if saved
            {
                LoadBreed(); // Refresh list
            }
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            if (lvBreedData.SelectedItem is KoiBreed selectedBreed)
            {
                var saveKoiBreedWindow = new SaveKoiBreedWindow(selectedBreed); // Pass selected breed
                saveKoiBreedWindow.Owner = this;
                if (saveKoiBreedWindow.ShowDialog() == true)
                {
                    LoadBreed();
                }
            }
            else
            {
                MessageBox.Show("Please select a breed to edit.");
            }
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            if (lvBreedData.SelectedItem is KoiBreed selectedBreed)
            {
                var result = MessageBox.Show($"Are you sure you want to delete {selectedBreed.BreedName}?", "Confirm Delete", MessageBoxButton.YesNo);
                if (result == MessageBoxResult.Yes)
                {
                    breedService.DeleteBreed(selectedBreed);
                    LoadBreed();
                }
            }
            else
            {
                MessageBox.Show("Please select a breed to delete.");
            }
        }

        private void Refresh_Click(object sender, RoutedEventArgs e)
        {
            LoadBreed();
        }
    }
}

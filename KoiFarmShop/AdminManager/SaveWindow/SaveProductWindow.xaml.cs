using KoiFarmShop.BLL.Interface;
using KoiFarmShop.BLL.Service;
using KoiFarmShop.DAL.Models;
using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace KoiFarmShop.AdminManager.SaveWindow
{
    public partial class SaveProductWindow : Window
    {
        private readonly IProductService productService;
        private readonly IKoiBreedService breedService;
        private readonly ISupplierService supplierService;
        private Product _product; // To hold the product being edited

        public SaveProductWindow()
        {
            InitializeComponent();
            productService = new ProductService();
            supplierService = new SupplierService();
            breedService = new KoiBreedService();
            LoadBreed();
            LoadSupplier();
            LoadStatus();
            LoadGender();
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
        private void LoadGender()
        {
            try
            {
                // Define gender options: "Male" and "Female"
                var genderList = new[] {
                    new { Gender = "Male", GenderName = "Male" },
                    new { Gender = "Female", GenderName = "Female" }
                };

                cboGender.ItemsSource = genderList;
                cboGender.DisplayMemberPath = "GenderName";
                cboGender.SelectedValuePath = "Gender";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error loading gender");
            }
        }

        private void LoadStatus()
        {
            try
            {
                var statusList = new[] {
                    new { Status = (byte)0, StatusName = "Deleted" },
                    new { Status = (byte)1, StatusName = "Active" }
                };

                cboStatus.ItemsSource = statusList;
                cboStatus.DisplayMemberPath = "StatusName";
                cboStatus.SelectedValuePath = "Status";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error loading status");
            }
        }
        public SaveProductWindow(Product product) : this()
        {
            _product = product;
            txtProductId.Text = _product.ProductId.ToString();
            txtName.Text = _product.Name;
            cmbBreed.SelectedValue = _product.BreedId;
            cmbSupplier.SelectedValue = _product.SupplierId;
            txtOrigin.Text = _product.Origin;
            txtSize.Text = _product.Size?.ToString();
            txtFeedAmount.Text = _product.FeedAmountPerDay?.ToString();
            txtPrice.Text = _product.Price.ToString();
            txtStock.Text = _product.Stock.ToString();
            cboStatus.SelectedValue = _product.Status;
            cboGender.SelectedValue = _product.Gender;
            dpBirthDate.SelectedDate = _product.BirthDay.HasValue ? _product.BirthDay.Value.ToDateTime(new TimeOnly(0, 0)) : (DateTime?)null;

        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var product = new Product
                {
                    ProductId = string.IsNullOrEmpty(txtProductId.Text) ? 0 : int.Parse(txtProductId.Text),
                    Name = txtName.Text,
                    BreedId = (int)cmbBreed.SelectedValue,
                    SupplierId = (int)cmbSupplier.SelectedValue,
                    Origin = txtOrigin.Text,
                    BirthDay = dpBirthDate.SelectedDate.HasValue ? DateOnly.FromDateTime(dpBirthDate.SelectedDate.Value) : null,
                    Size = decimal.TryParse(txtSize.Text, out decimal size) ? size : (decimal?)null,
                    FeedAmountPerDay = decimal.TryParse(txtFeedAmount.Text, out decimal feedAmount) ? feedAmount : (decimal?)null,
                    Price = decimal.Parse(txtPrice.Text),
                    Stock = int.Parse(txtStock.Text),
                    Status = (byte)cboStatus.SelectedValue,
                    Gender = cboGender.SelectedValue.ToString()
                };

                if (_product == null) 
                {
                    productService.AddProduct(product);
                }
                else 
                {
                    product.ProductId = _product.ProductId;
                    productService.UpdateProduct(product);
                }

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error saving product");
            }
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}

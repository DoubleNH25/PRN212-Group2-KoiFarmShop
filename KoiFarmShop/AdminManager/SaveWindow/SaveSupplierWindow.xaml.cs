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

namespace KoiFarmShop.AdminManager.SaveWindow
{
    /// <summary>
    /// Interaction logic for SaveSupplierWindow.xaml
    /// </summary>
    public partial class SaveSupplierWindow : Window
    {
        private readonly ISupplierService supplierService;
        private Supplier currentSupplier;

        // Constructor cho chế độ Add
        public SaveSupplierWindow()
        {
            InitializeComponent();
            supplierService = new SupplierService();
            txtSupplierId.IsReadOnly = true;
        }

        // Constructor cho chế độ Edit
        public SaveSupplierWindow(Supplier supplier) : this()
        {
            currentSupplier = supplier;
            LoadSupplierData(); 
        }

        private void LoadSupplierData()
        {
            if (currentSupplier != null)
            {
                txtSupplierId.Text = currentSupplier.SupplierId.ToString();
                txtName.Text = currentSupplier.Name;
                txtContactInfo.Text = currentSupplier.ContactInfo;
                txtAddress.Text = currentSupplier.Address;
            }
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (currentSupplier == null)
                {
                    var newSupplier = new Supplier
                    {
                        Name = txtName.Text,
                        ContactInfo = txtContactInfo.Text,
                        Address = txtAddress.Text
                    };
                    supplierService.AddSupplier(newSupplier);
                }
                else
                {
                    currentSupplier.Name = txtName.Text;
                    currentSupplier.ContactInfo = txtContactInfo.Text;
                    currentSupplier.Address = txtAddress.Text;
                    supplierService.UpdateSupplier(currentSupplier);
                }

                MessageBox.Show("Save supplier successfull!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}

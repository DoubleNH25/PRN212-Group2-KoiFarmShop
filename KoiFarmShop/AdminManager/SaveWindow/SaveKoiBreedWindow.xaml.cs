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
using System.Xml.Linq;

namespace KoiFarmShop.AdminManager.SaveWindow
{
    /// <summary>
    /// Interaction logic for SaveKoiBreedWindow.xaml
    /// </summary>
    public partial class SaveKoiBreedWindow : Window
    {
        private readonly IKoiBreedService breedService;
        private readonly KoiBreed breed;

        // Constructor for adding
        public SaveKoiBreedWindow()
        {
            InitializeComponent();
            breedService = new KoiBreedService();
            txtBreedId.IsReadOnly = true; // ID should be non-editable
        }

        // Constructor for editing
        public SaveKoiBreedWindow(KoiBreed existingBreed) : this()
        {
            breed = existingBreed;
            // Fill the fields with existing breed data
            txtBreedId.Text = breed.BreedId.ToString();
            txtName.Text = breed.BreedName;
            txtDescription.Text = breed.Description;
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            // Create or update breed based on the mode
            if (breed == null) // Add mode
            {
                var newBreed = new KoiBreed
                {
                    BreedName = txtName.Text,
                    Description = txtDescription.Text
                };
                breedService.AddBreed(newBreed);
            }
            else // Edit mode
            {
                breed.BreedName = txtName.Text;
                breed.Description = txtDescription.Text;
                breedService.UpdateBreed(breed);
            }

            DialogResult = true; // Close the window and return success
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }
    }

}

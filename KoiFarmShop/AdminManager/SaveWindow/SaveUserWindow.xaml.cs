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
    /// Interaction logic for SaveUserWindow.xaml
    /// </summary>
    public partial class SaveUserWindow : Window
    {
        private readonly IUserService _userService;
        private bool isEditMode;
        private User user;

        public SaveUserWindow(bool isEditMode, User selectedUser = null)
        {
            InitializeComponent();
            _userService = new UserService();
            this.isEditMode = isEditMode;
            this.user = selectedUser ?? new User();

            cboRole.ItemsSource = new List<string> { "Customer", "Admin", "Manager", "Employee" };
            cboStatus.ItemsSource = new Dictionary<int, string>
            {
                { 1, "Active" },
                { 0, "Deleted" }
            };
            cboStatus.DisplayMemberPath = "Value";
            cboStatus.SelectedValuePath = "Key";

            if (isEditMode && user != null)
            {
                txtUserId.Text = user.UserId.ToString();
                txtUserId.IsReadOnly = true;
                txtName.Text = user.Name;
                txtEmail.Text = user.Email;
                txtPassword.Password = user.Password;
                txtPhone.Text = user.Phone;
                txtAddress.Text = user.Address;
                cboRole.SelectedItem = user.Role;
                cboStatus.SelectedValue = user.Status;
            }
            else
            {
                txtUserId.IsReadOnly = true; 
                txtUserId.Text = string.Empty;
            }
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            if (isEditMode)
            {
                user.UserId = int.Parse(txtUserId.Text);
            }
            else
            {
                user.UserId = 0;
            }

            user.Name = txtName.Text;
            user.Email = txtEmail.Text;
            user.Password = txtPassword.Password;
            user.Phone = txtPhone.Text;
            user.Address = txtAddress.Text;
            user.Role = cboRole.SelectedItem?.ToString();
            user.Status = Convert.ToByte(cboStatus.SelectedValue);


            if (isEditMode)
            {
                _userService.UpdateUser(user);
                MessageBox.Show("User updated successfully.");
            }
            else
            {
                _userService.AddUser(user);
                MessageBox.Show("User added successfully.");
            }
            this.Close();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}

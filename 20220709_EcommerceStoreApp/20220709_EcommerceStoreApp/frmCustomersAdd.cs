using _20220709_EcommerceStoreApp.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20220709_EcommerceStoreApp
{
    public partial class frmCustomersAdd : Form
    {
        private frmCustomers frmCustomers;
        public frmCustomersAdd(frmCustomers frmCustomers)
        {
            InitializeComponent();
            this.frmCustomers = frmCustomers;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.Name = txtName.Text;
            customer.Email = txtEmail.Text;
            customer.Phone = txtPhone.Text;
            customer.Address = txtAddress.Text;

            if(string.IsNullOrEmpty(txtBalance.Text))
            {
                MessageBox.Show("Balance cannot be empty.");
                return;
            }

            customer.Balance = int.Parse(txtBalance.Text);

            CustomerManager customerManager = new CustomerManager();
            customerManager.InsertCustomer(customer);

            MessageBox.Show("Customer Data Saved.");

            this.frmCustomers.LoadCustomersGrid();
            this.Close();
        }

        private void txtBalance_Leave(object sender, EventArgs e)
        {
            Regex match = new Regex(@"^[0-9]\d*(\.\d{1})?$");

            if (!match.IsMatch(txtBalance.Text))
            {
                MessageBox.Show("It must be number.");
                txtBalance.Text = "";
                txtBalance.Focus();
            }
        }
    }
}

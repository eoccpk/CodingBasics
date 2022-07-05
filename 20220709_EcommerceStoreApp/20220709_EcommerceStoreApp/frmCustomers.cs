using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _20220709_EcommerceStoreApp.Logic;

namespace _20220709_EcommerceStoreApp
{
    public partial class frmCustomers : Form
    {
        public frmCustomers()
        {
            InitializeComponent();
        }

        private void frmCustomers_Load(object sender, EventArgs e)
        {
            LoadCustomersGrid();
        }

        public void LoadCustomersGrid()
        {
            CustomerManager customerManager = new CustomerManager();
            var customers = customerManager.GetAllCustomers();
            dgvCustomers.DataSource = customers;
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            frmCustomersAdd frmCustomersAdd = new frmCustomersAdd(this);
            frmCustomersAdd.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvCustomers.SelectedRows.Count != 1)
                {
                    MessageBox.Show("Please select Customer");
                    return;
                }

                int CustomerId = (int)dgvCustomers.SelectedRows[0].Cells[0].Value;
                CustomerManager customerManager = new CustomerManager();
                customerManager.DeleteCustomer(CustomerId);
                LoadCustomersGrid();
                MessageBox.Show("Customer Deleted");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

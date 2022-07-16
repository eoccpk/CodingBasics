using _20220709_EcommerceStoreApp.Logic;
using System;
using System.Windows.Forms;

namespace _20220709_EcommerceStoreApp
{
    public partial class frmProducts : Form
    {
        public frmProducts()
        {
            InitializeComponent();
        }

        private void frmProducts_Load(object sender, EventArgs e)
        {
            LoadProductsGrid();
        }

        public void LoadProductsGrid()
        {
            ProductManager productManager = new ProductManager();
            dgvProducts.DataSource = productManager.GetAllProducts();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            frmProductsNew frmProductsNew = new frmProductsNew(this);
            frmProductsNew.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvProducts.SelectedRows.Count != 1)
                {
                    MessageBox.Show("Please select Product");
                    return;
                }

                int ProductId = (int)dgvProducts.SelectedRows[0].Cells[0].Value;
                ProductManager productManager = new ProductManager();
                productManager.DeleteProduct(ProductId);
                LoadProductsGrid();
                MessageBox.Show("Product Deleted");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

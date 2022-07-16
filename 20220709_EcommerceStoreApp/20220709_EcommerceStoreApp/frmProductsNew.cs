using _20220709_EcommerceStoreApp.Logic;
using System;
using System.Windows.Forms;

namespace _20220709_EcommerceStoreApp
{
    public partial class frmProductsNew : Form
    {
        frmProducts frmProducts;
        public frmProductsNew(frmProducts frmProducts)
        {
            InitializeComponent();
            this.frmProducts = frmProducts;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.Code = txtCode.Text;
            product.Name = txtName.Text;
            product.Category = txtCategory.Text;
            product.UnitPrice = int.Parse(txtUnitPrice.Text);
            product.StockQuantity = txtStockQuantity.Text;
            product.Rating = int.Parse(txtRating.Text);
            product.Seller = txtSeller.Text;
            product.Image = txtImage.Text;

            ProductManager productManager = new ProductManager();
            productManager.InsertProduct(product);

            MessageBox.Show("New Product has been added");
            frmProducts.LoadProductsGrid();
        }
    }
}

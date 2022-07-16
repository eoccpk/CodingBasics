using System;
using System.Windows.Forms;

namespace _20220708_DesktopApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "kamran" && txtPassword.Text == "12345")
            {
                lblMessage.Text = "Welcome " + txtUsername.Text;
                MessageBox.Show("Logged-In Successfully.");
            }
            else
            {
                MessageBox.Show("Wrong User Name or Password.");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeNova
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblpass_Click(object sender, EventArgs e)
        {

        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblUser_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUser.Text;
            string password = txtPass.Text;

            if (username == "admin" && password == "123")
            {
                Admin adminForm = new Admin();
                adminForm.Show();
                this.Hide(); // hide login form
            }
            else if (username == "user" && password == "123")
            {
                Customer customerForm = new Customer();
                customerForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password!");
            }
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           

        }

        private void lblcafe_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

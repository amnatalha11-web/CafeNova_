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
    public partial class Customer : Form
    {
        // Lists to store items and their prices
        List<string> cartItems = new List<string>();
        List<int> cartPrices = new List<int>();

        public Customer()
        {
            InitializeComponent();
        }

        private void lblcafe_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGenerateBill_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < cartItems.Count; i++)
            {
                Admin.AllOrders.Add(cartItems[i] + " - Rs " + cartPrices[i]);
            }

            Billing billForm = new Billing(cartItems, cartPrices);
            billForm.Show();



        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close(); // close Customer form
            Login loginForm = new Login();
            loginForm.Show(); // go back to Login form
        }

        private void btnAddCoffee_Click(object sender, EventArgs e)
        {
            string item = "Coffee";
            int price = 200;
            cartItems.Add("Coffee");
            cartPrices.Add(200);
            MessageBox.Show("Coffee added to cart!");
            DataStore.AllItems.Add(item);
            DataStore.AllPrices.Add(price);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string item = "Coffee";
            int price = 200;
            cartItems.Add("Coffee");
            cartPrices.Add(200);
            MessageBox.Show("Coffee added to cart!");
            DataStore.AllItems.Add(item);
            DataStore.AllPrices.Add(price);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string item = "Coffee";
            int price = 200;
            cartItems.Add("Coffee");
            cartPrices.Add(200);
            MessageBox.Show("Coffee added to cart!");
            DataStore.AllItems.Add(item);
            DataStore.AllPrices.Add(price);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

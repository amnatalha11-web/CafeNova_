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
    public partial class Admin : Form
    {
        public static List<string> AllOrders = new List<string>();

        public Admin()
        {
            InitializeComponent();
        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }

        private void Admin_Load(object sender, EventArgs e)
        {
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            listBoxOrders.Items.Clear(); // clear previous items

            for (int i = 0; i < DataStore.AllItems.Count; i++)
            {
                string item = DataStore.AllItems[i];
                int price = DataStore.AllPrices[i];
                listBoxOrders.Items.Add(item + " - " + price + " PKR");
            }
        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Login loginForm = new Login();
            loginForm.Show();
        }

        private void listBoxOrders_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

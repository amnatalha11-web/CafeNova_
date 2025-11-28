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
    public partial class Billing : Form
    {
        public Billing(List<string> items, List<int> prices)
        {
            InitializeComponent();

            int total = 0;

            // Add items to listbox and calculate total
            for (int i = 0; i < items.Count; i++)
            {
                listBox1.Items.Add(items[i] + " -Rs " + prices[i]);
                total += prices[i];
            }

            lblTotal.Text = "Total: Rss " + total;
        }

        private void Billing_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

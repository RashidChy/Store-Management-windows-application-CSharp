using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreManagement.UI
{
    public partial class AddItems : UserControl
    {
        Methods mn = new Methods();
        string query;
        public AddItems()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            query = "insert into items(Name,Catagory,Price) values ('" + txtname.Text + "','" + txtcatagory.Text + "','" + txtprice.Text + "')";
            mn.setData(query);
            clearAll();
        }
        public void clearAll()
        {
            txtcatagory.SelectedIndex=-1;
            txtname.Clear();
            txtprice.Clear();

        }
    }
}

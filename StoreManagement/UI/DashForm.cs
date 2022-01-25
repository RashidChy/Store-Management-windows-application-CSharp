using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreManagement.UI
{
    public partial class DashForm : Form
    {
        public DashForm()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            makeBill1.Visible = true;
            makeBill1.BringToFront();

            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 fr = new Form1();
            this.Hide();
            fr.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DashForm_Load(object sender, EventArgs e)
        {
            addItems1.Visible = false;
            makeBill1.Visible = false;
            updateItems1.Visible = false;
            removeItem1.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            addItems1.Visible = true;
            addItems1.BringToFront();
        }

        private void btnUpdateItem_Click(object sender, EventArgs e)
        {
            updateItems1.Visible = true;
            updateItems1.BringToFront();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
          removeItem1.Visible=true;
          removeItem1.BringToFront();
        }
    }
}

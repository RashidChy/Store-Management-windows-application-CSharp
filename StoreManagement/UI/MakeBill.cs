using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DGVPrinterHelper;

namespace StoreManagement.UI
{
    
    public partial class MakeBill : UserControl
    {
        Methods mn = new Methods();
        String query;
        int noOFRow, total = 0;
        int amount=0;
        public MakeBill()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtCatogory_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            String category = txtCatogory.Text;
            query = "select Name from items where Catagory ='" + category + "'";
            showItem(query);
        }

        private void textSearch_TextChanged(object sender, EventArgs e)
        {
          
            String category = txtCatogory.Text;
            query = "select Name from items where Catagory ='" + category + "' and Name like'"+textSearch.Text+"%'";
            showItem(query);
            

        }
        private void showItem(string query)
        {
            listBox1.Items.Clear();
            DataSet ds = mn.getData(query);
            int i;

            for (i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                listBox1.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtQuantity.ResetText();
            txtTotal.Clear();
            string text = listBox1.GetItemText(listBox1.SelectedItem);
            txtItemName.Text = text;
            query = "select Price from Items where name ='" + text + "'";
            DataSet ds = mn.getData(query);
            try
            {
                txtPrice.Text = ds.Tables[0].Rows[0][0].ToString();
            }
            catch
            {

            }
        }

        private void txtQuantity_ValueChanged(object sender, EventArgs e)
        {
            Int64 quan = Int64.Parse(txtQuantity.Value.ToString());
            Int64 price = Int64.Parse(txtPrice.Text);
            txtTotal.Text = (quan*price).ToString();

        }

        private void txtRemove_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.Rows.RemoveAt(this.dataGridView1.SelectedRows[0].Index);
                total = total - amount;
                labeltotalamount.Text = "Bdt. " + total;
            }
            catch
            {

            }
           // total =total- amount;
            //labeltotalamount.Text = "Bdt. " + total;
        }

        
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                amount = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());

            }
            catch
            {

            }
            
        }

        private void txtItemName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtPrint_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Customer Bill";
            printer.SubTitle = string.Format("Date: {0}", DateTime.Now.Date);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Total Payable amount:" +labeltotalamount.Text;
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(dataGridView1);
            total = 0;
            dataGridView1.Rows.Clear();
            labeltotalamount.Text = "Bdt. " + total;


        }

        private void btnAddtoChart_Click(object sender, EventArgs e)
        {
            if (txtTotal.Text != "0" && txtTotal.Text != "")
            {
                noOFRow = dataGridView1.Rows.Add();
                dataGridView1.Rows[noOFRow].Cells[0].Value = txtItemName.Text;
                dataGridView1.Rows[noOFRow].Cells[1].Value = txtPrice.Text;
                dataGridView1.Rows[noOFRow].Cells[2].Value = txtQuantity.Value;
                dataGridView1.Rows[noOFRow].Cells[3].Value = txtTotal.Text;

                total = total + int.Parse(txtTotal.Text);
                labeltotalamount.Text = "Bdt. " + total;
            }
            else
            {
                MessageBox.Show("Minimum Quantity needs to atleast 1");
            }
        }
    }
}

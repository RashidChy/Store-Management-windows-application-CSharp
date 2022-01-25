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
    public partial class updateItems : UserControl
    {
        Methods mn = new Methods();
        String query;
        public updateItems()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void updateItems_Load(object sender, EventArgs e)
        {
            loadData();

        }
        public void loadData()
        {
            query = "select * from Items";
            DataSet ds = mn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];

        }

        private void txtSearchItem_TextChanged(object sender, EventArgs e)
        {
            query = "select * from Items where Name like'" + txtSearchItem.Text + "%'";
            DataSet ds = mn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];

        }

        int id;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            string category = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            string name = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            int price =int.Parse(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
            txtCategory.Text = category;
            txtName.Text = name;
            txtPrice.Text = price.ToString();


        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            query = "update Items set Name='" + txtName.Text + "',Catagory='" + txtCategory.Text + "',Price=" + txtPrice.Text + " where Id =" + id + "";
            mn.setData(query);
            loadData();
            txtName.Clear();
            txtCategory.Clear();
            txtPrice.Clear();
            
        }

        private void txtCategory_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

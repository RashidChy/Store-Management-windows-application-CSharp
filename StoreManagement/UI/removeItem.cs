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
    public partial class removeItem : UserControl
    {
        Methods mn = new Methods();
        string query;
        public removeItem()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void removeItem_Load(object sender, EventArgs e)
        {
            loadData();
        }
        public void loadData()
        {
            query = "select * from Items";
            DataSet se = mn.getData(query);
            dataGridView1.DataSource = se.Tables[0];
        }

        private void txtSearchItem_TextChanged(object sender, EventArgs e)
        {
           query ="select * from Items where name like'"+txtSearchItem.Text+"%'";
            DataSet se = mn.getData(query);
            dataGridView1.DataSource = se.Tables[0];
                
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if( MessageBox.Show("Delete this Item?","Important Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)

            {
                int id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                query = "delete from Items where Id=" +id+"";
                mn.setData(query);
                loadData();


            }
        }

        private void dataGridView1_Enter(object sender, EventArgs e)
        {
            loadData();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

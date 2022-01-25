using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StoreManagement.UI;

namespace StoreManagement
{
    public partial class Form1 : Form
    {
      
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblFooter_Click(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (UserNameTextBox.Text == "")
            {
               MessageBox.Show("UserName Required");
            }
            
            if (PasswordTextBox.Text == "")
            {
                MessageBox.Show("Password Required");
                
            }
            
            if (UserNameTextBox.Text != "" && PasswordTextBox.Text != "")
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-BR1CNRR;Initial Catalog=Store;Integrated Security=True");

                try
                {
                    con.Open();
                    string query = "Select count(*) from [User] where UserName='" + UserNameTextBox.Text + "' And Password='" + PasswordTextBox.Text + "'";
                    SqlCommand sqlcmd = new SqlCommand(query, con);
                    int a = Convert.ToInt32(sqlcmd.ExecuteScalar());
                    if (a == 1)
                    {
                        this.Hide();
                        DashForm df = new DashForm();
                        df.Show();
                        
                   
                    }
                    else
                    {
                        MessageBox.Show("Invalid Credentials!");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }

        }

        //private bool IsValid()
        //{
           // if(UserNameTextBox.Text.Trim() == string.Empty)
           // {
            //    MessageBox.Show("User name is required", "form validatoin err");
            //    return false;

           // }
           // if (PasswordTextBox.Text.Trim() == string.Empty)
           // {
            //    MessageBox.Show("Password is required", "form validatoin err");
           //     return false;

          //  }
           // return true;
       // }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }
    }
}

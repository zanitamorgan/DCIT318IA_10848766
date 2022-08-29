using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DCIT318IA_10848766
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\LENOVO\OneDrive\Documents\SIMSdb.mdf;Integrated Security=True;Connect Timeout=30");
        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void RoleCb_SelectedIndexChanged(object sender, EventArgs e)
        {
                
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                string query = "Insert into UserTble values('" + UnameTb.Text + "', '" + EmailTb.Text + "', '" + PassTb.Text + "', '" + RoleCb.Text + "')";
               
                if (RoleCb.Text == "Admin")
                {
                    SqlCommand command = new SqlCommand(query, Con);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Success");
                    Con.Close();
                    Products log = new Products();
                    this.Hide();
                    log.Show();
                } 
                else
                {
                    SqlCommand command = new SqlCommand(query, Con);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Success");
                    Con.Close();
                    Products log = new Products();
                    this.Hide();
                    log.Show();
                }
            } 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void PassTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void UnameTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            this.Hide();
            log.Show();
        }

        private void guna2HtmlLabel4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

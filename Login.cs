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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\LENOVO\OneDrive\Documents\SIMSdb.mdf;Integrated Security=True;Connect Timeout=30");
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {

        }

        private void guna2CircleButton1_Click_1(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2HtmlLabel6_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel8_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel9_Click(object sender, EventArgs e)
        {
           
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string Username = LogName.Text;
            string Password = LogPassword.Text;

            try
            {
                string query = "select * from UserTble where UserName = '" + LogName.Text + "' AND UserPassword= '" +LogPassword.Text + "' AND UserRole= '" + LogRole.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, Con);
                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if(dtable.Rows.Count > 0 && LogRole.Text == "Admin")
                {
                    Username = LogName.Text;
                    Password = LogPassword.Text;
                    Products log = new Products();
                    this.Hide();
                    log.Show();
                }
                else if (dtable.Rows.Count > 0 && LogRole.Text == "Attendant")
                {
                    Username = LogName.Text;
                    Password = LogPassword.Text;
                    TillForm log = new TillForm();
                    this.Hide();
                    log.Show();
                }
                else
                {
                    MessageBox.Show("Invalid user details");
                    LogName.Text = "";
                    LogPassword.Text = "";
                }
            }catch
            {
                MessageBox.Show("Invalid user details");
            }finally
            {
                Con.Close();
            }
        }

        private void LogName_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Click(object sender, EventArgs e)
        {
            string username = LogName.Text;
            string password = LogPassword.Text;

            try
            {
                string query = "select * from UserTble where UserName = '" + LogName.Text + "' AND UserPassword = '" + LogPassword.Text + "' AND UserRole = '" + LogRole.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count > 0 && LogRole.Text == "Admin")
                {
                    username = LogName.Text;
                    password = LogPassword.Text;
                    Products log = new Products();
                    this.Hide();
                    log.Show();
                }
                else if (dt.Rows.Count > 0 && LogRole.Text == "Attendant")
                {
                    username = LogName.Text;
                    password = LogPassword.Text;
                    TillForm log = new TillForm();
                    this.Hide();
                    log.Show();
                }
                else
                {
                    MessageBox.Show("Invalid");
                }
            }

            catch
            {
                MessageBox.Show("Invalid user");
            }
        }

        private void LogRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

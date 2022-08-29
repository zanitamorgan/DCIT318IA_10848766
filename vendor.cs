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
    public partial class vendor : Form
    {
        public vendor()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\LENOVO\OneDrive\Documents\SIMSdb.mdf;Integrated Security=True;Connect Timeout=30");
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                string query = "insert into UserTble values(" + UsernameTb.Text + ", '" + UserMailTb.Text + "','" + UserpasswordTb.Text + "', '" + UserroleTb.Text + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("User Added Successfully");
                Con.Close();
                populate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (UsernameTb.Text == "" || UserMailTb.Text == "" || UserpasswordTb.Text == "" || UserroleTb.Text == "")
                {
                    MessageBox.Show("Missing Information");

                }
                else
                {
                    Con.Open();
                    string query = "Update UserTble set UserMail='" + UserMailTb.Text + "', UserPassword='" + UserpasswordTb.Text + "', UserRole='" + UserroleTb.Text + "' where UserName=" + UsernameTb.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User Successfully Update");
                    Con.Close();
                    populate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void populate()
        {
            Con.Open();
            string query = "Select * from UserTble";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            VendDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void vendor_Load_1(object sender, EventArgs e)
        {
            populate();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (UsernameTb.Text == "")
                {
                    MessageBox.Show("Select The User To Delete");
                }
                else
                {
                    Con.Open();
                    string query = "Delete from UserTble where UserName =" + UsernameTb.Text + "";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User Deleted Successfully");
                    Con.Close();
                    populate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        

        private void VendDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            UsernameTb.Text = VendDGV.SelectedRows[0].Cells[0].Value.ToString();
            UserMailTb.Text = VendDGV.SelectedRows[0].Cells[1].Value.ToString();
            UserpasswordTb.Text = VendDGV.SelectedRows[0].Cells[2].Value.ToString();
            UserroleTb.SelectedValue = VendDGV.SelectedRows[0].Cells[3].Value.ToString();
        }





        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {

        }



        private void guna2HtmlLabel7_Click(object sender, EventArgs e)
        {

        }

        private void VendName_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            Products log = new Products();
            this.Hide();
            log.Show();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            CategoryForm log = new CategoryForm();
            this.Hide();
            log.Show();
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            TransactionForm log = new TransactionForm();
            this.Hide();
            log.Show();
        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
            StockForm log = new StockForm();
            this.Hide();
            log.Show();
        }

        private void bunifuThinButton26_Click(object sender, EventArgs e)
        {
            ReceiptForm log = new ReceiptForm();
            this.Hide();
            log.Show();
        }

        private void guna2HtmlLabel9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuThinButton27_Click(object sender, EventArgs e)
        {
            TillForm log = new TillForm();
            this.Hide();
            log.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            this.Hide();
            log.Show();
        }
    }
}

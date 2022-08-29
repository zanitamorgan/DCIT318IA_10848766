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
    public partial class CategoryForm : Form
    {
        public CategoryForm()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\LENOVO\OneDrive\Documents\SIMSdb.mdf;Integrated Security=True;Connect Timeout=30");
        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                string query = "insert into CategoryTable values(" + CatIdDb.Text + ", '" + CatNameDb.Text + "','" + CatDescDb.Text + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Category Added Successfully");
                Con.Close();
                populate();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
private void populate()
        {
            Con.Open();
            string query = "Select * from CategoryTable";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            CatDGV.DataSource = ds.Tables[0]; 
            Con.Close();
        }
        private void CategoryForm_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void CatDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CatIdDb.Text = CatDGV.SelectedRows[0].Cells[0].Value.ToString();
            CatNameDb.Text = CatDGV.SelectedRows[0].Cells[1].Value.ToString();
            CatDescDb.Text = CatDGV.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if(CatIdDb.Text == "")
                {
                    MessageBox.Show("Select The Category To Delete");
                }
                else
                {
                    Con.Open();
                    string query = "Delete from CategoryTable where CatId =" + CatIdDb.Text + "";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Category Deleted Successfully");
                    Con.Close();
                    populate();
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if(CatIdDb.Text =="" || CatNameDb.Text =="" || CatDescDb.Text =="")
                {
                    MessageBox.Show("Missing Information");

                }
                else
                {
                    Con.Open();
                    string query = "Update CategoryTable set CatName='" + CatNameDb.Text + "', CatDesc='" + CatDescDb.Text + "' where CatId=" + CatIdDb.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Category Successfully Update");
                    Con.Close();
                    populate();
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CatDVG_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            Products prod = new Products();
            prod.Show();
            this.Hide();
        }

        private void CatNameDb_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            vendor log = new vendor();
            this.Hide();
            log.Show();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2HtmlLabel8_Click(object sender, EventArgs e)
        {
            vendor log = new vendor();
            this.Hide();
            log.Show();
        }
    }
}

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
    public partial class Products : Form
    {
        public Products()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\LENOVO\OneDrive\Documents\SIMSdb.mdf;Integrated Security=True;Connect Timeout=30");
        private void guna2HtmlLabel4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void fillcombo()
        {
            //This method binds the combobox with the database
            Con.Open();
            SqlCommand cmd = new SqlCommand("Select ProdName from ProductTable", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("ProdName", typeof(string));
            dt.Load(rdr);
            CatCb.ValueMember = "prodName";
            CatCb.DataSource = dt;
            Con.Close();
        }
        private void Products_Load(object sender, EventArgs e)
        {
            fillcombo();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            CategoryForm cat = new CategoryForm();
            cat.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                string query = "insert into ProductTable values(" + ProdId.Text + ", '" + ProdName.Text + "'," + ProdQty.Text + ", "+ProdPrice.Text+ ", '" +CatCb.SelectedValue.ToString() + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product Added Successfully");
                Con.Close();
                //populate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void populate()
        {
            Con.Open();
            string query = "Select * from ProductTable";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ProdGDV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void CProducts_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ProdId.Text = ProdGDV.SelectedRows[0].Cells[0].Value.ToString();
            ProdName.Text = ProdGDV.SelectedRows[0].Cells[1].Value.ToString();
            ProdQty.Text = ProdGDV.SelectedRows[0].Cells[2].Value.ToString();
            ProdPrice.Text = ProdGDV.SelectedRows[0].Cells[3].Value.ToString();
            CatCb.SelectedValue = ProdGDV.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (ProdId.Text == "")
                {
                    MessageBox.Show("Select The Product To Delete");
                }
                else
                {
                    Con.Open();
                    string query = "Delete from ProductTable where ProdId =" + ProdId.Text + "";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product Deleted Successfully");
                    Con.Close();
                    populate();
                }
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
                if (ProdId.Text == "" || ProdName.Text == "" || ProdQty.Text == "" || ProdPrice.Text == "")
                {
                    MessageBox.Show("Missing Information");

                }
                else
                {
                    Con.Open();
                    string query = "Update ProductTable set ProdName='" + ProdName.Text + "', ProdQty='" + ProdQty.Text + "', ProdPrice='" + ProdPrice.Text + "' where ProdId=" + ProdId.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product Successfully Update");
                    Con.Close();
                    populate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void guna2HtmlLabel8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {

        }

        private void ProdPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            vendor log = new vendor();
            this.Hide();
            log.Show();
        }

        private void guna2HtmlLabel4_Click_1(object sender, EventArgs e)
        {
            vendor log = new vendor();
            this.Hide();
            log.Show();
        }

        private void ProdId_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            this.Hide();
            log.Show();
        }
    }
}

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
    public partial class StockForm : Form
    {
        public StockForm()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\LENOVO\OneDrive\Documents\SIMSdb.mdf;Integrated Security=True;Connect Timeout=30");
        private void guna2HtmlLabel8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void getData()
        {
            Con.Open();
            string query = "select ProdName, ProdQty from ProductTable";
            SqlDataAdapter adapter = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            var ds = new DataSet();
            adapter.Fill(ds);
            StockDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void guna2TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel3_Click(object sender, EventArgs e)
        {
            vendor log = new vendor();
            this.Hide();
            log.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            vendor log = new vendor();
            this.Hide();
            log.Show();
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            TransactionForm log = new TransactionForm();
            this.Hide();
            log.Show();
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            getData();
        }
    }
}

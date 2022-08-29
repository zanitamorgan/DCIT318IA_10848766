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
using System.Drawing.Printing;

namespace DCIT318IA_10848766
{
    public partial class TransactionForm : Form
    {
        public TransactionForm()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\LENOVO\OneDrive\Documents\SIMSdb.mdf;Integrated Security=True;Connect Timeout=30");
        private void guna2HtmlLabel8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void populate()
        {
            Con.Open();
            string query = "select * from ReceiptTable";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            SalesDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void guna2TextBox6_TextChanged(object sender, EventArgs e)
        {

        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            ReceiptForm log = new ReceiptForm();
            this.Hide();
            log.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("SHOPRITE RECEIPT", new Font("Microsoft Sans Serif", 30, FontStyle.Bold), Brushes.Red, new Point(200, 50));

            e.Graphics.DrawString("Attendant:", new Font("Microsoft Sans Serif", 20, FontStyle.Bold), Brushes.Blue, new Point(50, 150));
            e.Graphics.DrawString("" + SalesDGV.SelectedRows[0].Cells[1].Value.ToString(), new Font("Microsoft Sans Serif", 20, FontStyle.Bold), Brushes.Blue, new Point(250, 150));

            e.Graphics.DrawString("Product:", new Font("Microsoft Sans Serif", 20, FontStyle.Bold), Brushes.Blue, new Point(50, 200));
            e.Graphics.DrawString("" + SalesDGV.SelectedRows[0].Cells[2].Value.ToString(), new Font("Microsoft Sans Serif", 20, FontStyle.Bold), Brushes.Blue, new Point(250, 200));

            e.Graphics.DrawString("Price:", new Font("Microsoft Sans Serif", 20, FontStyle.Bold), Brushes.Blue, new Point(50, 250));
            e.Graphics.DrawString("" + SalesDGV.SelectedRows[0].Cells[3].Value.ToString(), new Font("Microsoft Sans Serif", 20, FontStyle.Bold), Brushes.Blue, new Point(250, 250));

            e.Graphics.DrawString("Quantity:", new Font("Microsoft Sans Serif", 20, FontStyle.Bold), Brushes.Blue, new Point(50, 300));
            e.Graphics.DrawString("" + SalesDGV.SelectedRows[0].Cells[4].Value.ToString(), new Font("Microsoft Sans Serif", 20, FontStyle.Bold), Brushes.Blue, new Point(250, 300));

            e.Graphics.DrawString("Date:", new Font("Microsoft Sans Serif", 20, FontStyle.Bold), Brushes.Blue, new Point(50, 350));
            e.Graphics.DrawString("" + SalesDGV.SelectedRows[0].Cells[5].Value.ToString(), new Font("Microsoft Sans Serif", 20, FontStyle.Bold), Brushes.Blue, new Point(250, 350));

            e.Graphics.DrawString("Signature:", new Font("Microsoft Sans Serif", 20, FontStyle.Bold), Brushes.Blue, new Point(50, 400));
            e.Graphics.DrawString("" +SalesDGV.SelectedRows[0].Cells[6].Value.ToString(), new Font("Microsoft Sans Serif", 20, FontStyle.Bold), Brushes.Blue, new Point(250, 400));
        

    }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            vendor log = new vendor();
            this.Hide();
            log.Show();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            ReceiptForm log = new ReceiptForm();
            this.Hide();
            log.Show();
        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
            StockForm log = new StockForm();
            this.Hide();
            log.Show();
        }
    }
}

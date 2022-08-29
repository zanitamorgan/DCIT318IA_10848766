using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DCIT318IA_10848766
{
    public partial class ReceiptForm : Form
    {
        public ReceiptForm()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\LENOVO\OneDrive\Documents\SIMSdb.mdf;Integrated Security=True;Connect Timeout=30");
        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
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

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
            StockForm log = new StockForm();
            this.Hide();
            log.Show();
        }

        private void guna2HtmlLabel9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void ReceiptBt_Click(object sender, EventArgs e)
        {
            RecId.Text = "";
            AtName.Text = "";
            ProdSold.Text = "";
            QtySold.Text = "";
            PriceTb.Text = "";
            DateTb.Text = "";
            SignTb.Text = "";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                string query = "insert into ReceiptTable values ('" + RecId.Text + "' ,' " + AtName.Text + " ',' " + ProdSold.Text + " ',' " + QtySold.Text + " ',' " + PriceTb.Text + " ',' " + DateTb.Text + " ',' " + SignTb.Text + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Transaction Receipt Saved!");
                Con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString("SHOPRITE RECEIPT", new Font("Microsoft Sans Serif", 30, FontStyle.Bold), Brushes.Red, new Point(200, 50));

            e.Graphics.DrawString("Attendant:", new Font("Microsoft Sans Serif", 20, FontStyle.Bold), Brushes.Blue, new Point(50, 150));
            e.Graphics.DrawString("" + AtName.Text, new Font("Microsoft Sans Serif", 20, FontStyle.Bold), Brushes.Blue, new Point(250, 150));

            e.Graphics.DrawString("Product:", new Font("Microsoft Sans Serif", 20, FontStyle.Bold), Brushes.Blue, new Point(50, 200));
            e.Graphics.DrawString("" + ProdSold.Text, new Font("Microsoft Sans Serif", 20, FontStyle.Bold), Brushes.Blue, new Point(250, 200));

            e.Graphics.DrawString("Price:", new Font("Microsoft Sans Serif", 20, FontStyle.Bold), Brushes.Blue, new Point(50, 250));
            e.Graphics.DrawString("" + QtySold.Text, new Font("Microsoft Sans Serif", 20, FontStyle.Bold), Brushes.Blue, new Point(250, 250));

            e.Graphics.DrawString("Quantity:", new Font("Microsoft Sans Serif", 20, FontStyle.Bold), Brushes.Blue, new Point(50, 300));
            e.Graphics.DrawString("" + PriceTb.Text, new Font("Microsoft Sans Serif", 20, FontStyle.Bold), Brushes.Blue, new Point(250, 300));

            e.Graphics.DrawString("Date:", new Font("Microsoft Sans Serif", 20, FontStyle.Bold), Brushes.Blue, new Point(50, 350));
            e.Graphics.DrawString("" + DateTb.Text, new Font("Microsoft Sans Serif", 20, FontStyle.Bold), Brushes.Blue, new Point(250, 350));

            e.Graphics.DrawString("Signature:", new Font("Microsoft Sans Serif", 20, FontStyle.Bold), Brushes.Blue, new Point(50, 400));
            e.Graphics.DrawString("" + SignTb.Text, new Font("Microsoft Sans Serif", 20, FontStyle.Bold), Brushes.Blue, new Point(250, 400));
        }
    }

}

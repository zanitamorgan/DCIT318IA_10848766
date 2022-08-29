using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DCIT318IA_10848766
{
    public partial class TillForm : Form
    {
        

        public TillForm()
        {
            InitializeComponent();
        }

        int timeStart = 1;

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            StockForm log = new StockForm();
            this.Hide();
            log.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2HtmlLabel4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            TransactionForm log = new TransactionForm();
            this.Hide();
            log.Show();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timeStart > 0)
            {
                timeStart = timeStart + 1;
                TimerBox.Text = timeStart + "Seconds";
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            this.Hide();
            log.Show();
        }
    }
}

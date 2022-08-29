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
    public partial class Splashscrn : Form
    {
        public Splashscrn()
        {
            InitializeComponent();
        }
        int startpoint = 0;

        private void Myprogress_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
             startpoint += 1;
            Myprogress.Value = startpoint;
            if(Myprogress.Value == 100)
                {
                Myprogress.Value = 0;
                timer1.Stop();
                SignUp log = new SignUp();
                this.Hide();
                log.Show();
            }
        }

        private void Splashscrn_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}

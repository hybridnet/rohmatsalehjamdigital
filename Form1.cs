using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Time
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime aDate = DateTime.Now;
            txtDetik.Text = aDate.ToString("ss");
            txtMenit.Text = aDate.ToString("mm");
            txtJam.Text = aDate.ToString("HH");
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yuzde18
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayı1;
            double yuzdesi;
            sayı1 = Convert.ToInt16(textBox1.Text);
            yuzdesi = sayı1 * 0.18;
            label1.Text = yuzdesi.ToString();
        }
    }
}

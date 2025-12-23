using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sayaçlar
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        int sayı;
        private void button2_Click(object sender, EventArgs e)
        {
            
            sayı = Convert.ToInt32(textBox1.Text);
            sayı = sayı + 1;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            sayı = Convert.ToInt32(textBox1.Text);
            sayı = sayı - 1;
        }
    }
}

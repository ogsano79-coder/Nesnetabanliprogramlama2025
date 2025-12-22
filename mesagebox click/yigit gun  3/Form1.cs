using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yigit_gun__3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           // MessageBox.Show("merhaba bilisim", "form 1", MessageBoxButtons.YesNo);
            MessageBox.Show("merhaba bilisim","form 1",MessageBoxButtons.YesNo);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("tıkladın");
        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show("cift tıkladın","merhaba");
        }
    }
}

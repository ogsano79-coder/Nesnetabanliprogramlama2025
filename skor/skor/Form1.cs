using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace skor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte skor1, skor2;
            skor1=5;
            skor2 = 0;
            if (skor1 > skor2) ;
            MessageBox.Show("1. takım kazandı");
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uygulama16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double turkcedogru, matdogru;
            double turkceyanlıs, matyanlıs;
            double turkcenet, matnet;
            turkcedogru = Convert.ToDouble(textBox1.Text);
            turkceyanlıs = Convert.ToDouble(textBox2.Text);
            turkcenet = (turkcedogru - (turkceyanlıs / 4));
            textBox3.Text = turkcenet.ToString();
            matdogru = Convert.ToDouble(textBox4.Text);
            matyanlıs = Convert.ToDouble(textBox5.Text);
            matnet = (matdogru - (matyanlıs / 4));
            textBox6.Text = matnet.ToString();


        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            //xtBox4.Enabled = true;
        }
    }
}

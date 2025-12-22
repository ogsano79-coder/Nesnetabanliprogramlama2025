using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gun_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            MessageBox.Show("mouse uzerimde");
        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("buton 2ye tıklandı");
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            MessageBox.Show("mouse uzerimde degil");
        }
    }
}

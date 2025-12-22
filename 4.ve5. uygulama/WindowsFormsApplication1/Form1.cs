using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void webBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            listBox1.Items.Add(webBrowser1.Url);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(webBrowser1.Url);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(textBox1.Text);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            webBrowser1.GoHome();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }
    }
}

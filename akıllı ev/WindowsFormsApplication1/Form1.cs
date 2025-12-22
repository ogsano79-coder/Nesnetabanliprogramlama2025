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

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
            listBox1.Items.Add("lambalar açık");

            }
            else
            {
            listBox1.Items.Add("lambalar kapalı");
            }
            if (checkBox2.Checked == true)
            {
            listBox1.Items.Add("kombi açık");
            }  
            else 
            {
            listBox1.Items.Add("kombi kapalı");
            }

        }
    }
}

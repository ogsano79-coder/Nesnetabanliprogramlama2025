using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();                   
        }
        ArrayList sehirler = new ArrayList();  
        private void button1_Click(object sender, EventArgs e)
        {
            sehirler.Add(textBox1.Text);
            listele();     
        }
        private void listele()
        {
            listBox1.Items.Clear();
            foreach (string sehir in sehirler)
            {
                listBox1.Items.Add(sehir);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int indexno = listBox1.SelectedIndex;
            sehirler.Insert(indexno, textBox1.Text);
            listele();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int indexno = listBox1.SelectedIndex;
            sehirler[indexno] = textBox1.Text;
            listele();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int indexno = listBox1.SelectedIndex;
            sehirler.RemoveAt(indexno);
            listele();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (sehirler.Contains(textBox1.Text))
            {
                label3.Text = "aranan değer bulundu";
                listBox1.SelectedIndex = sehirler.IndexOf(textBox1.Text);
            }

            else
            {
                label3.Text = "aranan değer bulunamadı";
            }
        }



    }
}

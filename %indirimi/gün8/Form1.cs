using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gün8
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

            int etiketfiyat;
            double indirimfiyat;
            etiketfiyat = Convert.ToInt32(textBox1.Text);
            indirimfiyat = etiketfiyat - etiketfiyat * 0.10;
            label3.Text = indirimfiyat.ToString();
            
            
            
         
            
            
            
            /*int sayı1, sayı2,sonuc;
            sayı1 = 5;
            sayı2 = 10;
            sonuc = (sayı1 + sayı2) * 2 + 5;
            MessageBox.Show(sonuc.ToString());*/

        }

        private void button5_Click(object sender, EventArgs e)
        {
            int sayı1, sayı2, sonuc;
            sayı1 = 5;
            sayı2 = 10;
            sonuc = (sayı1 + sayı2) * 2 + 5;
            MessageBox.Show(sonuc.ToString());

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int etiketfiyat;
            double indirimfiyat;
            etiketfiyat = Convert.ToInt32(textBox1.Text);
            indirimfiyat = etiketfiyat - etiketfiyat * 0.25;
            label3.Text = indirimfiyat.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int etiketfiyat;
            double indirimfiyat;
            etiketfiyat = Convert.ToInt32(textBox1.Text);
            indirimfiyat = etiketfiyat - etiketfiyat * 0.50;
            label3.Text = indirimfiyat.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int etiketfiyat;
            double indirimfiyat;
            etiketfiyat = Convert.ToInt32(textBox1.Text);
            indirimfiyat = etiketfiyat - etiketfiyat * 0.75;
            label3.Text = indirimfiyat.ToString();
        }
    }
}

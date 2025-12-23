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

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int sayı1,sayı2,sayı3;
            sayı1 = Convert.ToInt32(TextBox1.Text);
            sayı2 = Convert.ToInt32(TextBox2.Text);
            sayı3 = Convert.ToInt32(TextBox3.Text);
            
            if (sayı1>sayı2 && sayı1>sayı3)

            {
                MessageBox.Show("sayı1 en büyük");
            }

            else if (sayı1 < sayı2 && sayı1 < sayı3)
            {
                MessageBox.Show("sayı1 en küçük");
            }

            else if (sayı2 > sayı1 && sayı2 > sayı3)
            {
                MessageBox.Show("sayı2 en büyük");
            }

            else if (sayı2 < sayı1 && sayı2 < sayı3)
            {
                MessageBox.Show("sayı2 en küçük");
            }
            else if (sayı3 > sayı1 && sayı3 > sayı2)

            {
                MessageBox.Show("sayı3 en büyük");
            }
            else if (sayı3 < sayı1 && sayı3 < sayı2)

            {
                MessageBox.Show("sayı3 en küçük");
            }
            else
            {
                MessageBox.Show("yanlış karakter");
            }
        }
    }
}

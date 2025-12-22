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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            decimal hesap = 0;
            if(tabControl1.SelectedIndex==2)
            {
             textBox4.Text="";
             textBox4.Text +=textBox1.Text+"\r\n";
             textBox4.Text +=textBox2.Text+"\r\n";
             textBox4.Text +=textBox3.Text+"\r\n";

             
             if (numericUpDown1.Value > 0)
             { 
                hesap += numericUpDown1.Value*12;
                textBox4.Text+= string.Format("Çorba {0:C}",numericUpDown1.Value * 12) + "\r\n";                
             }
             else if (numericUpDown2.Value > 0)
             {
                hesap += numericUpDown2.Value * 20;
                textBox4.Text += string.Format("salata {0:C}", numericUpDown2.Value * 20) + "\r\n";
             }
             else if (numericUpDown3.Value > 0)
             {
                 hesap += numericUpDown3.Value * 40;
                 textBox4.Text += string.Format("ana yemek {0:C}", numericUpDown3.Value * 40) + "\r\n";
             }
             else if (numericUpDown4.Value > 0)
             {
                 hesap += numericUpDown4.Value * 25;
                 textBox4.Text += string.Format("tatlı {0:C}", numericUpDown4.Value * 25) + "\r\n";
             }

               
               textBox4.Text += string.Format("Toplam {0:C}",hesap);               
            }
        }




    }
}

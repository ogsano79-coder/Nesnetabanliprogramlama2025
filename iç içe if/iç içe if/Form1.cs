using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iç_içe_if
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte not;
            not = Convert.ToByte(textBox1.Text);

            if (not >= 50)
            {
                     if (not >= 85)
                     {
                        textBox2.Text=("takdir belgesi aldınız");
                     }
                     else if (not >=70)
                     { 
                        textBox2.Text=("teşekkür belgesi aldınız");
                     }
                     else 
                     {
                       textBox2.Text=("belge almadan geçtiniz");
                     }





            }

            else
            {
                textBox2.Text=("sınıfta kaldıız");
            }

                
           }       
        }


}



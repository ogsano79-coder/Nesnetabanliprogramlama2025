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

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            DialogResult cevap = MessageBox.Show("çıkmak istediğinize eminmisiniz", "Çıkış", MessageBoxButtons.YesNo);
 
            if(cevap==DialogResult.Yes)
 
            {
                this.Close();
            }
 
            else if(cevap==DialogResult.No)

            {

                this.Activate();
 
            }
        }

        private void kesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Cut();
        }

        private void kopyalaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Copy();
        }

        private void yapıştırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Paste();

        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void herToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Undo();
        }

    }
}

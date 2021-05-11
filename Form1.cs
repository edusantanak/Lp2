using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            string stringona = txtFrase.Text.Trim();
            int total = 0;
            foreach (char letra in stringona)
            {
                if ((char.ToUpper(letra) == ' '))
                {
                    total += 1;
                }
            }
            MessageBox.Show(" a palavra " + txtFrase.Text + "tem " + total.ToString() + "Espaços em branco");
        }

        private void btnLetraR_Click(object sender, EventArgs e)
        {
            string stringona = txtFrase.Text.Trim();
            int total = 0;
            foreach (char letra in stringona)
            {
                if ((char.ToUpper(letra) == 'R'))
                {
                    total += 1;
                }
            }
            MessageBox.Show(" a palavra " + txtFrase.Text + "tem " + total.ToString() + " letras R");

        }



        private void button1_Click_1(object sender, EventArgs e)
        {










        }

        private void form2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 objFrm2 = new Form2();
          
            objFrm2.WindowState = FormWindowState.Maximized;
            objFrm2.Show();
        }

        private void form4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 objFrm4 = new Form4();
            
            objFrm4.WindowState = FormWindowState.Maximized;
            objFrm4.Show();
        }

        private void form5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 objFrm5 = new Form5();
            
            objFrm5.WindowState = FormWindowState.Maximized;
            objFrm5.Show();
        }
    }
}

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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a = txtFrase.Text.Trim();
            char[] arr = a.ToCharArray();
            Array.Reverse(arr);


            a = "";
            foreach (char c in arr)
            {
                a = a + c.ToString();

            }
            if (a == txtFrase.Text.Trim())
            { MessageBox.Show("A palavra é Palindroma"); }
            else { MessageBox.Show("A palavra não é palindroma"); }
            MessageBox.Show(a);



        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}

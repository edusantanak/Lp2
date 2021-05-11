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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double H;
            int i = 1,N;
            H = 0;
           
            N = Convert.ToInt16(txtNum.Text);
            for( i=1;i<=N;i++)
            {
                H = H +(double) 1 / i;
            }
            MessageBox.Show(""+H);
           

        }
    }
}

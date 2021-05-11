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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Double SalarioBruto =0;
            
            int Produçao = Convert.ToInt32(txtProduçao.Text);
            int  B = 0, C = 0, D = 0;
            double A = Convert.ToDouble(txtSalario);
            int Gratificaçao =0;
            
            if (Convert.ToDouble(txtProduçao) >= 100)
            {
                B = 1;
            }
            else { B = 0; }

            if (Produçao >= 120) { C = 1; }

            else { C = 0; }

            if (Produçao >= 150) { D = 1; }

            else { D = 0; }

            SalarioBruto = A+A*(0.05*B+0.1*C+0.1*D);
            MessageBox.Show("o salario bruto é =" + SalarioBruto);
            if (Convert.ToInt16(txtGratificaçao) >= 1)
            { Gratificaçao += 1; }

            if (Convert.ToDouble(txtProduçao) >= 150 || Gratificaçao >= 1)
            {
                SalarioBruto = SalarioBruto;
                MessageBox.Show("o salario bruto é =" + SalarioBruto);
            }
            else { MessageBox.Show("valor de produçao errado");   } 



        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Gratificaçao_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void txtGratificaçao_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

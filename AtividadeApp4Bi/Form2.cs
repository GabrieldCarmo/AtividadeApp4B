using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtividadeApp4Bi
{
    public partial class frmtabuada : Form
    {
        public frmtabuada()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            txtnum.Clear();
            txttabuada.Clear();

            int I = 1;
            int num, tab = 0;

            num = Convert.ToInt16(txtnum.Text);

            if (num >= 1 && num <= 9)
            {
                while (I <= 10)
                {
                    tab = num * I;
                    txttabuada.AppendText(num + " x " + I + " = " + tab + Environment.NewLine);
                    I++;
                }
            }
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtnum.Clear();
            txttabuada.Clear();
            txtnum.Focus();
        }
    }
}

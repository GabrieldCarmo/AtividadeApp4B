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

        private void btncalcular_Click(object sender, EventArgs e)
        {
            txttabuada.Clear();

            int I = 1;
            int num, tab = 0;

            num = Convert.ToInt16(txtnum.Text);

            if (num >= 1 && num <= 9)
            {
                while (I <= 10)
                {
                    tab = num * I;
                    txttabuada.Text += num + " x " + I + " = " + tab + "\r\n";
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

        private void btnsair_Click_1(object sender, EventArgs e)
        {
            Hide();
            frmmenu menu = new frmmenu();
            menu.Show();
        }

        private void btncalcularfor_Click(object sender, EventArgs e)
        {
            txttabuada.Clear();

            int I;
            int num, tab = 0;

            num = Convert.ToInt16(txtnum.Text);

            if (num >= 1 && num <= 9)
            {
                for (I = 1; I <= 10; I++)
                {
                    tab = num * I;
                    txttabuada.Text += num + " x " + I + " = " + tab + "\r\n";
                }
            }
        }

        private void btncalculardowhile_Click(object sender, EventArgs e)
        {
            {
                txttabuada.Clear();

                int I = 1;
                int num, tab = 0;

                num = Convert.ToInt16(txtnum.Text);

                if (num >= 1 && num <= 9)
                {
                    do
                    {
                        tab = num * I;
                        txttabuada.Text += num + " x " + I + " = " + tab + "\r\n";
                        I++;
                    } while (I <= 10);
                }
            }
        }
    }
}

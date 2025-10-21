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
    public partial class frmconversor : Form
    {
        public frmconversor()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            int I = 10;
            double F;

            txtconversor.Clear();

            while (I <= 100)
            {
                F = (I * 1.8) + 32;
                txtconversor.Text += I + "°C = " + F + "°F\r\n";
                I = I + 10;
            }
        }

        private void btncalculardowhile_Click(object sender, EventArgs e)
        {
            int I = 10;
            double F;

            txtconversor.Clear();

            do
            {
                F = (I * 1.8) + 32;
                txtconversor.Text += I + "°C = " + F + "°F\r\n";
                I = I + 10;
            } while (I <= 100);
        }

        private void btncalcularfor_Click(object sender, EventArgs e)
        {
            int I = 10;
            double F;

            txtconversor.Clear();

            for (I = 10; I <= 100; I = I + 10)
            {
                F = (I * 1.8) + 32;
                txtconversor.Text += I + "°C = " + F + "°F\r\n";
            }
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtconversor.Clear();
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            Hide();
            frmmenu menu = new frmmenu();
            menu.Show();
        }
    }
}

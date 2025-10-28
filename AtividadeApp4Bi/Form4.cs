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
    public partial class frmarea : Form
    {
        public frmarea()
        {
            InitializeComponent();
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            Hide();
            frmmenu menu = new frmmenu();
            menu.Show();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            int C, I=1;
            double lar, com, total=0, areac;

            C = Convert.ToInt16(txtcomodos.Text);

            while (I <= C) 
            {
                com = Convert.ToDouble(txtcom.Text);
                lar = Convert.ToDouble(txtlar.Text);

                areac = lar * com;

                total += areac;

                MessageBox.Show($"Área do {I}º cômodo: {areac} m²");

                txtlar.Clear();
                txtcom.Clear();

                I++;
            }

            txtareac.Text = total.ToString();
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtcom.Clear();
            txtcomodos.Clear();
            txtlar.Clear();
            txtcomodos.Focus();
        }
    }
}

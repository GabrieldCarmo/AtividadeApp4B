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
            int C, I;
            double lar, com, total, areac;

            C = Convert.ToInt16(txtcomodos.Text);

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

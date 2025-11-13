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
        double areatot = 0.0, lar = 0.0, com = 0.0, areaC = 0.0;
        DialogResult resultado = DialogResult.Yes;
        private void btncalcular_Click(object sender, EventArgs e)
        {
            lar = Convert.ToDouble(txtlargura.Text);
            com = Convert.ToDouble(txtcomp.Text);
            areaC = lar * com;
            areatot += areaC;
            txtareaco.Text = areaC.ToString();

            resultado = MessageBox.Show("Deseja adicionar as medidas de mais um cômodo?", "Continuar", MessageBoxButtons.YesNo);

            if (resultado == DialogResult.Yes)
            {
                txtlargura.Clear();
                txtcomp.Clear();
                txtareaco.Clear();
                txtlargura.Focus();
            }
            else if (resultado == DialogResult.No)
            {
                txtareatot.Text = areatot.ToString();
            }
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtareaco.Clear();
            txtareatot.Clear();
            txtcomp.Clear();
            txtlargura.Clear();
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            Hide();
            frmmenu menu = new frmmenu();
            menu.Show();
        }

        private void txtareaco_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

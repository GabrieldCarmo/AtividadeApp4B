namespace AtividadeApp4Bi
{
    public partial class frmmenu : Form
    {
        public frmmenu()
        {
            InitializeComponent();
        }

        private void programaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tabuadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            frmtabuada tabuada = new frmtabuada();
            tabuada.Show();
        }
    }
}

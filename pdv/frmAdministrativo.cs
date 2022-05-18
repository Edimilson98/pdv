namespace pdv
{
    public partial class frmAdministrativo : Form
    {
        public frmAdministrativo()
        {
            InitializeComponent();
        }

        private void usúariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuarios usuario = new frmUsuarios();
            usuario.ShowDialog();
   
        }
    }
}
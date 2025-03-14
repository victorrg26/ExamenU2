namespace ExamenU2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUsuarios Usuarios = new FrmUsuarios();
            Usuarios.Show();
        }
    }
}

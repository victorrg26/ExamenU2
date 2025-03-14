using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Acceso_Datos_New;

namespace ExamenU2
{
    public partial class FrmUsuarios : Form
    {
        public FrmUsuarios()
        {
            InitializeComponent();
        }
        private void ActualizaGrid()
        {
            Datos obj = new Datos();
            DataSet ds = obj.Consulta("SELECT Id, APaterno AS [Apellido Paterno], AMaterno AS [Apellido Materno], Nombre, Telefono, Correo FROM Usuarios");

            if (ds != null)
            {
                dgvUsuarios.DataSource = ds.Tables[0];
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            FrmCambiosUsuario actualiza = new FrmCambiosUsuario(
            dgvUsuarios[0, e.RowIndex].Value.ToString(),
            dgvUsuarios[1, e.RowIndex].Value.ToString(),
            dgvUsuarios[2, e.RowIndex].Value.ToString(),
            dgvUsuarios[3, e.RowIndex].Value.ToString(),
            dgvUsuarios[4, e.RowIndex].Value.ToString(),
            dgvUsuarios[5, e.RowIndex].Value.ToString()
        );
            actualiza.Show();
        }

        private void FrmUsuarios_Activated(object sender, EventArgs e)
        {
            ActualizaGrid();
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            ActualizaGrid();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmAgregarUsuario inse = new FrmAgregarUsuario();
            inse.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 menu = Application.OpenForms["Form1"] as Form1;
            if (menu != null)
            {
                menu.Show();
                this.Close();
            }
            else
            {
                menu = new Form1();
                menu.Show();
                this.Close();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }
    }
}

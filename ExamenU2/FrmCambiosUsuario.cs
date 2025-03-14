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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ExamenU2
{
    public partial class FrmCambiosUsuario : Form
    {
        public FrmCambiosUsuario(string Id, string APaterno, string AMaterno, string Nombre,
            string Telefono, string Correo)
        {
            InitializeComponent();

            txtId.Text = Id;
            txtAPaterno.Text = APaterno;
            txtAMaterno.Text = AMaterno;
            txtNombre.Text = Nombre;
            txtTelefono.Text = Telefono;
            txtCorreo.Text = Correo;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string aPaterno = txtAPaterno.Text;
            string aMaterno = txtAMaterno.Text;
            string nombre = txtNombre.Text;
            string telefonotx = txtTelefono.Text;
            string correo = txtCorreo.Text;
            string id = txtId.Text;

            try
            {
              

                long telefono = long.Parse(telefonotx);

                Datos datos = new Datos();
                bool f = datos.comando("UPDATE Usuarios SET APaterno='" + aPaterno + "', AMaterno='" + aMaterno +
                                      "', Nombre='" + nombre + "', Telefono='" + telefono + "', Correo='" +
                                      correo + "' WHERE Id='" + id + "'");

                if (f==true)
                {
                    MessageBox.Show("Datos actualizados", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al actualizar", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("El teléfono debe contener solo números", "Error de validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTelefono.Focus();
            }
            catch (OverflowException)
            {
                MessageBox.Show("El número de teléfono es demasiado largo", "Error de validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTelefono.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmCambiosUsuario_Load(object sender, EventArgs e)
        {

        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("¿Está seguro de eliminar el registro?",
               "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Datos datos = new Datos();
                bool f = datos.comando("DELETE FROM Usuarios WHERE Id='" + txtId.Text + "'");
                if (f == true)
                {
                    MessageBox.Show("Datos Eliminados", "Sistema",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al eliminar", "Sistema",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

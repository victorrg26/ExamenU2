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
    public partial class FrmAgregarUsuario : Form
    {
        public FrmAgregarUsuario()
        {
            InitializeComponent();
        }



        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string aPaterno = txtAPaterno.Text;
            string aMaterno = txtAMaterno.Text;
            string nombre = txtNombre.Text;
            string telefonotx = txtTelefono.Text;
            string correo = txtCorreo.Text;

            try
            {
                long telefono = long.Parse(telefonotx);

                Datos datos = new Datos();
                bool f = datos.comando("INSERT INTO Usuarios (APaterno, AMaterno, Nombre, Telefono, Correo) " +
                                      "VALUES ('" + aPaterno + "', '" + aMaterno + "', '" + nombre + "', '" +
                                      telefono + "', '" + correo + "')");

                if (f)
                {
                    MessageBox.Show("Datos insertados", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al insertar", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}

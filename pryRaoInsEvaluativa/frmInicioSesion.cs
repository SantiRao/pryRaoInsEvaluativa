using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace pryRaoInsEvaluativa
{
    public partial class frmInicioSesion : Form
    {
        public frmInicioSesion()
        {
            InitializeComponent();
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            if (txtUsuario.Text != "")
            {
                txtContraseña.Enabled = true;

            }
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
            if (txtContraseña.Text != "")
            {
                btnIniciarSesion.Enabled = true;
            }
        }

        int intentos = 0;

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            string Usuario = txtUsuario.Text;
            string Contraseña = txtContraseña.Text;

            if (clsUsuario.Login(Usuario, Contraseña))
            {
                clsUsuario UsuarioActual = new clsUsuario
                {
                    Usuario = Usuario,
                    Contraseña = Contraseña
                    
                };

                UsuarioActual.Username = Usuario;

                clsUsuario.RegistroLogin(Usuario);
                MessageBox.Show("Inicio de Sesion Exitoso!");
                this.Hide();
                frmMain d = new frmMain();
                d.ShowDialog();

            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                intentos++;
                MessageBox.Show(intentos + " de 3 intentos");

                txtUsuario.Clear();
                txtContraseña.Clear();

            }

            if (intentos > 3)
            {
                MessageBox.Show("Intente de nuevo en 24hs");
                txtUsuario.Enabled = false;
            }
        }
    }
}

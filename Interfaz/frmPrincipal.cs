using Negocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaz
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

         private void crearUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // muestra la pantalla para crear un usuario

                frmCrearUsuario pantalla = new frmCrearUsuario();
                pantalla.MdiParent = this;
                pantalla.Show();
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message);
            }
        }//fin crearUsuarioToolStripMenuItem_Click

        private void verUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // muestra la pantalla para consultar un usuario

                frmConsultarUsuarios pantalla = new frmConsultarUsuarios();
                pantalla.MdiParent = this;
                pantalla.Show();
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message);
            }
        }

        private void cambiarContraseñaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // muestra la pantalla para Cambiar contraseña

                frmCambiarPassword pantalla = new frmCambiarPassword();
                pantalla.MdiParent = this;
                pantalla.Show();
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message);
            }
        }

        private void cambiarEstadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // muestra la pantalla para Cambiar contraseña

                frmCambiarEstado pantalla = new frmCambiarEstado();
                pantalla.MdiParent = this;
                pantalla.Show();
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message);
            }
        }

        private void mnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }//fin class
}//fin space


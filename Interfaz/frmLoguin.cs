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
    public partial class frmLoguin : Form
    {
        public frmLoguin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {

        }

        private void LlblCrearUsu_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmCrearUsuario frmCrearU = new frmCrearUsuario();
            frmCrearU.Show();
            this.Hide();
        }
    }
}

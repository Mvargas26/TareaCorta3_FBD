using Negocios;
using System; 
using System.Data; 
using System.Windows.Forms;

namespace Interfaz
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void LlblCrearUsu_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmCrearUsuario frmCU = new frmCrearUsuario();
            frmCU.Show();
            this.Hide();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {

        }
    }
}

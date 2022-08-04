using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocios;

namespace Interfaz
{
    public partial class frmCrearUsuario : Form
    {
        public frmCrearUsuario()
        {
            InitializeComponent();
        }
        Negocios_MySQL objNegocios = new Negocios_MySQL();
        private void btnAgregarU_Click(object sender, EventArgs e)
        {
            String Query = "insert into usuario(Nombre, Apellidos, Usuario, Contrasena, Estado) values('" + txtNombre.Text + "','" + txtApellidos.Text + "','" + txtUsuario.Text + "','" + txtContrasena.Text + "');";
            objNegocios.CreateUsu(Query);
            MessageBox.Show("El usuario se creo correctamente");
        }
    }
}

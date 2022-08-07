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
        //VARIABLES GlOBALES
        Negocios_MySQL objNegocios = new Negocios_MySQL();
        DataTable dt_Usuarios = new DataTable();//tendra la info que viene desde la BD
        Usuario obj_Usuario = new Usuario();//objeto de la Clase Usuario(Andres)
        private void btnAgregarU_Click(object sender, EventArgs e)
        {
            try
            {
                //Validaciones
               while (txtNombre.Text == "")
                {
                    MessageBox.Show("El Nombre es requerido");
                    return;
                }
                while (txtApellidos.Text == "")
                {
                    MessageBox.Show("El Apellido es requerido");
                    return;
                }
                while (txtUsuario.Text == "")
                {
                    MessageBox.Show("El Usuario es requerido sin espacios");
                    return;
                }
                while (txtContrasena.Text == "")
                {
                    MessageBox.Show("La contraseña es requerida");
                    return;
                }
                while (txtConfContra.Text == "")
                {
                    MessageBox.Show("Favor confirmar la contraseña");
                    return;
                }
                while (txtConfContra.Text != txtContrasena.Text)
                {
                    MessageBox.Show("La contraseña y la confirmacion son Distintas");
                    return;
                }
                //este ciclo valida que el ID no este en uso
                foreach (DataRow fila in dt_Usuarios.Rows)
                {
                    if (txtIdentificacion.Text.Equals(fila["Id"].ToString()))
                    {
                        MessageBox.Show("Ese id ya pertenece a otro Usuario, porfavor indique otro.");
                        return;
                    }
                 }
                //fin validaciones

                //cargamos nuesto obj Usuario con la info
                obj_Usuario.PId = Convert.ToInt32(txtIdentificacion.Text);
                obj_Usuario.PNombre = txtNombre.Text;
                obj_Usuario.PApellidos = txtApellidos.Text;
                obj_Usuario.PUsuario = txtUsuario.Text;
                obj_Usuario.PContrasena = txtContrasena.Text;
                obj_Usuario.PEstado = Convert.ToInt16(0);

                //se envia el query con los atributos del objeto cliente
                String Query = "insert into usuario(Id,Nombre, Apellidos, Usuario, Contrasena, Estado) values(" + obj_Usuario.PId + ",'" +
                    obj_Usuario.PNombre + "','" + obj_Usuario.PApellidos + "','" + obj_Usuario.PUsuario + "','" + obj_Usuario.PContrasena +"',"+
                    obj_Usuario.PEstado +");";

                objNegocios.QueryMySQLNegocios_DT(Query);
                MessageBox.Show("El usuario se creo correctamente");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCrearUsuario_Load(object sender, EventArgs e)
        {
            try
            {
                dt_Usuarios = objNegocios.QueryMySQLNegocios_DT("Select * from usuario");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }//fin load

    }//fin class
}//fin space

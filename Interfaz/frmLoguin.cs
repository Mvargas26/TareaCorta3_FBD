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
    public partial class frmLoguin : Form
    {
        public frmLoguin()
        {
            InitializeComponent();
        }

        //VARIABLES GLOBALES
        Negocios_MySQL objNegocios = new Negocios_MySQL();
        DataTable dt_Usuarios = new DataTable();//tendra la info que viene desde la BD
        Boolean UserValido = false;

        private void frmLoguin_Load(object sender, EventArgs e)
        {
            try
            {
                dt_Usuarios = objNegocios.QueryMySQLNegocios_DT("Select * from usuario");

                //se recorre el DT con los usuarios para agregar el ususario al combo
                foreach (DataRow fila in dt_Usuarios.Rows)
                {
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }//fin load

        private void chk_Ver_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (chk_Ver.Checked)
                {
                    this.txtContrasena.UseSystemPasswordChar = false;
                }
                else
                {
                    this.txtContrasena.UseSystemPasswordChar = true;
                }

            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message);
            }
        }//fin chk_Ver_CheckedChanged

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                //validaciones
                while (txtusuario.Text == "")
                {
                    MessageBox.Show("El Usuario es requerido");
                    return;
                }

                while (txtContrasena.Text == "")
                {
                    MessageBox.Show("El Password es requerido");
                    return;
                }

                foreach (DataRow fila in dt_Usuarios.Rows)
                {
                    if (fila["Usuario"].ToString().Equals(txtusuario.Text))
                    {
                        if ( !fila["Estado"].ToString().Equals("1"))
                        {
                            MessageBox.Show("El usuario Existe pero esta inactivo");
                            return;
                        }

                        if (fila["Contrasena"].ToString().Equals(txtContrasena.Text))
                        {
                            UserValido = true;
                            break;
                        }
                    }
                }

                if (UserValido == true)
                {
                    MessageBox.Show("Usuario Valido");
                    this.Close();
                }
                else 
                {
                    MessageBox.Show("Las credenciales del Usuario son incorrectas");
                    return;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }//fin btnIngresar_Click

    }//fin class
}//fin space

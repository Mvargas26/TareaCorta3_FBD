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
    public partial class frmCambiarPassword : Form
    {
        public frmCambiarPassword()
        {
            InitializeComponent();
        }

        //VARIABLES GLOBALES
        Negocios_MySQL objNegocios = new Negocios_MySQL();
        DataTable dt_Usuarios = new DataTable();//tendra la info que viene desde la BD

        private void frmCambiarPassword_Load(object sender, EventArgs e)
        {
            try
            {
                dt_Usuarios = objNegocios.QueryMySQLNegocios_DT("Select * from usuario");

                //se recorre el DT con los usuarios para agregar el ususario al combo
                foreach (DataRow fila in dt_Usuarios.Rows)
                {
                    //agrega un item por cada fila en la columna Usuario
                    cmblistaUsuarios.Items.Add(fila["Usuario"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }//fin load

        private void chkMostrarAnterior_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (chkMostrarAnterior.Checked)
                {
                    this.txtPasswordAnterior.UseSystemPasswordChar = false;
                }
                else
                {
                    this.txtPasswordAnterior.UseSystemPasswordChar = true;
                } 
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message);
            }
        }//fin passw ant

        private void chkNuevoPass_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (chkNuevoPass.Checked)
                {
                    this.txtPasswordNuevo.UseSystemPasswordChar = false;
                }
                else
                {
                    this.txtPasswordNuevo.UseSystemPasswordChar = true;
                }

            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message);
            }
        }//fin nuevo pass

        private void chkConfirmar_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (chkConfirmar.Checked)
                {
                    this.txtConfirmarPassword.UseSystemPasswordChar = false;
                }
                else
                {
                    this.txtConfirmarPassword.UseSystemPasswordChar = true;
                } 
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }//fin btn cancelar

        private void btnCambioPassword_Click(object sender, EventArgs e)
        {
        try 
         { 
            //validaciones

            while (cmblistaUsuarios.Text == "")
            {
                MessageBox.Show("Aun no seleciona el Usuario de la Lista");
                return; 
            } 
            while (txtPasswordAnterior.Text == "")
            {
                MessageBox.Show("Contraseña anterior requerida");
                return; 
            }

            while (txtPasswordNuevo.Text == "")
            {
                MessageBox.Show("Contraseña  nueva requerida");
                return; 
            }

            while (txtConfirmarPassword.Text == "")
            {
                MessageBox.Show("Confirmar Contraseña es requerido");
                return; 
            }

            while (txtConfirmarPassword.Text != txtPasswordNuevo.Text)
            {
                MessageBox.Show("La contraseña y la confirmacion son distintas");
                return; 
            }

            foreach(DataRow fila in dt_Usuarios.Rows)
                {
                    if (fila["Usuario"].ToString().Equals(cmblistaUsuarios.Text))
                    {
                        if(fila["Contrasena"].ToString() != txtPasswordAnterior.Text)
                        {
                            MessageBox.Show("La contraseña actual no es igual a la que usted ingreso como anterior");
                            return;
                        }
                    }
                }
                //FIN VALIDACIONES
                String passwordNew = txtPasswordNuevo.Text;
                String UsuarioElegido = cmblistaUsuarios.Text;
                objNegocios.QueryMySQLNegocios_DT(" UPDATE usuario SET Contrasena = '" + passwordNew +
                    "'  WHERE Usuario = '"+ UsuarioElegido + "';");

                MessageBox.Show("La contraseña se modifico Correctamente");
                this.Close();
         }
        catch (Exception ex)
         {
            MessageBox.Show(ex.Message);
         }
        }

        private void cmblistaUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                foreach (DataRow fila in dt_Usuarios.Rows)
                {
                    if (fila["Usuario"].ToString().Equals(cmblistaUsuarios.Text))
                    {
                        txtUserModif.Text = fila["Id"].ToString();
                    } 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }//fin cmblistaUsuarios_SelectedIndexChanged
    }//fin class
}//fin space

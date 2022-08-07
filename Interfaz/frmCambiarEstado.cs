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
    public partial class frmCambiarEstado : Form
    {
        public frmCambiarEstado()
        {
            InitializeComponent();
        }
        //VARIABLES GLOBALES
         Negocios_MySQL objNegocios = new Negocios_MySQL();
        DataTable dt_Usuarios = new DataTable();//tendra la info que viene desde la BD
        private void frmCambiarEstado_Load(object sender, EventArgs e)
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardarEstado_Click(object sender, EventArgs e)
        {
            try
            {
                //VALIDACIONES
                while (cmblistaUsuarios.Text == "")
                {
                    MessageBox.Show("Aun no seleciona el Usuario de la Lista");
                    return;
                }
                while (cmbNuevoEstado.Text == "")
                {
                    MessageBox.Show("Aun no seleciona el Nuevo Estado");
                    return;
                }
                //FIN VALIDACIONES

                byte estadoBit = 0;
                String UsuarioElegido = cmblistaUsuarios.Text;//guarda el usuario q se eligio

                //si selecionaron activo mandamos un 1
                if (cmbNuevoEstado.Text.Equals("Activo"))
                {
                    estadoBit = 1;
                }
                else
                {
                    estadoBit = 0;
                }

                objNegocios.QueryMySQLNegocios_DT(" UPDATE usuario SET Estado = " + estadoBit +
                   "   WHERE Usuario = '" + UsuarioElegido + "';");

                MessageBox.Show("El estado se modifico Correctamente");
                this.Close(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }//fin btnGuardarEstado_Click
    }//fin class
}//fin space

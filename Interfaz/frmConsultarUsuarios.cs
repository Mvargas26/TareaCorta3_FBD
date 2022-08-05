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
    public partial class frmConsultarUsuarios : Form
    {
        public frmConsultarUsuarios()
        {
            InitializeComponent();
        }
        //VARIABLES GLOBALES
        Negocios_MySQL objNegocios = new Negocios_MySQL();
        DataTable dt_Usuarios = new DataTable();//tendra la info que viene desde la BD
        private void frmConsultarUsuarios_Load(object sender, EventArgs e)
        {
            try
            {
                //cargamos la informacion de la tabla en la base de datos a un Data table
                dt_Usuarios = objNegocios.QueryMySQLNegocios_DT("Select * from usuario");

                //limpiamos el data grid a usar
                dgvUsuarios.DataSource = null;
                dgvUsuarios.Columns.Clear();
                dgvUsuarios.Rows.Clear();

                //aqui lo cargamos
                dgvUsuarios.DataSource = dt_Usuarios;
                dgvUsuarios.Update();
                dgvUsuarios.ReadOnly = true;
                dgvUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }//fin load

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                //limpiamos el data grid a usar
                dgvUsuarios.DataSource = null;
                dgvUsuarios.Columns.Clear();
                dgvUsuarios.Rows.Clear();


                //columnas manualmente
                dgvUsuarios.ColumnCount = 6;

                dgvUsuarios.Columns[0].Name = "Id";
                dgvUsuarios.Columns[1].Name = "Nombre";
                dgvUsuarios.Columns[2].Name = "Apellidos";
                dgvUsuarios.Columns[3].Name = "Usuario";
                dgvUsuarios.Columns[4].Name = "Contrasena";
                dgvUsuarios.Columns[5].Name = "Estado";

                foreach ( DataRow fila in dt_Usuarios.Rows)
                {
                    if (txtUsuarioBuscar.Text == fila["Usuario"].ToString())
                    {
                        dgvUsuarios.Rows.Add(fila["ID"], fila["Nombre"], fila["Apellidos"], fila["Usuario"], fila["Contrasena"], fila["Estado"]);
                    } 
                }

                //aqui recorremos el data grid ya cargado para cambiar el estado de 1 a activo
                foreach (DataGridViewRow dr in dgvUsuarios.Rows)
                {
                    if (dr.Cells["Estado"].Value.ToString().Equals("1"))
                    {
                        dr.Cells["Estado"].Value = "Activo";
                    }
                    else
                    {
                        dr.Cells["Estado"].Value = "Inactivo";
                    }
                  
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }//fin btnBsucar
        }


        private void LimpiarTodo()
        {
            //limpiamos el data grid a usar
            dgvUsuarios.DataSource = null;
            dgvUsuarios.Columns.Clear();
            dgvUsuarios.Rows.Clear();

            txtUsuarioBuscar.Text = "";
        }//fin metodo que limpia los campos y el data grid

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            try
            {
                LimpiarTodo();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }//fin class
}//fin space

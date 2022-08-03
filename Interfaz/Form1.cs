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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProbar_Click(object sender, EventArgs e)
        {
            try
            {
                Negocios_MySQL objNego = new Negocios_MySQL();
                DataTable dt = new DataTable();

                //primero limpiamos el data grid
                dgvPrueba.DataSource = null;
                dgvPrueba.Columns.Clear();
                dgvPrueba.Rows.Clear();

                dt = objNego.QueryMySQLNegocios_DT("SELECT * FROM usuarios_db.usuario;");

                dgvPrueba.DataSource = dt;
                dgvPrueba.Update();
                dgvPrueba.ReadOnly = true;
                dgvPrueba.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

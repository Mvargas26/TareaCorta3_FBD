using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Datos_MySQL
    {
        MySqlConnection mySQLconector = new MySqlConnection();
        public Datos_MySQL() //constructor
        {
            try
            {
                StringBuilder StrConexionArmado = new StringBuilder();

                StrConexionArmado.Append("Server=");
                StrConexionArmado.Append(ConfigurationManager.AppSettings["ServerName"]);
                StrConexionArmado.Append("; port=");
                StrConexionArmado.Append(ConfigurationManager.AppSettings["Port"]);
                StrConexionArmado.Append("; User id=");
                StrConexionArmado.Append(ConfigurationManager.AppSettings["User"]);
                StrConexionArmado.Append("; Password=");
                StrConexionArmado.Append(ConfigurationManager.AppSettings["Password"]);
                StrConexionArmado.Append("; DataBase=");
                StrConexionArmado.Append(ConfigurationManager.AppSettings["DataBase"]);
                StrConexionArmado.Append(";");

                this.mySQLconector = new MySqlConnection(StrConexionArmado.ToString());
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }//fin costructor

        /// <summary>
        /// Funcion que realiza la consulta a una tabla especifica
        /// </summary>
        /// <param name="QueryDelUsuario">Trae la consulta en un String desde interfaz</param>
        /// <returns></returns>
        public DataTable QueryMySQL_DT(String QueryDelUsuario)
        {
            try
            {
                MySqlCommand cmd = mySQLconector.CreateCommand();

                cmd.CommandText = QueryDelUsuario;
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dtdatos = new DataTable();

                mySQLconector.Open();

                adapter.Fill(dtdatos);



                return dtdatos;
            }
            catch (MySqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                mySQLconector.Close();
            }
        }//fin query 
    }//fin class
}//fin namespace

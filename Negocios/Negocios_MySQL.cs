using Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios
{
   public  class Negocios_MySQL
    {
      
        public DataTable QueryMySQLNegocios_DT(String QueryUserNegociosMySQL)
        {
            try
            {
                Datos_MySQL objDatos = new Datos_MySQL();

                return objDatos.QueryMySQL_DT(QueryUserNegociosMySQL);
            }
            catch (Exception Error)
            {
                throw new Exception(Error.Message);
            }
        }//fin metodo QueryMySQLNegocios_DT

        public void CreateUsu(String QueryUser)
        {
            try
            {
                Datos_MySQL objDatos = new Datos_MySQL();
                objDatos.InsertUsu(QueryUser);
            }
            catch (Exception Error)
            {
                throw new Exception(Error.Message);
            }
        }
    }//fin class
}//fin space

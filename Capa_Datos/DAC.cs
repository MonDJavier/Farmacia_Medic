using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Capa_Datos
{
    public class DAC
    {
        //8creamos la cadena de conexion
        private SqlConnection Conexion = new SqlConnection("Data Source=192.168.100.69;Initial Catalog=LogCMWF;Integrated Security=True");

        //metodo de apertura y cierre de conexion

        public SqlConnection abrir_conexion()
        {
            if (Conexion.State == ConnectionState.Closed)
            {
                Conexion.Open();
            }
            return Conexion;
        }
        public SqlConnection cerrar_conexion()
        {
            if (Conexion.State == ConnectionState.Open)
            {
                Conexion.Close();
            }
            return Conexion;
        }
    }

}

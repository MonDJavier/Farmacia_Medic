using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatosPrueba
{
    public class Class1
    {

        private SqlCommand cmdSP;
        private SqlConnection Conexion = new SqlConnection(@"Data Source=DESKTOP-VJ244OG\SQLEXPRESS;Initial Catalog=bd_farmacia;Integrated Security=True");

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

        public void PrepararSP(String sp)
        {
            //procedimiento almacenado
            cmdSP.Connection = abrir_conexion();
            cmdSP.CommandType = CommandType.StoredProcedure;
            cmdSP.CommandText = sp;
        }

        public void AddParametro(String param, String valor)
        {
            SqlParameter par = new SqlParameter();
            par.ParameterName = param;
            par.Value = valor;
            cmdSP.Parameters.Add(par);
        }

        public void ejecutarSP()
        {
            SqlDataReader spResult;
            cmdSP.Prepare();
            spResult = cmdSP.ExecuteReader();
        }

        public void ejecutarSQL(String s, String nTable, DataSet ds)
        {
            SqlDataAdapter sqlAdapter;
            sqlAdapter = new SqlDataAdapter(s, abrir_conexion());
            sqlAdapter.Fill(ds, nTable);
            cerrar_conexion();
        }
    }
}

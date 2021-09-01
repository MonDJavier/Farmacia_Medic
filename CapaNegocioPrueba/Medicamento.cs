using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocioPrueba
{
    public class Medicamento : CapaDatosPrueba.Class1
    {
        #region Atributos

        private int cod_med;
        private string nombre;
        private double precio;
        private string foto;
        private int stock;
        private int cod_cat;
        #endregion 

        #region Constructor

        public Medicamento()
        {
            cod_med = 0;
            nombre = string.Empty;
            precio = 0;
            stock = 0;

        }

        #endregion 

        #region Propiedades
        public int Codigo
        {
            get { return this.cod_med; }
            set { this.cod_med = value; }
        }

        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }

        public double Precio
        {
            get { return this.precio; }
            set { this.precio = value; }
        }

        public int Stock
        {
            get { return this.stock; }
            set { this.stock = value; }
        }

        public int Cod_categoria
        {
            get { return this.cod_cat; }
            set { this.cod_cat = value; }
        }
        public Byte[] xfoto
        {
            get { return this.xfoto; }
            set { this.xfoto = value; }
        }
        #endregion 

        #region 
        public void guardar()
        {

            PrepararSP("insertarMedicamento");
            AddParametro("@nombre", nombre);
            AddParametro("@precio", precio.ToString());
            AddParametro("@foto", xfoto.ToString());
            AddParametro("@stock", stock.ToString());
            AddParametro("@cod_cat", cod_cat.ToString());
            ejecutarSP();
        }
        #endregion

        public DataSet llamarMedicamento(string criterio, string key)
        {
            string s;
            DataSet ds = new DataSet();
            s = "select cod_med, nombre, precio,stock from medicamento  where nombre like'" + criterio + "%' and cod_cat=" + key + "";
            ejecutarSQL(s, "tm", ds);
            return ds;
        }

        public DataSet buscarPorNombre(String criterio)
        {
            string s;
            s = "select  cod_med, nombre,precio,foto, stock from medicamento where nombre like '" + criterio + "%'";
            DataSet ds = new DataSet();
            ejecutarSQL(s, "tm", ds);
            return ds;

        }
    }
}

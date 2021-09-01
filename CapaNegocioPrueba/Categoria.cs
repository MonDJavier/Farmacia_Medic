using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaNegocioPrueba
{
    public class Categoria
    {
        #region atributos

        private int cod_cat;
        private string nombre;

        #endregion 


        #region constructor

        public Categoria()
        {
            cod_cat = 0;
            nombre = string.Empty;
        }

        #endregion 


        #region Propiedades

        public int Codigo
        {
            get { return this.cod_cat; }
            set { this.cod_cat = value; }
        }

        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }
        #endregion


    }
}

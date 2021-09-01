using CapaDatosPrueba;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocioPrueba
{
    public class Ajuste
    {
        DataClasses1DataContext linq = new DataClasses1DataContext();
        #region Atributos

        private int cod_ajt;
        private DateTime fecha;
        private string observacion;

        #endregion

        #region Constructor

        public Ajuste()
        {
            cod_ajt = 0;
            fecha = DateTime.Today.Date;
            observacion = string.Empty;
        }

        #endregion 

        #region Propiedades
        public int Codigo
        {
            get { return this.cod_ajt; }
            set { this.cod_ajt = value; }
        }

        public DateTime Fecha
        {
            get { return this.fecha; }
            set { this.fecha = value; }
        }

        public string Observacion
        {
            get { return this.observacion; }
            set { this.observacion = value; }
        }


        #endregion 
    }
}

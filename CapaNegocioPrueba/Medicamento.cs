using CapaDatosPrueba;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocioPrueba
{
    public class Medicamento 
    {
        DataClasses1DataContext linq = new DataClasses1DataContext();

        public void MostrarMedicamento()
        {
            linq.mostrarMedicamentos();
        }


        public void AgregarMedicamento(string med_nombre, Decimal med_precio, int med_stock,int cat_cod)
        {
            linq.insertarMedicamento(med_nombre,med_precio,med_stock,cat_cod);
        }
        public void ModificarMedicamento(int med_cod,string med_nombre, Decimal med_precio, int med_stock, int cat_cod)
        {
            linq.modificarMedicamento(med_cod,med_nombre,med_precio,med_stock,cat_cod);
        }
        public void EliminarMedicamento(int med_cod)
        {
            linq.eliminarMedicamento(Convert.ToInt32(med_cod));
        }
    }
}

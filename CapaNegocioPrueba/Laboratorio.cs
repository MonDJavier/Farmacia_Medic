using CapaDatosPrueba;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaNegocioPrueba
{
    public class Laboratorio 
    {
        DataClasses1DataContext linq = new DataClasses1DataContext();

        public void MostrarLaboratorio()
        {
            linq.mostrarLaboratorio();
        }


        public void AgregarLaboratorio(string lab_nombre, string lab_dirrecion, string lab_telefono, string lab_email, string lab_web)
        {
            linq.insertarLaboratorio(lab_nombre,  lab_dirrecion, lab_telefono, lab_email,  lab_web);
        }
        public void ModificarLaboratorio(int lab_cod, string lab_nombre, string lab_dirrecion, string lab_telefono, string lab_email, string lab_web)
        {
            linq.modificar_laboratorio(lab_cod, lab_nombre, lab_dirrecion, lab_telefono, lab_email, lab_web);
        }
        public void EliminarLaboratorio(int lab_cod)
        {
            linq.eliminarLaboratorio(Convert.ToInt32(lab_cod));
        }


    }
}

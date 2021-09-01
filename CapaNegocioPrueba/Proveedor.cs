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
    public class Proveedor 
    {
        DataClasses1DataContext linq = new DataClasses1DataContext();

        public void MostrarProveedores()
        {
            linq.mostrarProveedor();
        }


        public void AgregarProveedor(string prove_nombre, string prove_nit, string prove_direccion, string prove_telefono, int lab_cod)
        {
            linq.insertarProveedor(prove_nombre, prove_nit, prove_direccion, prove_telefono, lab_cod);
        }
        public void ModificarProveedor(int prove_cod, string prove_nombre, string prove_nit, string prove_direccion, string prove_telefono)
        {
            linq.modificarProveedor(prove_cod, prove_nombre, prove_nit, prove_direccion, prove_telefono);
        }
        public void EliminarProveedor(int prove_cod)
        {
            linq.eliminarProveedor(Convert.ToInt32(prove_cod));
        }

    }
}

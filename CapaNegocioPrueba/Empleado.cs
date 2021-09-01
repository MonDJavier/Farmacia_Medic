using CapaDatosPrueba;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaNegocioPrueba
{
    public class Empleado 
    {
        DataClasses1DataContext linq = new DataClasses1DataContext();

        public void MostrarEmpleado()
        {
            linq.mostrarEmpleado();
        }


        public void AgregarEmpleado(string emp_nombre, string emp_paterno, string emp_materno, string emp_direccion, string emp_telefono, string emp_contraseña)
        {
            linq.insertarEmpleado( emp_nombre,emp_paterno,  emp_materno,  emp_direccion, emp_telefono, emp_contraseña);
        }
        public void ModificarEmpleado(string emp_nombre, string emp_paterno, string emp_materno, string emp_direccion, string emp_telefono, string emp_contraseña, int emp_ci)
        {
            linq.modificarEmpleado(emp_ci , emp_nombre, emp_paterno,  emp_materno,  emp_direccion, emp_telefono, emp_contraseña);
        }
        public void EliminarEmpleado(int emp_ci)
        {
            linq.eliminarEmpleado(Convert.ToInt32(emp_ci));
        }
        
        
    }
}

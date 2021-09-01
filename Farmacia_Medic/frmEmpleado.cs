using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using CapaDatosPrueba;
using CapaNegocioPrueba;


namespace Farmacia_Medic
{
    public partial class frmEmpleado : Form
    {
        DataClasses1DataContext linq = new DataClasses1DataContext();
        Empleado objeto = new Empleado();
        public frmEmpleado()
        {
            InitializeComponent();

        }

        public void Limpiar()
        {
            txtdireccion.Clear();
            txtpaterno.Clear();
            txtmaterno.Clear();
            txttelefono.Clear();
            txtnombre.Clear();
            txtContra.Clear();
        }
        
        private void cargarEmpleado()
        {
            dgempleado.DataSource = linq.mostrarEmpleado();
        }

        private void frmEmpleado_Load(object sender, EventArgs e)
        {
            cargarEmpleado();
        }


        private void btguardar_Click_1(object sender, EventArgs e)
        {
            objeto.AgregarEmpleado(txtnombre.Text,
            txtpaterno.Text,
            txtmaterno.Text,
            txtContra.Text,
            txtdireccion.Text,
            txttelefono.Text);
            cargarEmpleado();
            Limpiar();
        }

        private void btmodificar_Click_1(object sender, EventArgs e)
        {
            int emp_ci = Convert.ToInt32(dgempleado.CurrentRow.Cells[0].Value.ToString());
            objeto.ModificarEmpleado(txtnombre.Text,
            txtpaterno.Text,
            txtmaterno.Text,
            txtdireccion.Text,
            txttelefono.Text,
            txtContra.Text,
            Convert.ToInt32(emp_ci));
            cargarEmpleado();
            Limpiar();
        }

        private void bteliminar_Click_1(object sender, EventArgs e)
        {
            int emp_ci = Convert.ToInt32(dgempleado.CurrentRow.Cells[0].Value.ToString());
            objeto.EliminarEmpleado(Convert.ToInt32(emp_ci));
            cargarEmpleado();
        }

        private void dgempleado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)            {                txtnombre.Text = dgempleado.CurrentRow.Cells[1].Value.ToString();                txtpaterno.Text = dgempleado.CurrentRow.Cells[2].Value.ToString();                txtmaterno.Text = dgempleado.CurrentRow.Cells[3].Value.ToString();                txtdireccion.Text = dgempleado.CurrentRow.Cells[4].Value.ToString();                txttelefono.Text = dgempleado.CurrentRow.Cells[5].Value.ToString();                txtContra.Text = dgempleado.CurrentRow.Cells[6].Value.ToString();            }
            else
            {
                MessageBox.Show("---");
                Limpiar();
            }
        }

        private void txtbuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (string.IsNullOrEmpty(txtbuscar.Text))
            {
                cargarEmpleado();
            }
            else
            {
                var query = from c in linq.tbl_Empleado where c.emp_nombre.Contains(txtbuscar.Text) select c;
                dgempleado.DataSource = query;
            }
        }
    }
}

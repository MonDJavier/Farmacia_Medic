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
    public partial class frmProveedor : Form
    {
        DataClasses1DataContext linq = new DataClasses1DataContext();
        Proveedor objeto = new Proveedor();
        public frmProveedor()
        {
            InitializeComponent();
     
        }
        private void cargarProveedor()
        {
            dgprov.DataSource = linq.mostrarProveedor();
        }

        private void frmProveedor_Load(object sender, EventArgs e)
        {
            cargarProveedor();
        }

        public void Limpiar()
        {
            txtnombre.Clear();
            txtruc.Clear();
            txtdireccion.Clear();
            txttelefono.Clear();
            txtlab.Clear();
        }

        private void bteliminar_Click(object sender, EventArgs e)
        {
            int provee_cod = Convert.ToInt32(dgprov.CurrentRow.Cells[0].Value.ToString());
            objeto.EliminarProveedor(Convert.ToInt32(provee_cod));
            cargarProveedor();
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            int provee_cod = Convert.ToInt32(dgprov.CurrentRow.Cells[0].Value.ToString());
            objeto.ModificarProveedor(Convert.ToInt32(provee_cod),
            txtnombre.Text,
            txtruc.Text,
            txtdireccion.Text,
            txttelefono.Text);
            cargarProveedor();
            Limpiar();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            objeto.AgregarProveedor(txtnombre.Text,
            txtruc.Text,
            txtdireccion.Text,
            txttelefono.Text,
            Convert.ToInt32(txtlab.Text));
            cargarProveedor();
            Limpiar();
        }

        private void dgprov_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)            {                txtnombre.Text = dgprov.CurrentRow.Cells[1].Value.ToString();                txtruc.Text = dgprov.CurrentRow.Cells[2].Value.ToString();                txtdireccion.Text = dgprov.CurrentRow.Cells[3].Value.ToString();                txttelefono.Text = dgprov.CurrentRow.Cells[4].Value.ToString();                txtlab.Text = dgprov.CurrentRow.Cells[5].Value.ToString();            }
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
                cargarProveedor();
            }
            else
            {
                var query = from c in linq.tbl_Proveedor where c.prove_nombre.Contains(txtbuscar.Text) select c;
                dgprov.DataSource = query;
            }
        }
    }
}

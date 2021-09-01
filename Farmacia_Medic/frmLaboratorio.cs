using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocioPrueba;
using CapaDatosPrueba;

namespace Farmacia_Medic
{
    public partial class frmLaboratorio : Form
    {
        DataClasses1DataContext linq = new DataClasses1DataContext();
        Laboratorio objeto = new Laboratorio();
        public frmLaboratorio()
        {
            InitializeComponent();
        }
        private void cargarLaboratorio()
        {
            dglab.DataSource = linq.mostrarLaboratorio();
        }

        public void Limpiar()
        {
            txtNombre.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtEmail.Clear();
            txtWeb.Clear();
        }

        private void frmLaboratorio_Load(object sender, EventArgs e)
        {
            cargarLaboratorio();
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            objeto.AgregarLaboratorio(txtNombre.Text,
            txtDireccion.Text,
            txtTelefono.Text,
            txtEmail.Text,
            txtWeb.Text);
            cargarLaboratorio();
            Limpiar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int lab_cod = Convert.ToInt32(dglab.CurrentRow.Cells[0].Value.ToString());
            objeto.ModificarLaboratorio(Convert.ToInt32(lab_cod),
            txtNombre.Text,
            txtDireccion.Text,
            txtTelefono.Text,
            txtEmail.Text,
            txtWeb.Text);
            cargarLaboratorio();
            Limpiar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int lab_cod = Convert.ToInt32(dglab.CurrentRow.Cells[0].Value.ToString());
            objeto.EliminarLaboratorio(Convert.ToInt32(lab_cod));
            cargarLaboratorio();
        }

        private void dglab_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)            {                txtNombre.Text = dglab.CurrentRow.Cells[1].Value.ToString();                txtDireccion.Text = dglab.CurrentRow.Cells[2].Value.ToString();                txtTelefono.Text = dglab.CurrentRow.Cells[3].Value.ToString();                txtEmail.Text = dglab.CurrentRow.Cells[4].Value.ToString();                txtWeb.Text = dglab.CurrentRow.Cells[5].Value.ToString();            }
            else
            {
                MessageBox.Show("---");
                Limpiar();
            }
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (string.IsNullOrEmpty(txtBuscar.Text))
            {
                cargarLaboratorio();
            }
            else
            {
                var query = from c in linq.tbl_Laboratorio where c.lab_nombre.Contains(txtBuscar.Text) select c;
                dglab.DataSource = query;
            }
        }
    }

    
}


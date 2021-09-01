using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CapaNegocioPrueba;
using System.IO;
using CapaDatosPrueba;

namespace Farmacia_Medic
{
    public partial class frmMedicamento : Form
    {
        DataClasses1DataContext linq = new DataClasses1DataContext();
        Medicamento med = new Medicamento();
        public frmMedicamento()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            med.AgregarMedicamento(txtNombre.Text,
            Convert.ToDecimal(txtPrecio.Text),
            Convert.ToInt32(txtCategoria.Text),
            Convert.ToInt32(txtStock.Text));
            cargarMedicamento();
            Limpiar();
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            int med_cod = Convert.ToInt32(dgv_medicamentos.CurrentRow.Cells[0].Value.ToString());
            med.ModificarMedicamento(Convert.ToInt32(med_cod),
            txtNombre.Text,
            Convert.ToDecimal(txtPrecio.Text),
            Convert.ToInt32(txtStock.Text),
            Convert.ToInt32(txtCategoria.Text));
            cargarMedicamento();
            Limpiar();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            int med_cod = Convert.ToInt32(dgv_medicamentos.CurrentRow.Cells[0].Value.ToString());
            med.EliminarMedicamento(Convert.ToInt32(med_cod));
            cargarMedicamento();
        }

        private void frmMedicamento_Load(object sender, EventArgs e)
        {
            cargarMedicamento();
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (string.IsNullOrEmpty(txtBuscar.Text))
            {
                cargarMedicamento();
            }
            else
            {
                var query = from c in linq.tbl_Medicamento where c.med_nombre.Contains(txtBuscar.Text) select c;
                dgv_medicamentos.DataSource = query;
            }
        }
        public void Limpiar()
        {
            txtNombre.Clear();
            txtPrecio.Clear();
            txtCategoria.Clear();
            txtStock.Clear();
        }
        private void cargarMedicamento()
        {
            dgv_medicamentos.DataSource = linq.mostrarMedicamentos ();
        }

        private void dgv_medicamentos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)            {                txtNombre.Text = dgv_medicamentos.CurrentRow.Cells[1].Value.ToString();                txtCategoria.Text = dgv_medicamentos.CurrentRow.Cells[2].Value.ToString();                txtStock.Text = dgv_medicamentos.CurrentRow.Cells[3].Value.ToString();                txtPrecio.Text = dgv_medicamentos.CurrentRow.Cells[4].Value.ToString();            }
            else
            {
                MessageBox.Show("---");
                Limpiar();
            }
        }
    }
}

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
        public frmProveedor()
        {
            InitializeComponent();
            listar_lab();
            txtlab.Enabled = false;
        }
        public void Limpiar()
        {
            txtnombre.Clear();
            txtnit.Clear();
            txtdireccion.Clear();
            txttelefono.Clear();
        }
        void limpiar_text()
        {
            txtnombre.Text = "";
            txtnit.Text = "";
            txtdireccion.Text = "";
            txttelefono.Text = "";
            txtlab.Text = "";
        }
        public void habilitar()
        {
            limpiar_text();
            txtnombre.Enabled = true;
            txtnit.Enabled = true;
            txtdireccion.Enabled = true;
            txttelefono.Enabled = true;
        }
        public bool verificarVacio()
        {
            if (txtnombre.Text == "")
                if (txtnit.Text == "")
                    if (txttelefono.Text == "")
                        if (txtdireccion.Text == "")
                            return true;
            return false;
        }
        public string retornar_id_lab(string s)
        {
            Laboratorio c = new Laboratorio();
            DataSet ds = new DataSet();
            ds = c.buscarPorNombre(cbolab.Text);
            DataRow reg = ds.Tables[0].Rows[0];
            string x = reg[0].ToString();
            return x;
        }
        public void mostrarlab()
        {
            Laboratorio c = new Laboratorio();
            DataSet ds = new DataSet();
            ds = c.buscar();
            foreach (DataRow reg in ds.Tables[0].Rows)
                cbolab.Items.Add(reg[1].ToString().Trim());
        }
        public void listar_lab()
        {
            Laboratorio c = new Laboratorio();
            DataSet ds = new DataSet();
            ds = c.buscar();
            foreach (DataRow reg in ds.Tables[0].Rows)
                cbolab.Items.Add(reg[1].ToString().Trim());


            DataRow r = ds.Tables[0].Rows[0];
            cbolab.Text = r[1].ToString();
        }



        private void btnnuevo_Click(object sender, EventArgs e)
        {
            limpiar_text();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {

        }

        private void bteliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {

        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {

        }

        private void dgprov_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void frmProveedor_Load(object sender, EventArgs e)
        {

        }
    }
}

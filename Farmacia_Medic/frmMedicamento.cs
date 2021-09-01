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

namespace Farmacia_Medic
{
    public partial class frmMedicamento : Form
    {
        public frmMedicamento()
        {
            InitializeComponent();
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            ImgCli.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            Medicamento med = new Medicamento();
            med.Nombre = txtNombre.Text;
            med.Cod_categoria = int.Parse(txtCategoria.Text);
            med.Stock = int.Parse(txtStock.Text);
            med.Precio = double.Parse(txtPrecio.Text);
            ms.GetBuffer();
            med.guardar();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Medicamento c = new Medicamento();
            DataSet ds = new DataSet();
            ds = c.buscarPorNombre(txtBuscar.Text);
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "tm";
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            Medicamento p = new Medicamento();
            DataSet ds = new DataSet();
            ds = p.buscarPorNombre(txtBuscar.Text);
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "tm";

        }

        private void btn_foto_Click(object sender, EventArgs e)
        {
            OpenFileDialog fo = new OpenFileDialog();
            DialogResult rs = fo.ShowDialog();
            if (rs == DialogResult.OK)
            {
                ImgCli.Image = Image.FromFile(fo.FileName);
            }
        }

      
    }
}

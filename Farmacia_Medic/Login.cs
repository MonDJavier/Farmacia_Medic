using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Farmacia_Medic
{
    public partial class Login : Form
    {
        bool est;
        SqlConnection con = new SqlConnection(@"Data Source=192.168.100.69;Initial Catalog=bd_farmacia;Integrated Security=True");
        public Login()
        {
            InitializeComponent();
            timer1.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToString("dd-MM-yyyy");
            lblHora.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void ValidarEst(string usse, string passw)
        {
            try
            {

                SqlCommand command = new SqlCommand("SELECT estado FROM bd_farmacia.dbo.cliente WHERE nom=@usuario AND pass=@contraseña", con);
                con.Open();
                command.Parameters.AddWithValue("@nombre", usse);
                command.Parameters.AddWithValue("@pass", passw);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
                DataTable data = new DataTable();
                sqlDataAdapter.Fill(data);
                con.Close();
                if (data.Rows.Count == 1)
                {
                    con.Open();
                    SqlCommand command1 = new SqlCommand("SELECT estado FROM bd_farmacia.dbo.cliente WHERE nom=@usuario AND pass=@contraseña", con);
                    command1.Parameters.AddWithValue("@nombre", usse);
                    command1.Parameters.AddWithValue("@pass", passw);
                    SqlDataAdapter sqlDataAdapter1 = new SqlDataAdapter(command);
                    DataTable data1 = new DataTable();
                    sqlDataAdapter1.Fill(data1);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR ESTADO");
            }

        }

        private void btn_log_Click(object sender, EventArgs e)
        {
            ValidarEst(txt_nomlog.Text, txt_psslog.Text);
            Log(txt_nomlog.Text, txt_psslog.Text);
        }
        private void Log(string nombre, string password)
        {

            try
            {
                string txtlogus = txt_nomlog.Text;
                string txtlogpss = txt_psslog.Text;
                if (txtlogus == "" | txtlogpss == "")
                {

                    MessageBox.Show("FORMULARIO VACIO, INGRESE CAMPOS VALIDOS");
                }
                else
                {

                    SqlCommand cmd = new SqlCommand("SELECT usuario FROM dbo.cliente WHERE usuario=@usuario", con);
                    cmd.Parameters.AddWithValue("@usuario", nombre);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    con.Close();
                    if (dt.Rows.Count == 1)
                    {
                        con.Open();
                        SqlCommand cmd1 = new SqlCommand("SELECT usuario FROM dbo.cliente WHERE nom=@usuario AND pass =@contraseña", con);
                        cmd1.Parameters.AddWithValue("@usuario", nombre);
                        cmd1.Parameters.AddWithValue("@contraseña", password);
                        SqlDataAdapter sda1 = new SqlDataAdapter(cmd1);
                        DataTable dt1 = new DataTable();
                        sda.Fill(dt1);
                        string cedu = dt1.Rows[0][2].ToString();
                        con.Close();

                        if (dt1.Rows.Count == 1)
                        {

                            if (dt1.Rows[0][1].ToString() == "1")
                            {
                                MessageBox.Show("Bienvenido Cliente: " + " " + nombre);
                                this.Hide();
                                new Presentacion().ShowDialog();
                                this.Close();

                            }
                            else if (dt1.Rows[0][1].ToString() == "2")
                            {

                                MessageBox.Show("Bienvenido Empleado: " + " " + nombre );
                                this.Hide();
                                new Presentacion().ShowDialog();
                                this.Close();


                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("USUARIO O CONTRASEÑA NO VALIDOS, INTENTE NUEVAMNETE");

                    }


                }

            }
            catch (Exception)
            {


            }


        }
    }
}

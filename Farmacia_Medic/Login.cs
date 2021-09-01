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
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-VJ244OG\SQLEXPRESS;Initial Catalog=bd_farmacia;Integrated Security=True");
        public Login()
        {
            InitializeComponent();
            timer1.Start();
        }

        

        private void btn_log_Click(object sender, EventArgs e)
        {
          
            logear(txt_nomlog.Text, txt_psslog.Text);
        }
        private void logear(string Nombre, string passw)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from  tbl_Empleado where emp_nombre = @nom", con);
                cmd.Parameters.AddWithValue("nom", Nombre);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                con.Close();

                if (dt.Rows.Count == 1)
                {
                    con.Open();
                    SqlCommand cmd1 = new SqlCommand("select * from  tbl_Empleado where emp_nombre = @nom and emp_contraseña=@pass", con);
                    cmd1.Parameters.AddWithValue("pass", passw);
                    cmd1.Parameters.AddWithValue("nom", Nombre);
                    SqlDataAdapter sdp1 = new SqlDataAdapter(cmd1);
                    DataTable dt1 = new DataTable();
                    sdp1.Fill(dt1);
                    con.Close();
                            MessageBox.Show("Binevenido Administrador");
                            this.Hide();
                            new Presentacion().ShowDialog();
                            this.Close();
                    


                }
                else
                {


                    MessageBox.Show("Usuario no  existe...");


                }
            }
            catch (Exception)
            {
                throw;
            }
        }

            private void timer1_Tick_1(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToString("dd-MM-yyyy");
            lblHora.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmEmpleado().ShowDialog();
            this.Close();
        }
    }
}

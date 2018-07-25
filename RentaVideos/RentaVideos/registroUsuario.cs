using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;
namespace RentaVideos
{
    public partial class registroUsuario : Form
    {
        public registroUsuario()
        {
            InitializeComponent();
        }
        string user = "";
        public registroUsuario(string user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            menuPrincipal menu = new menuPrincipal(user);
            menu.Show();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            this.Hide();
            menuPrincipal menu = new menuPrincipal();
            menu.Show();
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            this.txtPassword.PasswordChar = '*';
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button58_Click(object sender, EventArgs e)
        {

        }

        private void registroUsuario_Load(object sender, EventArgs e)
        {
            MySqlCommand sql = new MySqlCommand(String.Format("Select * from Empleados"), ConectarServidor.conexion());
            MySqlDataAdapter da = new MySqlDataAdapter(sql);
            DataSet ds = new DataSet();

            da.Fill(ds);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                comboBox1.Items.Add(ds.Tables[0].Rows[i][0] + " | " + ds.Tables[0].Rows[i][1] + " " + ds.Tables[0].Rows[i][2]);
            }
        }
        public string GMD5(string text)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(text));
            byte[] result = md5.Hash;


            StringBuilder str = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                str.Append(result[i].ToString("x2"));

            }
            return str.ToString();
        }


        private void button47_Click(object sender, EventArgs e)
        {
            string cod = comboBox1.SelectedItem.ToString();
            cod = cod.Substring(0, cod.IndexOf(" "));

            MySqlCommand sql = new MySqlCommand(String.Format("pd_InsertarUsuario"), ConectarServidor.conexion());
            sql.CommandType = CommandType.StoredProcedure;

            //nombre de los parametros que recibe el procedimiento
            MySqlCommand sql2 = new MySqlCommand(String.Format("Select * from Usuarios where Nick_Name='"+ txtUser.Text+"'"), ConectarServidor.conexion());
            MySqlDataReader reader = sql2.ExecuteReader();
            MySqlCommand sql3 = new MySqlCommand(String.Format("Select * from Usuarios where idUsuarios='" + int.Parse(cod) + "'"), ConectarServidor.conexion());
            MySqlDataReader reader2 = sql3.ExecuteReader();
            if ((reader.Read() == true)||(reader2.Read()==true))
            {
                MessageBox.Show("El Usuario o Empleado ya existe! vuelva a intentarlo.");
                txtUser.Clear();
                txtPassword.Clear();
                cbRenta.Checked = false;
                cbCotizacion.Checked = false;
                cbRegistro.Checked = false;
                cbBusqueda.Checked = false;
                cbDevoluciones.Checked = false;
                cbRegUsuario.Checked = false;
                cbConfiguraciones.Checked = false;
            }
            else
            {
                sql.Parameters.AddWithValue("@usuario", txtUser.Text);
                sql.Parameters.AddWithValue("@pass", GMD5(txtPassword.Text));
                sql.Parameters.AddWithValue("@idEmpleado", int.Parse(cod));

                if (cbRenta.Checked)
                    sql.Parameters.AddWithValue("@rentaVideo", true);
                else
                    sql.Parameters.AddWithValue("@rentaVideo", false);
                
                if(cbCotizacion.Checked)
                    sql.Parameters.AddWithValue("@cotizacion", true);
                else
                    sql.Parameters.AddWithValue("@cotizacion", false);

                if (cbRegistro.Checked)
                    sql.Parameters.AddWithValue("@registro", true);
                else
                    sql.Parameters.AddWithValue("@registro", false);

                if (cbBusqueda.Checked)
                    sql.Parameters.AddWithValue("@busqueda", true);
                else
                    sql.Parameters.AddWithValue("@busqueda", false);

                if (cbDevoluciones.Checked)
                    sql.Parameters.AddWithValue("@devoluciones", true);
                else
                    sql.Parameters.AddWithValue("@devoluciones", false);

                if (cbRegUsuario.Checked)
                    sql.Parameters.AddWithValue("@registroUsuario", true);
                else
                    sql.Parameters.AddWithValue("@registroUsuario", false);

                if (cbConfiguraciones.Checked)
                    sql.Parameters.AddWithValue("@configuraciones", true);
                else
                    sql.Parameters.AddWithValue("@configuraciones", false);

                sql.ExecuteNonQuery();

                MessageBox.Show("USUARIO CREADO CORRECTAMENTE!");
                txtUser.Clear();
                txtPassword.Clear();
                cbRenta.Checked = false;
                cbCotizacion.Checked = false;
                cbRegistro.Checked = false;
                cbBusqueda.Checked = false;
                cbDevoluciones.Checked = false;
                cbRegUsuario.Checked = false;
                cbConfiguraciones.Checked = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Cancelar la creacion del Usuario?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                menuPrincipal menu = new menuPrincipal();
                menu.Show();
            }
        }
    }
}

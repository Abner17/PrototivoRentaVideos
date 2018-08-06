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
using System.Net;
using System.Net.NetworkInformation;
using System.Globalization;

namespace RentaVideos
{
    public partial class VentanaLogin : Form
    {
        string hora = "";
        public VentanaLogin()
        {
            InitializeComponent();
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


        private void button2_Click(object sender, EventArgs e)
        {
            ConectarServidor.cerrarConexion();
            Application.Exit();
        }

        private void btIngresar_Click(object sender, EventArgs e)
        {
         


            string user = this.txtUser.Text;
            string pass = this.txtPass.Text;
            try
            {
                MySqlCommand sql2 = new MySqlCommand(String.Format("Select * from Usuarios where Nick_Name='" + user + "'"), ConectarServidor.conexion());
                MySqlDataReader reader = sql2.ExecuteReader();
                if (reader.Read() == true)
                {
                    if (reader.GetString(2) == GMD5(pass))
                    {
                        DateTime fechaInicio = DateTime.Now;

                        IPHostEntry host;
                        string localIP = "";
                        host = Dns.GetHostEntry(Dns.GetHostName());
                        foreach (IPAddress ip in host.AddressList)
                        {
                            if (ip.AddressFamily.ToString() == "InterNetwork")
                            {
                                localIP = ip.ToString();
                                Console.WriteLine(fechaInicio);
                                Console.WriteLine(localIP);
                            }
                        }

                        try
                        {
                            MySqlCommand sql = new MySqlCommand(String.Format("pd_InsertarBitacora"), ConectarServidor.conexion());
                            sql.CommandType = CommandType.StoredProcedure;

                            sql.Parameters.AddWithValue("@userr", user);
                            sql.Parameters.AddWithValue("@fechHoraInicioSe", fechaInicio);
                            sql.Parameters.AddWithValue("@ipp", localIP);

                            sql.ExecuteNonQuery();

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }

                        this.Hide();
                        menuPrincipal menu = new menuPrincipal(user);
                        menu.Show();
                    }
                    else
                    {
                        MessageBox.Show("La contraseña es incorrecta! Vuelva a intentarlo.");
                    }
                }
                else
                {
                    MessageBox.Show("El Usuario es incorrecto! Vuelva a intentarlo.");
                }
                txtUser.Text = "";
                txtPass.Text = "";
            }catch(Exception ex){
                MessageBox.Show(ex.ToString());
            }
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            this.txtPass.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAyuda help = new frmAyuda();
            help.Show();
        }

        private void VentanaLogin_Load(object sender, EventArgs e)
        {
            ConectarServidor.conexion();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.hora = DateTime.Now.ToShortTimeString();
        }
    }
}

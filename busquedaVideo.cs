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

namespace RentaVideos
{
    public partial class busquedaVideo : Form
    {
        public busquedaVideo()
        {
            InitializeComponent();
        }
        string user = "";
        public busquedaVideo(string user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void btRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            menuPrincipal menu = new menuPrincipal(user);
            menu.Show();
        }

        public void autoCompletarCodigo()
        {
            try
            {
                MySqlCommand sql = new MySqlCommand(String.Format("Select idVideo from Videos"), ConectarServidor.conexion());
                MySqlDataReader dr = sql.ExecuteReader();
                AutoCompleteStringCollection mycollection = new AutoCompleteStringCollection();

                while (dr.Read() == true)
                {
                    Console.WriteLine(dr.GetString(0));
                    mycollection.Add(dr.GetString(0));
                }
                tbCodigo.AutoCompleteCustomSource = mycollection;
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public void autoCompletarTitulo()
        {
            try
            {
                MySqlCommand sql = new MySqlCommand(String.Format("Select Titulo from Videos"), ConectarServidor.conexion());
                MySqlDataReader dr = sql.ExecuteReader();
                AutoCompleteStringCollection mycollection = new AutoCompleteStringCollection();

                while (dr.Read() == true)
                {
                    Console.WriteLine(dr.GetString(0));
                    mycollection.Add(dr.GetString(0));
                }
                tbNombre.AutoCompleteCustomSource = mycollection;
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        private void busquedaVideo_Load(object sender, EventArgs e)
        {
            this.autoCompletarCodigo();
            this.autoCompletarTitulo();
        }

        private void btIngresar_Click(object sender, EventArgs e)
        {

        }

        private void btIngresar_Click_1(object sender, EventArgs e)
        {
            tbCodigo.Clear();
            lblCodigo.Text = "";
            lblTitulo.Text = "";
            lblDescripcion.Text = "";
            lblDuracion.Text = "";
            lblCopias.Text = "";
            lblCategoria.Text = "";
            lblFecha.Text = "";
            lblActor.Text = "";
            lblDirector.Text = "";
            lblPrecio.Text = "";
            lblFormato.Text = "";
            tbNombre.Clear();
        }
    }
}

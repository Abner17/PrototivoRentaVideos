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
            lblidVideo.Text = "";
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

        private void btBusqueda_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand sql = new MySqlCommand(String.Format("pd_BuscarVideoCodigo"), ConectarServidor.conexion());
                sql.CommandType = CommandType.StoredProcedure;

                sql.Parameters.AddWithValue("@codigo", tbCodigo.Text);
                MySqlDataReader reader = sql.ExecuteReader();

                if (reader.Read() == true)
                {
                    tbCodigo.Clear();
                    lblidVideo.Text = tbCodigo.Text;
                    lblTitulo.Text = reader.GetString(1);
                    lblDescripcion.Text = reader.GetString(2);
                    lblDuracion.Text = reader.GetString(10);
                    lblCopias.Text = reader.GetString(3);
                    lblCategoria.Text = reader.GetString(4);
                    lblFecha.Text = reader.GetString(5);
                    lblActor.Text = reader.GetString(9);
                    lblDirector.Text = reader.GetString(6);
                    lblPrecio.Text = reader.GetString(7);
                    lblFormato.Text = reader.GetString(8);
                }
                else
                {
                    tbCodigo.Clear();
                    lblidVideo.Text = "";
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
                    MessageBox.Show("El Codigo que busca no se encontro.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand sql = new MySqlCommand(String.Format("pd_BuscarVideoNombre"), ConectarServidor.conexion());
                sql.CommandType = CommandType.StoredProcedure;

                sql.Parameters.AddWithValue("@nombre", tbNombre.Text);
                MySqlDataReader reader = sql.ExecuteReader();

                if (reader.Read() == true)
                {
                    tbCodigo.Clear();
                    lblidVideo.Text = reader.GetString(0);
                    lblTitulo.Text = reader.GetString(1);
                    lblDescripcion.Text = reader.GetString(2);
                    lblDuracion.Text = reader.GetString(10);
                    lblCopias.Text = reader.GetString(3);
                    lblCategoria.Text = reader.GetString(4);
                    lblFecha.Text = reader.GetString(5);
                    lblActor.Text = reader.GetString(9);
                    lblDirector.Text = reader.GetString(6);
                    lblPrecio.Text = reader.GetString(7);
                    lblFormato.Text = reader.GetString(8);
                }
                else
                {
                    tbCodigo.Clear();
                    lblidVideo.Text = "";
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
                    MessageBox.Show("El Titulo que busca no se encontro.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tbCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo debes ingresar letras en un nombre", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
                return;
            }

        }

        private void tbNombre_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}

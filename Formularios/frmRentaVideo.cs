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

namespace RentaVideos.Formularios
{

    public partial class frmRentaVideo : Form
    {

        string user = "";
        public frmRentaVideo()
        {
            InitializeComponent();
            

        }
        public frmRentaVideo(string user)
        {   
            InitializeComponent();
            this.user = user;
        }

        private void lbl_codigo_Click(object sender, EventArgs e)
        {

        }

        private void cbo_genero_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbl_actor_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmRentaVideo_Load(object sender, EventArgs e)
        {

        }

        private void cbo_proveedor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            menuPrincipal menu = new menuPrincipal(user);
            menu.Show();
            this.Hide();
        }

        private void btn_facturar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmFactura factura = new frmFactura(user);
            factura.Show();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand sql = new MySqlCommand(String.Format("SELECT AUTO_INCREMENT FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Encabezado_Renta'"), ConectarServidor.conexion());
                MySqlDataReader reader = sql.ExecuteReader();
                if (reader.Read() == true)
                {
                    lblidRenta.Text = reader.GetString(0);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            if (txt_nombrePelicula.Text == "")
            {
                try
                {
                    MySqlCommand sql = new MySqlCommand(String.Format("pd_BuscarVideoCodigo"), ConectarServidor.conexion());
                    sql.CommandType = CommandType.StoredProcedure;

                    sql.Parameters.AddWithValue("@codigo", txt_codigo.Text);
                    MySqlDataReader reader = sql.ExecuteReader();

                    if (reader.Read() == true)
                    {
                        txt_nombrePelicula.Text = reader.GetString(1);
                        txt_directorPelicula.Text = reader.GetString(6);
                        txt_actor.Text = reader.GetString(9);
                        txt_disponible.Text = reader.GetString(3);
                        txt_formato.Text = reader.GetString(8);
                        txt_descripcionPelicula.Text = reader.GetString(2);
                        txtAño.Text = reader.GetString(5);
                        txt_precioRenta.Text = reader.GetString(7);
                        txtGenero.Text = reader.GetString(4);
                        txtDuracion.Text = reader.GetString(10);
                    }
                    else
                    {
                        MessageBox.Show("El Nombre que busca no se encontro.");
                        txt_codigo.Clear();
                        txt_directorPelicula.Clear();
                        txt_actor.Clear();
                        txt_disponible.Clear();
                        txt_formato.Clear();
                        txt_descripcionPelicula.Clear();
                        txtAño.Clear();
                        txt_precioRenta.Clear();
                        txtGenero.Clear();
                        txtDuracion.Clear();
                        txt_nombrePelicula.Clear();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }else if(txt_codigo.Text == "")
            {
                try
                {
                    MySqlCommand sql = new MySqlCommand(String.Format("pd_BuscarVideoNombre"), ConectarServidor.conexion());
                    sql.CommandType = CommandType.StoredProcedure;

                    sql.Parameters.AddWithValue("@nombre", txt_nombrePelicula.Text);
                    MySqlDataReader reader = sql.ExecuteReader();

                    if (reader.Read() == true)
                    {
                        txt_codigo.Text = reader.GetString(0);
                        txt_directorPelicula.Text = reader.GetString(6);
                        txt_actor.Text = reader.GetString(9);
                        txt_disponible.Text = reader.GetString(3);
                        txt_formato.Text = reader.GetString(8);
                        txt_descripcionPelicula.Text = reader.GetString(2);
                        txtAño.Text = reader.GetString(5);
                        txt_precioRenta.Text = reader.GetString(7);
                        txtGenero.Text = reader.GetString(4);
                        txtDuracion.Text = reader.GetString(10);
                    }
                    else
                    {
                        MessageBox.Show("El Nombre que busca no se encontro.");
                        txt_codigo.Clear();
                        txt_directorPelicula.Clear();
                        txt_actor.Clear();
                        txt_disponible.Clear();
                        txt_formato.Clear();
                        txt_descripcionPelicula.Clear();
                        txtAño.Clear();
                        txt_precioRenta.Clear();
                        txtGenero.Clear();
                        txtDuracion.Clear();
                        txt_nombrePelicula.Clear();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void btn_buscarNombre_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            txt_codigo.Clear();
            txt_directorPelicula.Clear();
            txt_actor.Clear();
            txt_disponible.Clear();
            txt_formato.Clear();
            txt_descripcionPelicula.Clear();
            txtAño.Clear();
            txt_precioRenta.Clear();
            txtGenero.Clear();
            txtDuracion.Clear();
            txt_nombrePelicula.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txt_disponible.Text != "0")
            {
                try
                {
                    MySqlCommand sql = new MySqlCommand(String.Format("pd_InsertaDetalleRenta"), ConectarServidor.conexion());
                    sql.CommandType = CommandType.StoredProcedure;

                    sql.Parameters.AddWithValue("@nombre", txt_nombrePelicula.Text);
                    sql.Parameters.AddWithValue("@idrenta", lblidRenta.Text);



                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

                txt_codigo.Clear();
                txt_directorPelicula.Clear();
                txt_actor.Clear();
                txt_disponible.Clear();
                txt_formato.Clear();
                txt_descripcionPelicula.Clear();
                txtAño.Clear();
                txt_precioRenta.Clear();
                txtGenero.Clear();
                txtDuracion.Clear();
                txt_nombrePelicula.Clear();
            }
        }

        private void txt_descripcionPelicula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo debes ingresar letras en un nombre", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
                return;
            }

        }

        private void txt_nombrePelicula_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo debes ingresar letras en un nombre", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
                return;
            }
        }
    }
}

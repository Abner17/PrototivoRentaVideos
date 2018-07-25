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
        {/*
            try
            {
                MySqlCommand sql = new MySqlCommand(String.Format("pd_BuscarVideoCodigo"), ConectarServidor.conexion());
                sql.CommandType = CommandType.StoredProcedure;

                sql.Parameters.AddWithValue("@codigo", txt_codigo.Text);
                MySqlDataReader reader = sql.ExecuteReader();

                if (reader.Read() == true)
                {
                    txt_nombrePelicula.Text = reader.GetString(0);
                   txt_directorPelicula.Text = reader.GetString(1);
                     txt_actor.Text = reader.GetString(2);
                   txt_disponible.Text = reader.GetString(3);
                    txt_formato.Text = reader.GetString(4);
                    txt_formato.Text = reader.GetString(4);
                }
                else
                {
                    MessageBox.Show("El Nombre que busca no se encontro.");
                    txtNombre.Clear();
                    txtDireccion.Clear();
                    txtTelefono.Clear();
                    txtCorreo.Clear();
                    tbCodigo.Clear();
                    tbNombre.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }*/
        }
    }
}

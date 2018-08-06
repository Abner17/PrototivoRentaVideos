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
    public partial class busquedaProveedor : Form
    {
        string user = "";
        public busquedaProveedor()
        {
            InitializeComponent();
        }
        public busquedaProveedor(string user)
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btBusqueda_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand sql = new MySqlCommand(String.Format("pd_BuscarProveedorCodigo"), ConectarServidor.conexion());
                sql.CommandType = CommandType.StoredProcedure;

                sql.Parameters.AddWithValue("@id_pro", tbCodigo.Text);
                MySqlDataReader reader = sql.ExecuteReader();

                if (reader.Read() == true)
                {
                    lblCodigo.Text = tbCodigo.Text;
                    lblNombre.Text = reader.GetString(1);
                    lblDireccion.Text = reader.GetString(2);
                    lblTelefono.Text = reader.GetString(3);
                    lblCorreo.Text = reader.GetString(4);
                }else{
                    MessageBox.Show("El codigo que busca no se encontro.");
                    lblNombre.Text = "";
                    lblDireccion.Text = "";
                    lblTelefono.Text = "";
                    lblCorreo.Text = "";
                    tbCodigo.Clear();
                    tbNombre.Clear();
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }           
        }

        private void btIngresar_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand sql = new MySqlCommand(String.Format("pd_BuscarProveedorNombre"), ConectarServidor.conexion());
                sql.CommandType = CommandType.StoredProcedure;

                sql.Parameters.AddWithValue("@nombre", tbNombre.Text);
                MySqlDataReader reader = sql.ExecuteReader();

                if (reader.Read() == true)
                {
                    lblCodigo.Text = reader.GetString(0);
                    lblNombre.Text = reader.GetString(1);
                    lblDireccion.Text = reader.GetString(2);
                    lblTelefono.Text = reader.GetString(3);
                    lblCorreo.Text = reader.GetString(4);
                }
                else
                {
                    MessageBox.Show("El Nombre que busca no se encontro.");
                    lblNombre.Text = "";
                    lblDireccion.Text = "";
                    lblTelefono.Text = "";
                    lblCorreo.Text = "";
                    tbCodigo.Clear();
                    tbNombre.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lblCodigo.Text = "";
            lblNombre.Text = "";
            lblDireccion.Text = "";
            lblTelefono.Text = "";
            lblCorreo.Text = "";
            tbCodigo.Clear();
            tbNombre.Clear();
        }

        public void autoCompletarCodigo()
        {
            try
            {
                MySqlCommand sql = new MySqlCommand(String.Format("Select idProveedores from Proveedores"), ConectarServidor.conexion());
                MySqlDataReader dr = sql.ExecuteReader();
                AutoCompleteStringCollection mycollection = new AutoCompleteStringCollection();

                while (dr.Read() == true)
                {
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
        public void autoCompletarNombre()
        {
            try
            {
                MySqlCommand sql = new MySqlCommand(String.Format("Select Nombre_proveedor from Proveedores"), ConectarServidor.conexion());
                MySqlDataReader dr = sql.ExecuteReader();
                AutoCompleteStringCollection mycollection = new AutoCompleteStringCollection();

                while (dr.Read() == true)
                {
                    mycollection.Add(dr.GetString(0));
                }
                tbNombre.AutoCompleteCustomSource = mycollection;
                dr.Close();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void busquedaProveedor_Load(object sender, EventArgs e)
        {
            this.autoCompletarNombre();
            this.autoCompletarCodigo();
        }
    }
}

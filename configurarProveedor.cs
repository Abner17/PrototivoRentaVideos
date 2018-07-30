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
    public partial class configurarProveedor : Form
    {
        string user = "";
        public configurarProveedor()
        {
            InitializeComponent();
        }
        public configurarProveedor(string user)
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

        private void configurarProveedor_Load(object sender, EventArgs e)
        {

        }

        private void btBusqueda_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand sql = new MySqlCommand(String.Format("pd_BuscarProveedorCodigo"), ConectarServidor.conexion());
                sql.CommandType = CommandType.StoredProcedure;

                sql.Parameters.AddWithValue("@id_pro", txtCodigo.Text);
                MySqlDataReader reader = sql.ExecuteReader();

                if (reader.Read() == true) {
                    txtCodigo.Enabled = false;
                    txtNombre.Enabled = true;
                    txtNombre.BackColor = Color.White;
                    txtDireccion.Enabled = true;
                    txtDireccion.BackColor = Color.White;
                    txtTelefono.Enabled = true;
                    txtTelefono.BackColor = Color.White;
                    txtCorreo.Enabled = true;
                    txtCorreo.BackColor = Color.White;

                    txtNombre.Text = reader.GetString(1);
                    txtDireccion.Text = reader.GetString(2);
                    txtTelefono.Text = reader.GetString(3);
                    txtCorreo.Text = reader.GetString(4);

                }
                else
                {
                    txtCodigo.Clear();
                    txtNombre.Clear();
                    txtDireccion.Clear();
                    txtTelefono.Clear();
                    txtCorreo.Clear();
                    MessageBox.Show("El Codigo que busca no se encontro.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand sql = new MySqlCommand(String.Format("	pd_ModificarProveedor"), ConectarServidor.conexion());
                sql.CommandType = CommandType.StoredProcedure;

                sql.Parameters.AddWithValue("@codigo", txtCodigo.Text);
                sql.Parameters.AddWithValue("@nombre", txtNombre.Text);
                sql.Parameters.AddWithValue("@direccion", txtDireccion.Text);
                sql.Parameters.AddWithValue("@telefono", int.Parse(txtTelefono.Text));
                sql.Parameters.AddWithValue("@correo", txtCorreo.Text);

                sql.ExecuteNonQuery();

                MessageBox.Show("CONFIGURACION REALIZADA CON EXITO!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("NO SE PUDO REALIZAR LA CONFIGURACION!");
            }

            txtCodigo.Clear();
            txtNombre.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();

            txtCodigo.Enabled = true;
            txtNombre.Enabled = false;
            txtNombre.BackColor = Color.FromArgb(22, 56, 59);
            txtDireccion.Enabled = false;
            txtDireccion.BackColor = Color.FromArgb(22, 56, 59);
            txtTelefono.Enabled = false;
            txtTelefono.BackColor = Color.FromArgb(22, 56, 59);
            txtCorreo.Enabled = false;
            txtCorreo.BackColor = Color.FromArgb(22, 56, 59);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand sql = new MySqlCommand(String.Format("pd_EliminarProveedor"), ConectarServidor.conexion());
                sql.CommandType = CommandType.StoredProcedure;

                sql.Parameters.AddWithValue("@codigo", txtCodigo.Text);
                sql.ExecuteNonQuery();

                MessageBox.Show("ELIMINACION REALIZADA CON EXITO!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("NO SE PUDO REALIZAR LA ELIMINACION!");
            }

            txtCodigo.Clear();
            txtNombre.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();

            txtCodigo.Enabled = true;
            txtNombre.Enabled = false;
            txtNombre.BackColor = Color.FromArgb(22, 56, 59);
            txtDireccion.Enabled = false;
            txtDireccion.BackColor = Color.FromArgb(22, 56, 59);
            txtTelefono.Enabled = false;
            txtTelefono.BackColor = Color.FromArgb(22, 56, 59);
            txtCorreo.Enabled = false;
            txtCorreo.BackColor = Color.FromArgb(22, 56, 59);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtCodigo.Clear();
            txtNombre.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();
            txtCodigo.Enabled = true;
            txtNombre.Enabled = false;
            txtNombre.BackColor = Color.FromArgb(22, 56, 59);
            txtDireccion.Enabled = false;
            txtDireccion.BackColor = Color.FromArgb(22, 56, 59);
            txtTelefono.Enabled = false;
            txtTelefono.BackColor = Color.FromArgb(22, 56, 59);
            txtCorreo.Enabled = false;
            txtCorreo.BackColor = Color.FromArgb(22, 56, 59);
        }
    }
}

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
    public partial class configurarCliente : Form
    {
        public configurarCliente()
        {
            InitializeComponent();
        }
        string user = "";
        public configurarCliente(string user)
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

        public void autoCompletarNit()
        {
            try
            {
                MySqlCommand sql = new MySqlCommand(String.Format("Select NIT from Cliente"), ConectarServidor.conexion());
                MySqlDataReader dr = sql.ExecuteReader();
                AutoCompleteStringCollection mycollection = new AutoCompleteStringCollection();

                while (dr.Read() == true)
                {
                    mycollection.Add(dr.GetString(0));
                }
                txtNit.AutoCompleteCustomSource = mycollection;
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void configurarCliente_Load(object sender, EventArgs e)
        {
            this.autoCompletarNit();
        }

        public void activarCasillas()
        {
            txtNit.Enabled = false;
            txtNombre.Enabled = true;
            txtNombre.BackColor = Color.White;
            txtApellido.Enabled = true;
            txtApellido.BackColor = Color.White;
            txtDpi.Enabled = true;
            txtDpi.BackColor = Color.White;
            txtDireccion.Enabled = true;
            txtDireccion.BackColor = Color.White;
            txtTelefono.Enabled = true;
            txtTelefono.BackColor = Color.White;
            txtEmail.Enabled = true;
            txtEmail.BackColor = Color.White;
            cboSexo.Enabled = true;
            cboSexo.BackColor = Color.White;
            txtFecha.Enabled = true;
        }

        public void limpiarDesactivarCasillas()
        {
            txtNit.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtDpi.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtEmail.Clear();

            txtNit.Enabled = true;
            txtNombre.Enabled = false;
            txtNombre.BackColor = Color.FromArgb(192, 64, 0);
            txtApellido.Enabled = false;
            txtApellido.BackColor = Color.FromArgb(192, 64, 0);
            txtDpi.Enabled = false;
            txtDpi.BackColor = Color.FromArgb(192, 64, 0);
            txtDireccion.Enabled = false;
            txtDireccion.BackColor = Color.FromArgb(192, 64, 0);
            txtTelefono.Enabled = false;
            txtTelefono.BackColor = Color.FromArgb(192, 64, 0);
            txtEmail.Enabled = false;
            txtEmail.BackColor = Color.FromArgb(192, 64, 0);
            cboSexo.Enabled = false;
            cboSexo.BackColor = Color.FromArgb(192, 64, 0);
            txtFecha.Enabled = false;
        }

        private void btBusqueda_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand sql = new MySqlCommand(String.Format("pd_BuscarClienteCodigo"), ConectarServidor.conexion());
                sql.CommandType = CommandType.StoredProcedure;

                sql.Parameters.AddWithValue("@codigo", txtNit.Text);
                MySqlDataReader reader = sql.ExecuteReader();

                if (reader.Read() == true)
                {
                    this.activarCasillas();

                    txtNombre.Text = reader.GetString(1);
                    txtApellido.Text = reader.GetString(2);
                    txtDpi.Text = reader.GetString(3);
                    txtDireccion.Text = reader.GetString(4);
                    cboSexo.Text = reader.GetString(5);
                    txtFecha.Text = reader.GetDateTime(6).ToString();
                    txtTelefono.Text = reader.GetString(7);
                }
                else
                {
                    txtNit.Clear();
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
            this.limpiarDesactivarCasillas();
        }

        private void btIngresar_Click(object sender, EventArgs e)
        {
            string fecha = txtFecha.Value.Year + "/" + txtFecha.Value.Month + "/" + txtFecha.Value.Day;

            try
            {
                MySqlCommand sql = new MySqlCommand(String.Format("pd_ModificarCliente"), ConectarServidor.conexion());
                sql.CommandType = CommandType.StoredProcedure;

                sql.Parameters.AddWithValue("@codigo", txtNit.Text);
                sql.Parameters.AddWithValue("@nombre", txtNombre.Text);
                sql.Parameters.AddWithValue("@apellido", txtApellido.Text);
                sql.Parameters.AddWithValue("@dpi", txtDpi.Text);
                sql.Parameters.AddWithValue("@direccion", txtDireccion.Text);
                sql.Parameters.AddWithValue("@sexo", cboSexo.Text);
                sql.Parameters.AddWithValue("@fecha", fecha);
                sql.Parameters.AddWithValue("@telefono", int.Parse(txtTelefono.Text));

                sql.ExecuteNonQuery();

                MessageBox.Show("CONFIGURACION REALIZADA CON EXITO!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("NO SE PUDO REALIZAR LA CONFIGURACION!" + ex.ToString());
            }
            this.limpiarDesactivarCasillas();
        }

        private void txtNit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo debes ingresar letras en un nombre", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
                return;
            }

        }
    }
}

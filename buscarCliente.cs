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
    public partial class buscarCliente : Form
    {
        public buscarCliente()
        {
            InitializeComponent();
        }
        string user = "";
        public buscarCliente(string user)
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
                tbNIT.AutoCompleteCustomSource = mycollection;
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
                MySqlCommand sql = new MySqlCommand(String.Format("Select Nombre_Cliente from Cliente"), ConectarServidor.conexion());
                MySqlDataReader dr = sql.ExecuteReader();
                AutoCompleteStringCollection mycollection = new AutoCompleteStringCollection();

                while (dr.Read() == true)
                {
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

        private void buscarCliente_Load(object sender, EventArgs e)
        {
            this.autoCompletarNit();
            this.autoCompletarNombre();
        }

        private void btBusqueda_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand sql = new MySqlCommand(String.Format("pd_BuscarClienteCodigo"), ConectarServidor.conexion());
                sql.CommandType = CommandType.StoredProcedure;

                sql.Parameters.AddWithValue("@codigo", tbNIT.Text);
                MySqlDataReader reader = sql.ExecuteReader();

                if (reader.Read() == true)
                {
                    tbNIT.Clear();
                    lblNit.Text = tbNIT.Text;
                    lblNombre.Text = reader.GetString(1);
                    lblApellido.Text = reader.GetString(2);
                    lblDpi.Text = reader.GetString(3);
                    lblDireccion.Text = reader.GetString(4);
                    lblSexo.Text = reader.GetString(5);
                    lblFecha.Text = reader.GetString(6);
                    lblTelefono.Text = reader.GetString(7);
                }
                else
                {
                    tbNIT.Clear();
                    lblNit.Text = "";
                    lblNombre.Text = "";
                    lblApellido.Text = "";
                    lblDpi.Text = "";
                    lblDireccion.Text = "";
                    lblSexo.Text = "";
                    lblFecha.Text = "";
                    lblTelefono.Text = "";
                    tbNombre.Clear();
                    MessageBox.Show("El NIT que busca no se encontro.");
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
                MySqlCommand sql = new MySqlCommand(String.Format("pd_BuscarClienteNombre"), ConectarServidor.conexion());
                sql.CommandType = CommandType.StoredProcedure;

                sql.Parameters.AddWithValue("@nombre", tbNombre.Text);
                MySqlDataReader reader = sql.ExecuteReader();

                if (reader.Read() == true)
                {
                    tbNIT.Clear();
                    lblNit.Text = reader.GetString(0);
                    lblNombre.Text = reader.GetString(1);
                    lblApellido.Text = reader.GetString(2);
                    lblDpi.Text = reader.GetString(3);
                    lblDireccion.Text = reader.GetString(4);
                    lblSexo.Text = reader.GetString(5);
                    lblFecha.Text = reader.GetString(6);
                    lblTelefono.Text = reader.GetString(7);
                }
                else
                {
                    tbNIT.Clear();
                    lblNit.Text = "";
                    lblNombre.Text = "";
                    lblApellido.Text = "";
                    lblDpi.Text = "";
                    lblDireccion.Text = "";
                    lblSexo.Text = "";
                    lblFecha.Text = "";
                    lblTelefono.Text = "";
                    tbNombre.Clear();
                    MessageBox.Show("El Nombre que busca no se encontro.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tbNombre_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btIngresar_Click(object sender, EventArgs e)
        {
            tbNIT.Clear();
            lblNit.Text = "";
            lblNombre.Text = "";
            lblApellido.Text = "";
            lblDpi.Text = "";
            lblDireccion.Text = "";
            lblSexo.Text = "";
            lblFecha.Text = "";
            lblTelefono.Text = "";
            tbNombre.Clear();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tbNIT_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void tbNIT_KeyPress(object sender, KeyPressEventArgs e)
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
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo debes ingresar letras en un nombre", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
                return;
            }
        }
    }
}

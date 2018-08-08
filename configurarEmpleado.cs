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
    public partial class configurarEmpleado : Form
    {
        string user = "";
        public configurarEmpleado()
        {
            InitializeComponent();
        }
        public configurarEmpleado(string user)
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
                MySqlCommand sql = new MySqlCommand(String.Format("Select idEmpleados from Empleados"), ConectarServidor.conexion());
                MySqlDataReader dr = sql.ExecuteReader();
                AutoCompleteStringCollection mycollection = new AutoCompleteStringCollection();

                while (dr.Read() == true)
                {
                    mycollection.Add(dr.GetString(0));
                }
                txtCodigo.AutoCompleteCustomSource = mycollection;
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void llenarComboBox()
        {
            try
            {
                MySqlCommand sql = new MySqlCommand(String.Format("Select * from Puestos"), ConectarServidor.conexion());
                MySqlDataAdapter da = new MySqlDataAdapter(sql);
                DataSet ds = new DataSet();

                da.Fill(ds);
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    comboBox9.Items.Add(ds.Tables[0].Rows[i][0] + " | " + ds.Tables[0].Rows[i][1]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void configurarEmpleado_Load(object sender, EventArgs e)
        {
            this.autoCompletarCodigo();
            this.llenarComboBox();
        }


        public void activarCasillas()
        {
            txtCodigo.Enabled = false;
            txtNombre.Enabled = true;
            txtNombre.BackColor = Color.White;
            txtApellido.Enabled = true;
            txtApellido.BackColor = Color.White;
            txtDireccion.Enabled = true;
            txtDireccion.BackColor = Color.White;
            txtTelefono.Enabled = true;
            txtTelefono.BackColor = Color.White;
            txtCorreo.Enabled = true;
            txtCorreo.BackColor = Color.White;
            comboBox9.Enabled = true;
            comboBox9.BackColor = Color.White;
        }

        public void limpiarDesactivarCasillas()
        {
            txtCodigo.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();
            txtCodigo.Enabled = true;
            txtNombre.Enabled = false;
            txtNombre.BackColor = Color.FromArgb(192, 64, 0);
            txtApellido.Enabled = false;
            txtApellido.BackColor = Color.FromArgb(192, 64, 0);
            txtDireccion.Enabled = false;
            txtDireccion.BackColor = Color.FromArgb(192, 64, 0);
            txtTelefono.Enabled = false;
            txtTelefono.BackColor = Color.FromArgb(192, 64, 0);
            txtCorreo.Enabled = false;
            txtCorreo.BackColor = Color.FromArgb(192, 64, 0);
            comboBox9.Enabled = false;
            comboBox9.BackColor = Color.FromArgb(192, 64, 0);
        }
        private void btBusqueda_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand sql = new MySqlCommand(String.Format("pd_BuscarEmpleadoCodigo"), ConectarServidor.conexion());
                sql.CommandType = CommandType.StoredProcedure;

                sql.Parameters.AddWithValue("@id_emp", txtCodigo.Text);
                MySqlDataReader reader = sql.ExecuteReader();

                if (reader.Read() == true)
                {
                    this.activarCasillas();

                    txtNombre.Text = reader.GetString(1);
                    txtApellido.Text = reader.GetString(2);
                    txtDireccion.Text = reader.GetString(3);
                    txtTelefono.Text = reader.GetString(4);
                    txtCorreo.Text = reader.GetString(6);

                    string puesto = reader.GetString(5);
                    string instruccion = "SELECT idPuestos, Nombre_Puesto FROM Puestos WHERE idPuestos = " + puesto;
                    sql = new MySqlCommand(String.Format(instruccion), ConectarServidor.conexion());
                    MySqlDataReader dr2 = sql.ExecuteReader();
                    if (dr2.Read() == true)
                    {
                        comboBox9.Text = dr2.GetString(1);
                    }

                }
                else
                {
                    txtCodigo.Clear();
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
            string cod = comboBox9.SelectedItem.ToString();
            cod = cod.Substring(0, cod.IndexOf(" "));
            try
            {
                MySqlCommand sql = new MySqlCommand(String.Format("pd_ModificarEmpleado"), ConectarServidor.conexion());
                sql.CommandType = CommandType.StoredProcedure;

                sql.Parameters.AddWithValue("@codigo", txtCodigo.Text);
                sql.Parameters.AddWithValue("@nombre", txtNombre.Text);
                sql.Parameters.AddWithValue("@apellido", txtApellido.Text);
                sql.Parameters.AddWithValue("@direccion", txtDireccion.Text);
                sql.Parameters.AddWithValue("@telefono", int.Parse(txtTelefono.Text));
                sql.Parameters.AddWithValue("@puesto", int.Parse(cod));
                sql.Parameters.AddWithValue("@correo", txtCorreo.Text);

                sql.ExecuteNonQuery();

                MessageBox.Show("CONFIGURACION REALIZADA CON EXITO!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("NO SE PUDO REALIZAR LA CONFIGURACION!");
            }
            this.limpiarDesactivarCasillas();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand sql = new MySqlCommand(String.Format("pd_EliminarUsuario"), ConectarServidor.conexion());
                sql.CommandType = CommandType.StoredProcedure;

                sql.Parameters.AddWithValue("@codigo", txtCodigo.Text);
                sql.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("NO SE PUDO REALIZAR LA ELIMINACION!");
            }

            try
            {
                MySqlCommand sql = new MySqlCommand(String.Format("pd_EliminarEmpleado"), ConectarServidor.conexion());
                sql.CommandType = CommandType.StoredProcedure;

                sql.Parameters.AddWithValue("@codigo", txtCodigo.Text);
                sql.ExecuteNonQuery();

                MessageBox.Show("ELIMINACION REALIZADA CON EXITO!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("NO SE PUDO REALIZAR LA ELIMINACION!");
            }

            this.limpiarDesactivarCasillas();
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
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

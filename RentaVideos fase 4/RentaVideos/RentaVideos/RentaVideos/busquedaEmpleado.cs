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
    public partial class busquedaEmpleado : Form
    {
        string user = "";
        public busquedaEmpleado()
        {
            InitializeComponent();
        }
        public busquedaEmpleado(string user)
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

        private void btBusqueda_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand sql = new MySqlCommand(String.Format("pd_BuscarEmpleadoCodigo"), ConectarServidor.conexion());
                sql.CommandType = CommandType.StoredProcedure;

                sql.Parameters.AddWithValue("@id_emp", tbCodigo.Text);
                MySqlDataReader reader = sql.ExecuteReader();

                if (reader.Read() == true)
                {
                    lblCodigo.Text = tbCodigo.Text;
                    lblNombre.Text = reader.GetString(1);
                    lblApellido.Text = reader.GetString(2);
                    lblDireccion.Text = reader.GetString(3);
                    lblTelefono.Text = reader.GetString(4);
                    lblCorreo.Text = reader.GetString(6);

                    string puesto = reader.GetString(5);
                    string instruccion = "SELECT idPuestos, Nombre_Puesto FROM Puestos WHERE idPuestos = " + puesto;
                    sql = new MySqlCommand(String.Format(instruccion), ConectarServidor.conexion());
                    MySqlDataReader dr2 = sql.ExecuteReader();
                    if (dr2.Read() == true)
                    {
                        lblPuesto.Text = dr2.GetString(1);
                    }
                }
                else
                {
                    tbCodigo.Clear();
                    lblCodigo.Text = "";
                    lblNombre.Text = "";
                    lblApellido.Text = "";
                    lblDireccion.Text = "";
                    lblTelefono.Text = "";
                    lblCorreo.Text = "";
                    tbNombre.Clear();
                    MessageBox.Show("El Codigo que busca no se encontro.");
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand sql = new MySqlCommand(String.Format("pd_BuscarEmpleadoNombre"), ConectarServidor.conexion());
                sql.CommandType = CommandType.StoredProcedure;

                sql.Parameters.AddWithValue("@nombre", tbNombre.Text);
                MySqlDataReader reader = sql.ExecuteReader();

                if (reader.Read() == true)
                {
                    lblCodigo.Text = reader.GetString(0);
                    lblNombre.Text = reader.GetString(1);
                    lblApellido.Text = reader.GetString(2);
                    lblDireccion.Text = reader.GetString(3);
                    lblTelefono.Text = reader.GetString(4);
                    lblCorreo.Text = reader.GetString(6);

                    string puesto = reader.GetString(5);
                    string instruccion = "SELECT idPuestos, Nombre_Puesto FROM Puestos WHERE idPuestos = " + puesto;
                    sql = new MySqlCommand(String.Format(instruccion), ConectarServidor.conexion());
                    MySqlDataReader dr2 = sql.ExecuteReader();
                    if(dr2.Read() == true)
                    {
                        lblPuesto.Text = dr2.GetString(1);
                    }

                }
                else
                {
                    tbCodigo.Clear();
                    lblCodigo.Text = "";
                    lblNombre.Text = "";
                    lblApellido.Text = "";
                    lblDireccion.Text = "";
                    lblTelefono.Text = "";
                    lblCorreo.Text = "";
                    tbNombre.Clear();
                    lblPuesto.Text = "";
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
            tbCodigo.Clear();
            lblCodigo.Text = "";
            lblNombre.Text = "";
            lblApellido.Text = "";
            lblDireccion.Text = "";
            lblTelefono.Text = "";
            lblCorreo.Text = "";
            lblPuesto.Text = "";
            tbNombre.Clear();
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
                MySqlCommand sql = new MySqlCommand(String.Format("Select Nombre_empleado from Empleados"), ConectarServidor.conexion());
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

        private void busquedaEmpleado_Load(object sender, EventArgs e)
        {
            this.autoCompletarCodigo();
            this.autoCompletarNombre();
        }

       

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tbCodigo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace RentaVideos
{
    public partial class registrarEmpleado : Form
    {
        string user = "";
        public registrarEmpleado()
        {
            InitializeComponent();
        }
        public registrarEmpleado(string user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void button64_Click(object sender, EventArgs e)
        {
            menuPrincipal menu = new menuPrincipal(user);
            menu.Show();
            this.Hide();
        }

        private void registrarEmpleado_Load(object sender, EventArgs e)
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
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {
   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("¿Desea Cancelar el Registro de Empleado?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                menuPrincipal menu = new menuPrincipal(user);
                menu.Show();
            }
        }

        private void button47_Click(object sender, EventArgs e)
        {
            string cod = comboBox9.SelectedItem.ToString();
            cod = cod.Substring(0, cod.IndexOf(" "));
            try
            {
                //nombre del procedimiento
                MySqlCommand sql = new MySqlCommand(String.Format("pd_InsertarEmpleado"), ConectarServidor.conexion());
                sql.CommandType = CommandType.StoredProcedure;

                //nombre de los parametros que recibe el procedimiento
                sql.Parameters.AddWithValue("@nombre", txtNombre.Text);
                sql.Parameters.AddWithValue("@apellido", txtApellido.Text);
                sql.Parameters.AddWithValue("@direccion", txtDireccion.Text);
                sql.Parameters.AddWithValue("@telefono", int.Parse(txtTelefono.Text));
                sql.Parameters.AddWithValue("@puesto", int.Parse(cod));
                sql.Parameters.AddWithValue("@correo", txtEmail.Text);

                sql.ExecuteNonQuery();

                MessageBox.Show("EMPLEADO REGISTRADO CORRECTAMENTE!");

            }catch(Exception ex)
            {
                MessageBox.Show("El EMPLEADO NO SE PUDO REGISTRAR!");
            }
            txtNombre.Clear();
            txtApellido.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtEmail.Clear();
        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class registrarProveedor : Form
    {
        string user = "";
        public registrarProveedor()
        {
            InitializeComponent();
        }
        public registrarProveedor(string user)
        {
            InitializeComponent();
            this.user = user;
        }


        private void button65_Click(object sender, EventArgs e)
        {
            this.Hide();
            menuPrincipal menu = new menuPrincipal(user);
            menu.Show();
        }

        private void button47_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand sql = new MySqlCommand(String.Format("pd_InsertarProveedor"), ConectarServidor.conexion());
                sql.CommandType = CommandType.StoredProcedure;

                sql.Parameters.AddWithValue("@nombre", txtNom.Text);
                sql.Parameters.AddWithValue("@direccion", txtDir.Text);
                sql.Parameters.AddWithValue("@telefono", int.Parse(txtTel.Text));
                sql.Parameters.AddWithValue("@correo", txtCorr.Text);

                sql.ExecuteNonQuery();

                MessageBox.Show("PROVEEDOR REGISTRADO CORRECTAMENTE!");
            }catch(Exception ex)
            {
                MessageBox.Show("EL PROVEEDOR NO SE PUDO REGISTRAR");
            }

            txtNom.Clear();
            txtDir.Clear();
            txtTel.Clear();
            txtCorr.Clear();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Cancelar el Registro de Empleado?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                menuPrincipal menu = new menuPrincipal(user);
                menu.Show();
            }
        }
    }
}

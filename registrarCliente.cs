using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentaVideos
{
    public partial class registrarCliente : Form
    {
        public registrarCliente()
        {
            InitializeComponent();
        }

        private void button63_Click(object sender, EventArgs e)
        {
            this.Hide();
            menuPrincipal menu = new menuPrincipal();
            menu.Show();
        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void button43_Click(object sender, EventArgs e)
        {
            int indice = sexoCliente.SelectedIndex;
          
           
            Clientes pCliente = new Clientes();
            pCliente.Nombre = nombreCliente.Text.Trim();
            pCliente.Apellido = apellidoCliente.Text.Trim();
            pCliente.Fecha_Nac = fechaCliente.Value.Year + "/" + fechaCliente.Value.Month + "/" + fechaCliente.Value.Day;
            pCliente.Direccion = direccionCliente.Text.Trim();
            pCliente.Dpi = dpiCliente.Text.Trim();
            pCliente.Nit = nitCliente.Text.Trim();
            pCliente.Sexo = sexoCliente.Items[indice].ToString().Trim();
            pCliente.Email = emailCliente.Text.Trim();
            pCliente.descripcionEmail = descripcionEmailCliente.Text.Trim();
            pCliente.Telefono = telefonoCliente.Text.Trim();
            pCliente.descripcionTelefono = descripcionTelefonoCliente.Text.Trim();
            pCliente.FechaRegistro = DateTime.Now.Year.ToString() +"/" + DateTime.Now.Month.ToString() + "/" + DateTime.Now.Day.ToString();
         
           
        
            int resultado = Clientes.Agregar(pCliente);
            if (resultado > 0)
            {
                nombreCliente.Clear();
                apellidoCliente.Clear();
                direccionCliente.Clear();
                dpiCliente.Clear();
                nitCliente.Clear();
                sexoCliente.Text = "Seleccione sexo";
                emailCliente.Clear();
                descripcionEmailCliente.Clear();
                telefonoCliente.Clear();
                descripcionTelefonoCliente.Clear();



                MessageBox.Show("Cliente Guardado Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudo guardar el cliente", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }


        }

        private void sexoCliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void registrarCliente_Load(object sender, EventArgs e)
        {
            sexoCliente.Text = "Seleccione sexo";
        }
    }
}

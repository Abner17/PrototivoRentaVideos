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
    public partial class frmFactura : Form
    {
        string user = "";
        public frmFactura()
        {
            InitializeComponent();
        }
        public frmFactura(string user)
        {
            InitializeComponent();
            this.user = user;
        }
        public void autocompletarcodigo()
        {
            try
            {
                MySqlCommand sql = new MySqlCommand(String.Format("Select idMembresia from Membresia"), ConectarServidor.conexion());
                MySqlDataReader dr = sql.ExecuteReader();
                AutoCompleteStringCollection mycollection = new AutoCompleteStringCollection();

                while (dr.Read() == true)
                {
                    mycollection.Add(dr.GetString(0));
                }
                txtMembresia.AutoCompleteCustomSource = mycollection;
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void frmFactura_Load(object sender, EventArgs e)
        {
            autocompletarcodigo();
            txtIva.Text = "0.12%";
            txtVendedor.Text = user;
            DateTime fecha = DateTime.Now;
            txtFecha.Text = fecha.ToString();
            try
            {
                MySqlCommand sql = new MySqlCommand(String.Format("Select * from FormaDePago"), ConectarServidor.conexion());
                MySqlDataAdapter da = new MySqlDataAdapter(sql);
                DataSet ds = new DataSet();

                da.Fill(ds);
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    cbo_formasPago.Items.Add(ds.Tables[0].Rows[i][0] + " | " + ds.Tables[0].Rows[i][1]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            try
            {
                MySqlCommand sql = new MySqlCommand(String.Format("Select * from Videos"), ConectarServidor.conexion());
                MySqlDataAdapter da = new MySqlDataAdapter(sql);
                DataSet ds = new DataSet();

                da.Fill(ds);
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    cobVideo.Items.Add(ds.Tables[0].Rows[i][0] + " | " + ds.Tables[0].Rows[i][1]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            try
            {
                MySqlCommand sql = new MySqlCommand(String.Format("SELECT AUTO_INCREMENT FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME='Encabezado_Factura'"), ConectarServidor.conexion());
                MySqlDataReader dr = sql.ExecuteReader();
                if (dr.Read() == true)
                {
                    txtNo.Text = dr.GetString(0);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txt_codCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            this.Hide();
            menuPrincipal menu = new menuPrincipal();
            menu.Show();
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            menuPrincipal menu = new menuPrincipal(user);
            menu.Show();
        }

        private void lbl_vendedor_Click(object sender, EventArgs e)
        {

        }

        private void txt_codCliente_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea cancelar esta factura?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                menuPrincipal menu = new menuPrincipal(user);
                menu.Show();
            }

        }

        private void button47_Click(object sender, EventArgs e)
        {
            double suma = 0;
            foreach (DataGridViewRow row in dgv_Peliculas.Rows)
            {
                double valor = Convert.ToDouble(row.Cells["subtotal"].Value);
                suma += valor;
            }
            txtTotal.Text = Convert.ToString(suma);

            string cod = cbo_formasPago.SelectedItem.ToString();
            cod = cod.Substring(0, cod.IndexOf(" "));

            try
            {
                //nombre del procedimiento
                MySqlCommand sql = new MySqlCommand(String.Format("pd_InsertarEncabezadoFactura"), ConectarServidor.conexion());
                sql.CommandType = CommandType.StoredProcedure;

                //nombre de los parametros que recibe el procedimiento
                sql.Parameters.AddWithValue("@fecha", txtFecha.Text);
                sql.Parameters.AddWithValue("@idMembresia", txtMembresia.Text);
                sql.Parameters.AddWithValue("@nit", txt_Nit.Text);
                sql.Parameters.AddWithValue("@pago", cod);
                sql.Parameters.AddWithValue("@vendedor", txtVendedor.Text);
                sql.Parameters.AddWithValue("@total", txtTotal.Text);
                sql.ExecuteNonQuery();

                MessageBox.Show("FACTURA GENERADA CORRECTAMENTE!");

            }
            catch (Exception ex)
            {
                MessageBox.Show("LA FACTURA NO SE PUDO GENERAR!");
            }

            this.Hide();
            menuPrincipal menu = new menuPrincipal(user);
            menu.Show();
        }

        private void btBusqueda_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand sql = new MySqlCommand(String.Format("pd_BuscarMembresia"), ConectarServidor.conexion());
                sql.CommandType = CommandType.StoredProcedure;

                sql.Parameters.AddWithValue("@codigo", txtMembresia.Text);
                MySqlDataReader reader = sql.ExecuteReader();
                
                if(reader.Read() == true)
                {
                    txt_Nit.Text = reader.GetString(0);
                }
                reader.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            try
            {
                MySqlCommand sql2 = new MySqlCommand(String.Format("pd_BuscarClienteCodigo"), ConectarServidor.conexion());
                sql2.CommandType = CommandType.StoredProcedure;

                sql2.Parameters.AddWithValue("@codigo", txt_Nit.Text);
                MySqlDataReader reader2 = sql2.ExecuteReader();

                if (reader2.Read() == true)
                {
                    txt_nombreCliente.Text = (reader2.GetString(1) + " " + reader2.GetString(2));
                    txt_direccion.Text = reader2.GetString(4);
                }
                reader2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void txt_nombreCliente_TextChanged(object sender, EventArgs e)
        {
            
        }

        
        private void button2_Click(object sender, EventArgs e)
        {
            string cod = cobVideo.SelectedItem.ToString();
            cod = cod.Substring(0, cod.IndexOf(" "));
            try
            {
                //nombre del procedimiento
                MySqlCommand sql = new MySqlCommand(String.Format("pd_BuscarVideoCodigo"), ConectarServidor.conexion());
                sql.CommandType = CommandType.StoredProcedure;

                //nombre de los parametros que recibe el procedimiento
                sql.Parameters.AddWithValue("@codigo", int.Parse(cod));
                MySqlDataReader reader = sql.ExecuteReader();

                if (reader.Read() == true)
                {
                    DataGridViewRow filas = new DataGridViewRow();
                    filas.CreateCells(dgv_Peliculas);
                    filas.Cells[0].Value = reader.GetString(0);
                    filas.Cells[1].Value = reader.GetString(1);
                    filas.Cells[2].Value = txtCantidad.Text;
                    filas.Cells[3].Value = reader.GetString(7);
                    double subTotal = double.Parse(txtCantidad.Text) * double.Parse(reader.GetString(7));
                    filas.Cells[4].Value = subTotal;

                    dgv_Peliculas.Rows.Add(filas);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            txtCantidad.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dgv_Peliculas.Rows.Remove(dgv_Peliculas.CurrentRow);
        }
    }
}

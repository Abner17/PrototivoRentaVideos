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
    public partial class configurarProducto : Form
    {
        public configurarProducto()
        {
            InitializeComponent();
        }
        string user = "";
        public configurarProducto(string user)
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
                MySqlCommand sql = new MySqlCommand(String.Format("Select idVideo from Videos"), ConectarServidor.conexion());
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
                MySqlCommand sql = new MySqlCommand(String.Format("Select * from Director_Video"), ConectarServidor.conexion());
                MySqlDataAdapter da = new MySqlDataAdapter(sql);
                DataSet ds = new DataSet();

                da.Fill(ds);
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    cboDirector.Items.Add(ds.Tables[0].Rows[i][0] + " | " + ds.Tables[0].Rows[i][1]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            try
            {
                MySqlCommand sql = new MySqlCommand(String.Format("Select * from Formato_Video"), ConectarServidor.conexion());
                MySqlDataAdapter da = new MySqlDataAdapter(sql);
                DataSet ds = new DataSet();

                da.Fill(ds);
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    cboFormato.Items.Add(ds.Tables[0].Rows[i][0] + " | " + ds.Tables[0].Rows[i][1]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            try
            {
                MySqlCommand sql = new MySqlCommand(String.Format("Select * from Categoria_Video"), ConectarServidor.conexion());
                MySqlDataAdapter da = new MySqlDataAdapter(sql);
                DataSet ds = new DataSet();

                da.Fill(ds);
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    cboCategoria.Items.Add(ds.Tables[0].Rows[i][0] + " | " + ds.Tables[0].Rows[i][1]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            try
            {
                MySqlCommand sql = new MySqlCommand(String.Format("Select * from ActorPrincipal_Video"), ConectarServidor.conexion());
                MySqlDataAdapter da = new MySqlDataAdapter(sql);
                DataSet ds = new DataSet();

                da.Fill(ds);
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    cboActor.Items.Add(ds.Tables[0].Rows[i][0] + " | " + ds.Tables[0].Rows[i][1]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        private void configurarProducto_Load(object sender, EventArgs e)
        {
            this.autoCompletarCodigo();
            this.llenarComboBox();    
        }

        public void activarCasillas()
        {
            txtCodigo.Enabled = false;
            txtTitulo.Enabled = true;
            txtTitulo.BackColor = Color.White;
            txtDuracion.Enabled = true;
            txtDuracion.BackColor = Color.White;
            txtCopias.Enabled = true;
            txtCopias.BackColor = Color.White;
            txtPrecio.Enabled = true;
            txtPrecio.BackColor = Color.White;
            txtFecha.Enabled = true;
            txtFecha.BackColor = Color.White;
            cboDirector.Enabled = true;
            cboDirector.BackColor = Color.White;
            cboFormato.Enabled = true;
            cboFormato.BackColor = Color.White;
            cboCategoria.Enabled = true;
            cboCategoria.BackColor = Color.White;
            cboActor.Enabled = true;
            cboActor.BackColor = Color.White;
            txtDescripcion.Enabled = true;
            txtDescripcion.BackColor = Color.White;
        }

        public void limpiarDesactivarCasillas()
        {
            txtCodigo.Clear();
            txtTitulo.Clear();
            txtDuracion.Clear();
            txtCopias.Clear();
            txtPrecio.Clear();
            txtDescripcion.Clear();
            txtFecha.Clear();

            txtCodigo.Enabled = true;
            txtTitulo.Enabled = false;
            txtTitulo.BackColor = Color.FromArgb(192, 64, 0);
            txtDuracion.Enabled = false;
            txtDuracion.BackColor = Color.FromArgb(192, 64, 0);
            txtCopias.Enabled = false;
            txtCopias.BackColor = Color.FromArgb(192, 64, 0);
            txtPrecio.Enabled = false;
            txtPrecio.BackColor = Color.FromArgb(192, 64, 0);
            txtFecha.Enabled = false;
            txtFecha.BackColor = Color.FromArgb(192, 64, 0);
            cboDirector.Enabled = false;
            cboDirector.BackColor = Color.FromArgb(192, 64, 0);
            cboFormato.Enabled = false;
            cboFormato.BackColor = Color.FromArgb(192, 64, 0);
            cboCategoria.Enabled = false;
            cboCategoria.BackColor = Color.FromArgb(192, 64, 0);
            cboActor.Enabled = false;
            cboActor.BackColor = Color.FromArgb(192, 64, 0);
            txtDescripcion.Enabled = false;
            txtDescripcion.BackColor = Color.FromArgb(192, 64, 0);
        }

        private void btBusqueda_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand sql = new MySqlCommand(String.Format("pd_BuscarVideoCodigo"), ConectarServidor.conexion());
                sql.CommandType = CommandType.StoredProcedure;

                sql.Parameters.AddWithValue("@codigo", txtCodigo.Text);
                MySqlDataReader reader = sql.ExecuteReader();

                if (reader.Read() == true)
                {
                    this.activarCasillas();

                    txtTitulo.Text = reader.GetString(1);
                    txtDuracion.Text = reader.GetString(10);
                    txtCopias.Text = reader.GetString(3);
                    txtPrecio.Text = reader.GetString(7);
                    txtFecha.Text = reader.GetString(5);
                    cboDirector.Text = reader.GetString(6);
                    cboFormato.Text = reader.GetString(8);
                    cboCategoria.Text = reader.GetString(4);
                    cboActor.Text = reader.GetString(9);
                    txtDescripcion.Text = reader.GetString(2);
                }
                else
                {
                    txtCodigo.Clear();
                    MessageBox.Show("El Codigo que busca no se encontro.");
                }
                reader.Close();
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
            string codDirector = cboDirector.SelectedItem.ToString();
            codDirector = codDirector.Substring(0, codDirector.IndexOf(" "));
            string codFormato = cboFormato.SelectedItem.ToString();
            codFormato = codFormato.Substring(0, codFormato.IndexOf(" "));
            string codCategoria = cboCategoria.SelectedItem.ToString();
            codCategoria = codCategoria.Substring(0, codCategoria.IndexOf(" "));
            string codActor = cboActor.SelectedItem.ToString();
            codActor = codActor.Substring(0, codActor.IndexOf(" "));
            try
            {
                MySqlCommand sql = new MySqlCommand(String.Format("pd_ModificarVideo"), ConectarServidor.conexion());
                sql.CommandType = CommandType.StoredProcedure;

                sql.Parameters.AddWithValue("@codigo", txtCodigo.Text);
                sql.Parameters.AddWithValue("@tit", txtTitulo.Text);
                sql.Parameters.AddWithValue("@descrip", txtDescripcion.Text);
                sql.Parameters.AddWithValue("@dur", txtDuracion.Text);
                sql.Parameters.AddWithValue("@cop", txtCopias.Text);
                sql.Parameters.AddWithValue("@cat", int.Parse(codCategoria));
                sql.Parameters.AddWithValue("@fecha", txtFecha.Text);
                sql.Parameters.AddWithValue("@actor", int.Parse(codActor));
                sql.Parameters.AddWithValue("@direc", int.Parse(codDirector));
                sql.Parameters.AddWithValue("@costo", txtPrecio);
                sql.Parameters.AddWithValue("@formt", int.Parse(codFormato));

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
                MySqlCommand sql = new MySqlCommand(String.Format("	pd_EliminarVideo"), ConectarServidor.conexion());
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

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

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

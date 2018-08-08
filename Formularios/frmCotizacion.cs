using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace RentaVideos.Formularios{
    public partial class frmCotizacion : Form
    {
        string user = "";
        public frmCotizacion()
        {
            InitializeComponent();
        }
        public frmCotizacion(string user)
        {
            InitializeComponent();
            this.user = user;
        }
        private void frmCotizacion_Load(object sender, EventArgs e)
        {

            //Text Box Categoria de Video
            categoriaVideo.Text = "Seleccione Categoria";
            categoriaVideo.Items.Clear();


            obtenerCodigoCotizacion();
            obtenerCategorias();
            DateTime thisDay = DateTime.Today;
            txtFecha.Text = thisDay.Year + "/" + thisDay.Month + "/" + thisDay.Day;





        }

        private void obtenerCategorias()
        {

            try
            {

                MySqlCommand cmc = new MySqlCommand("Select Categoria from Categoria_Video", ConectarServidor.conexion());
                MySqlDataReader almacenac = cmc.ExecuteReader();

                while (almacenac.Read())
                {
                    categoriaVideo.Refresh();
                    categoriaVideo.Items.Add(almacenac.GetValue(0).ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void obtenerCodigoCotizacion()
        {
            txtCodigoCotizacion.Clear();
            double codcotsum = 0;
            try
            {
                MySqlCommand cm = new MySqlCommand("Select Id_Cotizacion from Cotizacion_Encabezado", ConectarServidor.conexion());
                MySqlDataReader almacena = cm.ExecuteReader();

                if (almacena.Read())
                {
                    while (almacena.Read())
                    {

                    }
                    codcotsum = Convert.ToDouble(almacena.GetValue(0)) + 1;
                    txtCodigoCotizacion.Text = codcotsum.ToString();
                }
                else
                {
                    txtCodigoCotizacion.Text = "1";
                }

                //  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void limpiarText()
        {
            DateTime thisDay = DateTime.Today;
            txtFecha.Text = thisDay.Year + "/" + thisDay.Month + "/" + thisDay.Day;


            txtNit.Clear();
            txtMembresia.Clear();
            txt_nombreCliente.Clear();
            txt_direccionCliente.Clear();
            txt_telefonoCliente.Clear();
            dgv_Peliculas.Rows.Clear();
            dg_Cotizacion.Rows.Clear();
            txt_subTotal.Clear();
            txt_iva.Clear();
            txt_totalAPagar.Clear();
            categoriaVideo.Text = "";
        }


        private void llenarGrid()
        {
            try
            {
                //nombre del procedimiento
                MySqlCommand sql = new MySqlCommand(String.Format("pd_BuscarVideoCategoria"), ConectarServidor.conexion());
                sql.CommandType = CommandType.StoredProcedure;
                int indCategoria = categoriaVideo.SelectedIndex + 1;
                //nombre de los parametros que recibe el procedimiento
                sql.Parameters.AddWithValue("@codigo", indCategoria);
                MySqlDataReader reader = sql.ExecuteReader();

                while (reader.Read() == true)
                {
                    DataGridViewRow filas = new DataGridViewRow();
                    filas.CreateCells(dgv_Peliculas);

                    filas.Cells[0].Value = reader.GetString(0);
                    filas.Cells[1].Value = reader.GetString(1);
                    filas.Cells[2].Value = reader.GetString(3);
                    filas.Cells[3].Value = reader.GetString(7);



                    dgv_Peliculas.Rows.Add(filas);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


        }
        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            menuPrincipal menu = new menuPrincipal(user);
            menu.Show();
            this.Hide();



        }

        private void pnl_cotizacion_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            limpiarText();
            obtenerCodigoCotizacion();


        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button47_Click(object sender, EventArgs e)
        {
            ConsultaMembresia();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {





        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int n = e.RowIndex;
            int m = e.ColumnIndex;
            double suma = 0;
            double iva = 0;
            double total = 0;
            double codigoTABVideo = 0;
            codigoTABVideo = Convert.ToDouble(dgv_Peliculas.Rows[n].Cells[0].Value);
            bool codigoRepetido = false;
            // MessageBox.Show(n.ToString());
            if (n != -1)
            {


                foreach (DataGridViewRow row in dg_Cotizacion.Rows)
                {
                    double codigo = Convert.ToDouble(row.Cells["codigoCotizacion"].Value);

                    if (codigoTABVideo == codigo)
                    {
                        codigoRepetido = true;
                        MessageBox.Show("El video ya ah sido ingresado");
                    }


                }


                if (codigoRepetido == false)
                {

                    DataGridViewRow filas2 = new DataGridViewRow();
                    filas2.CreateCells(dg_Cotizacion);
                    filas2.Cells[0].Value = dgv_Peliculas.Rows[n].Cells[0].Value;
                    filas2.Cells[1].Value = dgv_Peliculas.Rows[n].Cells[1].Value;
                    filas2.Cells[2].Value = 1;
                    filas2.Cells[3].Value = dgv_Peliculas.Rows[n].Cells[3].Value;
                    dg_Cotizacion.Rows.Add(filas2);

                    double total2 = 0;

                    foreach (DataGridViewRow row in dg_Cotizacion.Rows)
                    {
                        double cantidad = Convert.ToDouble(row.Cells["CantidadCotizacion"].Value);


                        //  if(cantidad >   )
                        //  {

                        // }
                        double sub = Convert.ToDouble(row.Cells["PrecioCotizacion"].Value);
                        total2 = cantidad * sub;
                        row.Cells["SubTotalCotizacion"].Value = total2;

                    }


                    foreach (DataGridViewRow row in dg_Cotizacion.Rows)
                    {
                        double valor = Convert.ToDouble(row.Cells["SubtotalCotizacion"].Value);
                        suma += valor;
                    }


                    iva = suma * 0.12;
                    txt_subTotal.Text = Convert.ToString(suma);
                    total = iva + suma;
                    txt_iva.Text = Convert.ToString(iva);
                    txt_totalAPagar.Text = Convert.ToString(total);

                }
            }

        }

        private void categoriaVideo_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgv_Peliculas.Rows.Clear();
            llenarGrid();
        }

        private void dg_Cotizacion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {





        }

        private void dg_Cotizacion_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void dg_Cotizacion_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            double total = 0;
            int n = e.RowIndex;
            int m = e.ColumnIndex;
            double cantidadENBD = 0;
            double coddd = 0;

            coddd = Convert.ToDouble(dg_Cotizacion.Rows[n].Cells[0].Value);

            double cantidadSeleccionada = 0;
            cantidadSeleccionada = Convert.ToDouble(dg_Cotizacion.Rows[n].Cells[m].Value);
            //   MessageBox.Show("cantidadEscrita: " + codigoACTUAL);
            try
            {


                //nombre del procedimiento
                MySqlCommand sql = new MySqlCommand(String.Format("pd_BuscarVideoCodigo"), ConectarServidor.conexion());
                sql.CommandType = CommandType.StoredProcedure;

                //nombre de los parametros que recibe el procedimiento
                sql.Parameters.AddWithValue("@codigo", coddd);
                MySqlDataReader reader = sql.ExecuteReader();

                while (reader.Read() == true)
                {



                    cantidadENBD = Convert.ToDouble(reader.GetString(3));




                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }










            if (cantidadSeleccionada <= cantidadENBD)
            {



                foreach (DataGridViewRow row in dg_Cotizacion.Rows)
                {
                    double cantidad = Convert.ToDouble(row.Cells["CantidadCotizacion"].Value);
                    double sub = Convert.ToDouble(row.Cells["PrecioCotizacion"].Value);
                    total = cantidad * sub;
                    row.Cells["SubTotalCotizacion"].Value = total;

                }

                double suma = 0;
                double iva = 0;
                double total2 = 0;
                double valor = 0;
                foreach (DataGridViewRow row in dg_Cotizacion.Rows)
                {
                    valor = Convert.ToDouble(row.Cells["SubtotalCotizacion"].Value);
                    suma += valor;
                }
                txt_subTotal.Text = Convert.ToString(suma);

                iva = suma * 0.12;

                total2 = iva + suma;
                txt_iva.Text = Convert.ToString(iva);
                txt_totalAPagar.Text = Convert.ToString(total2);
            }
            else
            {
                MessageBox.Show("Existencias sobre pasadas, se colocó la cantidad maxima registrada");
                dg_Cotizacion.Rows[n].Cells[m].Value = cantidadENBD;



                foreach (DataGridViewRow row in dg_Cotizacion.Rows)
                {
                    double cantidad = Convert.ToDouble(row.Cells["CantidadCotizacion"].Value);
                    double sub = Convert.ToDouble(row.Cells["PrecioCotizacion"].Value);
                    total = cantidad * sub;
                    row.Cells["SubTotalCotizacion"].Value = total;

                }

                double suma = 0;
                double iva = 0;
                double total2 = 0;
                double valor = 0;
                foreach (DataGridViewRow row in dg_Cotizacion.Rows)
                {
                    valor = Convert.ToDouble(row.Cells["SubtotalCotizacion"].Value);
                    suma += valor;
                }
                txt_subTotal.Text = Convert.ToString(suma);

                iva = suma * 0.12;

                total2 = iva + suma;
                txt_iva.Text = Convert.ToString(iva);
                txt_totalAPagar.Text = Convert.ToString(total2);
            }

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btNuevo_Click(object sender, EventArgs e)
        {

            limpiarText();
            obtenerCodigoCotizacion();
        }


        private Bitmap CaptureControl(Control control)
        {
            Size s = control.Size;
            Bitmap memoryImage;
            using (Graphics myGraphics = CreateGraphics())
            {
                memoryImage = new Bitmap(s.Width, s.Height, myGraphics);
            }
            using (Graphics memoryGraphics = Graphics.FromImage(memoryImage))
            {
                Point screenPoint = PointToScreen(control.Location);
                memoryGraphics.CopyFromScreen(screenPoint.X, screenPoint.Y-10, 10, 0, s);
            }
            return memoryImage;
        }



        private void btEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                //nombre del procedimiento
                MySqlCommand sql = new MySqlCommand(String.Format("pd_InsertarCotizacionEncabezado"), ConectarServidor.conexion());
                sql.CommandType = CommandType.StoredProcedure;

                //nombre de los parametros que recibe el procedimiento

                sql.Parameters.AddWithValue("@Fecha_Cotizacion", txtFecha.Text);
                sql.Parameters.AddWithValue("@Id_Cliente", txtMembresia.Text);
                sql.Parameters.AddWithValue("@Id_Empleado", "1");
                sql.Parameters.AddWithValue("@Total", txt_totalAPagar.Text);

                sql.ExecuteNonQuery();

             

                foreach (DataGridViewRow row in dg_Cotizacion.Rows)
                {
                    double cantidad = Convert.ToDouble(row.Cells["CantidadCotizacion"].Value);
                    double codigoo = Convert.ToDouble(row.Cells["codigoCotizacion"].Value);
                    double sub = Convert.ToDouble(row.Cells["SubTotalCotizacion"].Value);






                    try
                    {
                        //nombre del procedimiento
                        MySqlCommand sql2 = new MySqlCommand(String.Format("pd_InsertarDetalleCotizacion"), ConectarServidor.conexion());
                        sql2.CommandType = CommandType.StoredProcedure;

                        //nombre de los parametros que recibe el procedimiento

                        sql2.Parameters.AddWithValue("@Id_Cotizacion", txtCodigoCotizacion.Text);
                        sql2.Parameters.AddWithValue("@Id_Video", codigoo.ToString());
                        sql2.Parameters.AddWithValue("@Cantidad", cantidad.ToString());
                        sql2.Parameters.AddWithValue("@SubTotal", sub.ToString());

                        sql2.ExecuteNonQuery();





                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("el detalle NO SE PUDO GENERAR! " + ex);
                    }



                    string nombreArchivo = "cotizacion"+txtCodigoCotizacion.Text+".png";
                    using (Bitmap bmp = CaptureControl(panel6))
                    {
                        bmp.Save(nombreArchivo, ImageFormat.Png);
                    }

               
                }


                //  limpiarText();
                //  obtenerCodigoCotizacion();
                MessageBox.Show("COTIZACION GENERADA CORRECTAMENTE!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("LA COTIZACION NO SE PUDO GENERAR!" + ex);
            }

        }

        private void ConsultaMembresia()
        {
            try
            {
                MySqlCommand sql3 = new MySqlCommand(String.Format("pd_BuscarMembresia"), ConectarServidor.conexion());
                sql3.CommandType = CommandType.StoredProcedure;

                sql3.Parameters.AddWithValue("@codigo", txtMembresia.Text);
                MySqlDataReader reader3 = sql3.ExecuteReader();

                if (reader3.Read() == true)
                {
                    txtNit.Text = reader3.GetString(0);


                    try
                    {
                        MySqlCommand sql2 = new MySqlCommand(String.Format("pd_BuscarClienteCodigo"), ConectarServidor.conexion());
                        sql2.CommandType = CommandType.StoredProcedure;

                        sql2.Parameters.AddWithValue("@codigo", txtNit.Text);
                        MySqlDataReader reader2 = sql2.ExecuteReader();

                        if (reader2.Read() == true)
                        {
                            txt_nombreCliente.Text = (reader2.GetString(1) + " " + reader2.GetString(2));
                            txt_direccionCliente.Text = reader2.GetString(4);
                            txt_telefonoCliente.Text = reader2.GetString(7);
                        }
                        reader2.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }


                    MessageBox.Show("Cliente encontrado");
                }
                else
                {
                    txtNit.Clear();
                    txt_nombreCliente.Clear();
                    txt_direccionCliente.Clear();
                    txt_telefonoCliente.Clear();
                    MessageBox.Show("La membresia no existe");

                }
                reader3.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }


       private void gridConsultaCotizacion(){
            double suma = 0;
            double iva = 0;
            double total = 0;
            try
            {
                //nombre del procedimiento
                MySqlCommand sql = new MySqlCommand(String.Format("pd_BuscarIdCotizacionDetalle"), ConectarServidor.conexion());
                sql.CommandType = CommandType.StoredProcedure;
             
                //nombre de los parametros que recibe el procedimiento
                sql.Parameters.AddWithValue("@codigo",txtCodigoCotizacion.Text);
                MySqlDataReader reader = sql.ExecuteReader();

                while (reader.Read() == true)
                {
                    DataGridViewRow filas = new DataGridViewRow();
                    filas.CreateCells(dg_Cotizacion);

                    filas.Cells[0].Value = reader.GetString(0);
                  //  filas.Cells[1].Value = reader.GetString(1);
                    filas.Cells[2].Value = reader.GetString(1);
                    filas.Cells[4].Value = reader.GetString(3);



                    dg_Cotizacion.Rows.Add(filas);
                }
                reader.Close();




          

                double total2= 0;
                foreach (DataGridViewRow row in dg_Cotizacion.Rows)
                {
                    double cantidad = Convert.ToDouble(row.Cells["CantidadCotizacion"].Value);
                    double sub = Convert.ToDouble(row.Cells["SubTotalCotizacion"].Value);
                    total2 = sub/cantidad;
                    row.Cells["PrecioCotizacion"].Value = total2;


                    double valor = Convert.ToDouble(row.Cells["SubtotalCotizacion"].Value);
                    suma += valor;




                    double codC = Convert.ToDouble(row.Cells["codigoCotizacion"].Value);
                    try
                    {
                        //nombre del procedimiento
                        MySqlCommand sql3 = new MySqlCommand(String.Format("pd_BuscarVideoCodigo"), ConectarServidor.conexion());
                        sql3.CommandType = CommandType.StoredProcedure;

                        //nombre de los parametros que recibe el procedimiento
                        sql3.Parameters.AddWithValue("@codigo", codC);
                        MySqlDataReader reader3 = sql3.ExecuteReader();
                        while (reader3.Read() == true)
                        {

                            row.Cells["nombreVideoCotizacion"].Value = reader3.GetString(1);
                        }



                            



                        reader3.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }





                }




                iva = suma * 0.12;
                txt_subTotal.Text = Convert.ToString(suma);
                total = iva + suma;
                txt_iva.Text = Convert.ToString(iva);
                txt_totalAPagar.Text = Convert.ToString(total);






            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }


        private void btConsulta_Click(object sender, EventArgs e)
        {
            //   char fecharestringida= [9];
            limpiarText();
            try
            {
                //nombre del procedimiento
                MySqlCommand sql = new MySqlCommand(String.Format("pd_BuscarMembresiaCotizacion"), ConectarServidor.conexion());
                sql.CommandType = CommandType.StoredProcedure;
             
                //nombre de los parametros que recibe el procedimiento
                sql.Parameters.AddWithValue("@codigo", txtCodigoCotizacion.Text);
                MySqlDataReader reader = sql.ExecuteReader();

                while (reader.Read() == true)
                {
                    txtFecha.Text = reader.GetString(1);
                    txtMembresia.Text = reader.GetString(2);
                    txt_totalAPagar.Text = reader.GetString(4);


                }
                reader.Close();
                ConsultaMembresia();

                gridConsultaCotizacion();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txt_nombreCliente_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo debes ingresar letras en un nombre", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
                return;
            }
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

        private void txt_telefonoCliente_KeyPress(object sender, KeyPressEventArgs e)
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

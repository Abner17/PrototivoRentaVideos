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
using Microsoft.VisualBasic;

namespace RentaVideos
{
    public partial class registrarVideo : Form
    {
        public registrarVideo()
        {
            InitializeComponent();
        }

        private void button66_Click(object sender, EventArgs e)
        {
            this.Hide();
            menuPrincipal menu = new menuPrincipal();
            menu.Show();
        }

        private void registrarVideo_Load(object sender, EventArgs e)
        {
            //Text Box Director de Video

            directorVideo.Text = "Seleccione Director";
            directorVideo.Items.Clear();
            MySqlCommand cm = new MySqlCommand("Select Nombre from Director_Video", ConectarServidor.conexion());
            MySqlDataReader almacena = cm.ExecuteReader();
            directorVideo.Items.Add("AGREGAR NUEVO");
            while (almacena.Read())
            {
                directorVideo.Refresh();
                directorVideo.Items.Add(almacena.GetValue(0).ToString());
            }

            //Text Box Formato de Video

            formatoVideo.Text = "Seleccione Formato";
            formatoVideo.Items.Clear();
            MySqlCommand cmf= new MySqlCommand("Select Formato from Formato_Video", ConectarServidor.conexion());
            MySqlDataReader almacenaf = cmf.ExecuteReader();
            formatoVideo.Items.Add("AGREGAR NUEVO");
            while (almacenaf.Read())
            {
                formatoVideo.Refresh();
                formatoVideo.Items.Add(almacenaf.GetValue(0).ToString());
            }

            //Text Box Categoria de Video
            categoriaVideo.Text = "Seleccione Categoria";
            categoriaVideo.Items.Clear();
            MySqlCommand cmc = new MySqlCommand("Select Categoria from Categoria_Video", ConectarServidor.conexion());
            MySqlDataReader almacenac = cmc.ExecuteReader();
            categoriaVideo.Items.Add("AGREGAR NUEVO");
            while (almacenac.Read())
            {
                categoriaVideo.Refresh();
                categoriaVideo.Items.Add(almacenac.GetValue(0).ToString());
            }
            //Text Box Actor Principal
            actorPrincipalVideo.Text = "Seleccione Actor";
            actorPrincipalVideo.Items.Clear();
            MySqlCommand cmact = new MySqlCommand("Select Nombre from ActorPrincipal_Video", ConectarServidor.conexion());
            MySqlDataReader almacenaact = cmact.ExecuteReader();
            actorPrincipalVideo.Items.Add("AGREGAR NUEVO");
            while (almacenaact.Read())
            {
                actorPrincipalVideo.Refresh();
                actorPrincipalVideo.Items.Add(almacenaact.GetValue(0).ToString());
            }





        }

      

       

        private void codigoVideo_TextChanged(object sender, EventArgs e)
        {

        }

        private void tituloVideo_TextChanged(object sender, EventArgs e)
        {

        }

        private void duracionVideo_TextChanged(object sender, EventArgs e)
        {

        }

        private void copiasVideo_TextChanged(object sender, EventArgs e)
        {

        }

        private void precioVideo_TextChanged(object sender, EventArgs e)
        {

        }

        private void anioVideo_ValueChanged(object sender, EventArgs e)
        {

        }
        private void directorVideo_SelectedIndexChanged(object sender, EventArgs e)
        {



            int indDirector = directorVideo.SelectedIndex;
        

            if (indDirector == 0)
            {
                string nombre;
                nombre = Microsoft.VisualBasic.Interaction.InputBox("Ingrese nuevo nombre:", "Registro de Director", "Ingrese aqui..");
                if (nombre != "")
                {
                    MySqlCommand director = new MySqlCommand(string.Format("Insert into Director_Video (Nombre) values ('{0}')",
             nombre), ConectarServidor.conexion());
                    int resultado = director.ExecuteNonQuery();
                    if (resultado > 0)
                    {
                        MessageBox.Show("Director guarado con exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        directorVideo.Text = "Seleccione Director";
                        directorVideo.Items.Clear();
                        MySqlCommand cm = new MySqlCommand("Select Nombre from Director_Video", ConectarServidor.conexion());
                        MySqlDataReader almacena = cm.ExecuteReader();
                        directorVideo.Items.Add("AGREGAR NUEVO");
                        while (almacena.Read())
                        {
                            directorVideo.Refresh();
                            directorVideo.Items.Add(almacena.GetValue(0).ToString());
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se pudo guardar el director", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("Saliendo del registro", "Salida con exito!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
            }

        }

        private void formatoVideo_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indFormato = formatoVideo.SelectedIndex;
            int indCategoria = categoriaVideo.SelectedIndex;
            int indActor = actorPrincipalVideo.SelectedIndex;

            if (indFormato == 0)
            {
                string nombre;
                nombre = Microsoft.VisualBasic.Interaction.InputBox("Ingrese nuevo formato:", "Registro de Formato", "Ingrese aqui..");
                if (nombre != "")
                {
                    MySqlCommand formato = new MySqlCommand(string.Format("Insert into Formato_Video (Formato) values ('{0}')",
             nombre), ConectarServidor.conexion());
                    int resultado = formato.ExecuteNonQuery();
                    if (resultado > 0)
                    {
                        MessageBox.Show("Formato guarado con exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);


                        formatoVideo.Text = "Seleccione Formato";
                        formatoVideo.Items.Clear();
                        MySqlCommand cmf = new MySqlCommand("Select Formato from Formato_Video", ConectarServidor.conexion());
                        MySqlDataReader almacenaf = cmf.ExecuteReader();
                        formatoVideo.Items.Add("AGREGAR NUEVO");
                        while (almacenaf.Read())
                        {
                            formatoVideo.Refresh();
                            formatoVideo.Items.Add(almacenaf.GetValue(0).ToString());
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se pudo guardar el formato", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("Saliendo del registro", "Salida con exito!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
            }
        }

        private void categoriaVideo_SelectedIndexChanged(object sender, EventArgs e)
        {
          
            int indCategoria = categoriaVideo.SelectedIndex;
            int indActor = actorPrincipalVideo.SelectedIndex;

            if (indCategoria == 0)
                
            {
                string nombre;
                nombre = Microsoft.VisualBasic.Interaction.InputBox("Ingrese nueva Categoría:", "Registro de Categoría", "Ingrese aqui..");
                if (nombre != "")
                {
                    MySqlCommand formato = new MySqlCommand(string.Format("Insert into Categoria_Video (Categoria) values ('{0}')",
             nombre), ConectarServidor.conexion());
                    int resultado = formato.ExecuteNonQuery();
                    if (resultado > 0)
                    {
                        MessageBox.Show("Categoría guarada con exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);


                        categoriaVideo.Text = "Seleccione Categoria";
                        categoriaVideo.Items.Clear();
                        MySqlCommand cmc = new MySqlCommand("Select Categoria from Categoria_Video", ConectarServidor.conexion());
                        MySqlDataReader almacenac = cmc.ExecuteReader();
                        categoriaVideo.Items.Add("AGREGAR NUEVO");
                        while (almacenac.Read())
                        {
                            categoriaVideo.Refresh();
                            categoriaVideo.Items.Add(almacenac.GetValue(0).ToString());
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se pudo guardar la categoria", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("Saliendo del registro", "Salida con exito!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
            }
        }

        private void actorPrincipalVideo_SelectedIndexChanged(object sender, EventArgs e)
        {
        
            int indActor = actorPrincipalVideo.SelectedIndex;

            if (indActor == 0)

            {
                string nombre;
                nombre = Microsoft.VisualBasic.Interaction.InputBox("Ingrese nuevo Actor Principal:", "Registro de Actor", "Ingrese aqui..");
                if (nombre != "")
                {
                    MySqlCommand formato = new MySqlCommand(string.Format("Insert into ActorPrincipal_Video (Nombre) values ('{0}')",
             nombre), ConectarServidor.conexion());
                    int resultado = formato.ExecuteNonQuery();
                    if (resultado > 0)
                    {
                        MessageBox.Show("Actor guardado con exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);


                        actorPrincipalVideo.Text = "Seleccione Actor";
                        actorPrincipalVideo.Items.Clear();
                        MySqlCommand cmact = new MySqlCommand("Select Nombre from ActorPrincipal_Video", ConectarServidor.conexion());
                        MySqlDataReader almacenaact = cmact.ExecuteReader();
                        actorPrincipalVideo.Items.Add("AGREGAR NUEVO");
                        while (almacenaact.Read())
                        {
                            actorPrincipalVideo.Refresh();
                            actorPrincipalVideo.Items.Add(almacenaact.GetValue(0).ToString());
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se pudo guardar el Actor Principal", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("Saliendo del registro", "Salida con exito!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
            }
        }

        private void descripcionVideo_TextChanged(object sender, EventArgs e)
        {

        }

        private void envioDatos()
        {
            






            int indDirector = directorVideo.SelectedIndex;
            int indFormato = formatoVideo.SelectedIndex;
            int indCategoria = categoriaVideo.SelectedIndex;
            int indActor = actorPrincipalVideo.SelectedIndex;

            if (indDirector == 0)
            {
                DialogResult opcion;
                opcion = MessageBox.Show("Ingrese nuevo nombre de Director: ", "Registro de Director", MessageBoxButtons.OK, MessageBoxIcon.Question);
           
            }




            Video pvideo = new Video();
            pvideo.Director = indDirector.ToString();
            pvideo.Categoria = indCategoria.ToString();
            pvideo.Formato = indFormato.ToString();
            pvideo.ActorPrincipal = indActor.ToString();

            pvideo.Anio = anioVideo.Value.Year + "/" + anioVideo.Value.Month + "/" + anioVideo.Value.Day;

            pvideo.Descripcion = descripcionVideo.Text.Trim();
            pvideo.Titulo = tituloVideo.Text.Trim();

            pvideo.Codigo = codigoVideo.Text.Trim();
            pvideo.Copias = copiasVideo.Text.Trim();
            pvideo.Duracion = duracionVideo.Text.Trim();
            pvideo.Precio = precioVideo.Text.Trim();



            int resultado = Video.Agregar(pvideo);
            if (resultado > 0)
            {
                descripcionVideo.Clear();
                tituloVideo.Clear();

                codigoVideo.Clear();
                copiasVideo.Clear();
                duracionVideo.Clear();
                precioVideo.Clear();
                actorPrincipalVideo.Text = "Seleccione Actor";
                categoriaVideo.Text = "Seleccione Categoria";
                formatoVideo.Text = "Seleccione Formato";
                directorVideo.Text = "Seleccione Director";

                MessageBox.Show("Video Guardado Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudo guardar el Video", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }


        private bool validacionCombo()
        {
            bool validacionComboBox = true;  
                if (directorVideo.SelectedIndex >= 0)
            {
                if (formatoVideo.SelectedIndex >= 0)
                {
                    if (categoriaVideo.SelectedIndex >= 0)
                    {
                        if (actorPrincipalVideo.SelectedIndex >= 0)
                        {

                        }
                        else
                        {
                            MessageBox.Show("Combo Box no seleccionado", "Seleccione un Actor Principal", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            validacionComboBox = false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Combo Box no seleccionado", "Seleccione una Categoría", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        validacionComboBox = false;
                    }
                }
                else
                {
                    MessageBox.Show("Combo Box no seleccionado", "Seleccione un Formato", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    validacionComboBox = false;
                }
            }
            else
            {
                MessageBox.Show("Combo Box no seleccionado", "Seleccione un Director", MessageBoxButtons.OK, MessageBoxIcon.Information);

                validacionComboBox = false;
            }
            return validacionComboBox;
        }

        private bool validacionTextchar()
        {
            bool valtextchar = true;
            if (string.IsNullOrEmpty(tituloVideo.Text))
            {
                valtextchar = false;
                MessageBox.Show("Text Box no ingresado", "Ingrese Titulo de video", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (string.IsNullOrEmpty(descripcionVideo.Text))
                {
                    valtextchar = false;
                    MessageBox.Show("Text Box no ingresado", "Ingrese descripcion de video", MessageBoxButtons.OK, MessageBoxIcon.Information);
                  }

            }
            return valtextchar;
        }

        private bool validacionTextstr()
        {
            bool validacionstr = true;
        

            if (string.IsNullOrEmpty(codigoVideo.Text))
            {
                validacionstr = false;
            //    MessageBox.Show("Text Box no ingresado", "Ingrese codigo de video", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (string.IsNullOrEmpty(copiasVideo.Text))
                {
                    validacionstr = false;
          //          MessageBox.Show("Text Box no ingresado", "Ingrese copias de video", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (string.IsNullOrEmpty(duracionVideo.Text))
                    {
                        validacionstr = false;
                 //       MessageBox.Show("Text Box no ingresado", "Ingrese duracion de video", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(precioVideo.Text))
                        {
                            validacionstr = false;
                     //       MessageBox.Show("Text Box no ingresado", "Ingrese precio de video", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }



                }

            }








            /*

            if (idcod>=0)
                            {
                                if ((int.Parse(copiasVideo.Text)) >= 0)
                                {
                                    if ((int.Parse(duracionVideo.Text)) >= 0)
                                    {
                                        if ((int.Parse(precioVideo.Text)) >= 0) {
                                        }
                                        else
                                        {
                                            validacionstr = false;
                                        }

                                    }
                                    else
                                    {
                                        validacionstr = false;
                                    }
                                }
                                else
                                {
                                    validacionstr = false;
                                }
                            }
                            else
                            {
                                validacionstr = false;
                            }
                       
    */
      if(validacionstr == false)
            {
                MessageBox.Show("Text Box no ingresado", "Algun campo numérico esta vacío", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }





            return validacionstr;
        }

        private bool validacionGeneral ()
        {
            bool valgeneral = true;

            if (validacionCombo() == false)
            {
                valgeneral = false;
            }
            else
            {
                if(validacionTextchar() == false)
                {
                    valgeneral = false;
                }
                else
                {

                }if(validacionTextstr()== false)
                {
                    valgeneral = false;
                }
                else
                {

                }
            }
            return valgeneral;
        }

        private void button27_Click(object sender, EventArgs e)
        {



        


            if (validacionGeneral())
            envioDatos();

           

          
       
    }
    }
}

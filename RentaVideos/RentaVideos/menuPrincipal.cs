using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace RentaVideos
{
    public partial class menuPrincipal : Form
    {
        string user = "";
        public menuPrincipal()
        {
            InitializeComponent();
        }
        public menuPrincipal(string user)
        {
            InitializeComponent();
            MySqlCommand sql2 = new MySqlCommand(String.Format("Select * from Usuarios where Nick_Name='" + user + "'"), ConectarServidor.conexion());
            MySqlDataReader reader = sql2.ExecuteReader();

            if (reader.Read() == true)
            {
                btRentar.Enabled = reader.GetBoolean(4);
                btCotizacion.Enabled = reader.GetBoolean(5);
                btRegistro.Enabled = reader.GetBoolean(6);
                btBusqueda.Enabled = reader.GetBoolean(7);
                btDevoluciones.Enabled = reader.GetBoolean(8);
                btRegistroUsuario.Enabled = reader.GetBoolean(9);
                btConfiguracion.Enabled = reader.GetBoolean(10);
                this.user = user;
            }
        }
        public static class Util
        {
            public enum Effect {  Roll, Slide, Center, Blend}
            public static void Animate(Control ctl, Effect effect, int msec, int angle)
            {
                int flags = effmap[(int)effect];

                if (ctl.Visible)
                {
                    flags |= 0x10000; angle += 180;
                }
                else
                {
                    if (ctl.TopLevelControl == ctl) flags |= 0x20000;
                    else if (effect == Effect.Blend) throw new ArgumentException();
                }
                flags |= dirmap[(angle % 360) / 45];
                bool ok = AnimateWindow(ctl.Handle, msec, flags);
                if (!ok) throw new Exception("Animation failed");
                ctl.Visible = !ctl.Visible;
            }

            private static int[] dirmap = { 1, 5, 4, 6, 2, 10, 8, 9 };
            private static int[] effmap = { 0, 0x40000, 0x10, 0x80000 };

            [DllImport("user32.dll")]
            private static extern bool AnimateWindow(IntPtr handle, int msec, int flags);

            internal static bool Animate(Panel registroVideo, Effect roll)
            {
                throw new NotImplementedException();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void btMenu_Click(object sender, EventArgs e)
        {
            Util.Animate(menu, Util.Effect.Roll, 150, 360);
            Util.Animate(subMenu, Util.Effect.Roll, 150, 360);
        }

        private void btRegresar_Click(object sender, EventArgs e)
        {
            if (busquedas.Visible == true)
            {
                Util.Animate(busquedas, Util.Effect.Roll, 150, 360);
                Util.Animate(subMenu, Util.Effect.Roll, 150, 360);
                Util.Animate(menu, Util.Effect.Roll, 150, 360);
            }else if (registros.Visible == true){
                Util.Animate(registros, Util.Effect.Roll, 150, 360);
                Util.Animate(subMenu, Util.Effect.Roll, 150, 360);
                Util.Animate(menu, Util.Effect.Roll, 150, 360);
            }else if (configuraciones.Visible == true)
            {
                Util.Animate(configuraciones, Util.Effect.Roll, 150, 360);
                Util.Animate(subMenu, Util.Effect.Roll, 150, 360);
                Util.Animate(menu, Util.Effect.Roll, 150, 360);
            }else{
                Util.Animate(subMenu, Util.Effect.Roll, 150, 360);
                Util.Animate(menu, Util.Effect.Roll, 150, 360);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (busquedas.Visible == true)
            {
              
                Util.Animate(busquedas, Util.Effect.Roll, 150, 360);
                Util.Animate(registros, Util.Effect.Roll, 150, 360);
             
            }
            else if(configuraciones.Visible == true)
            {
                Util.Animate(configuraciones, Util.Effect.Roll, 150, 360);
                Util.Animate(registros, Util.Effect.Roll, 150, 360);
            }
            else
            {
                
                Util.Animate(registros, Util.Effect.Roll, 150, 360);
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            //  Application.Exit();
            ConectarServidor.cerrarConexion();
            this.Hide();
            VentanaLogin looge = new VentanaLogin();
            looge.Show();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (registros.Visible == true)
            {
                Util.Animate(registros, Util.Effect.Roll, 150, 360);
                Util.Animate(busquedas, Util.Effect.Roll, 150, 360);

            }
            else if(configuraciones.Visible == true)
            {
               
                Util.Animate(configuraciones, Util.Effect.Roll, 150, 360);
                Util.Animate(busquedas, Util.Effect.Roll, 150, 360);
            }
            else
            {
                Util.Animate(busquedas, Util.Effect.Roll, 150, 360);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void busquedas_Paint(object sender, PaintEventArgs e)
        {

        }

        private void registros_Paint(object sender, PaintEventArgs e)
        {

        }

        private void subMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.Hide();
            configurarProducto cnfProducto = new configurarProducto();
            cnfProducto.Show();
        }

        private void configuraciones_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btConfiguracion_Click(object sender, EventArgs e)
        {
          
            if (registros.Visible == true)
            {
                Util.Animate(registros, Util.Effect.Roll, 150, 360);
                Util.Animate(configuraciones, Util.Effect.Roll, 150, 360);
            }
            else if (busquedas.Visible == true)
            {
         

                Util.Animate(busquedas, Util.Effect.Roll, 150, 360);
                Util.Animate(configuraciones, Util.Effect.Roll, 150, 360);
            }else
            {
                Util.Animate(configuraciones, Util.Effect.Roll, 150, 360);
            }
        }

        private void btRentar_Click(object sender, EventArgs e)
        {
            Formularios.frmRentaVideo nuevaRenta = new Formularios.frmRentaVideo(user);
            nuevaRenta.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void btRegEmpleado_Click(object sender, EventArgs e)
        {
            //registro empleado
            this.Hide();
            registrarEmpleado regEmpleado = new registrarEmpleado(user);
            regEmpleado.Show();
        }

        private void btRegCliente_Click(object sender, EventArgs e)
        {
            //regisrto cliente
            this.Hide();
            registrarCliente regCliente = new registrarCliente();
            regCliente.Show();
        }

        private void btRegVideo_Click(object sender, EventArgs e)
        {
            //registro video
            this.Hide();
            registrarVideo regVideo = new registrarVideo();
            regVideo.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //registro proveedor
            this.Hide();
            registrarProveedor regProveedor = new registrarProveedor(user);
            regProveedor.Show();
        }

        private void button17_Click(object sender, EventArgs e)
        {

        }

        private void btCotizacion_Click(object sender, EventArgs e)
        {
            Formularios.frmCotizacion nuevaCotizacion = new Formularios.frmCotizacion(user);
            nuevaCotizacion.Show();
            this.Hide();
        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            configurarProveedor cnfProveedor = new configurarProveedor(user);
            cnfProveedor.Show();
        }

        private void registroClientes_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void registroEmpleado_Paint(object sender, PaintEventArgs e)
        {

        }

        private void registroClientes_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void registroEmpleados_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btReportes_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmReportes reporte = new frmReportes(user);
            reporte.Show();
        }

        private void button64_Click(object sender, EventArgs e)
        {

        }

        private void button64_Click_1(object sender, EventArgs e)
        {

        }

        private void button63_Click(object sender, EventArgs e)
        {

        }

        private void button64_Click_2(object sender, EventArgs e)
        {
        
        }

        private void button65_Click(object sender, EventArgs e)
        {
           
        }

        private void button66_Click(object sender, EventArgs e)
        {
           
        }

        private void button67_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAyudaMenu help = new frmAyudaMenu(user);
            help.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Hide();
            busquedaVideo searchVideo = new busquedaVideo(user);
            searchVideo.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            busquedaEmpleado searchEmpleado = new busquedaEmpleado(user);
            searchEmpleado.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            buscarCliente searchCliente= new buscarCliente(user);
            searchCliente.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            busquedaProveedor searchProveedor = new busquedaProveedor(user);
            searchProveedor.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            configurarEmpleado cnfEmpleado = new configurarEmpleado(user);
            cnfEmpleado.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            configurarCliente cnfCliente = new configurarCliente(user);
            cnfCliente.Show();
        }

        private void button69_Click(object sender, EventArgs e)
        {
            this.Hide();
            registroUsuario newUsuario = new registroUsuario(user);
            newUsuario.Show();
        }

        private void button70_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPrivilegios privilegio = new frmPrivilegios(user);
            privilegio.Show();
        }

        private void button68_Click(object sender, EventArgs e)
        {
            this.Hide();
            rmDevoluciones devolucion = new rmDevoluciones(user);
            devolucion.Show();
        }
    }
}

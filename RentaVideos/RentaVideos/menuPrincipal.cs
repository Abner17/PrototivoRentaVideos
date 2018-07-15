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

namespace RentaVideos
{
    public partial class menuPrincipal : Form
    {
        public menuPrincipal()
        {
            InitializeComponent();
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
        int ocultarMenuRegistro = 0;
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
            if (ocultarMenuRegistro == 1)
            {
                ocultarMenuRegistro = 0;
                Util.Animate(registroVideo, Util.Effect.Roll, 150, 360);
            }
            else if (ocultarMenuRegistro == 2)
            {
                ocultarMenuRegistro = 0;
                Util.Animate(registroClientes, Util.Effect.Roll, 150, 360);
            }
            else if (ocultarMenuRegistro == 3)
            {
                ocultarMenuRegistro = 0;
                Util.Animate(registroEmpleados, Util.Effect.Roll, 150, 360);
            }
            else if (ocultarMenuRegistro == 4)
            {
                ocultarMenuRegistro = 0;
                Util.Animate(registroProveedor, Util.Effect.Roll, 150, 360);
            }

            if (busquedas.Visible == true)
            {
              
                Util.Animate(busquedas, Util.Effect.Roll, 150, 360);
                Util.Animate(registros, Util.Effect.Roll, 150, 360);
             
            }
            else if(configuraciones.Visible == true)
            {
                Util.Animate(configuraciones, Util.Effect.Roll, 150, 360);
                Util.Animate(registros, Util.Effect.Roll, 150, 360);
            }else
            {
                
                Util.Animate(registros, Util.Effect.Roll, 150, 360);
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
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

                if (ocultarMenuRegistro == 1)
                {
                    ocultarMenuRegistro = 0;
                    Util.Animate(registroVideo, Util.Effect.Roll, 150, 360);
                }
                else if (ocultarMenuRegistro == 2)
                {
                    ocultarMenuRegistro = 0;
                    Util.Animate(registroClientes, Util.Effect.Roll, 150, 360);
                }
                else if (ocultarMenuRegistro == 4)
                {
                    ocultarMenuRegistro = 0;
                    Util.Animate(registroProveedor, Util.Effect.Roll, 150, 360);
                }
            }
            else if(configuraciones.Visible == true)
            {
               
                Util.Animate(configuraciones, Util.Effect.Roll, 150, 360);
                Util.Animate(busquedas, Util.Effect.Roll, 150, 360);
            }else
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

                if (ocultarMenuRegistro == 1)
                {
                    ocultarMenuRegistro = 0;
                    Util.Animate(registroVideo, Util.Effect.Roll, 150, 360);
                }
                else if (ocultarMenuRegistro == 2)
                {
                    ocultarMenuRegistro = 0;
                    Util.Animate(registroClientes, Util.Effect.Roll, 150, 360);
                }
                else if (ocultarMenuRegistro == 4)
                {
                    ocultarMenuRegistro = 0;
                    Util.Animate(registroProveedor, Util.Effect.Roll, 150, 360);
                }





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
            ocultarMenuRegistro = 3;
            Util.Animate(registroEmpleados, Util.Effect.Roll, 150, 360);
        }

        private void btRegCliente_Click(object sender, EventArgs e)
        {
            //regisrto cliente
            ocultarMenuRegistro = 2;
            Util.Animate(registroClientes, Util.Effect.Roll, 150, 360);
        }

        private void btRegVideo_Click(object sender, EventArgs e)
        {
            //registro video
            ocultarMenuRegistro = 1;
            Util.Animate(registroVideo, Util.Effect.Roll, 150, 360);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //registro proveedor
            ocultarMenuRegistro = 4;
            Util.Animate(registroProveedor, Util.Effect.Roll, 150, 360);
        }

        private void button17_Click(object sender, EventArgs e)
        {

        }

        private void btCotizacion_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
        }

        private void button5_Click_1(object sender, EventArgs e)
        {

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
    }
}

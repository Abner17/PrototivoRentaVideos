using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}

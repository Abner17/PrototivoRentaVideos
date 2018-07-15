using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentaVideos.Formularios
{
    public partial class frmRentaVideo : Form
    {
        public frmRentaVideo()
        {
            InitializeComponent();
        }

        private void lbl_codigo_Click(object sender, EventArgs e)
        {

        }

        private void cbo_genero_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbl_actor_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmRentaVideo_Load(object sender, EventArgs e)
        {

        }

        private void cbo_proveedor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            menuPrincipal menu = new menuPrincipal();
            menu.Show();
        }
    }
}

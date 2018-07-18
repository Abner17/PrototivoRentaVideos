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
    public partial class rmDevoluciones : Form
    {
        public rmDevoluciones()
        {
            InitializeComponent();
        }

        private void btRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            menuPrincipal menu = new menuPrincipal();
            menu.Show();
        }

        private void rmDevoluciones_Load(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

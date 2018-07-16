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
    public partial class busquedaEmpleado : Form
    {
        public busquedaEmpleado()
        {
            InitializeComponent();
        }

        private void btRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            menuPrincipal menu = new menuPrincipal();
            menu.Show();
        }

        private void btBusqueda_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class configurarCliente : Form
    {
        public configurarCliente()
        {
            InitializeComponent();
        }
        string user = "";
        public configurarCliente(string user)
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

        private void configurarCliente_Load(object sender, EventArgs e)
        {

        }
    }
}

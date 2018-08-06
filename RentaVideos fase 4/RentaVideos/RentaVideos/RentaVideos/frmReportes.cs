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
    public partial class frmReportes : Form
    {
        string user = "";
        public frmReportes()
        {
            InitializeComponent();
        }
        public frmReportes(string user)
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

        private void frmReportes_Load(object sender, EventArgs e)
        {

        }
    }
}

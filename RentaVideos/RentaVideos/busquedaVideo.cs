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
    public partial class busquedaVideo : Form
    {
        public busquedaVideo()
        {
            InitializeComponent();
        }
        string user = "";
        public busquedaVideo(string user)
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

        private void busquedaVideo_Load(object sender, EventArgs e)
        {

        }
    }
}

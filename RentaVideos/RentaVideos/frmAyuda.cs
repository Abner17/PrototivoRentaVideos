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
    public partial class frmAyuda : Form
    {
        public frmAyuda()
        {
            InitializeComponent();
        }
        string user = "";
        public frmAyuda(string user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            VentanaLogin log = new VentanaLogin();
            log.Show();
        }

        private void frmAyuda_Load(object sender, EventArgs e)
        {

        }
    }
}

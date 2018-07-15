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
    public partial class VentanaLogin : Form
    {
        public VentanaLogin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btIngresar_Click(object sender, EventArgs e)
        {
            string user = this.txtUser.Text;
            string pass = this.txtPass.Text;
            if((user.Equals("admin")) && (pass.Equals("1234"))){
                this.Hide();
                menuPrincipal menu = new menuPrincipal();
                menu.Show();
            }
            txtUser.Text = "";
            txtPass.Text = "";
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            this.txtPass.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}

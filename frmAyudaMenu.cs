﻿using System;
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
    public partial class frmAyudaMenu : Form
    {
        public frmAyudaMenu()
        {
            InitializeComponent();
        }
        string user = "";
        public frmAyudaMenu(string user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            menuPrincipal menu = new menuPrincipal(user);
            menu.Show();
        }

        private void frmAyudaMenu_Load(object sender, EventArgs e)
        {

        }
    }
}

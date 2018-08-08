namespace RentaVideos.Formularios
{
    partial class frmCotizacion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnl_cotizacion = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btNuevo = new System.Windows.Forms.Button();
            this.btEnviar = new System.Windows.Forms.Button();
            this.btConsulta = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtFecha = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txt_nombreCliente = new System.Windows.Forms.TextBox();
            this.lbl_nombreCliente = new System.Windows.Forms.Label();
            this.txt_direccionCliente = new System.Windows.Forms.TextBox();
            this.lbl_direcion = new System.Windows.Forms.Label();
            this.lbl_telefono = new System.Windows.Forms.Label();
            this.txtNit = new System.Windows.Forms.TextBox();
            this.lbl_nit = new System.Windows.Forms.Label();
            this.txt_telefonoCliente = new System.Windows.Forms.TextBox();
            this.dg_Cotizacion = new System.Windows.Forms.DataGridView();
            this.codigoCotizacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreVideoCotizacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadCotizacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioCotizacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotalCotizacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_fecha = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbl_totalPagar = new System.Windows.Forms.Label();
            this.txt_iva = new System.Windows.Forms.TextBox();
            this.lbl_iva = new System.Windows.Forms.Label();
            this.txt_totalAPagar = new System.Windows.Forms.TextBox();
            this.txt_subTotal = new System.Windows.Forms.TextBox();
            this.lbl_subTotal = new System.Windows.Forms.Label();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgv_Peliculas = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.categoriaVideo = new System.Windows.Forms.ComboBox();
            this.lbl_datosCotizacion = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.button47 = new System.Windows.Forms.Button();
            this.txtMembresia = new System.Windows.Forms.TextBox();
            this.lbl_datosCliente = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtCodigoCotizacion = new System.Windows.Forms.TextBox();
            this.lbl_codigoCotizacion = new System.Windows.Forms.Label();
            this.pnl_cotizacion.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Cotizacion)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Peliculas)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_cotizacion
            // 
            this.pnl_cotizacion.Controls.Add(this.panel8);
            this.pnl_cotizacion.Controls.Add(this.panel6);
            this.pnl_cotizacion.Controls.Add(this.btn_cerrar);
            this.pnl_cotizacion.Controls.Add(this.panel3);
            this.pnl_cotizacion.Controls.Add(this.panel2);
            this.pnl_cotizacion.Controls.Add(this.panel1);
            this.pnl_cotizacion.Location = new System.Drawing.Point(-11, -9);
            this.pnl_cotizacion.Name = "pnl_cotizacion";
            this.pnl_cotizacion.Size = new System.Drawing.Size(1170, 639);
            this.pnl_cotizacion.TabIndex = 0;
            this.pnl_cotizacion.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_cotizacion_Paint);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Teal;
            this.panel8.Controls.Add(this.btNuevo);
            this.panel8.Controls.Add(this.btEnviar);
            this.panel8.Controls.Add(this.btConsulta);
            this.panel8.Location = new System.Drawing.Point(625, 48);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(487, 49);
            this.panel8.TabIndex = 61;
            // 
            // btNuevo
            // 
            this.btNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btNuevo.FlatAppearance.BorderSize = 0;
            this.btNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNuevo.ForeColor = System.Drawing.Color.White;
            this.btNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btNuevo.Location = new System.Drawing.Point(20, 5);
            this.btNuevo.Name = "btNuevo";
            this.btNuevo.Size = new System.Drawing.Size(103, 40);
            this.btNuevo.TabIndex = 91;
            this.btNuevo.Text = "Nuevo";
            this.btNuevo.UseVisualStyleBackColor = false;
            this.btNuevo.Click += new System.EventHandler(this.btNuevo_Click);
            // 
            // btEnviar
            // 
            this.btEnviar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btEnviar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btEnviar.FlatAppearance.BorderSize = 0;
            this.btEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEnviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEnviar.ForeColor = System.Drawing.Color.White;
            this.btEnviar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btEnviar.Location = new System.Drawing.Point(365, 5);
            this.btEnviar.Name = "btEnviar";
            this.btEnviar.Size = new System.Drawing.Size(103, 40);
            this.btEnviar.TabIndex = 92;
            this.btEnviar.Text = "Enviar";
            this.btEnviar.UseVisualStyleBackColor = false;
            this.btEnviar.Click += new System.EventHandler(this.btEnviar_Click);
            // 
            // btConsulta
            // 
            this.btConsulta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btConsulta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btConsulta.FlatAppearance.BorderSize = 0;
            this.btConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConsulta.ForeColor = System.Drawing.Color.White;
            this.btConsulta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btConsulta.Location = new System.Drawing.Point(187, 5);
            this.btConsulta.Name = "btConsulta";
            this.btConsulta.Size = new System.Drawing.Size(119, 40);
            this.btConsulta.TabIndex = 93;
            this.btConsulta.Text = "Consulta";
            this.btConsulta.UseVisualStyleBackColor = false;
            this.btConsulta.Click += new System.EventHandler(this.btConsulta_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel6.Controls.Add(this.pictureBox1);
            this.panel6.Controls.Add(this.txtFecha);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Controls.Add(this.dg_Cotizacion);
            this.panel6.Controls.Add(this.lbl_fecha);
            this.panel6.Controls.Add(this.label1);
            this.panel6.Controls.Add(this.panel4);
            this.panel6.Location = new System.Drawing.Point(572, 121);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(585, 497);
            this.panel6.TabIndex = 60;
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.pictureBox1.Image = global::RentaVideos.Properties.Resources.logoBlanco;
            this.pictureBox1.Location = new System.Drawing.Point(490, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(71, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 94;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txtFecha
            // 
            this.txtFecha.AutoSize = true;
            this.txtFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFecha.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txtFecha.Location = new System.Drawing.Point(75, 11);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(47, 13);
            this.txtFecha.TabIndex = 5;
            this.txtFecha.Text = "FECHA";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel7.Controls.Add(this.txt_nombreCliente);
            this.panel7.Controls.Add(this.lbl_nombreCliente);
            this.panel7.Controls.Add(this.txt_direccionCliente);
            this.panel7.Controls.Add(this.lbl_direcion);
            this.panel7.Controls.Add(this.lbl_telefono);
            this.panel7.Controls.Add(this.txtNit);
            this.panel7.Controls.Add(this.lbl_nit);
            this.panel7.Controls.Add(this.txt_telefonoCliente);
            this.panel7.Location = new System.Drawing.Point(24, 67);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(543, 86);
            this.panel7.TabIndex = 61;
            // 
            // txt_nombreCliente
            // 
            this.txt_nombreCliente.Location = new System.Drawing.Point(120, 10);
            this.txt_nombreCliente.Name = "txt_nombreCliente";
            this.txt_nombreCliente.Size = new System.Drawing.Size(136, 20);
            this.txt_nombreCliente.TabIndex = 5;
            this.txt_nombreCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nombreCliente_KeyPress);
            // 
            // lbl_nombreCliente
            // 
            this.lbl_nombreCliente.AutoSize = true;
            this.lbl_nombreCliente.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_nombreCliente.Location = new System.Drawing.Point(40, 13);
            this.lbl_nombreCliente.Name = "lbl_nombreCliente";
            this.lbl_nombreCliente.Size = new System.Drawing.Size(60, 13);
            this.lbl_nombreCliente.TabIndex = 7;
            this.lbl_nombreCliente.Text = "NOMBRE :";
            // 
            // txt_direccionCliente
            // 
            this.txt_direccionCliente.Location = new System.Drawing.Point(118, 57);
            this.txt_direccionCliente.Name = "txt_direccionCliente";
            this.txt_direccionCliente.ReadOnly = true;
            this.txt_direccionCliente.Size = new System.Drawing.Size(138, 20);
            this.txt_direccionCliente.TabIndex = 11;
            // 
            // lbl_direcion
            // 
            this.lbl_direcion.AutoSize = true;
            this.lbl_direcion.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_direcion.Location = new System.Drawing.Point(40, 60);
            this.lbl_direcion.Name = "lbl_direcion";
            this.lbl_direcion.Size = new System.Drawing.Size(72, 13);
            this.lbl_direcion.TabIndex = 10;
            this.lbl_direcion.Text = "DIRECCION :";
            // 
            // lbl_telefono
            // 
            this.lbl_telefono.AutoSize = true;
            this.lbl_telefono.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_telefono.Location = new System.Drawing.Point(315, 57);
            this.lbl_telefono.Name = "lbl_telefono";
            this.lbl_telefono.Size = new System.Drawing.Size(70, 13);
            this.lbl_telefono.TabIndex = 12;
            this.lbl_telefono.Text = "TELEFONO :";
            // 
            // txtNit
            // 
            this.txtNit.Location = new System.Drawing.Point(399, 14);
            this.txtNit.Name = "txtNit";
            this.txtNit.ReadOnly = true;
            this.txtNit.Size = new System.Drawing.Size(100, 20);
            this.txtNit.TabIndex = 9;
            this.txtNit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNit_KeyPress);
            // 
            // lbl_nit
            // 
            this.lbl_nit.AutoSize = true;
            this.lbl_nit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_nit.Location = new System.Drawing.Point(350, 17);
            this.lbl_nit.Name = "lbl_nit";
            this.lbl_nit.Size = new System.Drawing.Size(31, 13);
            this.lbl_nit.TabIndex = 8;
            this.lbl_nit.Text = "NIT :";
            // 
            // txt_telefonoCliente
            // 
            this.txt_telefonoCliente.Location = new System.Drawing.Point(400, 54);
            this.txt_telefonoCliente.Name = "txt_telefonoCliente";
            this.txt_telefonoCliente.ReadOnly = true;
            this.txt_telefonoCliente.Size = new System.Drawing.Size(100, 20);
            this.txt_telefonoCliente.TabIndex = 13;
            this.txt_telefonoCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_telefonoCliente_KeyPress);
            // 
            // dg_Cotizacion
            // 
            this.dg_Cotizacion.AllowUserToAddRows = false;
            this.dg_Cotizacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_Cotizacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoCotizacion,
            this.nombreVideoCotizacion,
            this.CantidadCotizacion,
            this.PrecioCotizacion,
            this.SubTotalCotizacion});
            this.dg_Cotizacion.Location = new System.Drawing.Point(24, 266);
            this.dg_Cotizacion.MultiSelect = false;
            this.dg_Cotizacion.Name = "dg_Cotizacion";
            this.dg_Cotizacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_Cotizacion.Size = new System.Drawing.Size(543, 222);
            this.dg_Cotizacion.TabIndex = 90;
            this.dg_Cotizacion.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_Cotizacion_CellContentClick);
            this.dg_Cotizacion.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_Cotizacion_CellEndEdit);
            this.dg_Cotizacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dg_Cotizacion_KeyPress);
            // 
            // codigoCotizacion
            // 
            this.codigoCotizacion.HeaderText = "Código";
            this.codigoCotizacion.Name = "codigoCotizacion";
            this.codigoCotizacion.ReadOnly = true;
            // 
            // nombreVideoCotizacion
            // 
            this.nombreVideoCotizacion.HeaderText = "Nombre";
            this.nombreVideoCotizacion.Name = "nombreVideoCotizacion";
            this.nombreVideoCotizacion.ReadOnly = true;
            // 
            // CantidadCotizacion
            // 
            this.CantidadCotizacion.HeaderText = "Cantidad";
            this.CantidadCotizacion.Name = "CantidadCotizacion";
            // 
            // PrecioCotizacion
            // 
            this.PrecioCotizacion.HeaderText = "Precio";
            this.PrecioCotizacion.Name = "PrecioCotizacion";
            this.PrecioCotizacion.ReadOnly = true;
            // 
            // SubTotalCotizacion
            // 
            this.SubTotalCotizacion.HeaderText = "SubTotal";
            this.SubTotalCotizacion.Name = "SubTotalCotizacion";
            // 
            // lbl_fecha
            // 
            this.lbl_fecha.AutoSize = true;
            this.lbl_fecha.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_fecha.Location = new System.Drawing.Point(21, 11);
            this.lbl_fecha.Name = "lbl_fecha";
            this.lbl_fecha.Size = new System.Drawing.Size(48, 13);
            this.lbl_fecha.TabIndex = 2;
            this.lbl_fecha.Text = "FECHA :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(19, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Cotizacion:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel4.Controls.Add(this.lbl_totalPagar);
            this.panel4.Controls.Add(this.txt_iva);
            this.panel4.Controls.Add(this.lbl_iva);
            this.panel4.Controls.Add(this.txt_totalAPagar);
            this.panel4.Controls.Add(this.txt_subTotal);
            this.panel4.Controls.Add(this.lbl_subTotal);
            this.panel4.Location = new System.Drawing.Point(24, 168);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(543, 86);
            this.panel4.TabIndex = 60;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // lbl_totalPagar
            // 
            this.lbl_totalPagar.AutoSize = true;
            this.lbl_totalPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_totalPagar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_totalPagar.Location = new System.Drawing.Point(16, 58);
            this.lbl_totalPagar.Name = "lbl_totalPagar";
            this.lbl_totalPagar.Size = new System.Drawing.Size(92, 13);
            this.lbl_totalPagar.TabIndex = 33;
            this.lbl_totalPagar.Text = "Total a Pagar :";
            // 
            // txt_iva
            // 
            this.txt_iva.Location = new System.Drawing.Point(289, 11);
            this.txt_iva.Name = "txt_iva";
            this.txt_iva.ReadOnly = true;
            this.txt_iva.Size = new System.Drawing.Size(100, 20);
            this.txt_iva.TabIndex = 32;
            // 
            // lbl_iva
            // 
            this.lbl_iva.AutoSize = true;
            this.lbl_iva.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_iva.Location = new System.Drawing.Point(240, 15);
            this.lbl_iva.Name = "lbl_iva";
            this.lbl_iva.Size = new System.Drawing.Size(30, 13);
            this.lbl_iva.TabIndex = 31;
            this.lbl_iva.Text = "IVA :";
            // 
            // txt_totalAPagar
            // 
            this.txt_totalAPagar.Location = new System.Drawing.Point(112, 55);
            this.txt_totalAPagar.Name = "txt_totalAPagar";
            this.txt_totalAPagar.ReadOnly = true;
            this.txt_totalAPagar.Size = new System.Drawing.Size(100, 20);
            this.txt_totalAPagar.TabIndex = 34;
            // 
            // txt_subTotal
            // 
            this.txt_subTotal.Location = new System.Drawing.Point(106, 11);
            this.txt_subTotal.Name = "txt_subTotal";
            this.txt_subTotal.ReadOnly = true;
            this.txt_subTotal.Size = new System.Drawing.Size(100, 20);
            this.txt_subTotal.TabIndex = 24;
            // 
            // lbl_subTotal
            // 
            this.lbl_subTotal.AutoSize = true;
            this.lbl_subTotal.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_subTotal.Location = new System.Drawing.Point(16, 14);
            this.lbl_subTotal.Name = "lbl_subTotal";
            this.lbl_subTotal.Size = new System.Drawing.Size(70, 13);
            this.lbl_subTotal.TabIndex = 23;
            this.lbl_subTotal.Text = "SUBTOTAL :";
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.BackgroundImage = global::RentaVideos.Properties.Resources.exit;
            this.btn_cerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cerrar.FlatAppearance.BorderSize = 0;
            this.btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cerrar.Location = new System.Drawing.Point(1121, 21);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(31, 34);
            this.btn_cerrar.TabIndex = 23;
            this.btn_cerrar.UseVisualStyleBackColor = true;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel3.Controls.Add(this.dgv_Peliculas);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.categoriaVideo);
            this.panel3.Controls.Add(this.lbl_datosCotizacion);
            this.panel3.Location = new System.Drawing.Point(19, 281);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(525, 337);
            this.panel3.TabIndex = 63;
            // 
            // dgv_Peliculas
            // 
            this.dgv_Peliculas.AllowUserToAddRows = false;
            this.dgv_Peliculas.AllowUserToDeleteRows = false;
            this.dgv_Peliculas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Peliculas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.Nombre,
            this.Cantidad,
            this.Precio});
            this.dgv_Peliculas.Location = new System.Drawing.Point(51, 106);
            this.dgv_Peliculas.MultiSelect = false;
            this.dgv_Peliculas.Name = "dgv_Peliculas";
            this.dgv_Peliculas.ReadOnly = true;
            this.dgv_Peliculas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Peliculas.Size = new System.Drawing.Size(417, 223);
            this.dgv_Peliculas.TabIndex = 89;
            this.dgv_Peliculas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // codigo
            // 
            this.codigo.HeaderText = "Código";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Existencias";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(53, 56);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 25);
            this.label9.TabIndex = 88;
            this.label9.Text = "Categoría:";
            // 
            // categoriaVideo
            // 
            this.categoriaVideo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoriaVideo.FormattingEnabled = true;
            this.categoriaVideo.Location = new System.Drawing.Point(194, 53);
            this.categoriaVideo.Name = "categoriaVideo";
            this.categoriaVideo.Size = new System.Drawing.Size(199, 28);
            this.categoriaVideo.TabIndex = 69;
            this.categoriaVideo.SelectedIndexChanged += new System.EventHandler(this.categoriaVideo_SelectedIndexChanged);
            // 
            // lbl_datosCotizacion
            // 
            this.lbl_datosCotizacion.AutoSize = true;
            this.lbl_datosCotizacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_datosCotizacion.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_datosCotizacion.Location = new System.Drawing.Point(57, 15);
            this.lbl_datosCotizacion.Name = "lbl_datosCotizacion";
            this.lbl_datosCotizacion.Size = new System.Drawing.Size(210, 24);
            this.lbl_datosCotizacion.TabIndex = 23;
            this.lbl_datosCotizacion.Text = "DATOS COTIZACION  :";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.lbl_datosCliente);
            this.panel2.Location = new System.Drawing.Point(19, 145);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(525, 96);
            this.panel2.TabIndex = 60;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Teal;
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.button47);
            this.panel5.Controls.Add(this.txtMembresia);
            this.panel5.Location = new System.Drawing.Point(0, 33);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(525, 43);
            this.panel5.TabIndex = 60;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(54, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 15);
            this.label2.TabIndex = 15;
            this.label2.Text = "MEMBRESIA:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button47
            // 
            this.button47.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button47.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button47.FlatAppearance.BorderSize = 0;
            this.button47.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button47.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button47.ForeColor = System.Drawing.Color.White;
            this.button47.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button47.Location = new System.Drawing.Point(291, 2);
            this.button47.Name = "button47";
            this.button47.Size = new System.Drawing.Size(177, 40);
            this.button47.TabIndex = 56;
            this.button47.Text = "Buscar";
            this.button47.UseVisualStyleBackColor = false;
            this.button47.Click += new System.EventHandler(this.button47_Click);
            // 
            // txtMembresia
            // 
            this.txtMembresia.Location = new System.Drawing.Point(153, 12);
            this.txtMembresia.Name = "txtMembresia";
            this.txtMembresia.Size = new System.Drawing.Size(100, 20);
            this.txtMembresia.TabIndex = 14;
            this.txtMembresia.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // lbl_datosCliente
            // 
            this.lbl_datosCliente.AutoSize = true;
            this.lbl_datosCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_datosCliente.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_datosCliente.Location = new System.Drawing.Point(159, 6);
            this.lbl_datosCliente.Name = "lbl_datosCliente";
            this.lbl_datosCliente.Size = new System.Drawing.Size(215, 24);
            this.lbl_datosCliente.TabIndex = 6;
            this.lbl_datosCliente.Text = "DATOS DEL CLIENTE  :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.txtCodigoCotizacion);
            this.panel1.Controls.Add(this.lbl_codigoCotizacion);
            this.panel1.Location = new System.Drawing.Point(23, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(525, 50);
            this.panel1.TabIndex = 59;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtCodigoCotizacion
            // 
            this.txtCodigoCotizacion.Location = new System.Drawing.Point(163, 16);
            this.txtCodigoCotizacion.Name = "txtCodigoCotizacion";
            this.txtCodigoCotizacion.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoCotizacion.TabIndex = 14;
            // 
            // lbl_codigoCotizacion
            // 
            this.lbl_codigoCotizacion.AutoSize = true;
            this.lbl_codigoCotizacion.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_codigoCotizacion.Location = new System.Drawing.Point(14, 19);
            this.lbl_codigoCotizacion.Name = "lbl_codigoCotizacion";
            this.lbl_codigoCotizacion.Size = new System.Drawing.Size(141, 13);
            this.lbl_codigoCotizacion.TabIndex = 1;
            this.lbl_codigoCotizacion.Text = "CODIGO DE COTIZACION :";
            // 
            // frmCotizacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(52)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(1158, 634);
            this.ControlBox = false;
            this.Controls.Add(this.pnl_cotizacion);
            this.Name = "frmCotizacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmCotizacion_Load);
            this.pnl_cotizacion.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Cotizacion)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Peliculas)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_cotizacion;
        private System.Windows.Forms.Label lbl_fecha;
        private System.Windows.Forms.Label lbl_codigoCotizacion;
        private System.Windows.Forms.TextBox txt_totalAPagar;
        private System.Windows.Forms.Label lbl_totalPagar;
        private System.Windows.Forms.TextBox txt_iva;
        private System.Windows.Forms.Label lbl_iva;
        private System.Windows.Forms.TextBox txt_subTotal;
        private System.Windows.Forms.Label lbl_subTotal;
        private System.Windows.Forms.TextBox txt_telefonoCliente;
        private System.Windows.Forms.Label lbl_telefono;
        private System.Windows.Forms.TextBox txt_direccionCliente;
        private System.Windows.Forms.Label lbl_direcion;
        private System.Windows.Forms.TextBox txtNit;
        private System.Windows.Forms.Label lbl_nit;
        private System.Windows.Forms.Label lbl_nombreCliente;
        private System.Windows.Forms.Label lbl_datosCliente;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_nombreCliente;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label txtFecha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMembresia;
        private System.Windows.Forms.TextBox txtCodigoCotizacion;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbl_datosCotizacion;
        private System.Windows.Forms.Button button47;
        private System.Windows.Forms.ComboBox categoriaVideo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgv_Peliculas;
        private System.Windows.Forms.DataGridView dg_Cotizacion;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btConsulta;
        private System.Windows.Forms.Button btEnviar;
        private System.Windows.Forms.Button btNuevo;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoCotizacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreVideoCotizacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadCotizacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioCotizacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotalCotizacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel8;
    }
}
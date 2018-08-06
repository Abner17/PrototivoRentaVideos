namespace RentaVideos.Formularios
{
    partial class frmFactura
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
            this.lbl_codigoFactura = new System.Windows.Forms.Label();
            this.txtMembresia = new System.Windows.Forms.TextBox();
            this.lbl_nombreCliente = new System.Windows.Forms.Label();
            this.txt_nombreCliente = new System.Windows.Forms.TextBox();
            this.lbl_fecha = new System.Windows.Forms.Label();
            this.lbl_vendedor = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_Nit = new System.Windows.Forms.TextBox();
            this.lbl_nit = new System.Windows.Forms.Label();
            this.lbl_formasPago = new System.Windows.Forms.Label();
            this.cbo_formasPago = new System.Windows.Forms.ComboBox();
            this.lbl_total = new System.Windows.Forms.Label();
            this.dgv_Peliculas = new System.Windows.Forms.DataGridView();
            this.cod_Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_iva = new System.Windows.Forms.Label();
            this.lbl_direccion = new System.Windows.Forms.Label();
            this.txt_direccion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cobVideo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button47 = new System.Windows.Forms.Button();
            this.btBusqueda = new System.Windows.Forms.Button();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.txtNo = new System.Windows.Forms.TextBox();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.txtVendedor = new System.Windows.Forms.TextBox();
            this.txtIva = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Peliculas)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_codigoFactura
            // 
            this.lbl_codigoFactura.AutoSize = true;
            this.lbl_codigoFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_codigoFactura.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_codigoFactura.Location = new System.Drawing.Point(446, 30);
            this.lbl_codigoFactura.Name = "lbl_codigoFactura";
            this.lbl_codigoFactura.Size = new System.Drawing.Size(113, 16);
            this.lbl_codigoFactura.TabIndex = 1;
            this.lbl_codigoFactura.Text = "NO. FACTURA:";
            // 
            // txtMembresia
            // 
            this.txtMembresia.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtMembresia.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtMembresia.Location = new System.Drawing.Point(186, 103);
            this.txtMembresia.Name = "txtMembresia";
            this.txtMembresia.Size = new System.Drawing.Size(179, 20);
            this.txtMembresia.TabIndex = 4;
            this.txtMembresia.TextChanged += new System.EventHandler(this.txt_codCliente_TextChanged_1);
            // 
            // lbl_nombreCliente
            // 
            this.lbl_nombreCliente.AutoSize = true;
            this.lbl_nombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombreCliente.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_nombreCliente.Location = new System.Drawing.Point(36, 137);
            this.lbl_nombreCliente.Name = "lbl_nombreCliente";
            this.lbl_nombreCliente.Size = new System.Drawing.Size(144, 16);
            this.lbl_nombreCliente.TabIndex = 5;
            this.lbl_nombreCliente.Text = "NOMBRE CLIENTE:";
            // 
            // txt_nombreCliente
            // 
            this.txt_nombreCliente.Location = new System.Drawing.Point(186, 136);
            this.txt_nombreCliente.Name = "txt_nombreCliente";
            this.txt_nombreCliente.Size = new System.Drawing.Size(179, 20);
            this.txt_nombreCliente.TabIndex = 6;
            this.txt_nombreCliente.TextChanged += new System.EventHandler(this.txt_nombreCliente_TextChanged);
            // 
            // lbl_fecha
            // 
            this.lbl_fecha.AutoSize = true;
            this.lbl_fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_fecha.Location = new System.Drawing.Point(497, 60);
            this.lbl_fecha.Name = "lbl_fecha";
            this.lbl_fecha.Size = new System.Drawing.Size(62, 16);
            this.lbl_fecha.TabIndex = 9;
            this.lbl_fecha.Text = "FECHA:";
            // 
            // lbl_vendedor
            // 
            this.lbl_vendedor.AutoSize = true;
            this.lbl_vendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_vendedor.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_vendedor.Location = new System.Drawing.Point(428, 173);
            this.lbl_vendedor.Name = "lbl_vendedor";
            this.lbl_vendedor.Size = new System.Drawing.Size(97, 16);
            this.lbl_vendedor.TabIndex = 10;
            this.lbl_vendedor.Text = "VENDEDOR:";
            this.lbl_vendedor.Click += new System.EventHandler(this.lbl_vendedor_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label12.Location = new System.Drawing.Point(12, 104);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(168, 16);
            this.label12.TabIndex = 24;
            this.label12.Text = "MEMBRESIA CLIENTE:";
            // 
            // txt_Nit
            // 
            this.txt_Nit.Location = new System.Drawing.Point(186, 169);
            this.txt_Nit.Name = "txt_Nit";
            this.txt_Nit.Size = new System.Drawing.Size(179, 20);
            this.txt_Nit.TabIndex = 27;
            // 
            // lbl_nit
            // 
            this.lbl_nit.AutoSize = true;
            this.lbl_nit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_nit.Location = new System.Drawing.Point(143, 169);
            this.lbl_nit.Name = "lbl_nit";
            this.lbl_nit.Size = new System.Drawing.Size(37, 16);
            this.lbl_nit.TabIndex = 30;
            this.lbl_nit.Text = "NIT:";
            // 
            // lbl_formasPago
            // 
            this.lbl_formasPago.AutoSize = true;
            this.lbl_formasPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_formasPago.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_formasPago.Location = new System.Drawing.Point(396, 201);
            this.lbl_formasPago.Name = "lbl_formasPago";
            this.lbl_formasPago.Size = new System.Drawing.Size(146, 16);
            this.lbl_formasPago.TabIndex = 33;
            this.lbl_formasPago.Text = "FORMAS DE PAGO:";
            // 
            // cbo_formasPago
            // 
            this.cbo_formasPago.AutoCompleteCustomSource.AddRange(new string[] {
            "Tarjeta de Credito/Debito",
            "Cheque",
            "Efectivo"});
            this.cbo_formasPago.FormattingEnabled = true;
            this.cbo_formasPago.Location = new System.Drawing.Point(548, 199);
            this.cbo_formasPago.Name = "cbo_formasPago";
            this.cbo_formasPago.Size = new System.Drawing.Size(121, 21);
            this.cbo_formasPago.TabIndex = 34;
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_total.Location = new System.Drawing.Point(500, 503);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(61, 16);
            this.lbl_total.TabIndex = 36;
            this.lbl_total.Text = "TOTAL:";
            // 
            // dgv_Peliculas
            // 
            this.dgv_Peliculas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Peliculas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cod_Producto,
            this.titulo,
            this.cantidad,
            this.precio,
            this.subtotal});
            this.dgv_Peliculas.Location = new System.Drawing.Point(126, 306);
            this.dgv_Peliculas.Name = "dgv_Peliculas";
            this.dgv_Peliculas.Size = new System.Drawing.Size(541, 150);
            this.dgv_Peliculas.TabIndex = 43;
            this.dgv_Peliculas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // cod_Producto
            // 
            this.cod_Producto.HeaderText = "CODIGO";
            this.cod_Producto.Name = "cod_Producto";
            // 
            // titulo
            // 
            this.titulo.HeaderText = "TITULO";
            this.titulo.Name = "titulo";
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "CANTIDAD";
            this.cantidad.Name = "cantidad";
            // 
            // precio
            // 
            this.precio.HeaderText = "PRECIO";
            this.precio.Name = "precio";
            // 
            // subtotal
            // 
            this.subtotal.HeaderText = "SUBTOTAL";
            this.subtotal.Name = "subtotal";
            // 
            // lbl_iva
            // 
            this.lbl_iva.AutoSize = true;
            this.lbl_iva.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_iva.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_iva.Location = new System.Drawing.Point(529, 474);
            this.lbl_iva.Name = "lbl_iva";
            this.lbl_iva.Size = new System.Drawing.Size(36, 16);
            this.lbl_iva.TabIndex = 44;
            this.lbl_iva.Text = "IVA:";
            // 
            // lbl_direccion
            // 
            this.lbl_direccion.AutoSize = true;
            this.lbl_direccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_direccion.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_direccion.Location = new System.Drawing.Point(88, 202);
            this.lbl_direccion.Name = "lbl_direccion";
            this.lbl_direccion.Size = new System.Drawing.Size(94, 16);
            this.lbl_direccion.TabIndex = 28;
            this.lbl_direccion.Text = "DIRECCION:";
            // 
            // txt_direccion
            // 
            this.txt_direccion.Location = new System.Drawing.Point(186, 202);
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.Size = new System.Drawing.Size(179, 20);
            this.txt_direccion.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(84, 268);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 16);
            this.label1.TabIndex = 75;
            this.label1.Text = "SELECCIONAR VIDEO:";
            // 
            // cobVideo
            // 
            this.cobVideo.AutoCompleteCustomSource.AddRange(new string[] {
            "Tarjeta de Credito/Debito",
            "Cheque",
            "Efectivo"});
            this.cobVideo.FormattingEnabled = true;
            this.cobVideo.Location = new System.Drawing.Point(257, 267);
            this.cobVideo.Name = "cobVideo";
            this.cobVideo.Size = new System.Drawing.Size(141, 21);
            this.cobVideo.TabIndex = 76;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(407, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 78;
            this.label2.Text = "CANTIDAD:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(500, 267);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(66, 20);
            this.txtCantidad.TabIndex = 79;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(56)))), ((int)(((byte)(59)))));
            this.button3.BackgroundImage = global::RentaVideos.Properties.Resources.iconEliminarCompra;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(625, 253);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(45, 42);
            this.button3.TabIndex = 82;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(56)))), ((int)(((byte)(59)))));
            this.button2.BackgroundImage = global::RentaVideos.Properties.Resources.iconAgregarCompra;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(573, 252);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(45, 42);
            this.button2.TabIndex = 77;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(56)))), ((int)(((byte)(59)))));
            this.button1.BackgroundImage = global::RentaVideos.Properties.Resources.iconoCancelar;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(618, 540);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 42);
            this.button1.TabIndex = 73;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button47
            // 
            this.button47.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(56)))), ((int)(((byte)(59)))));
            this.button47.BackgroundImage = global::RentaVideos.Properties.Resources.iconoAceptar;
            this.button47.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button47.FlatAppearance.BorderSize = 0;
            this.button47.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button47.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button47.ForeColor = System.Drawing.Color.White;
            this.button47.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button47.Location = new System.Drawing.Point(567, 540);
            this.button47.Name = "button47";
            this.button47.Size = new System.Drawing.Size(45, 42);
            this.button47.TabIndex = 61;
            this.button47.UseVisualStyleBackColor = false;
            this.button47.Click += new System.EventHandler(this.button47_Click);
            // 
            // btBusqueda
            // 
            this.btBusqueda.BackgroundImage = global::RentaVideos.Properties.Resources.icons8_Search_30px;
            this.btBusqueda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btBusqueda.FlatAppearance.BorderSize = 0;
            this.btBusqueda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBusqueda.ForeColor = System.Drawing.Color.White;
            this.btBusqueda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btBusqueda.Location = new System.Drawing.Point(371, 103);
            this.btBusqueda.Name = "btBusqueda";
            this.btBusqueda.Size = new System.Drawing.Size(27, 28);
            this.btBusqueda.TabIndex = 57;
            this.btBusqueda.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btBusqueda.UseVisualStyleBackColor = true;
            this.btBusqueda.Click += new System.EventHandler(this.btBusqueda_Click);
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.BackgroundImage = global::RentaVideos.Properties.Resources.exit;
            this.btn_cerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cerrar.FlatAppearance.BorderSize = 0;
            this.btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cerrar.Location = new System.Drawing.Point(711, 12);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(31, 34);
            this.btn_cerrar.TabIndex = 51;
            this.btn_cerrar.UseVisualStyleBackColor = true;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // txtNo
            // 
            this.txtNo.Enabled = false;
            this.txtNo.Location = new System.Drawing.Point(567, 26);
            this.txtNo.Name = "txtNo";
            this.txtNo.Size = new System.Drawing.Size(100, 20);
            this.txtNo.TabIndex = 85;
            // 
            // txtFecha
            // 
            this.txtFecha.Enabled = false;
            this.txtFecha.Location = new System.Drawing.Point(567, 60);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(100, 20);
            this.txtFecha.TabIndex = 86;
            // 
            // txtVendedor
            // 
            this.txtVendedor.Enabled = false;
            this.txtVendedor.Location = new System.Drawing.Point(548, 168);
            this.txtVendedor.Name = "txtVendedor";
            this.txtVendedor.Size = new System.Drawing.Size(121, 20);
            this.txtVendedor.TabIndex = 87;
            // 
            // txtIva
            // 
            this.txtIva.Enabled = false;
            this.txtIva.Location = new System.Drawing.Point(567, 473);
            this.txtIva.Name = "txtIva";
            this.txtIva.Size = new System.Drawing.Size(100, 20);
            this.txtIva.TabIndex = 88;
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(567, 503);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 89;
            // 
            // frmFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(56)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(754, 594);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtIva);
            this.Controls.Add(this.txtVendedor);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.txtNo);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cobVideo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button47);
            this.Controls.Add(this.btBusqueda);
            this.Controls.Add(this.btn_cerrar);
            this.Controls.Add(this.lbl_iva);
            this.Controls.Add(this.dgv_Peliculas);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.cbo_formasPago);
            this.Controls.Add(this.lbl_formasPago);
            this.Controls.Add(this.lbl_nit);
            this.Controls.Add(this.txt_direccion);
            this.Controls.Add(this.lbl_direccion);
            this.Controls.Add(this.txt_Nit);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lbl_vendedor);
            this.Controls.Add(this.lbl_fecha);
            this.Controls.Add(this.txt_nombreCliente);
            this.Controls.Add(this.lbl_nombreCliente);
            this.Controls.Add(this.txtMembresia);
            this.Controls.Add(this.lbl_codigoFactura);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "v";
            this.Load += new System.EventHandler(this.frmFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Peliculas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_codigoFactura;
        private System.Windows.Forms.TextBox txtMembresia;
        private System.Windows.Forms.Label lbl_nombreCliente;
        private System.Windows.Forms.TextBox txt_nombreCliente;
        private System.Windows.Forms.Label lbl_fecha;
        private System.Windows.Forms.Label lbl_vendedor;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_Nit;
        private System.Windows.Forms.Label lbl_nit;
        private System.Windows.Forms.Label lbl_formasPago;
        private System.Windows.Forms.ComboBox cbo_formasPago;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.DataGridView dgv_Peliculas;
        private System.Windows.Forms.Label lbl_iva;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.Label lbl_direccion;
        private System.Windows.Forms.TextBox txt_direccion;
        private System.Windows.Forms.Button btBusqueda;
        private System.Windows.Forms.Button button47;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cobVideo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtNo;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.TextBox txtVendedor;
        private System.Windows.Forms.TextBox txtIva;
        private System.Windows.Forms.TextBox txtTotal;
    }
}
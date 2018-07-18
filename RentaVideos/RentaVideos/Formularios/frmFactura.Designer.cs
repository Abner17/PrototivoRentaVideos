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
            this.txt_codFactura = new System.Windows.Forms.TextBox();
            this.lbl_cliente = new System.Windows.Forms.Label();
            this.txt_codCliente = new System.Windows.Forms.TextBox();
            this.lbl_nombreCliente = new System.Windows.Forms.Label();
            this.txt_nombreCliente = new System.Windows.Forms.TextBox();
            this.txt_fecha = new System.Windows.Forms.TextBox();
            this.lbl_fecha = new System.Windows.Forms.Label();
            this.lbl_vendedor = new System.Windows.Forms.Label();
            this.txt_vendedor = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_codClien = new System.Windows.Forms.TextBox();
            this.lbl_telefono = new System.Windows.Forms.Label();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.lbl_direccion = new System.Windows.Forms.Label();
            this.txt_direccion = new System.Windows.Forms.TextBox();
            this.lbl_nit = new System.Windows.Forms.Label();
            this.txt_nit = new System.Windows.Forms.TextBox();
            this.lbl_formasPago = new System.Windows.Forms.Label();
            this.cbo_formasPago = new System.Windows.Forms.ComboBox();
            this.lbl_total = new System.Windows.Forms.Label();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.dgv_Peliculas = new System.Windows.Forms.DataGridView();
            this.cod_Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_iva = new System.Windows.Forms.Label();
            this.txt_iva = new System.Windows.Forms.TextBox();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.btn_cerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Peliculas)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_codigoFactura
            // 
            this.lbl_codigoFactura.AutoSize = true;
            this.lbl_codigoFactura.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_codigoFactura.Location = new System.Drawing.Point(521, 106);
            this.lbl_codigoFactura.Name = "lbl_codigoFactura";
            this.lbl_codigoFactura.Size = new System.Drawing.Size(79, 13);
            this.lbl_codigoFactura.TabIndex = 1;
            this.lbl_codigoFactura.Text = "NO. FACTURA";
            // 
            // txt_codFactura
            // 
            this.txt_codFactura.Location = new System.Drawing.Point(641, 103);
            this.txt_codFactura.Name = "txt_codFactura";
            this.txt_codFactura.Size = new System.Drawing.Size(100, 20);
            this.txt_codFactura.TabIndex = 2;
            // 
            // lbl_cliente
            // 
            this.lbl_cliente.AutoSize = true;
            this.lbl_cliente.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_cliente.Location = new System.Drawing.Point(12, 46);
            this.lbl_cliente.Name = "lbl_cliente";
            this.lbl_cliente.Size = new System.Drawing.Size(55, 13);
            this.lbl_cliente.TabIndex = 3;
            this.lbl_cliente.Text = " CLIENTE";
            // 
            // txt_codCliente
            // 
            this.txt_codCliente.Location = new System.Drawing.Point(136, 106);
            this.txt_codCliente.Name = "txt_codCliente";
            this.txt_codCliente.Size = new System.Drawing.Size(100, 20);
            this.txt_codCliente.TabIndex = 4;
            // 
            // lbl_nombreCliente
            // 
            this.lbl_nombreCliente.AutoSize = true;
            this.lbl_nombreCliente.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_nombreCliente.Location = new System.Drawing.Point(13, 139);
            this.lbl_nombreCliente.Name = "lbl_nombreCliente";
            this.lbl_nombreCliente.Size = new System.Drawing.Size(102, 13);
            this.lbl_nombreCliente.TabIndex = 5;
            this.lbl_nombreCliente.Text = "NOMBRE CLIENTE";
            // 
            // txt_nombreCliente
            // 
            this.txt_nombreCliente.Location = new System.Drawing.Point(136, 132);
            this.txt_nombreCliente.Name = "txt_nombreCliente";
            this.txt_nombreCliente.Size = new System.Drawing.Size(258, 20);
            this.txt_nombreCliente.TabIndex = 6;
            // 
            // txt_fecha
            // 
            this.txt_fecha.Location = new System.Drawing.Point(641, 77);
            this.txt_fecha.Name = "txt_fecha";
            this.txt_fecha.Size = new System.Drawing.Size(100, 20);
            this.txt_fecha.TabIndex = 8;
            // 
            // lbl_fecha
            // 
            this.lbl_fecha.AutoSize = true;
            this.lbl_fecha.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_fecha.Location = new System.Drawing.Point(533, 84);
            this.lbl_fecha.Name = "lbl_fecha";
            this.lbl_fecha.Size = new System.Drawing.Size(42, 13);
            this.lbl_fecha.TabIndex = 9;
            this.lbl_fecha.Text = "FECHA";
            // 
            // lbl_vendedor
            // 
            this.lbl_vendedor.AutoSize = true;
            this.lbl_vendedor.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_vendedor.Location = new System.Drawing.Point(512, 178);
            this.lbl_vendedor.Name = "lbl_vendedor";
            this.lbl_vendedor.Size = new System.Drawing.Size(68, 13);
            this.lbl_vendedor.TabIndex = 10;
            this.lbl_vendedor.Text = "VENDEDOR";
            // 
            // txt_vendedor
            // 
            this.txt_vendedor.Location = new System.Drawing.Point(641, 175);
            this.txt_vendedor.Name = "txt_vendedor";
            this.txt_vendedor.Size = new System.Drawing.Size(100, 20);
            this.txt_vendedor.TabIndex = 11;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label12.Location = new System.Drawing.Point(12, 113);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(97, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "CODIGO CLIENTE";
            // 
            // txt_codClien
            // 
            this.txt_codClien.Location = new System.Drawing.Point(136, 43);
            this.txt_codClien.Name = "txt_codClien";
            this.txt_codClien.Size = new System.Drawing.Size(100, 20);
            this.txt_codClien.TabIndex = 25;
            this.txt_codClien.TextChanged += new System.EventHandler(this.txt_codCliente_TextChanged);
            // 
            // lbl_telefono
            // 
            this.lbl_telefono.AutoSize = true;
            this.lbl_telefono.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_telefono.Location = new System.Drawing.Point(12, 166);
            this.lbl_telefono.Name = "lbl_telefono";
            this.lbl_telefono.Size = new System.Drawing.Size(64, 13);
            this.lbl_telefono.TabIndex = 26;
            this.lbl_telefono.Text = "TELEFONO";
            // 
            // txt_telefono
            // 
            this.txt_telefono.Location = new System.Drawing.Point(136, 159);
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(100, 20);
            this.txt_telefono.TabIndex = 27;
            // 
            // lbl_direccion
            // 
            this.lbl_direccion.AutoSize = true;
            this.lbl_direccion.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_direccion.Location = new System.Drawing.Point(10, 194);
            this.lbl_direccion.Name = "lbl_direccion";
            this.lbl_direccion.Size = new System.Drawing.Size(66, 13);
            this.lbl_direccion.TabIndex = 28;
            this.lbl_direccion.Text = "DIRECCION";
            // 
            // txt_direccion
            // 
            this.txt_direccion.Location = new System.Drawing.Point(136, 191);
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.Size = new System.Drawing.Size(100, 20);
            this.txt_direccion.TabIndex = 29;
            // 
            // lbl_nit
            // 
            this.lbl_nit.AutoSize = true;
            this.lbl_nit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_nit.Location = new System.Drawing.Point(13, 219);
            this.lbl_nit.Name = "lbl_nit";
            this.lbl_nit.Size = new System.Drawing.Size(25, 13);
            this.lbl_nit.TabIndex = 30;
            this.lbl_nit.Text = "NIT";
            // 
            // txt_nit
            // 
            this.txt_nit.Location = new System.Drawing.Point(136, 217);
            this.txt_nit.Name = "txt_nit";
            this.txt_nit.Size = new System.Drawing.Size(100, 20);
            this.txt_nit.TabIndex = 31;
            // 
            // lbl_formasPago
            // 
            this.lbl_formasPago.AutoSize = true;
            this.lbl_formasPago.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_formasPago.Location = new System.Drawing.Point(507, 154);
            this.lbl_formasPago.Name = "lbl_formasPago";
            this.lbl_formasPago.Size = new System.Drawing.Size(103, 13);
            this.lbl_formasPago.TabIndex = 33;
            this.lbl_formasPago.Text = "FORMAS DE PAGO";
            // 
            // cbo_formasPago
            // 
            this.cbo_formasPago.AutoCompleteCustomSource.AddRange(new string[] {
            "Tarjeta de Credito/Debito",
            "Cheque",
            "Efectivo"});
            this.cbo_formasPago.FormattingEnabled = true;
            this.cbo_formasPago.Location = new System.Drawing.Point(641, 151);
            this.cbo_formasPago.Name = "cbo_formasPago";
            this.cbo_formasPago.Size = new System.Drawing.Size(121, 21);
            this.cbo_formasPago.TabIndex = 34;
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_total.Location = new System.Drawing.Point(512, 446);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(45, 13);
            this.lbl_total.TabIndex = 36;
            this.lbl_total.Text = "TOTAL ";
            // 
            // txt_total
            // 
            this.txt_total.Location = new System.Drawing.Point(592, 439);
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(100, 20);
            this.txt_total.TabIndex = 37;
            // 
            // dgv_Peliculas
            // 
            this.dgv_Peliculas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Peliculas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cod_Producto,
            this.descripcion,
            this.cantidad,
            this.precio,
            this.subtotal});
            this.dgv_Peliculas.Location = new System.Drawing.Point(151, 257);
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
            // descripcion
            // 
            this.descripcion.HeaderText = "DESCRIPCION";
            this.descripcion.Name = "descripcion";
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
            this.lbl_iva.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_iva.Location = new System.Drawing.Point(512, 419);
            this.lbl_iva.Name = "lbl_iva";
            this.lbl_iva.Size = new System.Drawing.Size(24, 13);
            this.lbl_iva.TabIndex = 44;
            this.lbl_iva.Text = "IVA";
            // 
            // txt_iva
            // 
            this.txt_iva.Location = new System.Drawing.Point(592, 413);
            this.txt_iva.Name = "txt_iva";
            this.txt_iva.Size = new System.Drawing.Size(100, 20);
            this.txt_iva.TabIndex = 45;
            // 
            // btn_guardar
            // 
            this.btn_guardar.FlatAppearance.BorderSize = 0;
            this.btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.btn_guardar.ForeColor = System.Drawing.Color.White;
            this.btn_guardar.Location = new System.Drawing.Point(285, 509);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(179, 36);
            this.btn_guardar.TabIndex = 46;
            this.btn_guardar.Text = "ACEPTAR";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.FlatAppearance.BorderSize = 0;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.btn_cancelar.ForeColor = System.Drawing.Color.White;
            this.btn_cancelar.Location = new System.Drawing.Point(483, 509);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(179, 36);
            this.btn_cancelar.TabIndex = 48;
            this.btn_cancelar.Text = "CANCELAR";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            // 
            // btn_buscar
            // 
            this.btn_buscar.FlatAppearance.BorderSize = 0;
            this.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.btn_buscar.ForeColor = System.Drawing.Color.White;
            this.btn_buscar.Location = new System.Drawing.Point(242, 31);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(179, 36);
            this.btn_buscar.TabIndex = 50;
            this.btn_buscar.Text = "BUSCAR";
            this.btn_buscar.UseVisualStyleBackColor = true;
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.BackgroundImage = global::RentaVideos.Properties.Resources.exit;
            this.btn_cerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cerrar.FlatAppearance.BorderSize = 0;
            this.btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cerrar.Location = new System.Drawing.Point(875, 12);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(31, 34);
            this.btn_cerrar.TabIndex = 51;
            this.btn_cerrar.UseVisualStyleBackColor = true;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // frmFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(56)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(936, 579);
            this.Controls.Add(this.btn_cerrar);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.txt_iva);
            this.Controls.Add(this.lbl_iva);
            this.Controls.Add(this.dgv_Peliculas);
            this.Controls.Add(this.txt_total);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.cbo_formasPago);
            this.Controls.Add(this.lbl_formasPago);
            this.Controls.Add(this.txt_nit);
            this.Controls.Add(this.lbl_nit);
            this.Controls.Add(this.txt_direccion);
            this.Controls.Add(this.lbl_direccion);
            this.Controls.Add(this.txt_telefono);
            this.Controls.Add(this.lbl_telefono);
            this.Controls.Add(this.txt_codClien);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txt_vendedor);
            this.Controls.Add(this.lbl_vendedor);
            this.Controls.Add(this.lbl_fecha);
            this.Controls.Add(this.txt_fecha);
            this.Controls.Add(this.txt_nombreCliente);
            this.Controls.Add(this.lbl_nombreCliente);
            this.Controls.Add(this.txt_codCliente);
            this.Controls.Add(this.lbl_cliente);
            this.Controls.Add(this.txt_codFactura);
            this.Controls.Add(this.lbl_codigoFactura);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmFactura";
            this.Load += new System.EventHandler(this.frmFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Peliculas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_codigoFactura;
        private System.Windows.Forms.TextBox txt_codFactura;
        private System.Windows.Forms.Label lbl_cliente;
        private System.Windows.Forms.TextBox txt_codCliente;
        private System.Windows.Forms.Label lbl_nombreCliente;
        private System.Windows.Forms.TextBox txt_nombreCliente;
        private System.Windows.Forms.TextBox txt_fecha;
        private System.Windows.Forms.Label lbl_fecha;
        private System.Windows.Forms.Label lbl_vendedor;
        private System.Windows.Forms.TextBox txt_vendedor;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_codClien;
        private System.Windows.Forms.Label lbl_telefono;
        private System.Windows.Forms.TextBox txt_telefono;
        private System.Windows.Forms.Label lbl_direccion;
        private System.Windows.Forms.TextBox txt_direccion;
        private System.Windows.Forms.Label lbl_nit;
        private System.Windows.Forms.TextBox txt_nit;
        private System.Windows.Forms.Label lbl_formasPago;
        private System.Windows.Forms.ComboBox cbo_formasPago;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.DataGridView dgv_Peliculas;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotal;
        private System.Windows.Forms.Label lbl_iva;
        private System.Windows.Forms.TextBox txt_iva;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Button btn_cerrar;
    }
}
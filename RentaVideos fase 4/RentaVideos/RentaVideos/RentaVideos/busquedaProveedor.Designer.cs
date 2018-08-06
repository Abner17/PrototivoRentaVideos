namespace RentaVideos
{
    partial class busquedaProveedor
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btBusqueda = new System.Windows.Forms.Button();
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btRegresar = new System.Windows.Forms.Button();
            this.button40 = new System.Windows.Forms.Button();
            this.button34 = new System.Windows.Forms.Button();
            this.button35 = new System.Windows.Forms.Button();
            this.button37 = new System.Windows.Forms.Button();
            this.button38 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(146)))), ((int)(((byte)(153)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.tbNombre);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btBusqueda);
            this.panel1.Controls.Add(this.tbCodigo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(381, 576);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::RentaVideos.Properties.Resources.icons8_Search_30px;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(327, 185);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(27, 28);
            this.button1.TabIndex = 59;
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbNombre
            // 
            this.tbNombre.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tbNombre.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbNombre.BackColor = System.Drawing.Color.White;
            this.tbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNombre.Location = new System.Drawing.Point(9, 185);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(303, 26);
            this.tbNombre.TabIndex = 58;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(9, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(245, 29);
            this.label2.TabIndex = 57;
            this.label2.Text = "BUSCAR POR NOMBRE: ";
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
            this.btBusqueda.Location = new System.Drawing.Point(327, 99);
            this.btBusqueda.Name = "btBusqueda";
            this.btBusqueda.Size = new System.Drawing.Size(27, 28);
            this.btBusqueda.TabIndex = 56;
            this.btBusqueda.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btBusqueda.UseVisualStyleBackColor = true;
            this.btBusqueda.Click += new System.EventHandler(this.btBusqueda_Click);
            // 
            // tbCodigo
            // 
            this.tbCodigo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbCodigo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbCodigo.BackColor = System.Drawing.Color.White;
            this.tbCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCodigo.Location = new System.Drawing.Point(9, 99);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(303, 26);
            this.tbCodigo.TabIndex = 55;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 29);
            this.label1.TabIndex = 54;
            this.label1.Text = "BUSCAR POR CODIGO:";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(30, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(324, 31);
            this.label8.TabIndex = 53;
            this.label8.Text = "BUSQUEDA PROVEEDOR";
            // 
            // btRegresar
            // 
            this.btRegresar.BackgroundImage = global::RentaVideos.Properties.Resources.left_arrow;
            this.btRegresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btRegresar.FlatAppearance.BorderSize = 0;
            this.btRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRegresar.Location = new System.Drawing.Point(791, 12);
            this.btRegresar.Name = "btRegresar";
            this.btRegresar.Size = new System.Drawing.Size(31, 34);
            this.btRegresar.TabIndex = 52;
            this.btRegresar.UseVisualStyleBackColor = true;
            this.btRegresar.Click += new System.EventHandler(this.btRegresar_Click);
            // 
            // button40
            // 
            this.button40.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button40.FlatAppearance.BorderSize = 0;
            this.button40.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button40.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button40.ForeColor = System.Drawing.Color.White;
            this.button40.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button40.Location = new System.Drawing.Point(491, 236);
            this.button40.Name = "button40";
            this.button40.Size = new System.Drawing.Size(94, 43);
            this.button40.TabIndex = 61;
            this.button40.Text = "E-mail:";
            this.button40.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button40.UseVisualStyleBackColor = true;
            // 
            // button34
            // 
            this.button34.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button34.FlatAppearance.BorderSize = 0;
            this.button34.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button34.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button34.ForeColor = System.Drawing.Color.White;
            this.button34.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button34.Location = new System.Drawing.Point(465, 185);
            this.button34.Name = "button34";
            this.button34.Size = new System.Drawing.Size(120, 43);
            this.button34.TabIndex = 49;
            this.button34.Text = "Teléfono:";
            this.button34.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button34.UseVisualStyleBackColor = true;
            // 
            // button35
            // 
            this.button35.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button35.FlatAppearance.BorderSize = 0;
            this.button35.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button35.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button35.ForeColor = System.Drawing.Color.White;
            this.button35.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button35.Location = new System.Drawing.Point(458, 138);
            this.button35.Name = "button35";
            this.button35.Size = new System.Drawing.Size(127, 43);
            this.button35.TabIndex = 47;
            this.button35.Text = "Dirección: ";
            this.button35.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button35.UseVisualStyleBackColor = true;
            // 
            // button37
            // 
            this.button37.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button37.FlatAppearance.BorderSize = 0;
            this.button37.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button37.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button37.ForeColor = System.Drawing.Color.White;
            this.button37.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button37.Location = new System.Drawing.Point(472, 93);
            this.button37.Name = "button37";
            this.button37.Size = new System.Drawing.Size(113, 43);
            this.button37.TabIndex = 43;
            this.button37.Text = "Nombre: ";
            this.button37.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button37.UseVisualStyleBackColor = true;
            // 
            // button38
            // 
            this.button38.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button38.FlatAppearance.BorderSize = 0;
            this.button38.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button38.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button38.ForeColor = System.Drawing.Color.White;
            this.button38.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button38.Location = new System.Drawing.Point(482, 51);
            this.button38.Name = "button38";
            this.button38.Size = new System.Drawing.Size(103, 43);
            this.button38.TabIndex = 41;
            this.button38.Text = "Código:";
            this.button38.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button38.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::RentaVideos.Properties.Resources.iconNueva2;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(740, 309);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 79);
            this.button2.TabIndex = 66;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblCodigo
            // 
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.ForeColor = System.Drawing.Color.White;
            this.lblCodigo.Location = new System.Drawing.Point(604, 64);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(154, 24);
            this.lblCodigo.TabIndex = 67;
            // 
            // lblNombre
            // 
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(602, 105);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(154, 24);
            this.lblNombre.TabIndex = 68;
            // 
            // lblDireccion
            // 
            this.lblDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.ForeColor = System.Drawing.Color.White;
            this.lblDireccion.Location = new System.Drawing.Point(604, 151);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(154, 24);
            this.lblDireccion.TabIndex = 69;
            // 
            // lblTelefono
            // 
            this.lblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.ForeColor = System.Drawing.Color.White;
            this.lblTelefono.Location = new System.Drawing.Point(602, 198);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(154, 24);
            this.lblTelefono.TabIndex = 70;
            // 
            // lblCorreo
            // 
            this.lblCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.ForeColor = System.Drawing.Color.White;
            this.lblCorreo.Location = new System.Drawing.Point(604, 249);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(154, 24);
            this.lblCorreo.TabIndex = 71;
            // 
            // busquedaProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(56)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(886, 430);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button40);
            this.Controls.Add(this.button34);
            this.Controls.Add(this.button35);
            this.Controls.Add(this.btRegresar);
            this.Controls.Add(this.button37);
            this.Controls.Add(this.button38);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "busquedaProveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "busquedaProveedor";
            this.Load += new System.EventHandler(this.busquedaProveedor_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btBusqueda;
        private System.Windows.Forms.TextBox tbCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btRegresar;
        private System.Windows.Forms.Button button40;
        private System.Windows.Forms.Button button34;
        private System.Windows.Forms.Button button35;
        private System.Windows.Forms.Button button37;
        private System.Windows.Forms.Button button38;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblCorreo;
    }
}
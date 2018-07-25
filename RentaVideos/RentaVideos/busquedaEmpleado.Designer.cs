namespace RentaVideos
{
    partial class busquedaEmpleado
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
            this.txtPuesto = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button45 = new System.Windows.Forms.Button();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.button51 = new System.Windows.Forms.Button();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.button56 = new System.Windows.Forms.Button();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.button57 = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.button58 = new System.Windows.Forms.Button();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.button59 = new System.Windows.Forms.Button();
            this.btIngresar = new System.Windows.Forms.Button();
            this.btRegresar = new System.Windows.Forms.Button();
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
            this.panel1.Size = new System.Drawing.Size(370, 575);
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
            this.button1.Location = new System.Drawing.Point(325, 185);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(27, 28);
            this.button1.TabIndex = 50;
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
            this.tbNombre.ForeColor = System.Drawing.Color.Black;
            this.tbNombre.Location = new System.Drawing.Point(7, 185);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(303, 26);
            this.tbNombre.TabIndex = 49;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(7, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(245, 29);
            this.label2.TabIndex = 48;
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
            this.btBusqueda.Location = new System.Drawing.Point(325, 99);
            this.btBusqueda.Name = "btBusqueda";
            this.btBusqueda.Size = new System.Drawing.Size(27, 28);
            this.btBusqueda.TabIndex = 47;
            this.btBusqueda.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btBusqueda.UseVisualStyleBackColor = true;
            this.btBusqueda.Click += new System.EventHandler(this.btBusqueda_Click);
            // 
            // tbCodigo
            // 
            this.tbCodigo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tbCodigo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbCodigo.BackColor = System.Drawing.Color.White;
            this.tbCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCodigo.ForeColor = System.Drawing.Color.Black;
            this.tbCodigo.Location = new System.Drawing.Point(7, 99);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(303, 26);
            this.tbCodigo.TabIndex = 46;
            this.tbCodigo.TextChanged += new System.EventHandler(this.tbCodigo_TextChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(7, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 29);
            this.label1.TabIndex = 45;
            this.label1.Text = "BUSCAR POR CODIGO:";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(63, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(304, 31);
            this.label8.TabIndex = 44;
            this.label8.Text = "BUSQUEDA EMPLEADO";
            // 
            // txtPuesto
            // 
            this.txtPuesto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(56)))), ((int)(((byte)(59)))));
            this.txtPuesto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPuesto.ForeColor = System.Drawing.Color.White;
            this.txtPuesto.Location = new System.Drawing.Point(606, 336);
            this.txtPuesto.Multiline = true;
            this.txtPuesto.Name = "txtPuesto";
            this.txtPuesto.Size = new System.Drawing.Size(155, 20);
            this.txtPuesto.TabIndex = 63;
            // 
            // txtCorreo
            // 
            this.txtCorreo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(56)))), ((int)(((byte)(59)))));
            this.txtCorreo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.ForeColor = System.Drawing.Color.White;
            this.txtCorreo.Location = new System.Drawing.Point(606, 287);
            this.txtCorreo.Multiline = true;
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(155, 20);
            this.txtCorreo.TabIndex = 62;
            // 
            // button2
            // 
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(489, 321);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 43);
            this.button2.TabIndex = 61;
            this.button2.Text = "Puesto:";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button45
            // 
            this.button45.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button45.FlatAppearance.BorderSize = 0;
            this.button45.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button45.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button45.ForeColor = System.Drawing.Color.White;
            this.button45.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button45.Location = new System.Drawing.Point(497, 272);
            this.button45.Name = "button45";
            this.button45.Size = new System.Drawing.Size(101, 43);
            this.button45.TabIndex = 60;
            this.button45.Text = "E-mail:";
            this.button45.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button45.UseVisualStyleBackColor = true;
            // 
            // txtTelefono
            // 
            this.txtTelefono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(56)))), ((int)(((byte)(59)))));
            this.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.ForeColor = System.Drawing.Color.White;
            this.txtTelefono.Location = new System.Drawing.Point(606, 238);
            this.txtTelefono.Multiline = true;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(155, 20);
            this.txtTelefono.TabIndex = 58;
            // 
            // button51
            // 
            this.button51.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button51.FlatAppearance.BorderSize = 0;
            this.button51.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button51.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button51.ForeColor = System.Drawing.Color.White;
            this.button51.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button51.Location = new System.Drawing.Point(471, 223);
            this.button51.Name = "button51";
            this.button51.Size = new System.Drawing.Size(122, 43);
            this.button51.TabIndex = 57;
            this.button51.Text = "Telefono:";
            this.button51.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button51.UseVisualStyleBackColor = true;
            // 
            // txtDireccion
            // 
            this.txtDireccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(56)))), ((int)(((byte)(59)))));
            this.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.ForeColor = System.Drawing.Color.White;
            this.txtDireccion.Location = new System.Drawing.Point(606, 192);
            this.txtDireccion.Multiline = true;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(153, 20);
            this.txtDireccion.TabIndex = 53;
            // 
            // button56
            // 
            this.button56.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button56.FlatAppearance.BorderSize = 0;
            this.button56.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button56.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button56.ForeColor = System.Drawing.Color.White;
            this.button56.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button56.Location = new System.Drawing.Point(465, 177);
            this.button56.Name = "button56";
            this.button56.Size = new System.Drawing.Size(135, 43);
            this.button56.TabIndex = 52;
            this.button56.Text = "Direccion:";
            this.button56.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button56.UseVisualStyleBackColor = true;
            // 
            // txtApellido
            // 
            this.txtApellido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(56)))), ((int)(((byte)(59)))));
            this.txtApellido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.ForeColor = System.Drawing.Color.White;
            this.txtApellido.Location = new System.Drawing.Point(606, 143);
            this.txtApellido.Multiline = true;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(153, 20);
            this.txtApellido.TabIndex = 51;
            // 
            // button57
            // 
            this.button57.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button57.FlatAppearance.BorderSize = 0;
            this.button57.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button57.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button57.ForeColor = System.Drawing.Color.White;
            this.button57.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button57.Location = new System.Drawing.Point(466, 128);
            this.button57.Name = "button57";
            this.button57.Size = new System.Drawing.Size(135, 43);
            this.button57.TabIndex = 50;
            this.button57.Text = "Apellidos:";
            this.button57.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button57.UseVisualStyleBackColor = true;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(56)))), ((int)(((byte)(59)))));
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.White;
            this.txtNombre.Location = new System.Drawing.Point(606, 98);
            this.txtNombre.Multiline = true;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(155, 20);
            this.txtNombre.TabIndex = 49;
            // 
            // button58
            // 
            this.button58.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button58.FlatAppearance.BorderSize = 0;
            this.button58.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button58.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button58.ForeColor = System.Drawing.Color.White;
            this.button58.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button58.Location = new System.Drawing.Point(468, 83);
            this.button58.Name = "button58";
            this.button58.Size = new System.Drawing.Size(132, 43);
            this.button58.TabIndex = 48;
            this.button58.Text = "Nombres: ";
            this.button58.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button58.UseVisualStyleBackColor = true;
            // 
            // txtCodigo
            // 
            this.txtCodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(56)))), ((int)(((byte)(59)))));
            this.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.ForeColor = System.Drawing.Color.White;
            this.txtCodigo.Location = new System.Drawing.Point(606, 54);
            this.txtCodigo.Multiline = true;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(155, 20);
            this.txtCodigo.TabIndex = 47;
            // 
            // button59
            // 
            this.button59.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button59.FlatAppearance.BorderSize = 0;
            this.button59.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button59.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button59.ForeColor = System.Drawing.Color.White;
            this.button59.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button59.Location = new System.Drawing.Point(487, 39);
            this.button59.Name = "button59";
            this.button59.Size = new System.Drawing.Size(113, 43);
            this.button59.TabIndex = 46;
            this.button59.Text = "Codigo:";
            this.button59.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button59.UseVisualStyleBackColor = true;
            // 
            // btIngresar
            // 
            this.btIngresar.BackgroundImage = global::RentaVideos.Properties.Resources.iconNueva2;
            this.btIngresar.FlatAppearance.BorderSize = 0;
            this.btIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.btIngresar.ForeColor = System.Drawing.Color.White;
            this.btIngresar.Location = new System.Drawing.Point(761, 397);
            this.btIngresar.Name = "btIngresar";
            this.btIngresar.Size = new System.Drawing.Size(82, 79);
            this.btIngresar.TabIndex = 51;
            this.btIngresar.UseVisualStyleBackColor = true;
            this.btIngresar.Click += new System.EventHandler(this.btIngresar_Click);
            // 
            // btRegresar
            // 
            this.btRegresar.BackgroundImage = global::RentaVideos.Properties.Resources.left_arrow;
            this.btRegresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btRegresar.FlatAppearance.BorderSize = 0;
            this.btRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRegresar.Location = new System.Drawing.Point(812, 10);
            this.btRegresar.Name = "btRegresar";
            this.btRegresar.Size = new System.Drawing.Size(31, 34);
            this.btRegresar.TabIndex = 43;
            this.btRegresar.UseVisualStyleBackColor = true;
            this.btRegresar.Click += new System.EventHandler(this.btRegresar_Click);
            // 
            // busquedaEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(56)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(889, 498);
            this.Controls.Add(this.btIngresar);
            this.Controls.Add(this.txtPuesto);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button45);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.button51);
            this.Controls.Add(this.btRegresar);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.button56);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.button57);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.button58);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.button59);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "busquedaEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "busquedaEmpleado";
            this.Load += new System.EventHandler(this.busquedaEmpleado_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btIngresar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btBusqueda;
        private System.Windows.Forms.TextBox tbCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btRegresar;
        private System.Windows.Forms.TextBox txtPuesto;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button45;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Button button51;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Button button56;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Button button57;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button button58;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button button59;
    }
}
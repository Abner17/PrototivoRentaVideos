namespace RentaVideos
{
    partial class registrarCliente
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
            this.button63 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.direccionCliente = new System.Windows.Forms.TextBox();
            this.dpiCliente = new System.Windows.Forms.TextBox();
            this.apellidoCliente = new System.Windows.Forms.TextBox();
            this.nombreCliente = new System.Windows.Forms.TextBox();
            this.nitCliente = new System.Windows.Forms.TextBox();
            this.sexoCliente = new System.Windows.Forms.ComboBox();
            this.fechaCliente = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.emailCliente = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.telefonoCliente = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button47 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // button63
            // 
            this.button63.BackgroundImage = global::RentaVideos.Properties.Resources.left_arrow;
            this.button63.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button63.FlatAppearance.BorderSize = 0;
            this.button63.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button63.Location = new System.Drawing.Point(500, 33);
            this.button63.Name = "button63";
            this.button63.Size = new System.Drawing.Size(31, 34);
            this.button63.TabIndex = 70;
            this.button63.UseVisualStyleBackColor = true;
            this.button63.Click += new System.EventHandler(this.button63_Click);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Image = global::RentaVideos.Properties.Resources.clienteIcono;
            this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label7.Location = new System.Drawing.Point(43, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(425, 58);
            this.label7.TabIndex = 63;
            this.label7.Text = "Regístro de Clientes";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // direccionCliente
            // 
            this.direccionCliente.Location = new System.Drawing.Point(204, 300);
            this.direccionCliente.Name = "direccionCliente";
            this.direccionCliente.Size = new System.Drawing.Size(200, 20);
            this.direccionCliente.TabIndex = 61;
            // 
            // dpiCliente
            // 
            this.dpiCliente.Location = new System.Drawing.Point(204, 253);
            this.dpiCliente.Name = "dpiCliente";
            this.dpiCliente.Size = new System.Drawing.Size(200, 20);
            this.dpiCliente.TabIndex = 56;
            this.dpiCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dpiCliente_KeyPress);
            // 
            // apellidoCliente
            // 
            this.apellidoCliente.Location = new System.Drawing.Point(204, 204);
            this.apellidoCliente.Name = "apellidoCliente";
            this.apellidoCliente.Size = new System.Drawing.Size(200, 20);
            this.apellidoCliente.TabIndex = 54;
            this.apellidoCliente.TextChanged += new System.EventHandler(this.apellidoCliente_TextChanged);
            this.apellidoCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.apellidoCliente_KeyPress);
            // 
            // nombreCliente
            // 
            this.nombreCliente.Location = new System.Drawing.Point(204, 159);
            this.nombreCliente.Name = "nombreCliente";
            this.nombreCliente.Size = new System.Drawing.Size(200, 20);
            this.nombreCliente.TabIndex = 52;
            this.nombreCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nombreCliente_KeyPress);
            // 
            // nitCliente
            // 
            this.nitCliente.Location = new System.Drawing.Point(204, 116);
            this.nitCliente.Name = "nitCliente";
            this.nitCliente.Size = new System.Drawing.Size(200, 20);
            this.nitCliente.TabIndex = 50;
            this.nitCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nitCliente_KeyPress);
            // 
            // sexoCliente
            // 
            this.sexoCliente.FormattingEnabled = true;
            this.sexoCliente.Items.AddRange(new object[] {
            "Femenino",
            "Masculino\t"});
            this.sexoCliente.Location = new System.Drawing.Point(204, 348);
            this.sexoCliente.Name = "sexoCliente";
            this.sexoCliente.Size = new System.Drawing.Size(200, 21);
            this.sexoCliente.TabIndex = 71;
            this.sexoCliente.SelectedIndexChanged += new System.EventHandler(this.sexoCliente_SelectedIndexChanged);
            this.sexoCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sexoCliente_KeyPress);
            // 
            // fechaCliente
            // 
            this.fechaCliente.Location = new System.Drawing.Point(204, 401);
            this.fechaCliente.Name = "fechaCliente";
            this.fechaCliente.Size = new System.Drawing.Size(200, 20);
            this.fechaCliente.TabIndex = 72;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(134, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 25);
            this.label1.TabIndex = 73;
            this.label1.Text = "Nit:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(82, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 25);
            this.label2.TabIndex = 74;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(78, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 25);
            this.label3.TabIndex = 75;
            this.label3.Text = "Apellido: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(125, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 25);
            this.label4.TabIndex = 76;
            this.label4.Text = "DPI:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(63, 294);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 25);
            this.label5.TabIndex = 77;
            this.label5.Text = "Dirección:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(109, 344);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 25);
            this.label6.TabIndex = 78;
            this.label6.Text = "Sexo:";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(63, 382);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 52);
            this.label8.TabIndex = 79;
            this.label8.Text = "Fecha de nacimiento:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(101, 447);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 25);
            this.label9.TabIndex = 80;
            this.label9.Text = "Email: ";
            // 
            // emailCliente
            // 
            this.emailCliente.Location = new System.Drawing.Point(204, 453);
            this.emailCliente.Name = "emailCliente";
            this.emailCliente.Size = new System.Drawing.Size(200, 20);
            this.emailCliente.TabIndex = 81;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(64, 494);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 25);
            this.label10.TabIndex = 82;
            this.label10.Text = "Telefono:";
            // 
            // telefonoCliente
            // 
            this.telefonoCliente.Location = new System.Drawing.Point(204, 500);
            this.telefonoCliente.Name = "telefonoCliente";
            this.telefonoCliente.Size = new System.Drawing.Size(200, 20);
            this.telefonoCliente.TabIndex = 83;
            this.telefonoCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.telefonoCliente_KeyPress);
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
            this.button1.Location = new System.Drawing.Point(486, 568);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 42);
            this.button1.TabIndex = 96;
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
            this.button47.Location = new System.Drawing.Point(423, 568);
            this.button47.Name = "button47";
            this.button47.Size = new System.Drawing.Size(45, 42);
            this.button47.TabIndex = 95;
            this.button47.UseVisualStyleBackColor = false;
            this.button47.Click += new System.EventHandler(this.button47_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel1.Location = new System.Drawing.Point(43, 91);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(425, 460);
            this.panel1.TabIndex = 97;
            // 
            // registrarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(56)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(555, 622);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button47);
            this.Controls.Add(this.telefonoCliente);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.emailCliente);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fechaCliente);
            this.Controls.Add(this.sexoCliente);
            this.Controls.Add(this.button63);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.direccionCliente);
            this.Controls.Add(this.dpiCliente);
            this.Controls.Add(this.apellidoCliente);
            this.Controls.Add(this.nombreCliente);
            this.Controls.Add(this.nitCliente);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "registrarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "registrarCliente";
            this.Load += new System.EventHandler(this.registrarCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button63;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox direccionCliente;
        private System.Windows.Forms.TextBox dpiCliente;
        private System.Windows.Forms.TextBox apellidoCliente;
        private System.Windows.Forms.TextBox nombreCliente;
        private System.Windows.Forms.TextBox nitCliente;
        private System.Windows.Forms.ComboBox sexoCliente;
        private System.Windows.Forms.DateTimePicker fechaCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox emailCliente;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox telefonoCliente;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button47;
        private System.Windows.Forms.Panel panel1;
    }
}
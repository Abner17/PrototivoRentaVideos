namespace RentaVideos
{
    partial class registrarVideo
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
            this.label5 = new System.Windows.Forms.Label();
            this.precioVideo = new System.Windows.Forms.TextBox();
            this.descripcionVideo = new System.Windows.Forms.RichTextBox();
            this.actorPrincipalVideo = new System.Windows.Forms.ComboBox();
            this.categoriaVideo = new System.Windows.Forms.ComboBox();
            this.formatoVideo = new System.Windows.Forms.ComboBox();
            this.directorVideo = new System.Windows.Forms.ComboBox();
            this.copiasVideo = new System.Windows.Forms.TextBox();
            this.duracionVideo = new System.Windows.Forms.TextBox();
            this.tituloVideo = new System.Windows.Forms.TextBox();
            this.codigoVideo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.anioVideo = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.button66 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button47 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Image = global::RentaVideos.Properties.Resources.videoIcono;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Location = new System.Drawing.Point(44, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(475, 58);
            this.label5.TabIndex = 74;
            this.label5.Text = "Regístro de Videos";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // precioVideo
            // 
            this.precioVideo.Location = new System.Drawing.Point(233, 293);
            this.precioVideo.Name = "precioVideo";
            this.precioVideo.Size = new System.Drawing.Size(199, 20);
            this.precioVideo.TabIndex = 72;
            this.precioVideo.TextChanged += new System.EventHandler(this.precioVideo_TextChanged);
            // 
            // descripcionVideo
            // 
            this.descripcionVideo.Location = new System.Drawing.Point(234, 579);
            this.descripcionVideo.Name = "descripcionVideo";
            this.descripcionVideo.Size = new System.Drawing.Size(199, 50);
            this.descripcionVideo.TabIndex = 70;
            this.descripcionVideo.Text = "";
            this.descripcionVideo.TextChanged += new System.EventHandler(this.descripcionVideo_TextChanged);
            // 
            // actorPrincipalVideo
            // 
            this.actorPrincipalVideo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actorPrincipalVideo.FormattingEnabled = true;
            this.actorPrincipalVideo.Location = new System.Drawing.Point(234, 532);
            this.actorPrincipalVideo.Name = "actorPrincipalVideo";
            this.actorPrincipalVideo.Size = new System.Drawing.Size(199, 28);
            this.actorPrincipalVideo.TabIndex = 69;
            this.actorPrincipalVideo.SelectedIndexChanged += new System.EventHandler(this.actorPrincipalVideo_SelectedIndexChanged);
            // 
            // categoriaVideo
            // 
            this.categoriaVideo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoriaVideo.FormattingEnabled = true;
            this.categoriaVideo.Location = new System.Drawing.Point(234, 482);
            this.categoriaVideo.Name = "categoriaVideo";
            this.categoriaVideo.Size = new System.Drawing.Size(199, 28);
            this.categoriaVideo.TabIndex = 68;
            this.categoriaVideo.SelectedIndexChanged += new System.EventHandler(this.categoriaVideo_SelectedIndexChanged);
            // 
            // formatoVideo
            // 
            this.formatoVideo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formatoVideo.FormattingEnabled = true;
            this.formatoVideo.Location = new System.Drawing.Point(232, 427);
            this.formatoVideo.Name = "formatoVideo";
            this.formatoVideo.Size = new System.Drawing.Size(201, 28);
            this.formatoVideo.TabIndex = 67;
            this.formatoVideo.SelectedIndexChanged += new System.EventHandler(this.formatoVideo_SelectedIndexChanged);
            // 
            // directorVideo
            // 
            this.directorVideo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.directorVideo.FormattingEnabled = true;
            this.directorVideo.Items.AddRange(new object[] {
            "Agregar nuevo"});
            this.directorVideo.Location = new System.Drawing.Point(233, 375);
            this.directorVideo.Name = "directorVideo";
            this.directorVideo.Size = new System.Drawing.Size(200, 28);
            this.directorVideo.TabIndex = 66;
            this.directorVideo.SelectedIndexChanged += new System.EventHandler(this.directorVideo_SelectedIndexChanged);
            // 
            // copiasVideo
            // 
            this.copiasVideo.Location = new System.Drawing.Point(232, 251);
            this.copiasVideo.Name = "copiasVideo";
            this.copiasVideo.Size = new System.Drawing.Size(199, 20);
            this.copiasVideo.TabIndex = 60;
            this.copiasVideo.TextChanged += new System.EventHandler(this.copiasVideo_TextChanged);
            this.copiasVideo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.copiasVideo_KeyPress);
            // 
            // duracionVideo
            // 
            this.duracionVideo.Location = new System.Drawing.Point(233, 210);
            this.duracionVideo.Name = "duracionVideo";
            this.duracionVideo.Size = new System.Drawing.Size(199, 20);
            this.duracionVideo.TabIndex = 58;
            this.duracionVideo.TextChanged += new System.EventHandler(this.duracionVideo_TextChanged);
            // 
            // tituloVideo
            // 
            this.tituloVideo.Location = new System.Drawing.Point(233, 165);
            this.tituloVideo.Name = "tituloVideo";
            this.tituloVideo.Size = new System.Drawing.Size(198, 20);
            this.tituloVideo.TabIndex = 54;
            this.tituloVideo.TextChanged += new System.EventHandler(this.tituloVideo_TextChanged);
            // 
            // codigoVideo
            // 
            this.codigoVideo.Location = new System.Drawing.Point(233, 121);
            this.codigoVideo.Name = "codigoVideo";
            this.codigoVideo.Size = new System.Drawing.Size(198, 20);
            this.codigoVideo.TabIndex = 52;
            this.codigoVideo.TextChanged += new System.EventHandler(this.codigoVideo_TextChanged);
            this.codigoVideo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.codigoVideo_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(142, 330);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 25);
            this.label6.TabIndex = 84;
            this.label6.Text = "Año:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(116, 288);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 25);
            this.label1.TabIndex = 83;
            this.label1.Text = "Precio:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(110, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 25);
            this.label4.TabIndex = 82;
            this.label4.Text = "Copias:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(90, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 25);
            this.label3.TabIndex = 81;
            this.label3.Text = "Duración:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(125, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 25);
            this.label2.TabIndex = 80;
            this.label2.Text = "Título:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(111, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 25);
            this.label7.TabIndex = 79;
            this.label7.Text = "Código:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(56, 535);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(173, 25);
            this.label8.TabIndex = 88;
            this.label8.Text = "Actor Principal:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(83, 483);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 25);
            this.label9.TabIndex = 87;
            this.label9.Text = "Categoría:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(98, 429);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 25);
            this.label10.TabIndex = 86;
            this.label10.Text = "Formato:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(100, 374);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 25);
            this.label11.TabIndex = 85;
            this.label11.Text = "Director:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(62, 579);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(143, 25);
            this.label12.TabIndex = 89;
            this.label12.Text = "Descripción:";
            // 
            // anioVideo
            // 
            this.anioVideo.Location = new System.Drawing.Point(232, 333);
            this.anioVideo.Name = "anioVideo";
            this.anioVideo.Size = new System.Drawing.Size(200, 20);
            this.anioVideo.TabIndex = 90;
            this.anioVideo.ValueChanged += new System.EventHandler(this.anioVideo_ValueChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(438, 205);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(56, 25);
            this.label14.TabIndex = 92;
            this.label14.Text = "min.";
            // 
            // button66
            // 
            this.button66.BackgroundImage = global::RentaVideos.Properties.Resources.left_arrow;
            this.button66.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button66.FlatAppearance.BorderSize = 0;
            this.button66.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button66.Location = new System.Drawing.Point(552, 37);
            this.button66.Name = "button66";
            this.button66.Size = new System.Drawing.Size(31, 34);
            this.button66.TabIndex = 76;
            this.button66.UseVisualStyleBackColor = true;
            this.button66.Click += new System.EventHandler(this.button66_Click);
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
            this.button1.Location = new System.Drawing.Point(538, 676);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 42);
            this.button1.TabIndex = 94;
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
            this.button47.Location = new System.Drawing.Point(475, 676);
            this.button47.Name = "button47";
            this.button47.Size = new System.Drawing.Size(45, 42);
            this.button47.TabIndex = 93;
            this.button47.UseVisualStyleBackColor = false;
            this.button47.Click += new System.EventHandler(this.button47_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel1.Location = new System.Drawing.Point(49, 96);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(470, 567);
            this.panel1.TabIndex = 95;
            // 
            // registrarVideo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(56)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(609, 730);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button47);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.anioVideo);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button66);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.precioVideo);
            this.Controls.Add(this.descripcionVideo);
            this.Controls.Add(this.actorPrincipalVideo);
            this.Controls.Add(this.categoriaVideo);
            this.Controls.Add(this.formatoVideo);
            this.Controls.Add(this.directorVideo);
            this.Controls.Add(this.copiasVideo);
            this.Controls.Add(this.duracionVideo);
            this.Controls.Add(this.tituloVideo);
            this.Controls.Add(this.codigoVideo);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "registrarVideo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "registrarVideo";
            this.Load += new System.EventHandler(this.registrarVideo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button66;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox precioVideo;
        private System.Windows.Forms.RichTextBox descripcionVideo;
        private System.Windows.Forms.ComboBox actorPrincipalVideo;
        private System.Windows.Forms.ComboBox categoriaVideo;
        private System.Windows.Forms.ComboBox formatoVideo;
        private System.Windows.Forms.ComboBox directorVideo;
        private System.Windows.Forms.TextBox copiasVideo;
        private System.Windows.Forms.TextBox duracionVideo;
        private System.Windows.Forms.TextBox tituloVideo;
        private System.Windows.Forms.TextBox codigoVideo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker anioVideo;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button47;
        private System.Windows.Forms.Panel panel1;
    }
}
namespace RentaVideos.Formularios
{
    partial class frmRentaVideo
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_codigo = new System.Windows.Forms.Label();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.lbl_nombrePelicula = new System.Windows.Forms.Label();
            this.txt_nombrePelicula = new System.Windows.Forms.TextBox();
            this.lbl_directorPelicula = new System.Windows.Forms.Label();
            this.txt_directorPelicula = new System.Windows.Forms.TextBox();
            this.lbl_actor = new System.Windows.Forms.Label();
            this.txt_actor = new System.Windows.Forms.TextBox();
            this.lbl_genero = new System.Windows.Forms.Label();
            this.lbl_apto = new System.Windows.Forms.Label();
            this.lbl_duracion = new System.Windows.Forms.Label();
            this.pnl_datosPeliculas = new System.Windows.Forms.Panel();
            this.txtAño = new System.Windows.Forms.TextBox();
            this.txtGenero = new System.Windows.Forms.TextBox();
            this.txtDuracion = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.lbl_datosAdicionales = new System.Windows.Forms.Label();
            this.pnl_datosRenta = new System.Windows.Forms.Panel();
            this.btn_facturar = new System.Windows.Forms.Button();
            this.txt_descripcionPelicula = new System.Windows.Forms.TextBox();
            this.lbl_descripcionPelicula = new System.Windows.Forms.Label();
            this.txt_cobroDemora = new System.Windows.Forms.TextBox();
            this.lbl_CoboPorDemora = new System.Windows.Forms.Label();
            this.txt_precioRenta = new System.Windows.Forms.TextBox();
            this.lbl_precioRenta = new System.Windows.Forms.Label();
            this.txt_formato = new System.Windows.Forms.TextBox();
            this.lbl_formato = new System.Windows.Forms.Label();
            this.txt_disponible = new System.Windows.Forms.TextBox();
            this.lbl_disponible = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblidRenta = new System.Windows.Forms.Label();
            this.pnl_datosPeliculas.SuspendLayout();
            this.pnl_datosRenta.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(20, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "DATOS PRINCIPALES DE PELICULAS :";
            // 
            // lbl_codigo
            // 
            this.lbl_codigo.AutoSize = true;
            this.lbl_codigo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_codigo.Location = new System.Drawing.Point(21, 52);
            this.lbl_codigo.Name = "lbl_codigo";
            this.lbl_codigo.Size = new System.Drawing.Size(55, 13);
            this.lbl_codigo.TabIndex = 1;
            this.lbl_codigo.Text = "CODIGO :";
            this.lbl_codigo.Click += new System.EventHandler(this.lbl_codigo_Click);
            // 
            // txt_codigo
            // 
            this.txt_codigo.Location = new System.Drawing.Point(113, 52);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(121, 20);
            this.txt_codigo.TabIndex = 2;
            // 
            // lbl_nombrePelicula
            // 
            this.lbl_nombrePelicula.AutoSize = true;
            this.lbl_nombrePelicula.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_nombrePelicula.Location = new System.Drawing.Point(21, 90);
            this.lbl_nombrePelicula.Name = "lbl_nombrePelicula";
            this.lbl_nombrePelicula.Size = new System.Drawing.Size(60, 13);
            this.lbl_nombrePelicula.TabIndex = 3;
            this.lbl_nombrePelicula.Text = "NOMBRE :";
            // 
            // txt_nombrePelicula
            // 
            this.txt_nombrePelicula.Location = new System.Drawing.Point(113, 90);
            this.txt_nombrePelicula.Name = "txt_nombrePelicula";
            this.txt_nombrePelicula.Size = new System.Drawing.Size(121, 20);
            this.txt_nombrePelicula.TabIndex = 4;
            // 
            // lbl_directorPelicula
            // 
            this.lbl_directorPelicula.AutoSize = true;
            this.lbl_directorPelicula.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_directorPelicula.Location = new System.Drawing.Point(22, 161);
            this.lbl_directorPelicula.Name = "lbl_directorPelicula";
            this.lbl_directorPelicula.Size = new System.Drawing.Size(69, 13);
            this.lbl_directorPelicula.TabIndex = 7;
            this.lbl_directorPelicula.Text = "DIRECTOR :";
            // 
            // txt_directorPelicula
            // 
            this.txt_directorPelicula.Location = new System.Drawing.Point(113, 158);
            this.txt_directorPelicula.Name = "txt_directorPelicula";
            this.txt_directorPelicula.Size = new System.Drawing.Size(121, 20);
            this.txt_directorPelicula.TabIndex = 8;
            // 
            // lbl_actor
            // 
            this.lbl_actor.AutoSize = true;
            this.lbl_actor.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_actor.Location = new System.Drawing.Point(22, 203);
            this.lbl_actor.Name = "lbl_actor";
            this.lbl_actor.Size = new System.Drawing.Size(50, 13);
            this.lbl_actor.TabIndex = 9;
            this.lbl_actor.Text = "ACTOR :";
            this.lbl_actor.Click += new System.EventHandler(this.lbl_actor_Click);
            // 
            // txt_actor
            // 
            this.txt_actor.Location = new System.Drawing.Point(113, 196);
            this.txt_actor.Name = "txt_actor";
            this.txt_actor.Size = new System.Drawing.Size(121, 20);
            this.txt_actor.TabIndex = 10;
            // 
            // lbl_genero
            // 
            this.lbl_genero.AutoSize = true;
            this.lbl_genero.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_genero.Location = new System.Drawing.Point(22, 243);
            this.lbl_genero.Name = "lbl_genero";
            this.lbl_genero.Size = new System.Drawing.Size(59, 13);
            this.lbl_genero.TabIndex = 11;
            this.lbl_genero.Text = "GENERO :";
            // 
            // lbl_apto
            // 
            this.lbl_apto.AutoSize = true;
            this.lbl_apto.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_apto.Location = new System.Drawing.Point(22, 287);
            this.lbl_apto.Name = "lbl_apto";
            this.lbl_apto.Size = new System.Drawing.Size(33, 13);
            this.lbl_apto.TabIndex = 13;
            this.lbl_apto.Text = "AÑO:";
            // 
            // lbl_duracion
            // 
            this.lbl_duracion.AutoSize = true;
            this.lbl_duracion.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_duracion.Location = new System.Drawing.Point(22, 335);
            this.lbl_duracion.Name = "lbl_duracion";
            this.lbl_duracion.Size = new System.Drawing.Size(70, 13);
            this.lbl_duracion.TabIndex = 15;
            this.lbl_duracion.Text = "DURACION :";
            // 
            // pnl_datosPeliculas
            // 
            this.pnl_datosPeliculas.Controls.Add(this.lblidRenta);
            this.pnl_datosPeliculas.Controls.Add(this.label3);
            this.pnl_datosPeliculas.Controls.Add(this.txtAño);
            this.pnl_datosPeliculas.Controls.Add(this.txtGenero);
            this.pnl_datosPeliculas.Controls.Add(this.txtDuracion);
            this.pnl_datosPeliculas.Controls.Add(this.button3);
            this.pnl_datosPeliculas.Controls.Add(this.btn_buscar);
            this.pnl_datosPeliculas.Controls.Add(this.label1);
            this.pnl_datosPeliculas.Controls.Add(this.lbl_datosAdicionales);
            this.pnl_datosPeliculas.Controls.Add(this.lbl_codigo);
            this.pnl_datosPeliculas.Controls.Add(this.txt_codigo);
            this.pnl_datosPeliculas.Controls.Add(this.lbl_duracion);
            this.pnl_datosPeliculas.Controls.Add(this.lbl_nombrePelicula);
            this.pnl_datosPeliculas.Controls.Add(this.txt_nombrePelicula);
            this.pnl_datosPeliculas.Controls.Add(this.lbl_apto);
            this.pnl_datosPeliculas.Controls.Add(this.lbl_genero);
            this.pnl_datosPeliculas.Controls.Add(this.lbl_directorPelicula);
            this.pnl_datosPeliculas.Controls.Add(this.txt_actor);
            this.pnl_datosPeliculas.Controls.Add(this.txt_directorPelicula);
            this.pnl_datosPeliculas.Controls.Add(this.lbl_actor);
            this.pnl_datosPeliculas.Location = new System.Drawing.Point(12, 12);
            this.pnl_datosPeliculas.Name = "pnl_datosPeliculas";
            this.pnl_datosPeliculas.Size = new System.Drawing.Size(459, 506);
            this.pnl_datosPeliculas.TabIndex = 20;
            // 
            // txtAño
            // 
            this.txtAño.Location = new System.Drawing.Point(113, 280);
            this.txtAño.Name = "txtAño";
            this.txtAño.Size = new System.Drawing.Size(121, 20);
            this.txtAño.TabIndex = 57;
            // 
            // txtGenero
            // 
            this.txtGenero.Location = new System.Drawing.Point(113, 236);
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.Size = new System.Drawing.Size(121, 20);
            this.txtGenero.TabIndex = 56;
            // 
            // txtDuracion
            // 
            this.txtDuracion.Location = new System.Drawing.Point(113, 328);
            this.txtDuracion.Name = "txtDuracion";
            this.txtDuracion.Size = new System.Drawing.Size(121, 20);
            this.txtDuracion.TabIndex = 55;
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(255, 220);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(179, 36);
            this.button3.TabIndex = 54;
            this.button3.Text = "NUEVO GENERO";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_buscar
            // 
            this.btn_buscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_buscar.FlatAppearance.BorderSize = 0;
            this.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.btn_buscar.ForeColor = System.Drawing.Color.White;
            this.btn_buscar.Location = new System.Drawing.Point(255, 64);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(179, 36);
            this.btn_buscar.TabIndex = 51;
            this.btn_buscar.Text = "BUSCAR";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // lbl_datosAdicionales
            // 
            this.lbl_datosAdicionales.AutoSize = true;
            this.lbl_datosAdicionales.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_datosAdicionales.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_datosAdicionales.Location = new System.Drawing.Point(20, 123);
            this.lbl_datosAdicionales.Name = "lbl_datosAdicionales";
            this.lbl_datosAdicionales.Size = new System.Drawing.Size(214, 24);
            this.lbl_datosAdicionales.TabIndex = 19;
            this.lbl_datosAdicionales.Text = "DATOS ADICIONALES :";
            this.lbl_datosAdicionales.Click += new System.EventHandler(this.label2_Click);
            // 
            // pnl_datosRenta
            // 
            this.pnl_datosRenta.Controls.Add(this.button1);
            this.pnl_datosRenta.Controls.Add(this.btn_facturar);
            this.pnl_datosRenta.Controls.Add(this.txt_descripcionPelicula);
            this.pnl_datosRenta.Controls.Add(this.lbl_descripcionPelicula);
            this.pnl_datosRenta.Controls.Add(this.txt_cobroDemora);
            this.pnl_datosRenta.Controls.Add(this.lbl_CoboPorDemora);
            this.pnl_datosRenta.Controls.Add(this.txt_precioRenta);
            this.pnl_datosRenta.Controls.Add(this.lbl_precioRenta);
            this.pnl_datosRenta.Controls.Add(this.txt_formato);
            this.pnl_datosRenta.Controls.Add(this.lbl_formato);
            this.pnl_datosRenta.Controls.Add(this.txt_disponible);
            this.pnl_datosRenta.Controls.Add(this.lbl_disponible);
            this.pnl_datosRenta.Controls.Add(this.label2);
            this.pnl_datosRenta.Location = new System.Drawing.Point(477, 12);
            this.pnl_datosRenta.Name = "pnl_datosRenta";
            this.pnl_datosRenta.Size = new System.Drawing.Size(520, 506);
            this.pnl_datosRenta.TabIndex = 21;
            // 
            // btn_facturar
            // 
            this.btn_facturar.FlatAppearance.BorderSize = 0;
            this.btn_facturar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_facturar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.btn_facturar.ForeColor = System.Drawing.Color.White;
            this.btn_facturar.Location = new System.Drawing.Point(221, 467);
            this.btn_facturar.Name = "btn_facturar";
            this.btn_facturar.Size = new System.Drawing.Size(296, 36);
            this.btn_facturar.TabIndex = 56;
            this.btn_facturar.Text = "GUARDAR Y FACTURAR";
            this.btn_facturar.UseVisualStyleBackColor = true;
            this.btn_facturar.Click += new System.EventHandler(this.btn_facturar_Click);
            // 
            // txt_descripcionPelicula
            // 
            this.txt_descripcionPelicula.Location = new System.Drawing.Point(50, 287);
            this.txt_descripcionPelicula.Multiline = true;
            this.txt_descripcionPelicula.Name = "txt_descripcionPelicula";
            this.txt_descripcionPelicula.Size = new System.Drawing.Size(341, 20);
            this.txt_descripcionPelicula.TabIndex = 11;
            // 
            // lbl_descripcionPelicula
            // 
            this.lbl_descripcionPelicula.AutoSize = true;
            this.lbl_descripcionPelicula.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_descripcionPelicula.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_descripcionPelicula.Location = new System.Drawing.Point(50, 243);
            this.lbl_descripcionPelicula.Name = "lbl_descripcionPelicula";
            this.lbl_descripcionPelicula.Size = new System.Drawing.Size(288, 24);
            this.lbl_descripcionPelicula.TabIndex = 10;
            this.lbl_descripcionPelicula.Text = "DESCRIPCION DE LA PELICULA";
            // 
            // txt_cobroDemora
            // 
            this.txt_cobroDemora.Location = new System.Drawing.Point(156, 175);
            this.txt_cobroDemora.Name = "txt_cobroDemora";
            this.txt_cobroDemora.Size = new System.Drawing.Size(121, 20);
            this.txt_cobroDemora.TabIndex = 9;
            // 
            // lbl_CoboPorDemora
            // 
            this.lbl_CoboPorDemora.AutoSize = true;
            this.lbl_CoboPorDemora.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_CoboPorDemora.Location = new System.Drawing.Point(23, 178);
            this.lbl_CoboPorDemora.Name = "lbl_CoboPorDemora";
            this.lbl_CoboPorDemora.Size = new System.Drawing.Size(127, 13);
            this.lbl_CoboPorDemora.TabIndex = 8;
            this.lbl_CoboPorDemora.Text = "COBRO POR DEMORA :";
            // 
            // txt_precioRenta
            // 
            this.txt_precioRenta.Location = new System.Drawing.Point(155, 134);
            this.txt_precioRenta.Name = "txt_precioRenta";
            this.txt_precioRenta.Size = new System.Drawing.Size(121, 20);
            this.txt_precioRenta.TabIndex = 7;
            // 
            // lbl_precioRenta
            // 
            this.lbl_precioRenta.AutoSize = true;
            this.lbl_precioRenta.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_precioRenta.Location = new System.Drawing.Point(23, 134);
            this.lbl_precioRenta.Name = "lbl_precioRenta";
            this.lbl_precioRenta.Size = new System.Drawing.Size(111, 13);
            this.lbl_precioRenta.TabIndex = 6;
            this.lbl_precioRenta.Text = "PRECIO DE RENTA :";
            // 
            // txt_formato
            // 
            this.txt_formato.Location = new System.Drawing.Point(155, 90);
            this.txt_formato.Name = "txt_formato";
            this.txt_formato.Size = new System.Drawing.Size(121, 20);
            this.txt_formato.TabIndex = 5;
            // 
            // lbl_formato
            // 
            this.lbl_formato.AutoSize = true;
            this.lbl_formato.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_formato.Location = new System.Drawing.Point(23, 97);
            this.lbl_formato.Name = "lbl_formato";
            this.lbl_formato.Size = new System.Drawing.Size(66, 13);
            this.lbl_formato.TabIndex = 4;
            this.lbl_formato.Text = "FORMATO :";
            // 
            // txt_disponible
            // 
            this.txt_disponible.Location = new System.Drawing.Point(155, 52);
            this.txt_disponible.Name = "txt_disponible";
            this.txt_disponible.Size = new System.Drawing.Size(121, 20);
            this.txt_disponible.TabIndex = 3;
            // 
            // lbl_disponible
            // 
            this.lbl_disponible.AutoSize = true;
            this.lbl_disponible.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_disponible.Location = new System.Drawing.Point(23, 59);
            this.lbl_disponible.Name = "lbl_disponible";
            this.lbl_disponible.Size = new System.Drawing.Size(126, 13);
            this.lbl_disponible.TabIndex = 2;
            this.lbl_disponible.Text = "COPIAS DISPONIBLES :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(50, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "DATOS DE RENTA  :";
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.BackgroundImage = global::RentaVideos.Properties.Resources.exit;
            this.btn_cerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cerrar.FlatAppearance.BorderSize = 0;
            this.btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cerrar.Location = new System.Drawing.Point(1003, 14);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(31, 34);
            this.btn_cerrar.TabIndex = 22;
            this.btn_cerrar.UseVisualStyleBackColor = true;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(221, 390);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(296, 36);
            this.button1.TabIndex = 57;
            this.button1.Text = "RENTAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(9, 446);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 58;
            this.label3.Text = "ID RENTA ACTUAL:";
            // 
            // lblidRenta
            // 
            this.lblidRenta.AutoSize = true;
            this.lblidRenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblidRenta.ForeColor = System.Drawing.Color.White;
            this.lblidRenta.Location = new System.Drawing.Point(141, 438);
            this.lblidRenta.Name = "lblidRenta";
            this.lblidRenta.Size = new System.Drawing.Size(0, 24);
            this.lblidRenta.TabIndex = 59;
            // 
            // frmRentaVideo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(56)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(1080, 530);
            this.ControlBox = false;
            this.Controls.Add(this.btn_cerrar);
            this.Controls.Add(this.pnl_datosRenta);
            this.Controls.Add(this.pnl_datosPeliculas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRentaVideo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmRentaVideo_Load);
            this.pnl_datosPeliculas.ResumeLayout(false);
            this.pnl_datosPeliculas.PerformLayout();
            this.pnl_datosRenta.ResumeLayout(false);
            this.pnl_datosRenta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_codigo;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.Label lbl_nombrePelicula;
        private System.Windows.Forms.TextBox txt_nombrePelicula;
        private System.Windows.Forms.Label lbl_directorPelicula;
        private System.Windows.Forms.TextBox txt_directorPelicula;
        private System.Windows.Forms.Label lbl_actor;
        private System.Windows.Forms.TextBox txt_actor;
        private System.Windows.Forms.Label lbl_genero;
        private System.Windows.Forms.Label lbl_apto;
        private System.Windows.Forms.Label lbl_duracion;
        private System.Windows.Forms.Panel pnl_datosPeliculas;
        private System.Windows.Forms.Panel pnl_datosRenta;
        private System.Windows.Forms.TextBox txt_descripcionPelicula;
        private System.Windows.Forms.Label lbl_descripcionPelicula;
        private System.Windows.Forms.TextBox txt_cobroDemora;
        private System.Windows.Forms.Label lbl_CoboPorDemora;
        private System.Windows.Forms.TextBox txt_precioRenta;
        private System.Windows.Forms.Label lbl_precioRenta;
        private System.Windows.Forms.TextBox txt_formato;
        private System.Windows.Forms.Label lbl_formato;
        private System.Windows.Forms.TextBox txt_disponible;
        private System.Windows.Forms.Label lbl_disponible;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Button btn_facturar;
        private System.Windows.Forms.TextBox txtDuracion;
        private System.Windows.Forms.TextBox txtGenero;
        private System.Windows.Forms.TextBox txtAño;
        private System.Windows.Forms.Label lbl_datosAdicionales;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblidRenta;
    }
}
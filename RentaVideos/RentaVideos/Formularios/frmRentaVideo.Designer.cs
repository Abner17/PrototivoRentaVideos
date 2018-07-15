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
            this.lbl_proveedor = new System.Windows.Forms.Label();
            this.cbo_proveedor = new System.Windows.Forms.ComboBox();
            this.lbl_directorPelicula = new System.Windows.Forms.Label();
            this.txt_directorPelicula = new System.Windows.Forms.TextBox();
            this.lbl_actor = new System.Windows.Forms.Label();
            this.txt_actor = new System.Windows.Forms.TextBox();
            this.lbl_genero = new System.Windows.Forms.Label();
            this.cbo_genero = new System.Windows.Forms.ComboBox();
            this.lbl_apto = new System.Windows.Forms.Label();
            this.cbo_apto = new System.Windows.Forms.ComboBox();
            this.lbl_duracion = new System.Windows.Forms.Label();
            this.nud_duracion = new System.Windows.Forms.NumericUpDown();
            this.lbl_pelicula = new System.Windows.Forms.Label();
            this.lbl_datosAdicionales = new System.Windows.Forms.Label();
            this.pnl_datosPeliculas = new System.Windows.Forms.Panel();
            this.btn_buscarNombre = new System.Windows.Forms.Button();
            this.btn_buscarCodigo = new System.Windows.Forms.Button();
            this.btn_apto = new System.Windows.Forms.Button();
            this.btn_genero = new System.Windows.Forms.Button();
            this.pic_pelicula = new System.Windows.Forms.PictureBox();
            this.pnl_datosRenta = new System.Windows.Forms.Panel();
            this.btn_facturar = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_formato = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.nud_duracion)).BeginInit();
            this.pnl_datosPeliculas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_pelicula)).BeginInit();
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
            // lbl_proveedor
            // 
            this.lbl_proveedor.AutoSize = true;
            this.lbl_proveedor.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_proveedor.Location = new System.Drawing.Point(21, 178);
            this.lbl_proveedor.Name = "lbl_proveedor";
            this.lbl_proveedor.Size = new System.Drawing.Size(81, 13);
            this.lbl_proveedor.TabIndex = 5;
            this.lbl_proveedor.Text = "PROVEEDOR :";
            // 
            // cbo_proveedor
            // 
            this.cbo_proveedor.FormattingEnabled = true;
            this.cbo_proveedor.Items.AddRange(new object[] {
            "UNIVERSAL",
            "WARNER BROS",
            "EUROPA",
            "FOX",
            "NETFLIX"});
            this.cbo_proveedor.Location = new System.Drawing.Point(113, 170);
            this.cbo_proveedor.Name = "cbo_proveedor";
            this.cbo_proveedor.Size = new System.Drawing.Size(121, 21);
            this.cbo_proveedor.TabIndex = 6;
            this.cbo_proveedor.SelectedIndexChanged += new System.EventHandler(this.cbo_proveedor_SelectedIndexChanged);
            // 
            // lbl_directorPelicula
            // 
            this.lbl_directorPelicula.AutoSize = true;
            this.lbl_directorPelicula.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_directorPelicula.Location = new System.Drawing.Point(21, 216);
            this.lbl_directorPelicula.Name = "lbl_directorPelicula";
            this.lbl_directorPelicula.Size = new System.Drawing.Size(69, 13);
            this.lbl_directorPelicula.TabIndex = 7;
            this.lbl_directorPelicula.Text = "DIRECTOR :";
            // 
            // txt_directorPelicula
            // 
            this.txt_directorPelicula.Location = new System.Drawing.Point(113, 216);
            this.txt_directorPelicula.Name = "txt_directorPelicula";
            this.txt_directorPelicula.Size = new System.Drawing.Size(121, 20);
            this.txt_directorPelicula.TabIndex = 8;
            // 
            // lbl_actor
            // 
            this.lbl_actor.AutoSize = true;
            this.lbl_actor.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_actor.Location = new System.Drawing.Point(21, 264);
            this.lbl_actor.Name = "lbl_actor";
            this.lbl_actor.Size = new System.Drawing.Size(50, 13);
            this.lbl_actor.TabIndex = 9;
            this.lbl_actor.Text = "ACTOR :";
            this.lbl_actor.Click += new System.EventHandler(this.lbl_actor_Click);
            // 
            // txt_actor
            // 
            this.txt_actor.Location = new System.Drawing.Point(113, 261);
            this.txt_actor.Name = "txt_actor";
            this.txt_actor.Size = new System.Drawing.Size(121, 20);
            this.txt_actor.TabIndex = 10;
            // 
            // lbl_genero
            // 
            this.lbl_genero.AutoSize = true;
            this.lbl_genero.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_genero.Location = new System.Drawing.Point(21, 315);
            this.lbl_genero.Name = "lbl_genero";
            this.lbl_genero.Size = new System.Drawing.Size(59, 13);
            this.lbl_genero.TabIndex = 11;
            this.lbl_genero.Text = "GENERO :";
            // 
            // cbo_genero
            // 
            this.cbo_genero.FormattingEnabled = true;
            this.cbo_genero.Items.AddRange(new object[] {
            "ACCION",
            "TERROR",
            "COMICAS",
            "DRAMA",
            "SERIE",
            "INFANTILES"});
            this.cbo_genero.Location = new System.Drawing.Point(113, 312);
            this.cbo_genero.Name = "cbo_genero";
            this.cbo_genero.Size = new System.Drawing.Size(121, 21);
            this.cbo_genero.TabIndex = 12;
            this.cbo_genero.SelectedIndexChanged += new System.EventHandler(this.cbo_genero_SelectedIndexChanged);
            // 
            // lbl_apto
            // 
            this.lbl_apto.AutoSize = true;
            this.lbl_apto.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_apto.Location = new System.Drawing.Point(21, 364);
            this.lbl_apto.Name = "lbl_apto";
            this.lbl_apto.Size = new System.Drawing.Size(42, 13);
            this.lbl_apto.TabIndex = 13;
            this.lbl_apto.Text = "APTO :";
            // 
            // cbo_apto
            // 
            this.cbo_apto.FormattingEnabled = true;
            this.cbo_apto.Items.AddRange(new object[] {
            "MENORES DE 13 AÑOS",
            "MAYORES DE 13 AÑOS",
            "ADULTOS"});
            this.cbo_apto.Location = new System.Drawing.Point(113, 364);
            this.cbo_apto.Name = "cbo_apto";
            this.cbo_apto.Size = new System.Drawing.Size(121, 21);
            this.cbo_apto.TabIndex = 14;
            // 
            // lbl_duracion
            // 
            this.lbl_duracion.AutoSize = true;
            this.lbl_duracion.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_duracion.Location = new System.Drawing.Point(21, 414);
            this.lbl_duracion.Name = "lbl_duracion";
            this.lbl_duracion.Size = new System.Drawing.Size(70, 13);
            this.lbl_duracion.TabIndex = 15;
            this.lbl_duracion.Text = "DURACION :";
            // 
            // nud_duracion
            // 
            this.nud_duracion.Location = new System.Drawing.Point(114, 414);
            this.nud_duracion.Name = "nud_duracion";
            this.nud_duracion.Size = new System.Drawing.Size(120, 20);
            this.nud_duracion.TabIndex = 16;
            // 
            // lbl_pelicula
            // 
            this.lbl_pelicula.AutoSize = true;
            this.lbl_pelicula.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_pelicula.Location = new System.Drawing.Point(21, 456);
            this.lbl_pelicula.Name = "lbl_pelicula";
            this.lbl_pelicula.Size = new System.Drawing.Size(64, 13);
            this.lbl_pelicula.TabIndex = 17;
            this.lbl_pelicula.Text = "PELICULA :";
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
            // pnl_datosPeliculas
            // 
            this.pnl_datosPeliculas.Controls.Add(this.btn_buscarNombre);
            this.pnl_datosPeliculas.Controls.Add(this.btn_buscarCodigo);
            this.pnl_datosPeliculas.Controls.Add(this.btn_apto);
            this.pnl_datosPeliculas.Controls.Add(this.btn_genero);
            this.pnl_datosPeliculas.Controls.Add(this.label1);
            this.pnl_datosPeliculas.Controls.Add(this.pic_pelicula);
            this.pnl_datosPeliculas.Controls.Add(this.lbl_datosAdicionales);
            this.pnl_datosPeliculas.Controls.Add(this.lbl_pelicula);
            this.pnl_datosPeliculas.Controls.Add(this.lbl_codigo);
            this.pnl_datosPeliculas.Controls.Add(this.nud_duracion);
            this.pnl_datosPeliculas.Controls.Add(this.txt_codigo);
            this.pnl_datosPeliculas.Controls.Add(this.lbl_duracion);
            this.pnl_datosPeliculas.Controls.Add(this.lbl_nombrePelicula);
            this.pnl_datosPeliculas.Controls.Add(this.cbo_apto);
            this.pnl_datosPeliculas.Controls.Add(this.txt_nombrePelicula);
            this.pnl_datosPeliculas.Controls.Add(this.lbl_apto);
            this.pnl_datosPeliculas.Controls.Add(this.lbl_proveedor);
            this.pnl_datosPeliculas.Controls.Add(this.cbo_genero);
            this.pnl_datosPeliculas.Controls.Add(this.cbo_proveedor);
            this.pnl_datosPeliculas.Controls.Add(this.lbl_genero);
            this.pnl_datosPeliculas.Controls.Add(this.lbl_directorPelicula);
            this.pnl_datosPeliculas.Controls.Add(this.txt_actor);
            this.pnl_datosPeliculas.Controls.Add(this.txt_directorPelicula);
            this.pnl_datosPeliculas.Controls.Add(this.lbl_actor);
            this.pnl_datosPeliculas.Location = new System.Drawing.Point(12, 12);
            this.pnl_datosPeliculas.Name = "pnl_datosPeliculas";
            this.pnl_datosPeliculas.Size = new System.Drawing.Size(459, 590);
            this.pnl_datosPeliculas.TabIndex = 20;
            // 
            // btn_buscarNombre
            // 
            this.btn_buscarNombre.Location = new System.Drawing.Point(256, 90);
            this.btn_buscarNombre.Name = "btn_buscarNombre";
            this.btn_buscarNombre.Size = new System.Drawing.Size(119, 23);
            this.btn_buscarNombre.TabIndex = 22;
            this.btn_buscarNombre.Text = "BUSCAR";
            this.btn_buscarNombre.UseVisualStyleBackColor = true;
            // 
            // btn_buscarCodigo
            // 
            this.btn_buscarCodigo.Location = new System.Drawing.Point(256, 49);
            this.btn_buscarCodigo.Name = "btn_buscarCodigo";
            this.btn_buscarCodigo.Size = new System.Drawing.Size(119, 23);
            this.btn_buscarCodigo.TabIndex = 21;
            this.btn_buscarCodigo.Text = "BUSCAR";
            this.btn_buscarCodigo.UseVisualStyleBackColor = true;
            // 
            // btn_apto
            // 
            this.btn_apto.Location = new System.Drawing.Point(272, 364);
            this.btn_apto.Name = "btn_apto";
            this.btn_apto.Size = new System.Drawing.Size(119, 23);
            this.btn_apto.TabIndex = 20;
            this.btn_apto.Text = "NUEVO ";
            this.btn_apto.UseVisualStyleBackColor = true;
            // 
            // btn_genero
            // 
            this.btn_genero.Location = new System.Drawing.Point(272, 312);
            this.btn_genero.Name = "btn_genero";
            this.btn_genero.Size = new System.Drawing.Size(119, 23);
            this.btn_genero.TabIndex = 12;
            this.btn_genero.Text = "NUEVO GENERO";
            this.btn_genero.UseVisualStyleBackColor = true;
            // 
            // pic_pelicula
            // 
            this.pic_pelicula.Image = global::RentaVideos.Properties.Resources.registrob;
            this.pic_pelicula.Location = new System.Drawing.Point(114, 453);
            this.pic_pelicula.Name = "pic_pelicula";
            this.pic_pelicula.Size = new System.Drawing.Size(120, 102);
            this.pic_pelicula.TabIndex = 18;
            this.pic_pelicula.TabStop = false;
            // 
            // pnl_datosRenta
            // 
            this.pnl_datosRenta.Controls.Add(this.btn_facturar);
            this.pnl_datosRenta.Controls.Add(this.btn_guardar);
            this.pnl_datosRenta.Controls.Add(this.btn_formato);
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
            this.pnl_datosRenta.Size = new System.Drawing.Size(454, 590);
            this.pnl_datosRenta.TabIndex = 21;
            // 
            // btn_facturar
            // 
            this.btn_facturar.Location = new System.Drawing.Point(197, 338);
            this.btn_facturar.Name = "btn_facturar";
            this.btn_facturar.Size = new System.Drawing.Size(119, 23);
            this.btn_facturar.TabIndex = 23;
            this.btn_facturar.Text = "FACTURAR";
            this.btn_facturar.UseVisualStyleBackColor = true;
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(50, 338);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(119, 23);
            this.btn_guardar.TabIndex = 22;
            this.btn_guardar.Text = "GUARDAR";
            this.btn_guardar.UseVisualStyleBackColor = true;
            // 
            // btn_formato
            // 
            this.btn_formato.Location = new System.Drawing.Point(291, 87);
            this.btn_formato.Name = "btn_formato";
            this.btn_formato.Size = new System.Drawing.Size(119, 23);
            this.btn_formato.TabIndex = 21;
            this.btn_formato.Text = "NUEVO FORMATO";
            this.btn_formato.UseVisualStyleBackColor = true;
            // 
            // txt_descripcionPelicula
            // 
            this.txt_descripcionPelicula.Location = new System.Drawing.Point(50, 287);
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
            this.btn_cerrar.Location = new System.Drawing.Point(958, 14);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(31, 34);
            this.btn_cerrar.TabIndex = 22;
            this.btn_cerrar.UseVisualStyleBackColor = true;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // frmRentaVideo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(56)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(1021, 614);
            this.ControlBox = false;
            this.Controls.Add(this.btn_cerrar);
            this.Controls.Add(this.pnl_datosRenta);
            this.Controls.Add(this.pnl_datosPeliculas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRentaVideo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmRentaVideo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud_duracion)).EndInit();
            this.pnl_datosPeliculas.ResumeLayout(false);
            this.pnl_datosPeliculas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_pelicula)).EndInit();
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
        private System.Windows.Forms.Label lbl_proveedor;
        private System.Windows.Forms.ComboBox cbo_proveedor;
        private System.Windows.Forms.Label lbl_directorPelicula;
        private System.Windows.Forms.TextBox txt_directorPelicula;
        private System.Windows.Forms.Label lbl_actor;
        private System.Windows.Forms.TextBox txt_actor;
        private System.Windows.Forms.Label lbl_genero;
        private System.Windows.Forms.ComboBox cbo_genero;
        private System.Windows.Forms.Label lbl_apto;
        private System.Windows.Forms.ComboBox cbo_apto;
        private System.Windows.Forms.Label lbl_duracion;
        private System.Windows.Forms.NumericUpDown nud_duracion;
        private System.Windows.Forms.Label lbl_pelicula;
        private System.Windows.Forms.PictureBox pic_pelicula;
        private System.Windows.Forms.Label lbl_datosAdicionales;
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
        private System.Windows.Forms.Button btn_apto;
        private System.Windows.Forms.Button btn_genero;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_formato;
        private System.Windows.Forms.Button btn_buscarNombre;
        private System.Windows.Forms.Button btn_buscarCodigo;
        private System.Windows.Forms.Button btn_facturar;
        private System.Windows.Forms.Button btn_cerrar;
    }
}
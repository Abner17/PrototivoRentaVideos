namespace RentaVideos
{
    partial class menuPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menuPrincipal));
            this.menu = new System.Windows.Forms.Panel();
            this.btMenu = new System.Windows.Forms.Button();
            this.subMenu = new System.Windows.Forms.Panel();
            this.btCorreo = new System.Windows.Forms.Button();
            this.btBitacora = new System.Windows.Forms.Button();
            this.btDevoluciones = new System.Windows.Forms.Button();
            this.button67 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.btRentar = new System.Windows.Forms.Button();
            this.btConfiguracion = new System.Windows.Forms.Button();
            this.btReportes = new System.Windows.Forms.Button();
            this.btCotizacion = new System.Windows.Forms.Button();
            this.btBusqueda = new System.Windows.Forms.Button();
            this.btRegistro = new System.Windows.Forms.Button();
            this.btRegresar = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.registros = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonProve = new System.Windows.Forms.Button();
            this.btRegCliente = new System.Windows.Forms.Button();
            this.btRegEmpleado = new System.Windows.Forms.Button();
            this.btRegVideo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.busquedas = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.configuraciones = new System.Windows.Forms.Panel();
            this.button70 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.imageList3 = new System.Windows.Forms.ImageList(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.menu.SuspendLayout();
            this.subMenu.SuspendLayout();
            this.registros.SuspendLayout();
            this.busquedas.SuspendLayout();
            this.configuraciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Controls.Add(this.btMenu);
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(286, 610);
            this.menu.TabIndex = 0;
            // 
            // btMenu
            // 
            this.btMenu.BackgroundImage = global::RentaVideos.Properties.Resources.icoMenu;
            this.btMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btMenu.FlatAppearance.BorderSize = 0;
            this.btMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMenu.Location = new System.Drawing.Point(12, 12);
            this.btMenu.Name = "btMenu";
            this.btMenu.Size = new System.Drawing.Size(56, 45);
            this.btMenu.TabIndex = 0;
            this.btMenu.UseVisualStyleBackColor = true;
            this.btMenu.Click += new System.EventHandler(this.btMenu_Click);
            // 
            // subMenu
            // 
            this.subMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(146)))), ((int)(((byte)(153)))));
            this.subMenu.Controls.Add(this.btCorreo);
            this.subMenu.Controls.Add(this.btBitacora);
            this.subMenu.Controls.Add(this.btDevoluciones);
            this.subMenu.Controls.Add(this.button67);
            this.subMenu.Controls.Add(this.label9);
            this.subMenu.Controls.Add(this.btRentar);
            this.subMenu.Controls.Add(this.btConfiguracion);
            this.subMenu.Controls.Add(this.btReportes);
            this.subMenu.Controls.Add(this.btCotizacion);
            this.subMenu.Controls.Add(this.btBusqueda);
            this.subMenu.Controls.Add(this.btRegistro);
            this.subMenu.Controls.Add(this.btRegresar);
            this.subMenu.Location = new System.Drawing.Point(0, 0);
            this.subMenu.Name = "subMenu";
            this.subMenu.Size = new System.Drawing.Size(286, 682);
            this.subMenu.TabIndex = 1;
            this.subMenu.Visible = false;
            this.subMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.subMenu_Paint);
            // 
            // btCorreo
            // 
            this.btCorreo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btCorreo.FlatAppearance.BorderSize = 0;
            this.btCorreo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCorreo.ForeColor = System.Drawing.Color.White;
            this.btCorreo.Image = global::RentaVideos.Properties.Resources.iconCorreo3;
            this.btCorreo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btCorreo.Location = new System.Drawing.Point(8, 497);
            this.btCorreo.Name = "btCorreo";
            this.btCorreo.Size = new System.Drawing.Size(270, 43);
            this.btCorreo.TabIndex = 49;
            this.btCorreo.Text = "CORREO";
            this.btCorreo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btCorreo.UseVisualStyleBackColor = true;
            // 
            // btBitacora
            // 
            this.btBitacora.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btBitacora.FlatAppearance.BorderSize = 0;
            this.btBitacora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBitacora.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBitacora.ForeColor = System.Drawing.Color.White;
            this.btBitacora.Image = global::RentaVideos.Properties.Resources.iconBitacora;
            this.btBitacora.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btBitacora.Location = new System.Drawing.Point(8, 547);
            this.btBitacora.Name = "btBitacora";
            this.btBitacora.Size = new System.Drawing.Size(274, 43);
            this.btBitacora.TabIndex = 48;
            this.btBitacora.Text = "BITACORA";
            this.btBitacora.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btBitacora.UseVisualStyleBackColor = true;
            this.btBitacora.Click += new System.EventHandler(this.button69_Click);
            // 
            // btDevoluciones
            // 
            this.btDevoluciones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btDevoluciones.FlatAppearance.BorderSize = 0;
            this.btDevoluciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDevoluciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDevoluciones.ForeColor = System.Drawing.Color.White;
            this.btDevoluciones.Image = global::RentaVideos.Properties.Resources.barcod;
            this.btDevoluciones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btDevoluciones.Location = new System.Drawing.Point(8, 298);
            this.btDevoluciones.Name = "btDevoluciones";
            this.btDevoluciones.Size = new System.Drawing.Size(270, 43);
            this.btDevoluciones.TabIndex = 47;
            this.btDevoluciones.Text = "DEVOLUCIONES";
            this.btDevoluciones.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btDevoluciones.UseVisualStyleBackColor = true;
            this.btDevoluciones.Click += new System.EventHandler(this.button68_Click);
            // 
            // button67
            // 
            this.button67.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button67.BackgroundImage")));
            this.button67.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button67.FlatAppearance.BorderSize = 0;
            this.button67.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button67.Location = new System.Drawing.Point(248, 17);
            this.button67.Name = "button67";
            this.button67.Size = new System.Drawing.Size(34, 34);
            this.button67.TabIndex = 46;
            this.button67.UseVisualStyleBackColor = true;
            this.button67.Click += new System.EventHandler(this.button67_Click);
            // 
            // label9
            // 
            this.label9.ImageIndex = 0;
            this.label9.ImageList = this.imageList2;
            this.label9.Location = new System.Drawing.Point(65, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(161, 158);
            this.label9.TabIndex = 7;
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "logoBlanco.png");
            // 
            // btRentar
            // 
            this.btRentar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btRentar.FlatAppearance.BorderSize = 0;
            this.btRentar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRentar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRentar.ForeColor = System.Drawing.Color.White;
            this.btRentar.Image = global::RentaVideos.Properties.Resources.comprasw;
            this.btRentar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btRentar.Location = new System.Drawing.Point(8, 249);
            this.btRentar.Name = "btRentar";
            this.btRentar.Size = new System.Drawing.Size(270, 43);
            this.btRentar.TabIndex = 6;
            this.btRentar.Text = "RENTAR VIDEO";
            this.btRentar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btRentar.UseVisualStyleBackColor = true;
            this.btRentar.Click += new System.EventHandler(this.btRentar_Click);
            // 
            // btConfiguracion
            // 
            this.btConfiguracion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btConfiguracion.FlatAppearance.BorderSize = 0;
            this.btConfiguracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btConfiguracion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConfiguracion.ForeColor = System.Drawing.Color.White;
            this.btConfiguracion.Image = global::RentaVideos.Properties.Resources.configuration;
            this.btConfiguracion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btConfiguracion.Location = new System.Drawing.Point(8, 596);
            this.btConfiguracion.Name = "btConfiguracion";
            this.btConfiguracion.Size = new System.Drawing.Size(274, 43);
            this.btConfiguracion.TabIndex = 5;
            this.btConfiguracion.Text = "CONFIGURACIONES";
            this.btConfiguracion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btConfiguracion.UseVisualStyleBackColor = true;
            this.btConfiguracion.Click += new System.EventHandler(this.btConfiguracion_Click);
            // 
            // btReportes
            // 
            this.btReportes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btReportes.FlatAppearance.BorderSize = 0;
            this.btReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btReportes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btReportes.ForeColor = System.Drawing.Color.White;
            this.btReportes.Image = global::RentaVideos.Properties.Resources.reportesd;
            this.btReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btReportes.Location = new System.Drawing.Point(8, 447);
            this.btReportes.Name = "btReportes";
            this.btReportes.Size = new System.Drawing.Size(270, 43);
            this.btReportes.TabIndex = 4;
            this.btReportes.Text = "REPORTES";
            this.btReportes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btReportes.UseVisualStyleBackColor = true;
            this.btReportes.Click += new System.EventHandler(this.btReportes_Click);
            // 
            // btCotizacion
            // 
            this.btCotizacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btCotizacion.FlatAppearance.BorderSize = 0;
            this.btCotizacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCotizacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCotizacion.ForeColor = System.Drawing.Color.White;
            this.btCotizacion.Image = global::RentaVideos.Properties.Resources.ventasw;
            this.btCotizacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btCotizacion.Location = new System.Drawing.Point(8, 200);
            this.btCotizacion.Name = "btCotizacion";
            this.btCotizacion.Size = new System.Drawing.Size(270, 43);
            this.btCotizacion.TabIndex = 3;
            this.btCotizacion.Text = "COTIZACION";
            this.btCotizacion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btCotizacion.UseVisualStyleBackColor = true;
            this.btCotizacion.Click += new System.EventHandler(this.btCotizacion_Click);
            // 
            // btBusqueda
            // 
            this.btBusqueda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btBusqueda.FlatAppearance.BorderSize = 0;
            this.btBusqueda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBusqueda.ForeColor = System.Drawing.Color.White;
            this.btBusqueda.Image = global::RentaVideos.Properties.Resources.iconBusqueda;
            this.btBusqueda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btBusqueda.Location = new System.Drawing.Point(8, 398);
            this.btBusqueda.Name = "btBusqueda";
            this.btBusqueda.Size = new System.Drawing.Size(270, 43);
            this.btBusqueda.TabIndex = 2;
            this.btBusqueda.Text = "BUSQUEDAS";
            this.btBusqueda.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btBusqueda.UseVisualStyleBackColor = true;
            this.btBusqueda.Click += new System.EventHandler(this.button4_Click);
            // 
            // btRegistro
            // 
            this.btRegistro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btRegistro.FlatAppearance.BorderSize = 0;
            this.btRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRegistro.ForeColor = System.Drawing.Color.White;
            this.btRegistro.Image = global::RentaVideos.Properties.Resources.registrow;
            this.btRegistro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btRegistro.Location = new System.Drawing.Point(8, 348);
            this.btRegistro.Name = "btRegistro";
            this.btRegistro.Size = new System.Drawing.Size(270, 43);
            this.btRegistro.TabIndex = 1;
            this.btRegistro.Text = "REGISTROS";
            this.btRegistro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btRegistro.UseVisualStyleBackColor = true;
            this.btRegistro.Click += new System.EventHandler(this.button3_Click);
            // 
            // btRegresar
            // 
            this.btRegresar.BackgroundImage = global::RentaVideos.Properties.Resources.left_arrow;
            this.btRegresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btRegresar.FlatAppearance.BorderSize = 0;
            this.btRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRegresar.Location = new System.Drawing.Point(15, 17);
            this.btRegresar.Name = "btRegresar";
            this.btRegresar.Size = new System.Drawing.Size(31, 34);
            this.btRegresar.TabIndex = 0;
            this.btRegresar.UseVisualStyleBackColor = true;
            this.btRegresar.Click += new System.EventHandler(this.btRegresar_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "iconVideo.png");
            this.imageList1.Images.SetKeyName(1, "invoice.png");
            // 
            // registros
            // 
            this.registros.Controls.Add(this.button3);
            this.registros.Controls.Add(this.label2);
            this.registros.Controls.Add(this.buttonProve);
            this.registros.Controls.Add(this.btRegCliente);
            this.registros.Controls.Add(this.btRegEmpleado);
            this.registros.Controls.Add(this.btRegVideo);
            this.registros.Location = new System.Drawing.Point(292, 3);
            this.registros.Name = "registros";
            this.registros.Size = new System.Drawing.Size(556, 679);
            this.registros.TabIndex = 2;
            this.registros.Visible = false;
            this.registros.Paint += new System.Windows.Forms.PaintEventHandler(this.registros_Paint);
            // 
            // button3
            // 
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = global::RentaVideos.Properties.Resources.userw;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button3.Location = new System.Drawing.Point(212, 489);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(179, 172);
            this.button3.TabIndex = 13;
            this.button3.Text = "USUARIO";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(191, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 37);
            this.label2.TabIndex = 12;
            this.label2.Text = "REGISTRO";
            // 
            // buttonProve
            // 
            this.buttonProve.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonProve.FlatAppearance.BorderSize = 0;
            this.buttonProve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProve.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProve.ForeColor = System.Drawing.Color.White;
            this.buttonProve.Image = global::RentaVideos.Properties.Resources.group;
            this.buttonProve.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonProve.Location = new System.Drawing.Point(311, 289);
            this.buttonProve.Name = "buttonProve";
            this.buttonProve.Size = new System.Drawing.Size(179, 172);
            this.buttonProve.TabIndex = 5;
            this.buttonProve.Text = "PROVEEDOR";
            this.buttonProve.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonProve.UseVisualStyleBackColor = true;
            this.buttonProve.Click += new System.EventHandler(this.button1_Click);
            // 
            // btRegCliente
            // 
            this.btRegCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btRegCliente.FlatAppearance.BorderSize = 0;
            this.btRegCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRegCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRegCliente.ForeColor = System.Drawing.Color.White;
            this.btRegCliente.Image = global::RentaVideos.Properties.Resources.user;
            this.btRegCliente.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btRegCliente.Location = new System.Drawing.Point(99, 289);
            this.btRegCliente.Name = "btRegCliente";
            this.btRegCliente.Size = new System.Drawing.Size(179, 172);
            this.btRegCliente.TabIndex = 4;
            this.btRegCliente.Text = "CLIENTE";
            this.btRegCliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btRegCliente.UseVisualStyleBackColor = true;
            this.btRegCliente.Click += new System.EventHandler(this.btRegCliente_Click);
            // 
            // btRegEmpleado
            // 
            this.btRegEmpleado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btRegEmpleado.FlatAppearance.BorderSize = 0;
            this.btRegEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRegEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRegEmpleado.ForeColor = System.Drawing.Color.White;
            this.btRegEmpleado.Image = global::RentaVideos.Properties.Resources.iconEmpleado3;
            this.btRegEmpleado.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btRegEmpleado.Location = new System.Drawing.Point(311, 86);
            this.btRegEmpleado.Name = "btRegEmpleado";
            this.btRegEmpleado.Size = new System.Drawing.Size(179, 172);
            this.btRegEmpleado.TabIndex = 3;
            this.btRegEmpleado.Text = "EMPLEADO";
            this.btRegEmpleado.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btRegEmpleado.UseVisualStyleBackColor = true;
            this.btRegEmpleado.Click += new System.EventHandler(this.btRegEmpleado_Click);
            // 
            // btRegVideo
            // 
            this.btRegVideo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btRegVideo.FlatAppearance.BorderSize = 0;
            this.btRegVideo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRegVideo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRegVideo.ForeColor = System.Drawing.Color.White;
            this.btRegVideo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btRegVideo.ImageIndex = 0;
            this.btRegVideo.ImageList = this.imageList1;
            this.btRegVideo.Location = new System.Drawing.Point(99, 86);
            this.btRegVideo.Name = "btRegVideo";
            this.btRegVideo.Size = new System.Drawing.Size(179, 172);
            this.btRegVideo.TabIndex = 2;
            this.btRegVideo.Text = "VIDEO";
            this.btRegVideo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btRegVideo.UseVisualStyleBackColor = true;
            this.btRegVideo.Click += new System.EventHandler(this.btRegVideo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(187, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 37);
            this.label1.TabIndex = 11;
            this.label1.Text = "BUSQUEDA";
            // 
            // busquedas
            // 
            this.busquedas.Controls.Add(this.label1);
            this.busquedas.Controls.Add(this.button8);
            this.busquedas.Controls.Add(this.button9);
            this.busquedas.Controls.Add(this.button10);
            this.busquedas.Controls.Add(this.button11);
            this.busquedas.Location = new System.Drawing.Point(292, 0);
            this.busquedas.Name = "busquedas";
            this.busquedas.Size = new System.Drawing.Size(556, 682);
            this.busquedas.TabIndex = 9;
            this.busquedas.Visible = false;
            this.busquedas.Paint += new System.Windows.Forms.PaintEventHandler(this.busquedas_Paint);
            // 
            // button8
            // 
            this.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Image = global::RentaVideos.Properties.Resources.group;
            this.button8.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button8.Location = new System.Drawing.Point(298, 395);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(179, 172);
            this.button8.TabIndex = 5;
            this.button8.Text = "PROVEEDOR";
            this.button8.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.White;
            this.button9.Image = global::RentaVideos.Properties.Resources.user;
            this.button9.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button9.Location = new System.Drawing.Point(86, 395);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(179, 172);
            this.button9.TabIndex = 4;
            this.button9.Text = "CLIENTE";
            this.button9.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.Color.White;
            this.button10.Image = global::RentaVideos.Properties.Resources.userw;
            this.button10.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button10.Location = new System.Drawing.Point(290, 160);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(179, 172);
            this.button10.TabIndex = 3;
            this.button10.Text = "EMPLEADO";
            this.button10.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button11.FlatAppearance.BorderSize = 0;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.ForeColor = System.Drawing.Color.White;
            this.button11.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button11.ImageIndex = 0;
            this.button11.ImageList = this.imageList1;
            this.button11.Location = new System.Drawing.Point(78, 160);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(179, 172);
            this.button11.TabIndex = 2;
            this.button11.Text = "VIDEO";
            this.button11.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // configuraciones
            // 
            this.configuraciones.Controls.Add(this.button70);
            this.configuraciones.Controls.Add(this.label4);
            this.configuraciones.Controls.Add(this.button5);
            this.configuraciones.Controls.Add(this.button6);
            this.configuraciones.Controls.Add(this.button14);
            this.configuraciones.Controls.Add(this.button7);
            this.configuraciones.Location = new System.Drawing.Point(292, 3);
            this.configuraciones.Name = "configuraciones";
            this.configuraciones.Size = new System.Drawing.Size(556, 679);
            this.configuraciones.TabIndex = 10;
            this.configuraciones.Visible = false;
            this.configuraciones.Paint += new System.Windows.Forms.PaintEventHandler(this.configuraciones_Paint);
            // 
            // button70
            // 
            this.button70.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button70.FlatAppearance.BorderSize = 0;
            this.button70.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button70.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button70.ForeColor = System.Drawing.Color.White;
            this.button70.Image = global::RentaVideos.Properties.Resources.union;
            this.button70.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button70.Location = new System.Drawing.Point(127, 495);
            this.button70.Name = "button70";
            this.button70.Size = new System.Drawing.Size(308, 172);
            this.button70.TabIndex = 13;
            this.button70.Text = "PRIVILEGIOS DE USUARIO";
            this.button70.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button70.UseVisualStyleBackColor = true;
            this.button70.Click += new System.EventHandler(this.button70_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(102, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(346, 37);
            this.label4.TabIndex = 12;
            this.label4.Text = "CONFIGURACIONES";
            // 
            // button5
            // 
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Image = global::RentaVideos.Properties.Resources.group;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button5.Location = new System.Drawing.Point(282, 287);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(179, 172);
            this.button5.TabIndex = 5;
            this.button5.Text = "PROVEEDOR";
            this.button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // button6
            // 
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Image = global::RentaVideos.Properties.Resources.user;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button6.Location = new System.Drawing.Point(70, 287);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(179, 172);
            this.button6.TabIndex = 4;
            this.button6.Text = "CLIENTE";
            this.button6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button14
            // 
            this.button14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button14.FlatAppearance.BorderSize = 0;
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.ForeColor = System.Drawing.Color.White;
            this.button14.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button14.ImageIndex = 0;
            this.button14.ImageList = this.imageList1;
            this.button14.Location = new System.Drawing.Point(70, 89);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(179, 172);
            this.button14.TabIndex = 2;
            this.button14.Text = "VIDEO";
            this.button14.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button7
            // 
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Image = global::RentaVideos.Properties.Resources.userw;
            this.button7.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button7.Location = new System.Drawing.Point(284, 92);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(179, 172);
            this.button7.TabIndex = 3;
            this.button7.Text = "EMPLEADO";
            this.button7.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // imageList3
            // 
            this.imageList3.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList3.ImageStream")));
            this.imageList3.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList3.Images.SetKeyName(0, "invoice.png");
            this.imageList3.Images.SetKeyName(1, "icons8_Search_Property_104px.png");
            this.imageList3.Images.SetKeyName(2, "comprasw.png");
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::RentaVideos.Properties.Resources.exit;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(854, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(31, 34);
            this.button2.TabIndex = 7;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // menuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(56)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(906, 682);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.subMenu);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.configuraciones);
            this.Controls.Add(this.registros);
            this.Controls.Add(this.busquedas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "menuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "menuPrincipal";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menu.ResumeLayout(false);
            this.subMenu.ResumeLayout(false);
            this.registros.ResumeLayout(false);
            this.registros.PerformLayout();
            this.busquedas.ResumeLayout(false);
            this.busquedas.PerformLayout();
            this.configuraciones.ResumeLayout(false);
            this.configuraciones.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menu;
        private System.Windows.Forms.Button btMenu;
        private System.Windows.Forms.Button btRegresar;
        private System.Windows.Forms.Panel subMenu;
        private System.Windows.Forms.Button btConfiguracion;
        private System.Windows.Forms.Button btReportes;
        private System.Windows.Forms.Button btCotizacion;
        private System.Windows.Forms.Button btBusqueda;
        private System.Windows.Forms.Button btRegistro;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel registros;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonProve;
        private System.Windows.Forms.Button btRegCliente;
        private System.Windows.Forms.Button btRegEmpleado;
        private System.Windows.Forms.Button btRegVideo;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel busquedas;
        private System.Windows.Forms.Button btRentar;
        private System.Windows.Forms.Panel configuraciones;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.Button button67;
        private System.Windows.Forms.ImageList imageList3;
        private System.Windows.Forms.Button btBitacora;
        private System.Windows.Forms.Button btDevoluciones;
        private System.Windows.Forms.Button button70;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btCorreo;
        private System.Windows.Forms.Button button3;
    }
}


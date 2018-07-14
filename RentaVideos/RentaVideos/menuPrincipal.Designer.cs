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
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btBusqueda = new System.Windows.Forms.Button();
            this.btRegistro = new System.Windows.Forms.Button();
            this.btRegresar = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.registros = new System.Windows.Forms.Panel();
            this.btRegVideo = new System.Windows.Forms.Button();
            this.btRegEmpleado = new System.Windows.Forms.Button();
            this.btRegCliente = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button13 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.busquedas = new System.Windows.Forms.Panel();
            this.menu.SuspendLayout();
            this.subMenu.SuspendLayout();
            this.registros.SuspendLayout();
            this.panel1.SuspendLayout();
            this.busquedas.SuspendLayout();
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
            this.subMenu.Controls.Add(this.button7);
            this.subMenu.Controls.Add(this.button6);
            this.subMenu.Controls.Add(this.button5);
            this.subMenu.Controls.Add(this.btBusqueda);
            this.subMenu.Controls.Add(this.btRegistro);
            this.subMenu.Controls.Add(this.btRegresar);
            this.subMenu.Location = new System.Drawing.Point(0, 0);
            this.subMenu.Name = "subMenu";
            this.subMenu.Size = new System.Drawing.Size(286, 610);
            this.subMenu.TabIndex = 1;
            this.subMenu.Visible = false;
            // 
            // button7
            // 
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Image = global::RentaVideos.Properties.Resources.configuration;
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.Location = new System.Drawing.Point(3, 288);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(280, 43);
            this.button7.TabIndex = 5;
            this.button7.Text = "CONFIGURACIONES";
            this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Image = global::RentaVideos.Properties.Resources.reportesd;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(3, 239);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(280, 43);
            this.button6.TabIndex = 4;
            this.button6.Text = "REPORTES";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Image = global::RentaVideos.Properties.Resources.ventasw;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(3, 190);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(280, 43);
            this.button5.TabIndex = 3;
            this.button5.Text = "MODIFICACIÓN";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // btBusqueda
            // 
            this.btBusqueda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btBusqueda.FlatAppearance.BorderSize = 0;
            this.btBusqueda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBusqueda.ForeColor = System.Drawing.Color.White;
            this.btBusqueda.Image = global::RentaVideos.Properties.Resources.icons8_Search_30px;
            this.btBusqueda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btBusqueda.Location = new System.Drawing.Point(3, 141);
            this.btBusqueda.Name = "btBusqueda";
            this.btBusqueda.Size = new System.Drawing.Size(280, 43);
            this.btBusqueda.TabIndex = 2;
            this.btBusqueda.Text = "BUSQUEDA";
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
            this.btRegistro.Location = new System.Drawing.Point(3, 92);
            this.btRegistro.Name = "btRegistro";
            this.btRegistro.Size = new System.Drawing.Size(280, 43);
            this.btRegistro.TabIndex = 1;
            this.btRegistro.Text = "REGISTRO";
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
            // registros
            // 
            this.registros.Controls.Add(this.label2);
            this.registros.Controls.Add(this.button1);
            this.registros.Controls.Add(this.btRegCliente);
            this.registros.Controls.Add(this.btRegEmpleado);
            this.registros.Controls.Add(this.btRegVideo);
            this.registros.Location = new System.Drawing.Point(292, 0);
            this.registros.Name = "registros";
            this.registros.Size = new System.Drawing.Size(518, 610);
            this.registros.TabIndex = 2;
            this.registros.Visible = false;
            this.registros.Paint += new System.Windows.Forms.PaintEventHandler(this.registros_Paint);
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
            this.btRegVideo.Location = new System.Drawing.Point(70, 92);
            this.btRegVideo.Name = "btRegVideo";
            this.btRegVideo.Size = new System.Drawing.Size(179, 172);
            this.btRegVideo.TabIndex = 2;
            this.btRegVideo.Text = "VIDEO";
            this.btRegVideo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btRegVideo.UseVisualStyleBackColor = true;
            this.btRegVideo.Click += new System.EventHandler(this.btRegVideo_Click);
            // 
            // btRegEmpleado
            // 
            this.btRegEmpleado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btRegEmpleado.FlatAppearance.BorderSize = 0;
            this.btRegEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRegEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRegEmpleado.ForeColor = System.Drawing.Color.White;
            this.btRegEmpleado.Image = global::RentaVideos.Properties.Resources.userw;
            this.btRegEmpleado.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btRegEmpleado.Location = new System.Drawing.Point(282, 92);
            this.btRegEmpleado.Name = "btRegEmpleado";
            this.btRegEmpleado.Size = new System.Drawing.Size(179, 172);
            this.btRegEmpleado.TabIndex = 3;
            this.btRegEmpleado.Text = "EMPLEADO";
            this.btRegEmpleado.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btRegEmpleado.UseVisualStyleBackColor = true;
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
            this.btRegCliente.Location = new System.Drawing.Point(70, 358);
            this.btRegCliente.Name = "btRegCliente";
            this.btRegCliente.Size = new System.Drawing.Size(179, 172);
            this.btRegCliente.TabIndex = 4;
            this.btRegCliente.Text = "CLIENTE";
            this.btRegCliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btRegCliente.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::RentaVideos.Properties.Resources.group;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(282, 358);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 172);
            this.button1.TabIndex = 5;
            this.button1.Text = "PROVEEDOR";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(165, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 37);
            this.label2.TabIndex = 12;
            this.label2.Text = "REGISTRO";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button12);
            this.panel1.Controls.Add(this.button13);
            this.panel1.Location = new System.Drawing.Point(109, 92);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(518, 610);
            this.panel1.TabIndex = 2;
            this.panel1.Visible = false;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button13
            // 
            this.button13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button13.FlatAppearance.BorderSize = 0;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.ForeColor = System.Drawing.Color.White;
            this.button13.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button13.ImageIndex = 0;
            this.button13.ImageList = this.imageList1;
            this.button13.Location = new System.Drawing.Point(70, 92);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(179, 172);
            this.button13.TabIndex = 2;
            this.button13.Text = "VIDEO";
            this.button13.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button13.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button12.FlatAppearance.BorderSize = 0;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.ForeColor = System.Drawing.Color.White;
            this.button12.Image = global::RentaVideos.Properties.Resources.userw;
            this.button12.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button12.Location = new System.Drawing.Point(282, 92);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(179, 172);
            this.button12.TabIndex = 3;
            this.button12.Text = "EMPLEADO";
            this.button12.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button12.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Image = global::RentaVideos.Properties.Resources.user;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button4.Location = new System.Drawing.Point(70, 358);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(179, 172);
            this.button4.TabIndex = 4;
            this.button4.Text = "CLIENTE";
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = global::RentaVideos.Properties.Resources.group;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button3.Location = new System.Drawing.Point(282, 358);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(179, 172);
            this.button3.TabIndex = 5;
            this.button3.Text = "PROVEEDOR";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(165, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 37);
            this.label3.TabIndex = 12;
            this.label3.Text = "REGISTRO";
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
            this.button11.Location = new System.Drawing.Point(70, 92);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(179, 172);
            this.button11.TabIndex = 2;
            this.button11.Text = "VIDEO";
            this.button11.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button11.UseVisualStyleBackColor = true;
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
            this.button10.Location = new System.Drawing.Point(282, 92);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(179, 172);
            this.button10.TabIndex = 3;
            this.button10.Text = "EMPLEADO";
            this.button10.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button10.UseVisualStyleBackColor = true;
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
            this.button9.Location = new System.Drawing.Point(70, 358);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(179, 172);
            this.button9.TabIndex = 4;
            this.button9.Text = "CLIENTE";
            this.button9.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button9.UseVisualStyleBackColor = true;
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
            this.button8.Location = new System.Drawing.Point(282, 358);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(179, 172);
            this.button8.TabIndex = 5;
            this.button8.Text = "PROVEEDOR";
            this.button8.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button8.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(189, 29);
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
            this.busquedas.Controls.Add(this.panel1);
            this.busquedas.Location = new System.Drawing.Point(292, 0);
            this.busquedas.Name = "busquedas";
            this.busquedas.Size = new System.Drawing.Size(518, 610);
            this.busquedas.TabIndex = 9;
            this.busquedas.Visible = false;
            this.busquedas.Paint += new System.Windows.Forms.PaintEventHandler(this.busquedas_Paint);
            // 
            // menuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(56)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(906, 611);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.subMenu);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.busquedas);
            this.Controls.Add(this.registros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "menuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "menuPrincipal";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menu.ResumeLayout(false);
            this.subMenu.ResumeLayout(false);
            this.registros.ResumeLayout(false);
            this.registros.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.busquedas.ResumeLayout(false);
            this.busquedas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menu;
        private System.Windows.Forms.Button btMenu;
        private System.Windows.Forms.Button btRegresar;
        private System.Windows.Forms.Panel subMenu;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btBusqueda;
        private System.Windows.Forms.Button btRegistro;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel registros;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btRegCliente;
        private System.Windows.Forms.Button btRegEmpleado;
        private System.Windows.Forms.Button btRegVideo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel busquedas;
    }
}


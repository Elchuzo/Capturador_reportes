namespace Capturador_gastro_avances
{
    partial class frmSesion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSesion));
            this.pnlTop = new System.Windows.Forms.Panel();
            this.btnMin = new FontAwesome.Sharp.IconButton();
            this.btnCerrar = new FontAwesome.Sharp.IconButton();
            this.pnlShade = new System.Windows.Forms.Panel();
            this.pnlFiltros = new System.Windows.Forms.Panel();
            this.btnRegresar = new FontAwesome.Sharp.IconButton();
            this.trkSaturacion = new System.Windows.Forms.TrackBar();
            this.trkContraste = new System.Windows.Forms.TrackBar();
            this.trkBrillo = new System.Windows.Forms.TrackBar();
            this.lblSaturacion = new System.Windows.Forms.Label();
            this.lblContraste = new System.Windows.Forms.Label();
            this.lblBrillo = new System.Windows.Forms.Label();
            this.pnlVideo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboVideo = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new FontAwesome.Sharp.IconButton();
            this.btnConectar = new FontAwesome.Sharp.IconButton();
            this.btnDesconectar = new FontAwesome.Sharp.IconButton();
            this.btnGrabar = new FontAwesome.Sharp.IconButton();
            this.btnFinal = new FontAwesome.Sharp.IconButton();
            this.comboRes = new System.Windows.Forms.ComboBox();
            this.pnlConexion = new System.Windows.Forms.Panel();
            this.lblResolucion = new System.Windows.Forms.Label();
            this.lblEntrada = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.comboInputs = new System.Windows.Forms.ComboBox();
            this.lblCapturas = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.pnlTop.SuspendLayout();
            this.pnlFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkSaturacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkContraste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkBrillo)).BeginInit();
            this.pnlVideo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlConexion.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(62)))), ((int)(((byte)(128)))));
            this.pnlTop.Controls.Add(this.btnMin);
            this.pnlTop.Controls.Add(this.btnCerrar);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(800, 35);
            this.pnlTop.TabIndex = 4;
            this.pnlTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTop_MouseDown);
            // 
            // btnMin
            // 
            this.btnMin.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnMin.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMin.IconColor = System.Drawing.Color.Black;
            this.btnMin.IconSize = 25;
            this.btnMin.Location = new System.Drawing.Point(740, 0);
            this.btnMin.Name = "btnMin";
            this.btnMin.Rotation = 0D;
            this.btnMin.Size = new System.Drawing.Size(30, 35);
            this.btnMin.TabIndex = 8;
            this.btnMin.TabStop = false;
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnCerrar.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.btnCerrar.IconColor = System.Drawing.Color.Black;
            this.btnCerrar.IconSize = 25;
            this.btnCerrar.Location = new System.Drawing.Point(770, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Rotation = 0D;
            this.btnCerrar.Size = new System.Drawing.Size(30, 35);
            this.btnCerrar.TabIndex = 6;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // pnlShade
            // 
            this.pnlShade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(56)))), ((int)(((byte)(115)))));
            this.pnlShade.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlShade.Location = new System.Drawing.Point(0, 35);
            this.pnlShade.Name = "pnlShade";
            this.pnlShade.Size = new System.Drawing.Size(800, 10);
            this.pnlShade.TabIndex = 5;
            // 
            // pnlFiltros
            // 
            this.pnlFiltros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(89)))));
            this.pnlFiltros.Controls.Add(this.btnRegresar);
            this.pnlFiltros.Controls.Add(this.trkSaturacion);
            this.pnlFiltros.Controls.Add(this.trkContraste);
            this.pnlFiltros.Controls.Add(this.trkBrillo);
            this.pnlFiltros.Controls.Add(this.lblSaturacion);
            this.pnlFiltros.Controls.Add(this.lblContraste);
            this.pnlFiltros.Controls.Add(this.lblBrillo);
            this.pnlFiltros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFiltros.Location = new System.Drawing.Point(561, 183);
            this.pnlFiltros.Name = "pnlFiltros";
            this.pnlFiltros.Size = new System.Drawing.Size(239, 417);
            this.pnlFiltros.TabIndex = 9;
            // 
            // btnRegresar
            // 
            this.btnRegresar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnRegresar.FlatAppearance.BorderSize = 0;
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnRegresar.IconChar = FontAwesome.Sharp.IconChar.Undo;
            this.btnRegresar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(229)))), ((int)(((byte)(238)))));
            this.btnRegresar.IconSize = 35;
            this.btnRegresar.Location = new System.Drawing.Point(0, 367);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Rotation = 0D;
            this.btnRegresar.Size = new System.Drawing.Size(239, 50);
            this.btnRegresar.TabIndex = 23;
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // trkSaturacion
            // 
            this.trkSaturacion.Location = new System.Drawing.Point(42, 260);
            this.trkSaturacion.Maximum = 100;
            this.trkSaturacion.Minimum = -100;
            this.trkSaturacion.Name = "trkSaturacion";
            this.trkSaturacion.Size = new System.Drawing.Size(151, 45);
            this.trkSaturacion.TabIndex = 5;
            this.trkSaturacion.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trkSaturacion.Scroll += new System.EventHandler(this.trkSaturacion_Scroll);
            // 
            // trkContraste
            // 
            this.trkContraste.Location = new System.Drawing.Point(39, 158);
            this.trkContraste.Maximum = 100;
            this.trkContraste.Minimum = -100;
            this.trkContraste.Name = "trkContraste";
            this.trkContraste.Size = new System.Drawing.Size(154, 45);
            this.trkContraste.TabIndex = 3;
            this.trkContraste.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trkContraste.Scroll += new System.EventHandler(this.trkContraste_Scroll);
            // 
            // trkBrillo
            // 
            this.trkBrillo.Location = new System.Drawing.Point(39, 67);
            this.trkBrillo.Maximum = 100;
            this.trkBrillo.Minimum = -100;
            this.trkBrillo.Name = "trkBrillo";
            this.trkBrillo.Size = new System.Drawing.Size(154, 45);
            this.trkBrillo.TabIndex = 1;
            this.trkBrillo.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trkBrillo.Scroll += new System.EventHandler(this.trkBrillo_Scroll);
            // 
            // lblSaturacion
            // 
            this.lblSaturacion.AutoSize = true;
            this.lblSaturacion.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaturacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(229)))), ((int)(((byte)(238)))));
            this.lblSaturacion.Location = new System.Drawing.Point(37, 216);
            this.lblSaturacion.Name = "lblSaturacion";
            this.lblSaturacion.Size = new System.Drawing.Size(114, 30);
            this.lblSaturacion.TabIndex = 4;
            this.lblSaturacion.Text = "Saturación";
            // 
            // lblContraste
            // 
            this.lblContraste.AutoSize = true;
            this.lblContraste.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraste.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(229)))), ((int)(((byte)(238)))));
            this.lblContraste.Location = new System.Drawing.Point(37, 115);
            this.lblContraste.Name = "lblContraste";
            this.lblContraste.Size = new System.Drawing.Size(106, 30);
            this.lblContraste.TabIndex = 2;
            this.lblContraste.Text = "Contraste";
            // 
            // lblBrillo
            // 
            this.lblBrillo.AutoSize = true;
            this.lblBrillo.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrillo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(229)))), ((int)(((byte)(238)))));
            this.lblBrillo.Location = new System.Drawing.Point(51, 25);
            this.lblBrillo.Name = "lblBrillo";
            this.lblBrillo.Size = new System.Drawing.Size(62, 30);
            this.lblBrillo.TabIndex = 0;
            this.lblBrillo.Text = "Brillo";
            // 
            // pnlVideo
            // 
            this.pnlVideo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(89)))));
            this.pnlVideo.Controls.Add(this.pictureBox1);
            this.pnlVideo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlVideo.Location = new System.Drawing.Point(0, 183);
            this.pnlVideo.Name = "pnlVideo";
            this.pnlVideo.Size = new System.Drawing.Size(561, 417);
            this.pnlVideo.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(60, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(418, 310);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // comboVideo
            // 
            this.comboVideo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(229)))), ((int)(((byte)(238)))));
            this.comboVideo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboVideo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboVideo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboVideo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.comboVideo.FormattingEnabled = true;
            this.comboVideo.Location = new System.Drawing.Point(12, 42);
            this.comboVideo.Name = "comboVideo";
            this.comboVideo.Size = new System.Drawing.Size(201, 25);
            this.comboVideo.TabIndex = 8;
            this.comboVideo.SelectedIndexChanged += new System.EventHandler(this.comboVideo_SelectedIndexChanged);
            // 
            // btnBuscar
            // 
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(229)))), ((int)(((byte)(238)))));
            this.btnBuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnBuscar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(229)))), ((int)(((byte)(238)))));
            this.btnBuscar.IconSize = 40;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(496, 27);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Rotation = 0D;
            this.btnBuscar.Size = new System.Drawing.Size(125, 46);
            this.btnBuscar.TabIndex = 9;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnConectar
            // 
            this.btnConectar.FlatAppearance.BorderSize = 0;
            this.btnConectar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConectar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnConectar.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConectar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(229)))), ((int)(((byte)(238)))));
            this.btnConectar.IconChar = FontAwesome.Sharp.IconChar.Link;
            this.btnConectar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(229)))), ((int)(((byte)(238)))));
            this.btnConectar.IconSize = 40;
            this.btnConectar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConectar.Location = new System.Drawing.Point(12, 94);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Rotation = 0D;
            this.btnConectar.Size = new System.Drawing.Size(158, 38);
            this.btnConectar.TabIndex = 10;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConectar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // btnDesconectar
            // 
            this.btnDesconectar.FlatAppearance.BorderSize = 0;
            this.btnDesconectar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesconectar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnDesconectar.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesconectar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(229)))), ((int)(((byte)(238)))));
            this.btnDesconectar.IconChar = FontAwesome.Sharp.IconChar.Unlink;
            this.btnDesconectar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(229)))), ((int)(((byte)(238)))));
            this.btnDesconectar.IconSize = 40;
            this.btnDesconectar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDesconectar.Location = new System.Drawing.Point(188, 94);
            this.btnDesconectar.Name = "btnDesconectar";
            this.btnDesconectar.Rotation = 0D;
            this.btnDesconectar.Size = new System.Drawing.Size(179, 38);
            this.btnDesconectar.TabIndex = 11;
            this.btnDesconectar.Text = "Desconectar";
            this.btnDesconectar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDesconectar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDesconectar.UseVisualStyleBackColor = true;
            this.btnDesconectar.Click += new System.EventHandler(this.btnDesconectar_Click);
            // 
            // btnGrabar
            // 
            this.btnGrabar.FlatAppearance.BorderSize = 0;
            this.btnGrabar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGrabar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnGrabar.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrabar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(229)))), ((int)(((byte)(238)))));
            this.btnGrabar.IconChar = FontAwesome.Sharp.IconChar.RecordVinyl;
            this.btnGrabar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(229)))), ((int)(((byte)(238)))));
            this.btnGrabar.IconSize = 40;
            this.btnGrabar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGrabar.Location = new System.Drawing.Point(627, 29);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Rotation = 0D;
            this.btnGrabar.Size = new System.Drawing.Size(161, 42);
            this.btnGrabar.TabIndex = 13;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGrabar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // btnFinal
            // 
            this.btnFinal.FlatAppearance.BorderSize = 0;
            this.btnFinal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinal.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnFinal.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(229)))), ((int)(((byte)(238)))));
            this.btnFinal.IconChar = FontAwesome.Sharp.IconChar.FolderOpen;
            this.btnFinal.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(229)))), ((int)(((byte)(238)))));
            this.btnFinal.IconSize = 40;
            this.btnFinal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFinal.Location = new System.Drawing.Point(631, 92);
            this.btnFinal.Name = "btnFinal";
            this.btnFinal.Rotation = 0D;
            this.btnFinal.Size = new System.Drawing.Size(139, 42);
            this.btnFinal.TabIndex = 14;
            this.btnFinal.Text = "Finalizar";
            this.btnFinal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFinal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFinal.UseVisualStyleBackColor = true;
            this.btnFinal.Click += new System.EventHandler(this.btnFinal_Click);
            // 
            // comboRes
            // 
            this.comboRes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(229)))), ((int)(((byte)(238)))));
            this.comboRes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboRes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboRes.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboRes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.comboRes.FormattingEnabled = true;
            this.comboRes.Location = new System.Drawing.Point(373, 42);
            this.comboRes.Name = "comboRes";
            this.comboRes.Size = new System.Drawing.Size(117, 25);
            this.comboRes.TabIndex = 15;
            // 
            // pnlConexion
            // 
            this.pnlConexion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(89)))));
            this.pnlConexion.Controls.Add(this.lblCantidad);
            this.pnlConexion.Controls.Add(this.lblResolucion);
            this.pnlConexion.Controls.Add(this.lblCapturas);
            this.pnlConexion.Controls.Add(this.lblEntrada);
            this.pnlConexion.Controls.Add(this.lblNombre);
            this.pnlConexion.Controls.Add(this.comboInputs);
            this.pnlConexion.Controls.Add(this.comboRes);
            this.pnlConexion.Controls.Add(this.btnFinal);
            this.pnlConexion.Controls.Add(this.btnGrabar);
            this.pnlConexion.Controls.Add(this.btnDesconectar);
            this.pnlConexion.Controls.Add(this.btnConectar);
            this.pnlConexion.Controls.Add(this.btnBuscar);
            this.pnlConexion.Controls.Add(this.comboVideo);
            this.pnlConexion.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlConexion.Location = new System.Drawing.Point(0, 45);
            this.pnlConexion.Name = "pnlConexion";
            this.pnlConexion.Size = new System.Drawing.Size(800, 138);
            this.pnlConexion.TabIndex = 6;
            // 
            // lblResolucion
            // 
            this.lblResolucion.AutoSize = true;
            this.lblResolucion.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResolucion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(229)))), ((int)(((byte)(238)))));
            this.lblResolucion.Location = new System.Drawing.Point(368, 14);
            this.lblResolucion.Name = "lblResolucion";
            this.lblResolucion.Size = new System.Drawing.Size(104, 25);
            this.lblResolucion.TabIndex = 19;
            this.lblResolucion.Text = "Resolución";
            // 
            // lblEntrada
            // 
            this.lblEntrada.AutoSize = true;
            this.lblEntrada.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntrada.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(229)))), ((int)(((byte)(238)))));
            this.lblEntrada.Location = new System.Drawing.Point(214, 14);
            this.lblEntrada.Name = "lblEntrada";
            this.lblEntrada.Size = new System.Drawing.Size(78, 25);
            this.lblEntrada.TabIndex = 18;
            this.lblEntrada.Text = "Entrada";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(229)))), ((int)(((byte)(238)))));
            this.lblNombre.Location = new System.Drawing.Point(7, 14);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(83, 25);
            this.lblNombre.TabIndex = 17;
            this.lblNombre.Text = "Nombre";
            // 
            // comboInputs
            // 
            this.comboInputs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(229)))), ((int)(((byte)(238)))));
            this.comboInputs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboInputs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboInputs.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboInputs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.comboInputs.FormattingEnabled = true;
            this.comboInputs.Location = new System.Drawing.Point(219, 42);
            this.comboInputs.Name = "comboInputs";
            this.comboInputs.Size = new System.Drawing.Size(148, 25);
            this.comboInputs.TabIndex = 16;
            // 
            // lblCapturas
            // 
            this.lblCapturas.AutoSize = true;
            this.lblCapturas.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCapturas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(229)))), ((int)(((byte)(238)))));
            this.lblCapturas.Location = new System.Drawing.Point(368, 102);
            this.lblCapturas.Name = "lblCapturas";
            this.lblCapturas.Size = new System.Drawing.Size(98, 25);
            this.lblCapturas.TabIndex = 2;
            this.lblCapturas.Text = "Capturas: ";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(229)))), ((int)(((byte)(238)))));
            this.lblCantidad.Location = new System.Drawing.Point(472, 102);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(23, 25);
            this.lblCantidad.TabIndex = 3;
            this.lblCantidad.Text = "0";
            // 
            // frmSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.pnlFiltros);
            this.Controls.Add(this.pnlVideo);
            this.Controls.Add(this.pnlConexion);
            this.Controls.Add(this.pnlShade);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSesion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Med Q";
            this.Load += new System.EventHandler(this.frmSesion_Load);
            this.Shown += new System.EventHandler(this.frmSesion_Shown);
            this.pnlTop.ResumeLayout(false);
            this.pnlFiltros.ResumeLayout(false);
            this.pnlFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkSaturacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkContraste)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkBrillo)).EndInit();
            this.pnlVideo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlConexion.ResumeLayout(false);
            this.pnlConexion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private FontAwesome.Sharp.IconButton btnMin;
        private FontAwesome.Sharp.IconButton btnCerrar;
        private System.Windows.Forms.Panel pnlShade;
        private System.Windows.Forms.Panel pnlFiltros;
        private FontAwesome.Sharp.IconButton btnRegresar;
        private System.Windows.Forms.TrackBar trkSaturacion;
        private System.Windows.Forms.TrackBar trkContraste;
        private System.Windows.Forms.TrackBar trkBrillo;
        private System.Windows.Forms.Label lblSaturacion;
        private System.Windows.Forms.Label lblContraste;
        private System.Windows.Forms.Label lblBrillo;
        private System.Windows.Forms.Panel pnlVideo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboVideo;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private FontAwesome.Sharp.IconButton btnConectar;
        private FontAwesome.Sharp.IconButton btnDesconectar;
        private FontAwesome.Sharp.IconButton btnGrabar;
        private FontAwesome.Sharp.IconButton btnFinal;
        private System.Windows.Forms.ComboBox comboRes;
        private System.Windows.Forms.Panel pnlConexion;
        private System.Windows.Forms.ComboBox comboInputs;
        private System.Windows.Forms.Label lblResolucion;
        private System.Windows.Forms.Label lblEntrada;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblCapturas;
    }
}
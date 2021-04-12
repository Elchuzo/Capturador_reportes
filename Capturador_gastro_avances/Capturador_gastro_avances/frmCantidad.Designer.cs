namespace Capturador_gastro_avances
{
    partial class frmCantidad
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
            this.pnlShade = new System.Windows.Forms.Panel();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.btnMin = new FontAwesome.Sharp.IconButton();
            this.btnCerrar = new FontAwesome.Sharp.IconButton();
            this.btnFin = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.comboImagenes = new System.Windows.Forms.ComboBox();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlShade
            // 
            this.pnlShade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(56)))), ((int)(((byte)(115)))));
            this.pnlShade.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlShade.Location = new System.Drawing.Point(0, 27);
            this.pnlShade.Name = "pnlShade";
            this.pnlShade.Size = new System.Drawing.Size(500, 10);
            this.pnlShade.TabIndex = 28;
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(62)))), ((int)(((byte)(128)))));
            this.pnlTop.Controls.Add(this.btnMin);
            this.pnlTop.Controls.Add(this.btnCerrar);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(500, 27);
            this.pnlTop.TabIndex = 27;
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
            this.btnMin.Location = new System.Drawing.Point(440, 0);
            this.btnMin.Name = "btnMin";
            this.btnMin.Rotation = 0D;
            this.btnMin.Size = new System.Drawing.Size(30, 27);
            this.btnMin.TabIndex = 14;
            this.btnMin.TabStop = false;
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click_1);
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
            this.btnCerrar.Location = new System.Drawing.Point(470, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Rotation = 0D;
            this.btnCerrar.Size = new System.Drawing.Size(30, 27);
            this.btnCerrar.TabIndex = 12;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnFin
            // 
            this.btnFin.FlatAppearance.BorderSize = 0;
            this.btnFin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFin.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnFin.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(229)))), ((int)(((byte)(238)))));
            this.btnFin.IconChar = FontAwesome.Sharp.IconChar.ArrowCircleRight;
            this.btnFin.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(229)))), ((int)(((byte)(238)))));
            this.btnFin.IconSize = 40;
            this.btnFin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFin.Location = new System.Drawing.Point(187, 307);
            this.btnFin.Name = "btnFin";
            this.btnFin.Rotation = 0D;
            this.btnFin.Size = new System.Drawing.Size(161, 42);
            this.btnFin.TabIndex = 32;
            this.btnFin.Text = "Continuar";
            this.btnFin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFin.UseVisualStyleBackColor = true;
            this.btnFin.Click += new System.EventHandler(this.btnFin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(229)))), ((int)(((byte)(238)))));
            this.label1.Location = new System.Drawing.Point(58, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 30);
            this.label1.TabIndex = 31;
            this.label1.Text = "Cantidad Imágenes";
            // 
            // comboImagenes
            // 
            this.comboImagenes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(229)))), ((int)(((byte)(238)))));
            this.comboImagenes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboImagenes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboImagenes.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboImagenes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.comboImagenes.FormattingEnabled = true;
            this.comboImagenes.Items.AddRange(new object[] {
            "6",
            "9",
            "12"});
            this.comboImagenes.Location = new System.Drawing.Point(315, 126);
            this.comboImagenes.Name = "comboImagenes";
            this.comboImagenes.Size = new System.Drawing.Size(117, 25);
            this.comboImagenes.TabIndex = 33;
            // 
            // frmCantidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(89)))));
            this.ClientSize = new System.Drawing.Size(500, 411);
            this.Controls.Add(this.comboImagenes);
            this.Controls.Add(this.btnFin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlShade);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCantidad";
            this.Text = "frmCantidad";
            this.Load += new System.EventHandler(this.frmCantidad_Load);
            this.pnlTop.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlShade;
        private System.Windows.Forms.Panel pnlTop;
        private FontAwesome.Sharp.IconButton btnMin;
        private FontAwesome.Sharp.IconButton btnCerrar;
        private FontAwesome.Sharp.IconButton btnFin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboImagenes;
    }
}
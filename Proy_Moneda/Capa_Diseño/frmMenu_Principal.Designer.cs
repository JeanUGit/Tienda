namespace Capa_Diseño
{
    partial class frmMenu_Principal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu_Principal));
            this.pnlCabecera = new System.Windows.Forms.Panel();
            this.lblCerrar = new System.Windows.Forms.Label();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnVinculaciones = new System.Windows.Forms.Button();
            this.btnRecargas = new System.Windows.Forms.Button();
            this.btnRegEmple = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.timerOcultarM = new System.Windows.Forms.Timer(this.components);
            this.timerMostrarM = new System.Windows.Forms.Timer(this.components);
            this.pnlCabecera.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCabecera
            // 
            this.pnlCabecera.BackColor = System.Drawing.Color.Blue;
            this.pnlCabecera.Controls.Add(this.lblCerrar);
            this.pnlCabecera.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCabecera.Location = new System.Drawing.Point(0, 0);
            this.pnlCabecera.Name = "pnlCabecera";
            this.pnlCabecera.Size = new System.Drawing.Size(730, 30);
            this.pnlCabecera.TabIndex = 0;
            // 
            // lblCerrar
            // 
            this.lblCerrar.AutoSize = true;
            this.lblCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCerrar.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCerrar.Location = new System.Drawing.Point(705, 4);
            this.lblCerrar.Name = "lblCerrar";
            this.lblCerrar.Size = new System.Drawing.Size(24, 24);
            this.lblCerrar.TabIndex = 0;
            this.lblCerrar.Text = "X";
            this.lblCerrar.Click += new System.EventHandler(this.lblCerrar_Click);
            // 
            // pnlMenu
            // 
            this.pnlMenu.Controls.Add(this.btnVinculaciones);
            this.pnlMenu.Controls.Add(this.btnRecargas);
            this.pnlMenu.Controls.Add(this.btnRegEmple);
            this.pnlMenu.Controls.Add(this.btnMenu);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 30);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(220, 400);
            this.pnlMenu.TabIndex = 1;
            // 
            // btnVinculaciones
            // 
            this.btnVinculaciones.FlatAppearance.BorderSize = 0;
            this.btnVinculaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVinculaciones.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVinculaciones.Image = ((System.Drawing.Image)(resources.GetObject("btnVinculaciones.Image")));
            this.btnVinculaciones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVinculaciones.Location = new System.Drawing.Point(0, 199);
            this.btnVinculaciones.Name = "btnVinculaciones";
            this.btnVinculaciones.Size = new System.Drawing.Size(220, 40);
            this.btnVinculaciones.TabIndex = 3;
            this.btnVinculaciones.Text = "Vinculaciones";
            this.btnVinculaciones.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVinculaciones.UseVisualStyleBackColor = true;
            this.btnVinculaciones.Click += new System.EventHandler(this.btnVinculaciones_Click);
            // 
            // btnRecargas
            // 
            this.btnRecargas.FlatAppearance.BorderSize = 0;
            this.btnRecargas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecargas.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecargas.Image = ((System.Drawing.Image)(resources.GetObject("btnRecargas.Image")));
            this.btnRecargas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRecargas.Location = new System.Drawing.Point(0, 153);
            this.btnRecargas.Name = "btnRecargas";
            this.btnRecargas.Size = new System.Drawing.Size(220, 40);
            this.btnRecargas.TabIndex = 2;
            this.btnRecargas.Text = "Recargas";
            this.btnRecargas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRecargas.UseVisualStyleBackColor = true;
            this.btnRecargas.Click += new System.EventHandler(this.btnRecargas_Click);
            // 
            // btnRegEmple
            // 
            this.btnRegEmple.FlatAppearance.BorderSize = 0;
            this.btnRegEmple.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegEmple.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegEmple.Image = ((System.Drawing.Image)(resources.GetObject("btnRegEmple.Image")));
            this.btnRegEmple.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegEmple.Location = new System.Drawing.Point(0, 107);
            this.btnRegEmple.Name = "btnRegEmple";
            this.btnRegEmple.Size = new System.Drawing.Size(220, 40);
            this.btnRegEmple.TabIndex = 1;
            this.btnRegEmple.Text = "Registro de empleados";
            this.btnRegEmple.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegEmple.UseVisualStyleBackColor = true;
            this.btnRegEmple.Click += new System.EventHandler(this.btnRegEmple_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnMenu.BackgroundImage = global::Capa_Diseño.Properties.Resources.menuoutline_110931;
            this.btnMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Location = new System.Drawing.Point(187, 3);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(30, 30);
            this.btnMenu.TabIndex = 0;
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedor.Location = new System.Drawing.Point(220, 30);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(510, 400);
            this.pnlContenedor.TabIndex = 2;
            // 
            // timerOcultarM
            // 
            this.timerOcultarM.Interval = 20;
            this.timerOcultarM.Tick += new System.EventHandler(this.timerOcultarM_Tick);
            // 
            // timerMostrarM
            // 
            this.timerMostrarM.Interval = 20;
            this.timerMostrarM.Tick += new System.EventHandler(this.timerMostrarM_Tick);
            // 
            // frmMenu_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 430);
            this.Controls.Add(this.pnlContenedor);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlCabecera);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMenu_Principal";
            this.Text = "frmMenu_Principal";
            this.pnlCabecera.ResumeLayout(false);
            this.pnlCabecera.PerformLayout();
            this.pnlMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCabecera;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlContenedor;
        private System.Windows.Forms.Label lblCerrar;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Timer timerOcultarM;
        private System.Windows.Forms.Timer timerMostrarM;
        private System.Windows.Forms.Button btnVinculaciones;
        private System.Windows.Forms.Button btnRecargas;
        private System.Windows.Forms.Button btnRegEmple;
    }
}
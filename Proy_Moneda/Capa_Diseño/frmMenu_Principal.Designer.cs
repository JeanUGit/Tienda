﻿namespace Capa_Diseño
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
            this.pbMinimizar = new System.Windows.Forms.PictureBox();
            this.pbNormal = new System.Windows.Forms.PictureBox();
            this.pbMaximizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMenu = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnVinculaciones = new System.Windows.Forms.Button();
            this.btnRecargas = new System.Windows.Forms.Button();
            this.btnRegEmple = new System.Windows.Forms.Button();
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.timerOcultarM = new System.Windows.Forms.Timer(this.components);
            this.timerMostrarM = new System.Windows.Forms.Timer(this.components);
            this.pnlCabecera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNormal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMaximizar)).BeginInit();
            this.pnlMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCabecera
            // 
            this.pnlCabecera.BackColor = System.Drawing.Color.Blue;
            this.pnlCabecera.Controls.Add(this.pbMinimizar);
            this.pnlCabecera.Controls.Add(this.pbNormal);
            this.pnlCabecera.Controls.Add(this.pbMaximizar);
            this.pnlCabecera.Controls.Add(this.btnCerrar);
            this.pnlCabecera.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCabecera.Location = new System.Drawing.Point(0, 0);
            this.pnlCabecera.Name = "pnlCabecera";
            this.pnlCabecera.Size = new System.Drawing.Size(950, 30);
            this.pnlCabecera.TabIndex = 0;
            this.pnlCabecera.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlCabecera_MouseDown);
            // 
            // pbMinimizar
            // 
            this.pbMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("pbMinimizar.Image")));
            this.pbMinimizar.Location = new System.Drawing.Point(844, 3);
            this.pbMinimizar.Name = "pbMinimizar";
            this.pbMinimizar.Size = new System.Drawing.Size(34, 24);
            this.pbMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMinimizar.TabIndex = 2;
            this.pbMinimizar.TabStop = false;
            this.pbMinimizar.Click += new System.EventHandler(this.pbMinimizar_Click);
            // 
            // pbNormal
            // 
            this.pbNormal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbNormal.Image = ((System.Drawing.Image)(resources.GetObject("pbNormal.Image")));
            this.pbNormal.Location = new System.Drawing.Point(881, 2);
            this.pbNormal.Name = "pbNormal";
            this.pbNormal.Size = new System.Drawing.Size(34, 24);
            this.pbNormal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNormal.TabIndex = 1;
            this.pbNormal.TabStop = false;
            this.pbNormal.Visible = false;
            this.pbNormal.Click += new System.EventHandler(this.pbNormal_Click);
            // 
            // pbMaximizar
            // 
            this.pbMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("pbMaximizar.Image")));
            this.pbMaximizar.Location = new System.Drawing.Point(881, 3);
            this.pbMaximizar.Name = "pbMaximizar";
            this.pbMaximizar.Size = new System.Drawing.Size(34, 24);
            this.pbMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMaximizar.TabIndex = 0;
            this.pbMaximizar.TabStop = false;
            this.pbMaximizar.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCerrar.BackgroundImage")));
            this.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Location = new System.Drawing.Point(915, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(35, 30);
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.button4_Click);
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.White;
            this.pnlMenu.Controls.Add(this.panel6);
            this.pnlMenu.Controls.Add(this.panel5);
            this.pnlMenu.Controls.Add(this.panel4);
            this.pnlMenu.Controls.Add(this.panel3);
            this.pnlMenu.Controls.Add(this.panel2);
            this.pnlMenu.Controls.Add(this.panel1);
            this.pnlMenu.Controls.Add(this.btnMenu);
            this.pnlMenu.Controls.Add(this.button3);
            this.pnlMenu.Controls.Add(this.button2);
            this.pnlMenu.Controls.Add(this.button1);
            this.pnlMenu.Controls.Add(this.btnVinculaciones);
            this.pnlMenu.Controls.Add(this.btnRecargas);
            this.pnlMenu.Controls.Add(this.btnRegEmple);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 30);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(229, 570);
            this.pnlMenu.TabIndex = 1;
            this.pnlMenu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlMenu_MouseDown);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Blue;
            this.panel6.Location = new System.Drawing.Point(1, 483);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(10, 69);
            this.panel6.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Blue;
            this.panel5.Location = new System.Drawing.Point(1, 400);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(10, 69);
            this.panel5.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Blue;
            this.panel4.Location = new System.Drawing.Point(1, 312);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 69);
            this.panel4.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Blue;
            this.panel3.Location = new System.Drawing.Point(1, 225);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 69);
            this.panel3.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Blue;
            this.panel2.Location = new System.Drawing.Point(1, 139);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 69);
            this.panel2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Location = new System.Drawing.Point(1, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 69);
            this.panel1.TabIndex = 0;
            // 
            // btnMenu
            // 
            this.btnMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMenu.BackgroundImage = global::Capa_Diseño.Properties.Resources.menuoutline_110931;
            this.btnMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Location = new System.Drawing.Point(186, 3);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(40, 40);
            this.btnMenu.TabIndex = 0;
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Arial Narrow", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = global::Capa_Diseño.Properties.Resources.almacenamiento;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(12, 483);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(216, 70);
            this.button3.TabIndex = 6;
            this.button3.Text = "Producto";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial Narrow", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::Capa_Diseño.Properties.Resources.controlar;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(12, 399);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(214, 70);
            this.button2.TabIndex = 5;
            this.button2.Text = "Inventario";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::Capa_Diseño.Properties.Resources.maquina;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(12, 311);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(214, 70);
            this.button1.TabIndex = 4;
            this.button1.Text = "Venta";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnVinculaciones
            // 
            this.btnVinculaciones.FlatAppearance.BorderSize = 0;
            this.btnVinculaciones.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnVinculaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVinculaciones.Font = new System.Drawing.Font("Arial Narrow", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVinculaciones.Image = global::Capa_Diseño.Properties.Resources.social;
            this.btnVinculaciones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVinculaciones.Location = new System.Drawing.Point(12, 225);
            this.btnVinculaciones.Name = "btnVinculaciones";
            this.btnVinculaciones.Size = new System.Drawing.Size(214, 70);
            this.btnVinculaciones.TabIndex = 3;
            this.btnVinculaciones.Text = "Vinculaciones";
            this.btnVinculaciones.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVinculaciones.UseVisualStyleBackColor = true;
            this.btnVinculaciones.Click += new System.EventHandler(this.btnVinculaciones_Click);
            // 
            // btnRecargas
            // 
            this.btnRecargas.FlatAppearance.BorderSize = 0;
            this.btnRecargas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnRecargas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecargas.Font = new System.Drawing.Font("Arial Narrow", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecargas.Image = global::Capa_Diseño.Properties.Resources.navegador;
            this.btnRecargas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRecargas.Location = new System.Drawing.Point(12, 139);
            this.btnRecargas.Name = "btnRecargas";
            this.btnRecargas.Size = new System.Drawing.Size(214, 70);
            this.btnRecargas.TabIndex = 2;
            this.btnRecargas.Text = "Recargas";
            this.btnRecargas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRecargas.UseVisualStyleBackColor = true;
            this.btnRecargas.Click += new System.EventHandler(this.btnRecargas_Click);
            // 
            // btnRegEmple
            // 
            this.btnRegEmple.FlatAppearance.BorderSize = 0;
            this.btnRegEmple.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnRegEmple.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegEmple.Font = new System.Drawing.Font("Arial Narrow", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegEmple.Image = global::Capa_Diseño.Properties.Resources.avatar_de_hombre;
            this.btnRegEmple.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegEmple.Location = new System.Drawing.Point(12, 54);
            this.btnRegEmple.Name = "btnRegEmple";
            this.btnRegEmple.Size = new System.Drawing.Size(214, 70);
            this.btnRegEmple.TabIndex = 1;
            this.btnRegEmple.Text = "Empleados";
            this.btnRegEmple.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegEmple.UseVisualStyleBackColor = true;
            this.btnRegEmple.Click += new System.EventHandler(this.btnRegEmple_Click);
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.AutoScroll = true;
            this.pnlContenedor.BackColor = System.Drawing.Color.White;
            this.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedor.Location = new System.Drawing.Point(229, 30);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(721, 570);
            this.pnlContenedor.TabIndex = 2;
            this.pnlContenedor.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlContenedor_MouseDown);
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
            this.ClientSize = new System.Drawing.Size(950, 600);
            this.Controls.Add(this.pnlContenedor);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlCabecera);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMenu_Principal";
            this.Text = "frmMenu_Principal";
            this.pnlCabecera.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNormal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMaximizar)).EndInit();
            this.pnlMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCabecera;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlContenedor;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Timer timerOcultarM;
        private System.Windows.Forms.Timer timerMostrarM;
        private System.Windows.Forms.Button btnVinculaciones;
        private System.Windows.Forms.Button btnRecargas;
        private System.Windows.Forms.Button btnRegEmple;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.PictureBox pbMinimizar;
        private System.Windows.Forms.PictureBox pbNormal;
        private System.Windows.Forms.PictureBox pbMaximizar;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
    }
}
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
            this.pnlCabecera = new System.Windows.Forms.Panel();
            this.pnlMenu = new System.Windows.Forms.Panel();
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
            this.button4 = new System.Windows.Forms.Button();
            this.pnlCabecera.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCabecera
            // 
            this.pnlCabecera.BackColor = System.Drawing.Color.Blue;
            this.pnlCabecera.Controls.Add(this.button4);
            this.pnlCabecera.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCabecera.Location = new System.Drawing.Point(0, 0);
            this.pnlCabecera.Name = "pnlCabecera";
            this.pnlCabecera.Size = new System.Drawing.Size(900, 30);
            this.pnlCabecera.TabIndex = 0;
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.White;
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
            this.pnlMenu.Size = new System.Drawing.Size(220, 570);
            this.pnlMenu.TabIndex = 1;
            // 
            // btnMenu
            // 
            this.btnMenu.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnMenu.BackgroundImage = global::Capa_Diseño.Properties.Resources.menuoutline_110931;
            this.btnMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Location = new System.Drawing.Point(177, 3);
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
            this.button3.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = global::Capa_Diseño.Properties.Resources.almacenamiento;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(2, 483);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(217, 70);
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
            this.button2.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::Capa_Diseño.Properties.Resources.controlar;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(0, 399);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(217, 70);
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
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::Capa_Diseño.Properties.Resources.maquina;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 311);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(217, 70);
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
            this.btnVinculaciones.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVinculaciones.Image = global::Capa_Diseño.Properties.Resources.social;
            this.btnVinculaciones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVinculaciones.Location = new System.Drawing.Point(0, 225);
            this.btnVinculaciones.Name = "btnVinculaciones";
            this.btnVinculaciones.Size = new System.Drawing.Size(217, 70);
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
            this.btnRecargas.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecargas.Image = global::Capa_Diseño.Properties.Resources.navegador;
            this.btnRecargas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRecargas.Location = new System.Drawing.Point(0, 139);
            this.btnRecargas.Name = "btnRecargas";
            this.btnRecargas.Size = new System.Drawing.Size(217, 70);
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
            this.btnRegEmple.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegEmple.Image = global::Capa_Diseño.Properties.Resources.avatar_de_hombre;
            this.btnRegEmple.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegEmple.Location = new System.Drawing.Point(0, 54);
            this.btnRegEmple.Name = "btnRegEmple";
            this.btnRegEmple.Size = new System.Drawing.Size(217, 70);
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
            this.pnlContenedor.Location = new System.Drawing.Point(220, 30);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(680, 570);
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
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Red;
            this.button4.Dock = System.Windows.Forms.DockStyle.Right;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Transparent;
            this.button4.Location = new System.Drawing.Point(867, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(33, 30);
            this.button4.TabIndex = 0;
            this.button4.Text = "X";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // frmMenu_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.pnlContenedor);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlCabecera);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMenu_Principal";
            this.Text = "frmMenu_Principal";
            this.pnlCabecera.ResumeLayout(false);
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
        private System.Windows.Forms.Button button4;
    }
}
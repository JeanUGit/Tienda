namespace Capa_Diseño
{
    partial class FrmVenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVenta));
            this.panelFondo = new System.Windows.Forms.Panel();
            this.btnQuitarTicket = new System.Windows.Forms.Button();
            this.btnNuevoTicket = new System.Windows.Forms.Button();
            this.btnSalidaCajero = new System.Windows.Forms.Button();
            this.btnAgregarCajero = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnCobrarVenta = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.tabcontrol = new System.Windows.Forms.Panel();
            this.metroTabControl = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.txtCodigoProducto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelFondo.SuspendLayout();
            this.tabcontrol.SuspendLayout();
            this.metroTabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelFondo
            // 
            this.panelFondo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelFondo.Controls.Add(this.btnQuitarTicket);
            this.panelFondo.Controls.Add(this.btnNuevoTicket);
            this.panelFondo.Controls.Add(this.btnSalidaCajero);
            this.panelFondo.Controls.Add(this.btnAgregarCajero);
            this.panelFondo.Controls.Add(this.btnBuscar);
            this.panelFondo.Controls.Add(this.btnCobrarVenta);
            this.panelFondo.Controls.Add(this.lblTotal);
            this.panelFondo.Controls.Add(this.tabcontrol);
            this.panelFondo.Controls.Add(this.txtCodigoProducto);
            this.panelFondo.Controls.Add(this.label1);
            this.panelFondo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFondo.Location = new System.Drawing.Point(0, 0);
            this.panelFondo.Name = "panelFondo";
            this.panelFondo.Size = new System.Drawing.Size(673, 436);
            this.panelFondo.TabIndex = 2;
            // 
            // btnQuitarTicket
            // 
            this.btnQuitarTicket.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnQuitarTicket.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.btnQuitarTicket.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnQuitarTicket.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.btnQuitarTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitarTicket.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitarTicket.ForeColor = System.Drawing.Color.Black;
            this.btnQuitarTicket.Image = ((System.Drawing.Image)(resources.GetObject("btnQuitarTicket.Image")));
            this.btnQuitarTicket.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuitarTicket.Location = new System.Drawing.Point(163, 354);
            this.btnQuitarTicket.Name = "btnQuitarTicket";
            this.btnQuitarTicket.Size = new System.Drawing.Size(148, 36);
            this.btnQuitarTicket.TabIndex = 16;
            this.btnQuitarTicket.Text = "Quitar Tiquete";
            this.btnQuitarTicket.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnQuitarTicket.UseVisualStyleBackColor = false;
            this.btnQuitarTicket.Click += new System.EventHandler(this.btnQuitarTicket_Click);
            // 
            // btnNuevoTicket
            // 
            this.btnNuevoTicket.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnNuevoTicket.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.btnNuevoTicket.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnNuevoTicket.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.btnNuevoTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoTicket.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoTicket.ForeColor = System.Drawing.Color.Black;
            this.btnNuevoTicket.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevoTicket.Image")));
            this.btnNuevoTicket.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevoTicket.Location = new System.Drawing.Point(9, 354);
            this.btnNuevoTicket.Name = "btnNuevoTicket";
            this.btnNuevoTicket.Size = new System.Drawing.Size(148, 36);
            this.btnNuevoTicket.TabIndex = 15;
            this.btnNuevoTicket.Text = "Nuevo Tiquete";
            this.btnNuevoTicket.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevoTicket.UseVisualStyleBackColor = false;
            this.btnNuevoTicket.Click += new System.EventHandler(this.btnNuevoTicket_Click);
            // 
            // btnSalidaCajero
            // 
            this.btnSalidaCajero.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSalidaCajero.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.btnSalidaCajero.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnSalidaCajero.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.btnSalidaCajero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalidaCajero.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalidaCajero.ForeColor = System.Drawing.Color.Black;
            this.btnSalidaCajero.Image = ((System.Drawing.Image)(resources.GetObject("btnSalidaCajero.Image")));
            this.btnSalidaCajero.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalidaCajero.Location = new System.Drawing.Point(499, 91);
            this.btnSalidaCajero.Name = "btnSalidaCajero";
            this.btnSalidaCajero.Size = new System.Drawing.Size(160, 30);
            this.btnSalidaCajero.TabIndex = 14;
            this.btnSalidaCajero.Text = "Salida de Cajero";
            this.btnSalidaCajero.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalidaCajero.UseVisualStyleBackColor = false;
            // 
            // btnAgregarCajero
            // 
            this.btnAgregarCajero.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAgregarCajero.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.btnAgregarCajero.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnAgregarCajero.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.btnAgregarCajero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarCajero.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarCajero.ForeColor = System.Drawing.Color.Black;
            this.btnAgregarCajero.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarCajero.Image")));
            this.btnAgregarCajero.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarCajero.Location = new System.Drawing.Point(488, 45);
            this.btnAgregarCajero.Name = "btnAgregarCajero";
            this.btnAgregarCajero.Size = new System.Drawing.Size(171, 30);
            this.btnAgregarCajero.TabIndex = 13;
            this.btnAgregarCajero.Text = "Agregar Al Cajero";
            this.btnAgregarCajero.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarCajero.UseVisualStyleBackColor = false;
            this.btnAgregarCajero.Click += new System.EventHandler(this.btnAgregarCajero_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.btnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.Black;
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(353, 45);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(100, 30);
            this.btnBuscar.TabIndex = 12;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // btnCobrarVenta
            // 
            this.btnCobrarVenta.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCobrarVenta.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.btnCobrarVenta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnCobrarVenta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.btnCobrarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCobrarVenta.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCobrarVenta.ForeColor = System.Drawing.Color.Black;
            this.btnCobrarVenta.Image = ((System.Drawing.Image)(resources.GetObject("btnCobrarVenta.Image")));
            this.btnCobrarVenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCobrarVenta.Location = new System.Drawing.Point(341, 368);
            this.btnCobrarVenta.Name = "btnCobrarVenta";
            this.btnCobrarVenta.Size = new System.Drawing.Size(153, 52);
            this.btnCobrarVenta.TabIndex = 11;
            this.btnCobrarVenta.Text = "Cobrar";
            this.btnCobrarVenta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCobrarVenta.UseVisualStyleBackColor = false;
            // 
            // lblTotal
            // 
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotal.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.Black;
            this.lblTotal.Location = new System.Drawing.Point(499, 368);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(162, 59);
            this.lblTotal.TabIndex = 7;
            this.lblTotal.Text = "$0";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabcontrol
            // 
            this.tabcontrol.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabcontrol.Controls.Add(this.metroTabControl);
            this.tabcontrol.Location = new System.Drawing.Point(9, 127);
            this.tabcontrol.Name = "tabcontrol";
            this.tabcontrol.Size = new System.Drawing.Size(652, 220);
            this.tabcontrol.TabIndex = 6;
            // 
            // metroTabControl
            // 
            this.metroTabControl.Controls.Add(this.metroTabPage1);
            this.metroTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl.Location = new System.Drawing.Point(0, 0);
            this.metroTabControl.Name = "metroTabControl";
            this.metroTabControl.Padding = new System.Drawing.Point(6, 8);
            this.metroTabControl.SelectedIndex = 0;
            this.metroTabControl.Size = new System.Drawing.Size(648, 216);
            this.metroTabControl.TabIndex = 0;
            this.metroTabControl.UseSelectable = true;
            this.metroTabControl.DoubleClick += new System.EventHandler(this.metroTabControl_DoubleClick);
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.BackColor = System.Drawing.Color.White;
            this.metroTabPage1.Enabled = true;
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(640, 174);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Tiquete 1";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            this.metroTabPage1.Visible = true;
            // 
            // txtCodigoProducto
            // 
            this.txtCodigoProducto.Location = new System.Drawing.Point(161, 52);
            this.txtCodigoProducto.Name = "txtCodigoProducto";
            this.txtCodigoProducto.Size = new System.Drawing.Size(181, 20);
            this.txtCodigoProducto.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Codigo del Producto:";
            // 
            // FrmVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 436);
            this.Controls.Add(this.panelFondo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmVenta";
            this.panelFondo.ResumeLayout(false);
            this.panelFondo.PerformLayout();
            this.tabcontrol.ResumeLayout(false);
            this.metroTabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelFondo;
        private System.Windows.Forms.Button btnQuitarTicket;
        private System.Windows.Forms.Button btnNuevoTicket;
        private System.Windows.Forms.Button btnSalidaCajero;
        private System.Windows.Forms.Button btnAgregarCajero;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnCobrarVenta;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Panel tabcontrol;
        private MetroFramework.Controls.MetroTabControl metroTabControl;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private System.Windows.Forms.TextBox txtCodigoProducto;
        private System.Windows.Forms.Label label1;
    }
}
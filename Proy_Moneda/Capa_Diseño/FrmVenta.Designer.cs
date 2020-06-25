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
            this.lblNombreCliente = new System.Windows.Forms.Label();
            this.txtDocumentoCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.ticket = new System.Windows.Forms.TabPage();
            this.tabla = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNuevoTicket = new System.Windows.Forms.Button();
            this.btnSalidaCajero = new System.Windows.Forms.Button();
            this.btnAgregarCajero = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnCobrarVenta = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtCodigoProducto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNumeroVenta = new System.Windows.Forms.Label();
            this.lblNumeroV = new System.Windows.Forms.Label();
            this.panelFondo.SuspendLayout();
            this.TabControl.SuspendLayout();
            this.ticket.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabla)).BeginInit();
            this.SuspendLayout();
            // 
            // panelFondo
            // 
            this.panelFondo.BackColor = System.Drawing.SystemColors.Window;
            this.panelFondo.Controls.Add(this.lblNumeroV);
            this.panelFondo.Controls.Add(this.lblNumeroVenta);
            this.panelFondo.Controls.Add(this.lblNombreCliente);
            this.panelFondo.Controls.Add(this.txtDocumentoCliente);
            this.panelFondo.Controls.Add(this.label2);
            this.panelFondo.Controls.Add(this.TabControl);
            this.panelFondo.Controls.Add(this.btnNuevoTicket);
            this.panelFondo.Controls.Add(this.btnSalidaCajero);
            this.panelFondo.Controls.Add(this.btnAgregarCajero);
            this.panelFondo.Controls.Add(this.btnBuscar);
            this.panelFondo.Controls.Add(this.btnCobrarVenta);
            this.panelFondo.Controls.Add(this.lblTotal);
            this.panelFondo.Controls.Add(this.txtCodigoProducto);
            this.panelFondo.Controls.Add(this.label1);
            this.panelFondo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFondo.Location = new System.Drawing.Point(0, 0);
            this.panelFondo.Name = "panelFondo";
            this.panelFondo.Size = new System.Drawing.Size(673, 436);
            this.panelFondo.TabIndex = 2;
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreCliente.Location = new System.Drawing.Point(244, 0);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(269, 29);
            this.lblNombreCliente.TabIndex = 20;
            this.lblNombreCliente.Text = "Nombre del Cliente";
            this.lblNombreCliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDocumentoCliente
            // 
            this.txtDocumentoCliente.Location = new System.Drawing.Point(250, 52);
            this.txtDocumentoCliente.Name = "txtDocumentoCliente";
            this.txtDocumentoCliente.Size = new System.Drawing.Size(165, 20);
            this.txtDocumentoCliente.TabIndex = 19;
            this.txtDocumentoCliente.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtDocumentoCliente_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(107, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 19);
            this.label2.TabIndex = 18;
            this.label2.Text = "Documento Cliente:";
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.ticket);
            this.TabControl.Location = new System.Drawing.Point(12, 140);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(649, 208);
            this.TabControl.TabIndex = 17;
            // 
            // ticket
            // 
            this.ticket.BackColor = System.Drawing.Color.Maroon;
            this.ticket.Controls.Add(this.tabla);
            this.ticket.Location = new System.Drawing.Point(4, 22);
            this.ticket.Name = "ticket";
            this.ticket.Padding = new System.Windows.Forms.Padding(3);
            this.ticket.Size = new System.Drawing.Size(641, 182);
            this.ticket.TabIndex = 0;
            this.ticket.Text = "TICKET 0";
            // 
            // tabla
            // 
            this.tabla.AllowUserToAddRows = false;
            this.tabla.AllowUserToDeleteRows = false;
            this.tabla.AllowUserToResizeColumns = false;
            this.tabla.AllowUserToResizeRows = false;
            this.tabla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tabla.BackgroundColor = System.Drawing.SystemColors.Window;
            this.tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre,
            this.Precio,
            this.Stock,
            this.Cantidad});
            this.tabla.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabla.Location = new System.Drawing.Point(3, 3);
            this.tabla.Name = "tabla";
            this.tabla.ReadOnly = true;
            this.tabla.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.tabla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tabla.Size = new System.Drawing.Size(635, 176);
            this.tabla.TabIndex = 0;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // Stock
            // 
            this.Stock.HeaderText = "Stock";
            this.Stock.Name = "Stock";
            this.Stock.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
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
            this.btnNuevoTicket.Location = new System.Drawing.Point(33, 354);
            this.btnNuevoTicket.Name = "btnNuevoTicket";
            this.btnNuevoTicket.Size = new System.Drawing.Size(163, 42);
            this.btnNuevoTicket.TabIndex = 15;
            this.btnNuevoTicket.Text = "Limpiar Tiquete";
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
            this.btnSalidaCajero.Location = new System.Drawing.Point(499, 104);
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
            this.btnAgregarCajero.Location = new System.Drawing.Point(499, 68);
            this.btnAgregarCajero.Name = "btnAgregarCajero";
            this.btnAgregarCajero.Size = new System.Drawing.Size(162, 30);
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
            this.btnBuscar.Location = new System.Drawing.Point(533, 32);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(100, 30);
            this.btnBuscar.TabIndex = 12;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
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
            this.btnCobrarVenta.Click += new System.EventHandler(this.btnCobrarVenta_Click);
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
            // txtCodigoProducto
            // 
            this.txtCodigoProducto.Location = new System.Drawing.Point(250, 105);
            this.txtCodigoProducto.Name = "txtCodigoProducto";
            this.txtCodigoProducto.Size = new System.Drawing.Size(69, 20);
            this.txtCodigoProducto.TabIndex = 5;
            this.txtCodigoProducto.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCodigoProducto_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(101, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Codigo del Producto:";
            // 
            // lblNumeroVenta
            // 
            this.lblNumeroVenta.AutoSize = true;
            this.lblNumeroVenta.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroVenta.Location = new System.Drawing.Point(3, 4);
            this.lblNumeroVenta.Name = "lblNumeroVenta";
            this.lblNumeroVenta.Size = new System.Drawing.Size(152, 36);
            this.lblNumeroVenta.TabIndex = 21;
            this.lblNumeroVenta.Text = "Número de Venta";
            // 
            // lblNumeroV
            // 
            this.lblNumeroV.AutoSize = true;
            this.lblNumeroV.Font = new System.Drawing.Font("Javanese Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroV.Location = new System.Drawing.Point(150, 0);
            this.lblNumeroV.Name = "lblNumeroV";
            this.lblNumeroV.Size = new System.Drawing.Size(30, 43);
            this.lblNumeroV.TabIndex = 22;
            this.lblNumeroV.Text = "0";
            // 
            // FrmVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 436);
            this.Controls.Add(this.panelFondo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "FrmVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmVenta";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FrmVenta_KeyUp);
            this.panelFondo.ResumeLayout(false);
            this.panelFondo.PerformLayout();
            this.TabControl.ResumeLayout(false);
            this.ticket.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabla)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelFondo;
        private System.Windows.Forms.Button btnNuevoTicket;
        private System.Windows.Forms.Button btnSalidaCajero;
        private System.Windows.Forms.Button btnAgregarCajero;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnCobrarVenta;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtCodigoProducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage ticket;
        public System.Windows.Forms.DataGridView tabla;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNombreCliente;
        private System.Windows.Forms.TextBox txtDocumentoCliente;
        private System.Windows.Forms.Label lblNumeroVenta;
        private System.Windows.Forms.Label lblNumeroV;
    }
}
namespace Capa_Diseño
{
    partial class FrmRecargas
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
            this.label2 = new System.Windows.Forms.Label();
            this.BtnRecargar = new System.Windows.Forms.Button();
            this.LblSaldo = new System.Windows.Forms.Label();
            this.TxtRecargaSaldo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 31);
            this.label2.TabIndex = 38;
            this.label2.Text = "Recarga de saldo:";
            // 
            // BtnRecargar
            // 
            this.BtnRecargar.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.BtnRecargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRecargar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRecargar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnRecargar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRecargar.Location = new System.Drawing.Point(31, 290);
            this.BtnRecargar.Name = "BtnRecargar";
            this.BtnRecargar.Size = new System.Drawing.Size(94, 33);
            this.BtnRecargar.TabIndex = 37;
            this.BtnRecargar.Text = "Recargar";
            this.BtnRecargar.UseVisualStyleBackColor = false;
            this.BtnRecargar.Click += new System.EventHandler(this.BtnRecargar_Click);
            // 
            // LblSaldo
            // 
            this.LblSaldo.AutoSize = true;
            this.LblSaldo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSaldo.Location = new System.Drawing.Point(27, 163);
            this.LblSaldo.Name = "LblSaldo";
            this.LblSaldo.Size = new System.Drawing.Size(48, 19);
            this.LblSaldo.TabIndex = 34;
            this.LblSaldo.Text = "Saldo:";
            // 
            // TxtRecargaSaldo
            // 
            this.TxtRecargaSaldo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtRecargaSaldo.Location = new System.Drawing.Point(31, 233);
            this.TxtRecargaSaldo.Name = "TxtRecargaSaldo";
            this.TxtRecargaSaldo.Size = new System.Drawing.Size(235, 27);
            this.TxtRecargaSaldo.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 19);
            this.label1.TabIndex = 32;
            this.label1.Text = "Saldo a recargar:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 19);
            this.label5.TabIndex = 31;
            this.label5.Text = "Saldo:";
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCodigo.Location = new System.Drawing.Point(31, 94);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(278, 27);
            this.TxtCodigo.TabIndex = 30;
            this.TxtCodigo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtCodigo_KeyUp);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 19);
            this.label4.TabIndex = 29;
            this.label4.Text = "Código:";
            // 
            // FrmRecargas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(372, 354);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnRecargar);
            this.Controls.Add(this.LblSaldo);
            this.Controls.Add(this.TxtRecargaSaldo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtCodigo);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRecargas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recargas";
            this.Load += new System.EventHandler(this.FrmRecargas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnRecargar;
        private System.Windows.Forms.Label LblSaldo;
        private System.Windows.Forms.TextBox TxtRecargaSaldo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtCodigo;
        private System.Windows.Forms.Label label4;
    }
}
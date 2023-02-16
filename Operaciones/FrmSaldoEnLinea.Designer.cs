namespace Operaciones
{
    partial class FrmSaldoEnLinea
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
            this.lblHora = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.ReporSaldoEnLinea = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(263, 9);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(0, 32);
            this.lblHora.TabIndex = 0;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(234, 50);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(0, 28);
            this.lblFecha.TabIndex = 1;
            // 
            // ReporSaldoEnLinea
            // 
            this.ReporSaldoEnLinea.LocalReport.ReportEmbeddedResource = "Operaciones.ReporteSaldoEnLinea.rdlc";
            this.ReporSaldoEnLinea.Location = new System.Drawing.Point(24, 121);
            this.ReporSaldoEnLinea.Name = "ReporSaldoEnLinea";
            this.ReporSaldoEnLinea.ServerReport.BearerToken = null;
            this.ReporSaldoEnLinea.Size = new System.Drawing.Size(713, 246);
            this.ReporSaldoEnLinea.TabIndex = 2;
            // 
            // FrmSaldoEnLinea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 496);
            this.Controls.Add(this.ReporSaldoEnLinea);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblHora);
            this.Name = "FrmSaldoEnLinea";
            this.Text = "FrmSaldoEnLinea";
            this.Load += new System.EventHandler(this.FrmSaldoEnLinea_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblFecha;
        private Microsoft.Reporting.WinForms.ReportViewer ReporSaldoEnLinea;
    }
}
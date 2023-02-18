namespace Operaciones
{
    partial class FrmAnularFac
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAnularFac));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cboEstacionamiento = new System.Windows.Forms.ComboBox();
            this.dvgListadoFactura = new System.Windows.Forms.DataGridView();
            this.Anular = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.iconButton4 = new FontAwesome.Sharp.IconButton();
            this.txtNumeroFactura = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgListadoFactura)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cboEstacionamiento);
            this.panel1.Controls.Add(this.dvgListadoFactura);
            this.panel1.Controls.Add(this.iconButton4);
            this.panel1.Controls.Add(this.txtNumeroFactura);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Location = new System.Drawing.Point(12, 102);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(842, 209);
            this.panel1.TabIndex = 0;
            // 
            // cboEstacionamiento
            // 
            this.cboEstacionamiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstacionamiento.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.cboEstacionamiento.FormattingEnabled = true;
            this.cboEstacionamiento.Location = new System.Drawing.Point(400, 16);
            this.cboEstacionamiento.Name = "cboEstacionamiento";
            this.cboEstacionamiento.Size = new System.Drawing.Size(209, 26);
            this.cboEstacionamiento.TabIndex = 39;
            // 
            // dvgListadoFactura
            // 
            this.dvgListadoFactura.AllowUserToAddRows = false;
            this.dvgListadoFactura.AllowUserToDeleteRows = false;
            this.dvgListadoFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgListadoFactura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Anular});
            this.dvgListadoFactura.Location = new System.Drawing.Point(27, 65);
            this.dvgListadoFactura.Name = "dvgListadoFactura";
            this.dvgListadoFactura.ReadOnly = true;
            this.dvgListadoFactura.Size = new System.Drawing.Size(781, 104);
            this.dvgListadoFactura.TabIndex = 38;
            this.dvgListadoFactura.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgListadoFactura_CellContentClick);
            // 
            // Anular
            // 
            this.Anular.HeaderText = "Anular";
            this.Anular.Name = "Anular";
            this.Anular.ReadOnly = true;
            this.Anular.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Anular.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // iconButton4
            // 
            this.iconButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(157)))), ((int)(((byte)(57)))));
            this.iconButton4.FlatAppearance.BorderSize = 0;
            this.iconButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton4.ForeColor = System.Drawing.SystemColors.Control;
            this.iconButton4.Icon = FontAwesome.Sharp.IconChar.ListAlt;
            this.iconButton4.IconColor = System.Drawing.Color.White;
            this.iconButton4.IconSize = 16;
            this.iconButton4.Image = ((System.Drawing.Image)(resources.GetObject("iconButton4.Image")));
            this.iconButton4.Location = new System.Drawing.Point(663, 11);
            this.iconButton4.Name = "iconButton4";
            this.iconButton4.Size = new System.Drawing.Size(98, 39);
            this.iconButton4.TabIndex = 33;
            this.iconButton4.Text = "Buscar";
            this.iconButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton4.UseVisualStyleBackColor = false;
            this.iconButton4.Click += new System.EventHandler(this.iconButton4_Click);
            // 
            // txtNumeroFactura
            // 
            this.txtNumeroFactura.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroFactura.Location = new System.Drawing.Point(177, 17);
            this.txtNumeroFactura.Name = "txtNumeroFactura";
            this.txtNumeroFactura.Size = new System.Drawing.Size(113, 26);
            this.txtNumeroFactura.TabIndex = 36;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(33, 20);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(138, 18);
            this.label16.TabIndex = 35;
            this.label16.Text = "Número Factura";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(322, 20);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(49, 18);
            this.label15.TabIndex = 34;
            this.label15.Text = "Sede";
            // 
            // FrmAnularFac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 450);
            this.Controls.Add(this.panel1);
            this.Name = "FrmAnularFac";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAnularFac";
            this.Load += new System.EventHandler(this.FrmAnularFac_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgListadoFactura)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cboEstacionamiento;
        private System.Windows.Forms.DataGridView dvgListadoFactura;
        private FontAwesome.Sharp.IconButton iconButton4;
        private System.Windows.Forms.TextBox txtNumeroFactura;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Anular;
    }
}
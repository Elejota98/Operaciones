namespace Operaciones
{
    partial class FrmResoluciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmResoluciones));
            this.dvgListadoResolucion = new System.Windows.Forms.DataGridView();
            this.Editar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconButton4 = new FontAwesome.Sharp.IconButton();
            this.cboEstacionamiento = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.DtmResolucion = new System.Windows.Forms.DateTimePicker();
            this.DtmFinResolucion = new System.Windows.Forms.DateTimePicker();
            this.TxtResolucion = new System.Windows.Forms.TextBox();
            this.TxtFacActual = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtFacFinal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtFacInicial = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtPrefijo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtModulo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtFacturacion = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.PanelAcciones = new System.Windows.Forms.Panel();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.btnGuardar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dvgListadoResolucion)).BeginInit();
            this.panel1.SuspendLayout();
            this.PanelAcciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // dvgListadoResolucion
            // 
            this.dvgListadoResolucion.AllowUserToAddRows = false;
            this.dvgListadoResolucion.AllowUserToDeleteRows = false;
            this.dvgListadoResolucion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgListadoResolucion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Editar});
            this.dvgListadoResolucion.Location = new System.Drawing.Point(29, 72);
            this.dvgListadoResolucion.Name = "dvgListadoResolucion";
            this.dvgListadoResolucion.ReadOnly = true;
            this.dvgListadoResolucion.Size = new System.Drawing.Size(797, 164);
            this.dvgListadoResolucion.TabIndex = 0;
            this.dvgListadoResolucion.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgListadoResolucion_CellContentClick);
            // 
            // Editar
            // 
            this.Editar.HeaderText = "Editar";
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.iconButton4);
            this.panel1.Controls.Add(this.dvgListadoResolucion);
            this.panel1.Location = new System.Drawing.Point(25, 281);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(892, 255);
            this.panel1.TabIndex = 1;
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
            this.iconButton4.Location = new System.Drawing.Point(728, 16);
            this.iconButton4.Name = "iconButton4";
            this.iconButton4.Size = new System.Drawing.Size(98, 39);
            this.iconButton4.TabIndex = 40;
            this.iconButton4.Text = "Buscar";
            this.iconButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton4.UseVisualStyleBackColor = false;
            this.iconButton4.Click += new System.EventHandler(this.iconButton4_Click);
            // 
            // cboEstacionamiento
            // 
            this.cboEstacionamiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstacionamiento.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.cboEstacionamiento.FormattingEnabled = true;
            this.cboEstacionamiento.Location = new System.Drawing.Point(358, 19);
            this.cboEstacionamiento.Name = "cboEstacionamiento";
            this.cboEstacionamiento.Size = new System.Drawing.Size(209, 26);
            this.cboEstacionamiento.TabIndex = 42;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(280, 23);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(49, 18);
            this.label15.TabIndex = 41;
            this.label15.Text = "Sede";
            // 
            // DtmResolucion
            // 
            this.DtmResolucion.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtmResolucion.CustomFormat = "dd-MM-yyyy";
            this.DtmResolucion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.DtmResolucion.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtmResolucion.Location = new System.Drawing.Point(207, 173);
            this.DtmResolucion.Name = "DtmResolucion";
            this.DtmResolucion.Size = new System.Drawing.Size(130, 26);
            this.DtmResolucion.TabIndex = 60;
            this.DtmResolucion.Value = new System.DateTime(2021, 11, 25, 0, 0, 0, 0);
            // 
            // DtmFinResolucion
            // 
            this.DtmFinResolucion.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtmFinResolucion.CustomFormat = "dd-MM-yyyy";
            this.DtmFinResolucion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.DtmFinResolucion.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtmFinResolucion.Location = new System.Drawing.Point(208, 219);
            this.DtmFinResolucion.Name = "DtmFinResolucion";
            this.DtmFinResolucion.Size = new System.Drawing.Size(130, 26);
            this.DtmFinResolucion.TabIndex = 59;
            this.DtmFinResolucion.Value = new System.DateTime(2021, 11, 25, 0, 0, 0, 0);
            // 
            // TxtResolucion
            // 
            this.TxtResolucion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.TxtResolucion.Location = new System.Drawing.Point(508, 60);
            this.TxtResolucion.Name = "TxtResolucion";
            this.TxtResolucion.Size = new System.Drawing.Size(181, 26);
            this.TxtResolucion.TabIndex = 55;
            // 
            // TxtFacActual
            // 
            this.TxtFacActual.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.TxtFacActual.Location = new System.Drawing.Point(508, 224);
            this.TxtFacActual.Name = "TxtFacActual";
            this.TxtFacActual.Size = new System.Drawing.Size(181, 26);
            this.TxtFacActual.TabIndex = 58;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.label1.Location = new System.Drawing.Point(75, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 18);
            this.label1.TabIndex = 43;
            this.label1.Text = "Facturación";
            // 
            // TxtFacFinal
            // 
            this.TxtFacFinal.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.TxtFacFinal.Location = new System.Drawing.Point(508, 173);
            this.TxtFacFinal.Name = "TxtFacFinal";
            this.TxtFacFinal.Size = new System.Drawing.Size(181, 26);
            this.TxtFacFinal.TabIndex = 57;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.label2.Location = new System.Drawing.Point(115, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 18);
            this.label2.TabIndex = 44;
            this.label2.Text = "Modulo";
            // 
            // TxtFacInicial
            // 
            this.TxtFacInicial.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.TxtFacInicial.Location = new System.Drawing.Point(508, 118);
            this.TxtFacInicial.Name = "TxtFacInicial";
            this.TxtFacInicial.Size = new System.Drawing.Size(181, 26);
            this.TxtFacInicial.TabIndex = 56;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.label3.Location = new System.Drawing.Point(115, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 18);
            this.label3.TabIndex = 45;
            this.label3.Text = "Prefijo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.label4.Location = new System.Drawing.Point(392, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 18);
            this.label4.TabIndex = 46;
            this.label4.Text = "Resolución";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.label5.Location = new System.Drawing.Point(23, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 18);
            this.label5.TabIndex = 47;
            this.label5.Text = "Fecha Resolución";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.label6.Location = new System.Drawing.Point(12, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(193, 18);
            this.label6.TabIndex = 48;
            this.label6.Text = "Fecha Final Resolución";
            // 
            // TxtPrefijo
            // 
            this.TxtPrefijo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.TxtPrefijo.Location = new System.Drawing.Point(208, 136);
            this.TxtPrefijo.Name = "TxtPrefijo";
            this.TxtPrefijo.Size = new System.Drawing.Size(111, 26);
            this.TxtPrefijo.TabIndex = 54;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.label7.Location = new System.Drawing.Point(372, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 18);
            this.label7.TabIndex = 49;
            this.label7.Text = "Factura Inicial ";
            // 
            // TxtModulo
            // 
            this.TxtModulo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.TxtModulo.Location = new System.Drawing.Point(208, 103);
            this.TxtModulo.Name = "TxtModulo";
            this.TxtModulo.Size = new System.Drawing.Size(111, 26);
            this.TxtModulo.TabIndex = 53;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.label8.Location = new System.Drawing.Point(372, 175);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 18);
            this.label8.TabIndex = 50;
            this.label8.Text = "Factura Final ";
            // 
            // TxtFacturacion
            // 
            this.TxtFacturacion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.TxtFacturacion.Location = new System.Drawing.Point(208, 69);
            this.TxtFacturacion.Name = "TxtFacturacion";
            this.TxtFacturacion.Size = new System.Drawing.Size(111, 26);
            this.TxtFacturacion.TabIndex = 52;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.label9.Location = new System.Drawing.Point(372, 226);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(131, 18);
            this.label9.TabIndex = 51;
            this.label9.Text = "Factura Actual ";
            // 
            // PanelAcciones
            // 
            this.PanelAcciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelAcciones.Controls.Add(this.iconButton3);
            this.PanelAcciones.Controls.Add(this.btnGuardar);
            this.PanelAcciones.Location = new System.Drawing.Point(777, 60);
            this.PanelAcciones.Name = "PanelAcciones";
            this.PanelAcciones.Size = new System.Drawing.Size(140, 126);
            this.PanelAcciones.TabIndex = 61;
            // 
            // iconButton3
            // 
            this.iconButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(32)))), ((int)(((byte)(2)))));
            this.iconButton3.FlatAppearance.BorderSize = 0;
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton3.ForeColor = System.Drawing.SystemColors.Control;
            this.iconButton3.Icon = FontAwesome.Sharp.IconChar.Film;
            this.iconButton3.IconColor = System.Drawing.Color.White;
            this.iconButton3.IconSize = 16;
            this.iconButton3.Image = ((System.Drawing.Image)(resources.GetObject("iconButton3.Image")));
            this.iconButton3.Location = new System.Drawing.Point(22, 68);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(98, 39);
            this.iconButton3.TabIndex = 2;
            this.iconButton3.Text = "Cancelar";
            this.iconButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton3.UseVisualStyleBackColor = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(151)))), ((int)(((byte)(218)))));
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnGuardar.Icon = FontAwesome.Sharp.IconChar.FloppyO;
            this.btnGuardar.IconColor = System.Drawing.Color.White;
            this.btnGuardar.IconSize = 16;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(22, 17);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(98, 39);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // FrmResoluciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 614);
            this.Controls.Add(this.PanelAcciones);
            this.Controls.Add(this.DtmResolucion);
            this.Controls.Add(this.DtmFinResolucion);
            this.Controls.Add(this.TxtResolucion);
            this.Controls.Add(this.TxtFacActual);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtFacFinal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtFacInicial);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtPrefijo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TxtModulo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TxtFacturacion);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cboEstacionamiento);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label15);
            this.Name = "FrmResoluciones";
            this.Text = "FrmResoluciones";
            this.Load += new System.EventHandler(this.FrmResoluciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgListadoResolucion)).EndInit();
            this.panel1.ResumeLayout(false);
            this.PanelAcciones.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dvgListadoResolucion;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton iconButton4;
        private System.Windows.Forms.ComboBox cboEstacionamiento;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker DtmResolucion;
        private System.Windows.Forms.DateTimePicker DtmFinResolucion;
        private System.Windows.Forms.TextBox TxtResolucion;
        private System.Windows.Forms.TextBox TxtFacActual;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtFacFinal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtFacInicial;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtPrefijo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtModulo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtFacturacion;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel PanelAcciones;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Editar;
    }
}
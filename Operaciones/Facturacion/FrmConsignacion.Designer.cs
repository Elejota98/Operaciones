namespace Operaciones.Facturacion
{
    partial class FrmConsignacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsignacion));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBuscar = new FontAwesome.Sharp.IconButton();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.TxtFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.TxtFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.DgvListado = new System.Windows.Forms.DataGridView();
            this.Editar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.CboEstacionamientoBuscar = new System.Windows.Forms.ComboBox();
            this.PnelInformacion = new System.Windows.Forms.Panel();
            this.PanelAcciones = new System.Windows.Forms.Panel();
            this.btnActualizar = new FontAwesome.Sharp.IconButton();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.btnGuardar = new FontAwesome.Sharp.IconButton();
            this.btnNuevo = new FontAwesome.Sharp.IconButton();
            this.txtFechaConsignacion = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cboTipoDeposito = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboSede = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtReferencia = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtIdConsignacion = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListado)).BeginInit();
            this.PnelInformacion.SuspendLayout();
            this.PanelAcciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.TxtFechaDesde);
            this.panel1.Controls.Add(this.TxtFechaHasta);
            this.panel1.Controls.Add(this.DgvListado);
            this.panel1.Controls.Add(this.CboEstacionamientoBuscar);
            this.panel1.Location = new System.Drawing.Point(24, 224);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(885, 222);
            this.panel1.TabIndex = 65;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(157)))), ((int)(((byte)(57)))));
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBuscar.Icon = FontAwesome.Sharp.IconChar.ListAlt;
            this.btnBuscar.IconColor = System.Drawing.Color.White;
            this.btnBuscar.IconSize = 16;
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(761, 25);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(98, 39);
            this.btnBuscar.TabIndex = 63;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.label9.Location = new System.Drawing.Point(3, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 18);
            this.label9.TabIndex = 57;
            this.label9.Text = "Sede";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.label10.Location = new System.Drawing.Point(283, 39);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 18);
            this.label10.TabIndex = 59;
            this.label10.Text = "Fecha Desde";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.label11.Location = new System.Drawing.Point(547, 40);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 18);
            this.label11.TabIndex = 60;
            this.label11.Text = "Hasta";
            // 
            // TxtFechaDesde
            // 
            this.TxtFechaDesde.CustomFormat = "yyyy-MM-dd 00:00:00";
            this.TxtFechaDesde.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.TxtFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.TxtFechaDesde.Location = new System.Drawing.Point(407, 35);
            this.TxtFechaDesde.Name = "TxtFechaDesde";
            this.TxtFechaDesde.Size = new System.Drawing.Size(113, 26);
            this.TxtFechaDesde.TabIndex = 55;
            // 
            // TxtFechaHasta
            // 
            this.TxtFechaHasta.CustomFormat = "yyyy-MM-dd 23:59:59";
            this.TxtFechaHasta.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.TxtFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.TxtFechaHasta.Location = new System.Drawing.Point(620, 35);
            this.TxtFechaHasta.Name = "TxtFechaHasta";
            this.TxtFechaHasta.Size = new System.Drawing.Size(113, 26);
            this.TxtFechaHasta.TabIndex = 61;
            // 
            // DgvListado
            // 
            this.DgvListado.AllowUserToAddRows = false;
            this.DgvListado.AllowUserToDeleteRows = false;
            this.DgvListado.AllowUserToOrderColumns = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvListado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.DgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Editar});
            this.DgvListado.Location = new System.Drawing.Point(28, 75);
            this.DgvListado.Name = "DgvListado";
            this.DgvListado.ReadOnly = true;
            this.DgvListado.Size = new System.Drawing.Size(778, 122);
            this.DgvListado.TabIndex = 54;
            this.DgvListado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListado_CellContentClick);
            // 
            // Editar
            // 
            this.Editar.HeaderText = "Editar";
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            // 
            // CboEstacionamientoBuscar
            // 
            this.CboEstacionamientoBuscar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.CboEstacionamientoBuscar.FormattingEnabled = true;
            this.CboEstacionamientoBuscar.Items.AddRange(new object[] {
            "Seleccione..."});
            this.CboEstacionamientoBuscar.Location = new System.Drawing.Point(58, 35);
            this.CboEstacionamientoBuscar.Name = "CboEstacionamientoBuscar";
            this.CboEstacionamientoBuscar.Size = new System.Drawing.Size(208, 26);
            this.CboEstacionamientoBuscar.TabIndex = 58;
            // 
            // PnelInformacion
            // 
            this.PnelInformacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnelInformacion.Controls.Add(this.PanelAcciones);
            this.PnelInformacion.Controls.Add(this.txtFechaConsignacion);
            this.PnelInformacion.Controls.Add(this.label1);
            this.PnelInformacion.Controls.Add(this.cboTipoDeposito);
            this.PnelInformacion.Controls.Add(this.label2);
            this.PnelInformacion.Controls.Add(this.cboSede);
            this.PnelInformacion.Controls.Add(this.label4);
            this.PnelInformacion.Controls.Add(this.txtUsuario);
            this.PnelInformacion.Controls.Add(this.label5);
            this.PnelInformacion.Controls.Add(this.txtReferencia);
            this.PnelInformacion.Controls.Add(this.label6);
            this.PnelInformacion.Controls.Add(this.txtValor);
            this.PnelInformacion.Controls.Add(this.label7);
            this.PnelInformacion.Controls.Add(this.label8);
            this.PnelInformacion.Controls.Add(this.txtIdConsignacion);
            this.PnelInformacion.Location = new System.Drawing.Point(24, 8);
            this.PnelInformacion.Name = "PnelInformacion";
            this.PnelInformacion.Size = new System.Drawing.Size(885, 210);
            this.PnelInformacion.TabIndex = 66;
            // 
            // PanelAcciones
            // 
            this.PanelAcciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelAcciones.Controls.Add(this.btnActualizar);
            this.PanelAcciones.Controls.Add(this.iconButton3);
            this.PanelAcciones.Controls.Add(this.btnGuardar);
            this.PanelAcciones.Controls.Add(this.btnNuevo);
            this.PanelAcciones.Location = new System.Drawing.Point(733, 16);
            this.PanelAcciones.Name = "PanelAcciones";
            this.PanelAcciones.Size = new System.Drawing.Size(144, 178);
            this.PanelAcciones.TabIndex = 56;
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(146)))), ((int)(((byte)(0)))));
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnActualizar.Icon = FontAwesome.Sharp.IconChar.Repeat;
            this.btnActualizar.IconColor = System.Drawing.Color.White;
            this.btnActualizar.IconSize = 16;
            this.btnActualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizar.Image")));
            this.btnActualizar.Location = new System.Drawing.Point(26, 18);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(98, 39);
            this.btnActualizar.TabIndex = 3;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
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
            this.iconButton3.Location = new System.Drawing.Point(27, 123);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(98, 39);
            this.iconButton3.TabIndex = 2;
            this.iconButton3.Text = "Cancelar";
            this.iconButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton3.UseVisualStyleBackColor = false;
            this.iconButton3.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(151)))), ((int)(((byte)(218)))));
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnGuardar.Icon = FontAwesome.Sharp.IconChar.ThumbsDown;
            this.btnGuardar.IconColor = System.Drawing.Color.White;
            this.btnGuardar.IconSize = 16;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(27, 72);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(98, 39);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "Eliminar";
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(157)))), ((int)(((byte)(57)))));
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.SystemColors.Control;
            this.btnNuevo.Icon = FontAwesome.Sharp.IconChar.User;
            this.btnNuevo.IconColor = System.Drawing.Color.White;
            this.btnNuevo.IconSize = 16;
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.Location = new System.Drawing.Point(27, 18);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(98, 39);
            this.btnNuevo.TabIndex = 0;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNuevo.UseVisualStyleBackColor = false;
            // 
            // txtFechaConsignacion
            // 
            this.txtFechaConsignacion.CustomFormat = "yyyy-MM-dd 00:00:00";
            this.txtFechaConsignacion.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.txtFechaConsignacion.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtFechaConsignacion.Location = new System.Drawing.Point(476, 103);
            this.txtFechaConsignacion.Name = "txtFechaConsignacion";
            this.txtFechaConsignacion.Size = new System.Drawing.Size(103, 26);
            this.txtFechaConsignacion.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Id Consignacion";
            // 
            // cboTipoDeposito
            // 
            this.cboTipoDeposito.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoDeposito.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.cboTipoDeposito.FormattingEnabled = true;
            this.cboTipoDeposito.Location = new System.Drawing.Point(147, 132);
            this.cboTipoDeposito.Name = "cboTipoDeposito";
            this.cboTipoDeposito.Size = new System.Drawing.Size(151, 27);
            this.cboTipoDeposito.TabIndex = 15;
            this.cboTipoDeposito.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cboTipoDeposito_MouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(392, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sede";
            // 
            // cboSede
            // 
            this.cboSede.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSede.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.cboSede.FormattingEnabled = true;
            this.cboSede.Location = new System.Drawing.Point(476, 16);
            this.cboSede.Name = "cboSede";
            this.cboSede.Size = new System.Drawing.Size(198, 27);
            this.cboSede.TabIndex = 14;
            this.cboSede.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cboSede_MouseClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 140);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tipo Deposito";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.txtUsuario.Location = new System.Drawing.Point(476, 59);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(198, 26);
            this.txtUsuario.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(381, 62);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 19);
            this.label5.TabIndex = 5;
            this.label5.Text = "Usuario";
            // 
            // txtReferencia
            // 
            this.txtReferencia.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.txtReferencia.Location = new System.Drawing.Point(147, 59);
            this.txtReferencia.Name = "txtReferencia";
            this.txtReferencia.Size = new System.Drawing.Size(130, 26);
            this.txtReferencia.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 62);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 19);
            this.label6.TabIndex = 6;
            this.label6.Text = "Referencia";
            // 
            // txtValor
            // 
            this.txtValor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.txtValor.Location = new System.Drawing.Point(147, 95);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(130, 26);
            this.txtValor.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(49, 98);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 19);
            this.label7.TabIndex = 7;
            this.label7.Text = "Valor";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(292, 106);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(167, 19);
            this.label8.TabIndex = 8;
            this.label8.Text = "Fecha Consignacion";
            // 
            // txtIdConsignacion
            // 
            this.txtIdConsignacion.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.txtIdConsignacion.Location = new System.Drawing.Point(147, 17);
            this.txtIdConsignacion.Name = "txtIdConsignacion";
            this.txtIdConsignacion.Size = new System.Drawing.Size(130, 26);
            this.txtIdConsignacion.TabIndex = 9;
            // 
            // FrmConsignacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 450);
            this.Controls.Add(this.PnelInformacion);
            this.Controls.Add(this.panel1);
            this.Name = "FrmConsignacion";
            this.Text = "FrmConsignacion";
            this.Load += new System.EventHandler(this.FrmConsignacion_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListado)).EndInit();
            this.PnelInformacion.ResumeLayout(false);
            this.PnelInformacion.PerformLayout();
            this.PanelAcciones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker TxtFechaDesde;
        private System.Windows.Forms.DateTimePicker TxtFechaHasta;
        private System.Windows.Forms.DataGridView DgvListado;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Editar;
        private System.Windows.Forms.ComboBox CboEstacionamientoBuscar;
        private System.Windows.Forms.Panel PnelInformacion;
        private System.Windows.Forms.DateTimePicker txtFechaConsignacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboTipoDeposito;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboSede;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtReferencia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtIdConsignacion;
        private System.Windows.Forms.Panel PanelAcciones;
        private FontAwesome.Sharp.IconButton btnActualizar;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private FontAwesome.Sharp.IconButton btnNuevo;
        private FontAwesome.Sharp.IconButton btnBuscar;
    }
}
namespace Operaciones.Facturacion
{
    partial class FrmFacturasManuales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFacturasManuales));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PnelInformacionModificar = new System.Windows.Forms.Panel();
            this.PanelAcciones = new System.Windows.Forms.Panel();
            this.btnActualizar = new FontAwesome.Sharp.IconButton();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.btnGuardar = new FontAwesome.Sharp.IconButton();
            this.btnNuevo = new FontAwesome.Sharp.IconButton();
            this.TxtFechaPago = new System.Windows.Forms.DateTimePicker();
            this.CboUsuario = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.CboTipoCobro = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.CboEstacionamiento = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtNumeroFactura = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.cboCarril = new System.Windows.Forms.ComboBox();
            this.txtPrefijo = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconButton4 = new FontAwesome.Sharp.IconButton();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.TxtFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.TxtFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.DgvListado = new System.Windows.Forms.DataGridView();
            this.Editar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.CboEstacionamientoBuscar = new System.Windows.Forms.ComboBox();
            this.PnelInformacionModificar.SuspendLayout();
            this.PanelAcciones.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListado)).BeginInit();
            this.SuspendLayout();
            // 
            // PnelInformacionModificar
            // 
            this.PnelInformacionModificar.BackColor = System.Drawing.Color.Beige;
            this.PnelInformacionModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PnelInformacionModificar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnelInformacionModificar.Controls.Add(this.PanelAcciones);
            this.PnelInformacionModificar.Controls.Add(this.TxtFechaPago);
            this.PnelInformacionModificar.Controls.Add(this.CboUsuario);
            this.PnelInformacionModificar.Controls.Add(this.label12);
            this.PnelInformacionModificar.Controls.Add(this.CboTipoCobro);
            this.PnelInformacionModificar.Controls.Add(this.label13);
            this.PnelInformacionModificar.Controls.Add(this.txtTotal);
            this.PnelInformacionModificar.Controls.Add(this.CboEstacionamiento);
            this.PnelInformacionModificar.Controls.Add(this.label14);
            this.PnelInformacionModificar.Controls.Add(this.label15);
            this.PnelInformacionModificar.Controls.Add(this.txtNumeroFactura);
            this.PnelInformacionModificar.Controls.Add(this.label16);
            this.PnelInformacionModificar.Controls.Add(this.label17);
            this.PnelInformacionModificar.Controls.Add(this.cboCarril);
            this.PnelInformacionModificar.Controls.Add(this.txtPrefijo);
            this.PnelInformacionModificar.Controls.Add(this.label18);
            this.PnelInformacionModificar.Controls.Add(this.label19);
            this.PnelInformacionModificar.Location = new System.Drawing.Point(24, 9);
            this.PnelInformacionModificar.Name = "PnelInformacionModificar";
            this.PnelInformacionModificar.Size = new System.Drawing.Size(885, 198);
            this.PnelInformacionModificar.TabIndex = 63;
            // 
            // PanelAcciones
            // 
            this.PanelAcciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelAcciones.Controls.Add(this.btnActualizar);
            this.PanelAcciones.Controls.Add(this.iconButton3);
            this.PanelAcciones.Controls.Add(this.btnGuardar);
            this.PanelAcciones.Controls.Add(this.btnNuevo);
            this.PanelAcciones.Location = new System.Drawing.Point(736, 4);
            this.PanelAcciones.Name = "PanelAcciones";
            this.PanelAcciones.Size = new System.Drawing.Size(144, 178);
            this.PanelAcciones.TabIndex = 55;
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
            this.btnGuardar.Icon = FontAwesome.Sharp.IconChar.FloppyO;
            this.btnGuardar.IconColor = System.Drawing.Color.White;
            this.btnGuardar.IconSize = 16;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(27, 72);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(98, 39);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "Guardar";
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
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // TxtFechaPago
            // 
            this.TxtFechaPago.CustomFormat = "yyyy-MM-dd 00:00:00";
            this.TxtFechaPago.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.TxtFechaPago.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.TxtFechaPago.Location = new System.Drawing.Point(198, 66);
            this.TxtFechaPago.Name = "TxtFechaPago";
            this.TxtFechaPago.Size = new System.Drawing.Size(113, 26);
            this.TxtFechaPago.TabIndex = 35;
            // 
            // CboUsuario
            // 
            this.CboUsuario.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.CboUsuario.FormattingEnabled = true;
            this.CboUsuario.Items.AddRange(new object[] {
            "Seleccione..."});
            this.CboUsuario.Location = new System.Drawing.Point(520, 105);
            this.CboUsuario.Name = "CboUsuario";
            this.CboUsuario.Size = new System.Drawing.Size(208, 26);
            this.CboUsuario.TabIndex = 34;
            this.CboUsuario.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CboUsuario_MouseClick);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.label12.Location = new System.Drawing.Point(429, 106);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 18);
            this.label12.TabIndex = 33;
            this.label12.Text = "Usuario";
            // 
            // CboTipoCobro
            // 
            this.CboTipoCobro.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.CboTipoCobro.FormattingEnabled = true;
            this.CboTipoCobro.Items.AddRange(new object[] {
            "Seleccione..."});
            this.CboTipoCobro.Location = new System.Drawing.Point(198, 108);
            this.CboTipoCobro.Name = "CboTipoCobro";
            this.CboTipoCobro.Size = new System.Drawing.Size(208, 26);
            this.CboTipoCobro.TabIndex = 32;
            this.CboTipoCobro.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CboTipoCobro_MouseClick);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.label13.Location = new System.Drawing.Point(39, 109);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(121, 18);
            this.label13.TabIndex = 31;
            this.label13.Text = "Tipo De Cobro";
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.txtTotal.Location = new System.Drawing.Point(519, 144);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(92, 26);
            this.txtTotal.TabIndex = 30;
            // 
            // CboEstacionamiento
            // 
            this.CboEstacionamiento.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.CboEstacionamiento.FormattingEnabled = true;
            this.CboEstacionamiento.Items.AddRange(new object[] {
            "Seleccione..."});
            this.CboEstacionamiento.Location = new System.Drawing.Point(198, 11);
            this.CboEstacionamiento.Name = "CboEstacionamiento";
            this.CboEstacionamiento.Size = new System.Drawing.Size(208, 26);
            this.CboEstacionamiento.TabIndex = 4;
            this.CboEstacionamiento.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CboEstacionamiento_MouseClick);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.label14.Location = new System.Drawing.Point(439, 147);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(48, 18);
            this.label14.TabIndex = 29;
            this.label14.Text = "Total";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.label15.Location = new System.Drawing.Point(111, 19);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(49, 18);
            this.label15.TabIndex = 3;
            this.label15.Text = "Sede";
            // 
            // txtNumeroFactura
            // 
            this.txtNumeroFactura.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.txtNumeroFactura.Location = new System.Drawing.Point(198, 147);
            this.txtNumeroFactura.Margin = new System.Windows.Forms.Padding(2);
            this.txtNumeroFactura.Name = "txtNumeroFactura";
            this.txtNumeroFactura.Size = new System.Drawing.Size(76, 26);
            this.txtNumeroFactura.TabIndex = 28;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.label16.Location = new System.Drawing.Point(450, 20);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(52, 18);
            this.label16.TabIndex = 5;
            this.label16.Text = "Carril";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.label17.Location = new System.Drawing.Point(30, 151);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(138, 18);
            this.label17.TabIndex = 27;
            this.label17.Text = "Número Factura";
            // 
            // cboCarril
            // 
            this.cboCarril.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.cboCarril.FormattingEnabled = true;
            this.cboCarril.Items.AddRange(new object[] {
            "PPM01"});
            this.cboCarril.Location = new System.Drawing.Point(522, 18);
            this.cboCarril.Name = "cboCarril";
            this.cboCarril.Size = new System.Drawing.Size(208, 26);
            this.cboCarril.TabIndex = 6;
            // 
            // txtPrefijo
            // 
            this.txtPrefijo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.txtPrefijo.Location = new System.Drawing.Point(519, 63);
            this.txtPrefijo.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrefijo.Name = "txtPrefijo";
            this.txtPrefijo.Size = new System.Drawing.Size(76, 26);
            this.txtPrefijo.TabIndex = 26;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.label18.Location = new System.Drawing.Point(39, 63);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(129, 18);
            this.label18.TabIndex = 7;
            this.label18.Text = "Fecha De Pago";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.label19.Location = new System.Drawing.Point(439, 64);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(59, 18);
            this.label19.TabIndex = 25;
            this.label19.Text = "Prefijo";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.iconButton4);
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
            this.panel1.TabIndex = 64;
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
            this.iconButton4.Location = new System.Drawing.Point(764, 25);
            this.iconButton4.Name = "iconButton4";
            this.iconButton4.Size = new System.Drawing.Size(98, 39);
            this.iconButton4.TabIndex = 62;
            this.iconButton4.Text = "Buscar";
            this.iconButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton4.UseVisualStyleBackColor = false;
            this.iconButton4.Click += new System.EventHandler(this.iconButton4_Click);
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
            this.TxtFechaHasta.Location = new System.Drawing.Point(620, 33);
            this.TxtFechaHasta.Name = "TxtFechaHasta";
            this.TxtFechaHasta.Size = new System.Drawing.Size(113, 26);
            this.TxtFechaHasta.TabIndex = 61;
            // 
            // DgvListado
            // 
            this.DgvListado.AllowUserToAddRows = false;
            this.DgvListado.AllowUserToDeleteRows = false;
            this.DgvListado.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvListado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
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
            // FrmFacturasManuales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 450);
            this.Controls.Add(this.PnelInformacionModificar);
            this.Controls.Add(this.panel1);
            this.Name = "FrmFacturasManuales";
            this.Text = "FrmFacturasManuales";
            this.Load += new System.EventHandler(this.FrmFacturasManuales_Load);
            this.PnelInformacionModificar.ResumeLayout(false);
            this.PnelInformacionModificar.PerformLayout();
            this.PanelAcciones.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnelInformacionModificar;
        private System.Windows.Forms.DateTimePicker TxtFechaPago;
        private System.Windows.Forms.ComboBox CboUsuario;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox CboTipoCobro;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.ComboBox CboEstacionamiento;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtNumeroFactura;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cboCarril;
        private System.Windows.Forms.TextBox txtPrefijo;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker TxtFechaDesde;
        private System.Windows.Forms.DateTimePicker TxtFechaHasta;
        private System.Windows.Forms.DataGridView DgvListado;
        private System.Windows.Forms.ComboBox CboEstacionamientoBuscar;
        private FontAwesome.Sharp.IconButton iconButton4;
        private System.Windows.Forms.Panel PanelAcciones;
        private FontAwesome.Sharp.IconButton btnActualizar;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private FontAwesome.Sharp.IconButton btnNuevo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Editar;
    }
}
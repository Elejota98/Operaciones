namespace Operaciones
{
    partial class FrmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.PanelMenu = new System.Windows.Forms.Panel();
            this.PanelSubMenu3 = new System.Windows.Forms.Panel();
            this.btnResolucion = new FontAwesome.Sharp.IconButton();
            this.btnAnularFac = new FontAwesome.Sharp.IconButton();
            this.btnFacturacion = new FontAwesome.Sharp.IconButton();
            this.PanelSubMenu2 = new System.Windows.Forms.Panel();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.PanelSubMenu1 = new System.Windows.Forms.Panel();
            this.iconButton4 = new FontAwesome.Sharp.IconButton();
            this.btnReposicionSinCobro = new FontAwesome.Sharp.IconButton();
            this.BtnPersonasAutorizadas = new FontAwesome.Sharp.IconButton();
            this.btnAutorizados = new FontAwesome.Sharp.IconButton();
            this.PanelFormulario = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.PanelMenu.SuspendLayout();
            this.PanelSubMenu3.SuspendLayout();
            this.PanelSubMenu2.SuspendLayout();
            this.PanelSubMenu1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Controls.Add(this.lblNombre);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1169, 100);
            this.panel1.TabIndex = 0;
            // 
            // btnSalir
            // 
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Location = new System.Drawing.Point(1131, 3);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(38, 37);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(83, 30);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(0, 24);
            this.lblNombre.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "¡Hola, ";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26.25F);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(180)))), ((int)(((byte)(77)))));
            this.lblTitulo.Location = new System.Drawing.Point(545, 29);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(109, 40);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Inicio";
            // 
            // PanelMenu
            // 
            this.PanelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(180)))), ((int)(((byte)(77)))));
            this.PanelMenu.Controls.Add(this.PanelSubMenu3);
            this.PanelMenu.Controls.Add(this.btnFacturacion);
            this.PanelMenu.Controls.Add(this.PanelSubMenu2);
            this.PanelMenu.Controls.Add(this.iconButton1);
            this.PanelMenu.Controls.Add(this.PanelSubMenu1);
            this.PanelMenu.Controls.Add(this.btnAutorizados);
            this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMenu.Location = new System.Drawing.Point(0, 100);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(200, 585);
            this.PanelMenu.TabIndex = 1;
            // 
            // PanelSubMenu3
            // 
            this.PanelSubMenu3.Controls.Add(this.btnResolucion);
            this.PanelSubMenu3.Controls.Add(this.btnAnularFac);
            this.PanelSubMenu3.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelSubMenu3.Location = new System.Drawing.Point(0, 382);
            this.PanelSubMenu3.Name = "PanelSubMenu3";
            this.PanelSubMenu3.Size = new System.Drawing.Size(200, 100);
            this.PanelSubMenu3.TabIndex = 5;
            // 
            // btnResolucion
            // 
            this.btnResolucion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.btnResolucion.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnResolucion.FlatAppearance.BorderSize = 0;
            this.btnResolucion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResolucion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.btnResolucion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(180)))), ((int)(((byte)(77)))));
            this.btnResolucion.Icon = FontAwesome.Sharp.IconChar.Language;
            this.btnResolucion.IconColor = System.Drawing.Color.White;
            this.btnResolucion.IconSize = 16;
            this.btnResolucion.Image = ((System.Drawing.Image)(resources.GetObject("btnResolucion.Image")));
            this.btnResolucion.Location = new System.Drawing.Point(0, 41);
            this.btnResolucion.Name = "btnResolucion";
            this.btnResolucion.Size = new System.Drawing.Size(200, 41);
            this.btnResolucion.TabIndex = 4;
            this.btnResolucion.Text = "Resoluciones";
            this.btnResolucion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnResolucion.UseVisualStyleBackColor = false;
            this.btnResolucion.Click += new System.EventHandler(this.btnResolucion_Click);
            // 
            // btnAnularFac
            // 
            this.btnAnularFac.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.btnAnularFac.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAnularFac.FlatAppearance.BorderSize = 0;
            this.btnAnularFac.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnularFac.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.btnAnularFac.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(180)))), ((int)(((byte)(77)))));
            this.btnAnularFac.Icon = FontAwesome.Sharp.IconChar.Sliders;
            this.btnAnularFac.IconColor = System.Drawing.Color.White;
            this.btnAnularFac.IconSize = 16;
            this.btnAnularFac.Image = ((System.Drawing.Image)(resources.GetObject("btnAnularFac.Image")));
            this.btnAnularFac.Location = new System.Drawing.Point(0, 0);
            this.btnAnularFac.Name = "btnAnularFac";
            this.btnAnularFac.Size = new System.Drawing.Size(200, 41);
            this.btnAnularFac.TabIndex = 3;
            this.btnAnularFac.Text = "Anulaciones";
            this.btnAnularFac.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAnularFac.UseVisualStyleBackColor = false;
            this.btnAnularFac.Click += new System.EventHandler(this.iconButton3_Click_1);
            // 
            // btnFacturacion
            // 
            this.btnFacturacion.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFacturacion.FlatAppearance.BorderSize = 0;
            this.btnFacturacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFacturacion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F);
            this.btnFacturacion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFacturacion.Icon = FontAwesome.Sharp.IconChar.ChevronDown;
            this.btnFacturacion.IconColor = System.Drawing.Color.White;
            this.btnFacturacion.IconSize = 16;
            this.btnFacturacion.Image = ((System.Drawing.Image)(resources.GetObject("btnFacturacion.Image")));
            this.btnFacturacion.Location = new System.Drawing.Point(0, 329);
            this.btnFacturacion.Name = "btnFacturacion";
            this.btnFacturacion.Size = new System.Drawing.Size(200, 53);
            this.btnFacturacion.TabIndex = 4;
            this.btnFacturacion.Text = "Facturación";
            this.btnFacturacion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFacturacion.UseVisualStyleBackColor = true;
            this.btnFacturacion.Click += new System.EventHandler(this.btnPuntoDePago_Click);
            // 
            // PanelSubMenu2
            // 
            this.PanelSubMenu2.Controls.Add(this.iconButton2);
            this.PanelSubMenu2.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelSubMenu2.Location = new System.Drawing.Point(0, 229);
            this.PanelSubMenu2.Name = "PanelSubMenu2";
            this.PanelSubMenu2.Size = new System.Drawing.Size(200, 100);
            this.PanelSubMenu2.TabIndex = 0;
            // 
            // iconButton2
            // 
            this.iconButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.iconButton2.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.iconButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(180)))), ((int)(((byte)(77)))));
            this.iconButton2.Icon = FontAwesome.Sharp.IconChar.ListUl;
            this.iconButton2.IconColor = System.Drawing.Color.White;
            this.iconButton2.IconSize = 16;
            this.iconButton2.Image = ((System.Drawing.Image)(resources.GetObject("iconButton2.Image")));
            this.iconButton2.Location = new System.Drawing.Point(0, 0);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(200, 41);
            this.iconButton2.TabIndex = 3;
            this.iconButton2.Text = "Saldo En Linea";
            this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton2.UseVisualStyleBackColor = false;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F);
            this.iconButton1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconButton1.Icon = FontAwesome.Sharp.IconChar.ChevronDown;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconSize = 16;
            this.iconButton1.Image = ((System.Drawing.Image)(resources.GetObject("iconButton1.Image")));
            this.iconButton1.Location = new System.Drawing.Point(0, 176);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(200, 53);
            this.iconButton1.TabIndex = 3;
            this.iconButton1.Text = "Reportes";
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // PanelSubMenu1
            // 
            this.PanelSubMenu1.Controls.Add(this.iconButton4);
            this.PanelSubMenu1.Controls.Add(this.btnReposicionSinCobro);
            this.PanelSubMenu1.Controls.Add(this.BtnPersonasAutorizadas);
            this.PanelSubMenu1.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelSubMenu1.Location = new System.Drawing.Point(0, 47);
            this.PanelSubMenu1.Name = "PanelSubMenu1";
            this.PanelSubMenu1.Size = new System.Drawing.Size(200, 129);
            this.PanelSubMenu1.TabIndex = 2;
            // 
            // iconButton4
            // 
            this.iconButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.iconButton4.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton4.FlatAppearance.BorderSize = 0;
            this.iconButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.iconButton4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(180)))), ((int)(((byte)(77)))));
            this.iconButton4.Icon = FontAwesome.Sharp.IconChar.Calendar;
            this.iconButton4.IconColor = System.Drawing.Color.White;
            this.iconButton4.IconSize = 16;
            this.iconButton4.Image = ((System.Drawing.Image)(resources.GetObject("iconButton4.Image")));
            this.iconButton4.Location = new System.Drawing.Point(0, 81);
            this.iconButton4.Name = "iconButton4";
            this.iconButton4.Size = new System.Drawing.Size(200, 41);
            this.iconButton4.TabIndex = 4;
            this.iconButton4.Text = "Actualizar Salida";
            this.iconButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton4.UseVisualStyleBackColor = false;
            // 
            // btnReposicionSinCobro
            // 
            this.btnReposicionSinCobro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.btnReposicionSinCobro.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReposicionSinCobro.FlatAppearance.BorderSize = 0;
            this.btnReposicionSinCobro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReposicionSinCobro.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.btnReposicionSinCobro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(180)))), ((int)(((byte)(77)))));
            this.btnReposicionSinCobro.Icon = FontAwesome.Sharp.IconChar.PencilSquareO;
            this.btnReposicionSinCobro.IconColor = System.Drawing.Color.White;
            this.btnReposicionSinCobro.IconSize = 16;
            this.btnReposicionSinCobro.Image = ((System.Drawing.Image)(resources.GetObject("btnReposicionSinCobro.Image")));
            this.btnReposicionSinCobro.Location = new System.Drawing.Point(0, 40);
            this.btnReposicionSinCobro.Name = "btnReposicionSinCobro";
            this.btnReposicionSinCobro.Size = new System.Drawing.Size(200, 41);
            this.btnReposicionSinCobro.TabIndex = 3;
            this.btnReposicionSinCobro.Text = "Reposición Sin Cobro";
            this.btnReposicionSinCobro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReposicionSinCobro.UseVisualStyleBackColor = false;
            this.btnReposicionSinCobro.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // BtnPersonasAutorizadas
            // 
            this.BtnPersonasAutorizadas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.BtnPersonasAutorizadas.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnPersonasAutorizadas.FlatAppearance.BorderSize = 0;
            this.BtnPersonasAutorizadas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPersonasAutorizadas.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.BtnPersonasAutorizadas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(180)))), ((int)(((byte)(77)))));
            this.BtnPersonasAutorizadas.Icon = FontAwesome.Sharp.IconChar.User;
            this.BtnPersonasAutorizadas.IconColor = System.Drawing.Color.White;
            this.BtnPersonasAutorizadas.IconSize = 16;
            this.BtnPersonasAutorizadas.Image = ((System.Drawing.Image)(resources.GetObject("BtnPersonasAutorizadas.Image")));
            this.BtnPersonasAutorizadas.Location = new System.Drawing.Point(0, 0);
            this.BtnPersonasAutorizadas.Name = "BtnPersonasAutorizadas";
            this.BtnPersonasAutorizadas.Size = new System.Drawing.Size(200, 40);
            this.BtnPersonasAutorizadas.TabIndex = 2;
            this.BtnPersonasAutorizadas.Text = "Personas Autorizadas";
            this.BtnPersonasAutorizadas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnPersonasAutorizadas.UseVisualStyleBackColor = false;
            this.BtnPersonasAutorizadas.Click += new System.EventHandler(this.BtnPersonasAutorizadas_Click);
            // 
            // btnAutorizados
            // 
            this.btnAutorizados.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAutorizados.FlatAppearance.BorderSize = 0;
            this.btnAutorizados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAutorizados.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F);
            this.btnAutorizados.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAutorizados.Icon = FontAwesome.Sharp.IconChar.ChevronDown;
            this.btnAutorizados.IconColor = System.Drawing.Color.White;
            this.btnAutorizados.IconSize = 16;
            this.btnAutorizados.Image = ((System.Drawing.Image)(resources.GetObject("btnAutorizados.Image")));
            this.btnAutorizados.Location = new System.Drawing.Point(0, 0);
            this.btnAutorizados.Name = "btnAutorizados";
            this.btnAutorizados.Size = new System.Drawing.Size(200, 47);
            this.btnAutorizados.TabIndex = 2;
            this.btnAutorizados.Text = "Autorizados";
            this.btnAutorizados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAutorizados.UseVisualStyleBackColor = true;
            this.btnAutorizados.Click += new System.EventHandler(this.btnAutorizados_Click);
            // 
            // PanelFormulario
            // 
            this.PanelFormulario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelFormulario.Location = new System.Drawing.Point(200, 100);
            this.PanelFormulario.Name = "PanelFormulario";
            this.PanelFormulario.Size = new System.Drawing.Size(969, 585);
            this.PanelFormulario.TabIndex = 2;
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 685);
            this.Controls.Add(this.PanelFormulario);
            this.Controls.Add(this.PanelMenu);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMenu";
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.PanelMenu.ResumeLayout(false);
            this.PanelSubMenu3.ResumeLayout(false);
            this.PanelSubMenu2.ResumeLayout(false);
            this.PanelSubMenu1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel PanelMenu;
        private System.Windows.Forms.Panel PanelSubMenu1;
        private FontAwesome.Sharp.IconButton BtnPersonasAutorizadas;
        private FontAwesome.Sharp.IconButton btnAutorizados;
        private System.Windows.Forms.Panel PanelFormulario;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Panel PanelSubMenu2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton btnReposicionSinCobro;
        private FontAwesome.Sharp.IconButton iconButton4;
        private FontAwesome.Sharp.IconButton btnFacturacion;
        private System.Windows.Forms.Panel PanelSubMenu3;
        private FontAwesome.Sharp.IconButton btnAnularFac;
        private FontAwesome.Sharp.IconButton btnResolucion;
    }
}
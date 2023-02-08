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
            this.lblNombre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.PanelMenu = new System.Windows.Forms.Panel();
            this.PanelSubMenu1 = new System.Windows.Forms.Panel();
            this.BtnPersonasAutorizadas = new FontAwesome.Sharp.IconButton();
            this.btnAutorizados = new FontAwesome.Sharp.IconButton();
            this.PanelFormulario = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.PanelMenu.SuspendLayout();
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
            this.PanelMenu.Controls.Add(this.PanelSubMenu1);
            this.PanelMenu.Controls.Add(this.btnAutorizados);
            this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMenu.Location = new System.Drawing.Point(0, 100);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(200, 585);
            this.PanelMenu.TabIndex = 1;
            // 
            // PanelSubMenu1
            // 
            this.PanelSubMenu1.Controls.Add(this.BtnPersonasAutorizadas);
            this.PanelSubMenu1.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelSubMenu1.Location = new System.Drawing.Point(0, 53);
            this.PanelSubMenu1.Name = "PanelSubMenu1";
            this.PanelSubMenu1.Size = new System.Drawing.Size(200, 131);
            this.PanelSubMenu1.TabIndex = 2;
            // 
            // BtnPersonasAutorizadas
            // 
            this.BtnPersonasAutorizadas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.BtnPersonasAutorizadas.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnPersonasAutorizadas.FlatAppearance.BorderSize = 0;
            this.BtnPersonasAutorizadas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPersonasAutorizadas.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.BtnPersonasAutorizadas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(180)))), ((int)(((byte)(77)))));
            this.BtnPersonasAutorizadas.Icon = FontAwesome.Sharp.IconChar.HddO;
            this.BtnPersonasAutorizadas.IconColor = System.Drawing.Color.White;
            this.BtnPersonasAutorizadas.IconSize = 16;
            this.BtnPersonasAutorizadas.Image = ((System.Drawing.Image)(resources.GetObject("BtnPersonasAutorizadas.Image")));
            this.BtnPersonasAutorizadas.Location = new System.Drawing.Point(0, 0);
            this.BtnPersonasAutorizadas.Name = "BtnPersonasAutorizadas";
            this.BtnPersonasAutorizadas.Size = new System.Drawing.Size(200, 59);
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
            this.btnAutorizados.Icon = FontAwesome.Sharp.IconChar.User;
            this.btnAutorizados.IconColor = System.Drawing.Color.White;
            this.btnAutorizados.IconSize = 16;
            this.btnAutorizados.Image = ((System.Drawing.Image)(resources.GetObject("btnAutorizados.Image")));
            this.btnAutorizados.Location = new System.Drawing.Point(0, 0);
            this.btnAutorizados.Name = "btnAutorizados";
            this.btnAutorizados.Size = new System.Drawing.Size(200, 53);
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
    }
}
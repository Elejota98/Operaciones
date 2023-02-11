using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Operaciones
{
    public partial class FrmMenu : Form
    {
       
        Login login= new Login();   
        public string Nombre;
        public string Cargo;
        public string Documento;
        public long IdEstacionamiento;
        private Form activeform = null;
        public FrmMenu()
        {
            InitializeComponent();
            customizeDesing();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {

            lblNombre.Text = Nombre + "!";
        }

        #region FuncionesMenu
        private void showSubMenu(Panel SubMenu)
        {
            if (SubMenu.Visible == false)
            {
                hideSubmenu();
                SubMenu.Visible = true;
            }
            else
            {
                SubMenu.Visible = false;
            }
        }

        private void hideSubmenu()
        {
            if (PanelSubMenu1.Visible == true)
                PanelSubMenu1.Visible = false;
            if (PanelSubMenu2.Visible == true)
                PanelSubMenu2.Visible = false;
            //if (PanelSubMenu3.Visible == true)
            //    PanelSubMenu3.Visible = false;
            //if (PanelSubMenu4.Visible == true)
            //    PanelSubMenu4.Visible = false;
            //if (PanelSubMenu5.Visible == true)
            //    PanelSubMenu5.Visible = false;
            //if (PanelSubMenu6.Visible == true)
            //    PanelSubMenu6.Visible = false;
        }

        private void customizeDesing()
        {

            PanelSubMenu1.Visible = false;
            PanelSubMenu2.Visible = false;
            //PanelSubMenu3.Visible = false;
            //PanelSubMenu4.Visible = false;
            //PanelSubMenu5.Visible = false;
            //PanelSubMenu6.Visible = false;


        }
        private void AbrirFormularioHijo(Form FormularioHijo)
        {
            if (activeform != null)

            activeform.Close();
            activeform = FormularioHijo;
            FormularioHijo.TopLevel = false;
            FormularioHijo.FormBorderStyle = FormBorderStyle.None;
            FormularioHijo.Dock = DockStyle.Fill;
            PanelFormulario.Controls.Add(FormularioHijo);
            PanelFormulario.Tag = FormularioHijo;
            FormularioHijo.BringToFront();
            FormularioHijo.Show();


        }
        #endregion|

        private void btnAutorizados_Click(object sender, EventArgs e)
        {
            login.Documento = Documento;
            showSubMenu(PanelSubMenu1);
        }

        private void BtnPersonasAutorizadas_Click(object sender, EventArgs e)
        {

            AbrirFormularioHijo(new FrmAutorizado(Documento,Cargo, IdEstacionamiento));
            
            lblTitulo.Text = BtnPersonasAutorizadas.Text;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            FrmLogin frml = new FrmLogin();
            frml.Show();
            this.Hide();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            showSubMenu(PanelSubMenu2);
        }
    }
}

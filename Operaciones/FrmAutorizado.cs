using Controlador;
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
    public partial class FrmAutorizado : Form
    {
       

        FrmMenu menu = new FrmMenu();
        AutorizacionesViewModel autorizacionesView = new AutorizacionesViewModel();
        PersonasAutorizadas personasAutorizadas = new PersonasAutorizadas();
        public FrmAutorizado(string documento, string cargo)
        {            
            InitializeComponent();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Limpiar();
            Desbloquear();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {

        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            Limpiar();
            Bloquear();
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            ListarAutorizados();
        }
        #region Funciones
        public void Bloquear()
        {
            txtDocumento.Enabled = false;
            cboAutorizados.Enabled = false;
            txtNombreApellidos.Enabled = false;
            txtEmpresa.Enabled = false;
            TxtNit.Enabled = false;
            txtTelefono.Enabled = false;
            DtmFechaInicio.Enabled = false;
            txtEmail.Enabled = false;
            txtPlaca1.Enabled = false;
            txtPlaca2.Enabled = false;
            txtPlaca3.Enabled = false;
            txtPlaca4.Enabled = false;
            txtPlaca5.Enabled = false;
            DtmFechaFin.Enabled = false;
            DvgListadoPersonasAutorizadas.Columns[0].Visible = false;

        }
        public void Desbloquear()
        {
            txtDocumento.Enabled = true;
            cboAutorizados.Enabled = true;
            txtNombreApellidos.Enabled = true;
            txtEmpresa.Enabled = true;
            TxtNit.Enabled = true;
            txtTelefono.Enabled = true;
            txtEmail.Enabled = true;
            txtPlaca1.Enabled = true;
            txtPlaca2.Enabled = true;
            txtPlaca3.Enabled = true;
            txtPlaca4.Enabled = true;
            txtPlaca5.Enabled = true;
            //DtmFechaFin.Enabled = true;
            //DtmFechaInicio.Enabled = true;

        }
        private void MensajeError(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Parquearse Tecnología", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void MensajeOk(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Parquearse Tecnología", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void ListarAutorizados()
        {

            if (txtDocumentoBuscar.Text != string.Empty || txtPlaca1Buscar.Text != string.Empty || txtPlaca2Buscar.Text != string.Empty)
            {
                personasAutorizadas.Documento = txtDocumentoBuscar.Text;
                personasAutorizadas.Placa1 = txtPlaca1Buscar.Text;
                personasAutorizadas.Placa2 = txtPlaca2Buscar.Text;

                try
                {
                    DvgListadoPersonasAutorizadas.DataSource = PersonasAutorizadasController.BuscarAutorizado(personasAutorizadas);
                    if (DvgListadoPersonasAutorizadas.Rows.Count < 1)
                    {
                        MensajeError("No Existen Datos");
                        txtDocumento.Text = null;
                        txtPlaca1.Text = string.Empty;
                        txtPlaca2.Text = string.Empty;
                    }
                    else
                    {
                        DvgListadoPersonasAutorizadas.DataSource = PersonasAutorizadasController.BuscarAutorizado(personasAutorizadas);
                        DvgListadoPersonasAutorizadas.Columns[0].Visible = true;
                    }

                }
                catch (Exception ex)
                {

                    throw ex;
                }
            }
            else
            {
                MensajeError("Faltan datos para realizar la busqueda");
                txtDocumentoBuscar.Focus();

            }

        }
        public void CargarAutorizaciones()
        {
            try
            {
                cboAutorizados.DataSource = PersonasAutorizadasController.ListarAutorizaciones();
                cboAutorizados.ValueMember = "IdAutorizacion";
                cboAutorizados.DisplayMember = "NombreAutorizacion";
                autorizacionesView.NombreAutorizacion = cboAutorizados.SelectedText.ToString();
                autorizacionesView.IdAutorizacion = Convert.ToInt32(cboAutorizados.SelectedValue);

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public bool CargarAutorizacionesPorId()
        {
            bool ok = false;
            try
            {
                cboAutorizados.DataSource = PersonasAutorizadasController.ListarAutorizacionesPorId(autorizacionesView);
                cboAutorizados.ValueMember = "IdAutorizacion";
                cboAutorizados.DisplayMember = "NombreAutorizacion";
                ok = true;

            }

            catch (Exception ex)
            {

                throw ex;
            }
            return ok;
        }
        public void Limpiar()
        {
            txtDocumento.Text = "";
            txtNombreApellidos.Text = "";
            CargarAutorizaciones();
            txtEmpresa.Text = "";
            TxtNit.Text = "";
            txtTelefono.Text = "";
            DtmFechaFin.Text = DateTime.Now.ToString();
            DtmFechaInicio.Text = DateTime.Now.ToString();
            txtEmail.Text = "";
            txtPlaca1.Text = "";
            txtPlaca2.Text = "";
            txtPlaca3.Text = "";
            txtPlaca4.Text = "";
            txtPlaca5.Text = "";
            txtDocumentoBuscar.Text = "";
            txtPlaca1Buscar.Text = "";
            txtPlaca2Buscar.Text = "";

        }

        #endregion

        private void DvgListadoPersonasAutorizadas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == DvgListadoPersonasAutorizadas.Columns["Editar"].Index)
            {
                DataGridViewCheckBoxCell ChkEditar = (DataGridViewCheckBoxCell)DvgListadoPersonasAutorizadas.Rows[e.RowIndex].Cells["Editar"];
                ChkEditar.Value = !Convert.ToBoolean(ChkEditar.Value);
                if (Convert.ToBoolean(ChkEditar.Value) == true)
                {
                    txtDocumento.Text = Convert.ToString(DvgListadoPersonasAutorizadas.CurrentRow.Cells["Documento"].Value);
                    CargarAutorizacionesPorId();
                    txtNombreApellidos.Text = Convert.ToString(DvgListadoPersonasAutorizadas.CurrentRow.Cells["NombreApellidos"].Value);
                    txtEmpresa.Text = Convert.ToString(DvgListadoPersonasAutorizadas.CurrentRow.Cells["NombreEmpresa"].Value);
                    TxtNit.Text = Convert.ToString(DvgListadoPersonasAutorizadas.CurrentRow.Cells["Nit"].Value);
                    txtTelefono.Text = Convert.ToString(DvgListadoPersonasAutorizadas.CurrentRow.Cells["Telefono"].Value);
                    txtEmail.Text = Convert.ToString(DvgListadoPersonasAutorizadas.CurrentRow.Cells["Email"].Value);
                    txtPlaca1.Text = Convert.ToString(DvgListadoPersonasAutorizadas.CurrentRow.Cells["Placa1"].Value);
                    txtPlaca2.Text = Convert.ToString(DvgListadoPersonasAutorizadas.CurrentRow.Cells["Placa2"].Value);
                    txtPlaca3.Text = Convert.ToString(DvgListadoPersonasAutorizadas.CurrentRow.Cells["Placa3"].Value);
                    txtPlaca4.Text = Convert.ToString(DvgListadoPersonasAutorizadas.CurrentRow.Cells["Placa4"].Value);
                    txtPlaca5.Text = Convert.ToString(DvgListadoPersonasAutorizadas.CurrentRow.Cells["Placa5"].Value);
                    DtmFechaInicio.Text = Convert.ToString(DvgListadoPersonasAutorizadas.CurrentRow.Cells["FechaInicio"].Value);
                    DtmFechaFin.Text = Convert.ToString(DvgListadoPersonasAutorizadas.CurrentRow.Cells["FechaFin"].Value);
                    Bloquear();
                    cboAutorizados.Enabled = true;
                    DtmFechaInicio.Enabled = true;
                    DtmFechaFin.Enabled = true;

                }


            }
        }

        private void FrmAutorizado_Load(object sender, EventArgs e)
        {

            Bloquear();
            CargarAutorizaciones();
        }

        private void cboAutorizados_MouseClick(object sender, MouseEventArgs e)
        {
            CargarAutorizaciones();
        }
    }
}

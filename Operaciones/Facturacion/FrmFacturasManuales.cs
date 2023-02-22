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

namespace Operaciones.Facturacion
{
    public partial class FrmFacturasManuales : Form
    {
        public string Cargo;
        public string Documento;
        public long IdEstacionamiento;
        public FrmFacturasManuales(string documento, string cargo, long idEstacionamiento)
        {
            InitializeComponent();
            Cargo = cargo;
            Documento = documento;
            IdEstacionamiento = idEstacionamiento;
            DgvListado.Columns[0].Visible = false;
        }


        #region FUNCIONES
        public void ListarEstacionamiento()
        {
            Estacionamiento estacionamiento = new Estacionamiento();
            estacionamiento.IdEstacionamiento = IdEstacionamiento;

            try
            {
                CboEstacionamientoBuscar.DataSource = EstacionamientoController.ListarEstacionamiento(estacionamiento);
                CboEstacionamientoBuscar.ValueMember = "IdEstacionamiento";
                CboEstacionamientoBuscar.DisplayMember = "Nombre";
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void ListarEstacionamientos()
        {
            try
            {
                CboEstacionamientoBuscar.DataSource = EstacionamientoController.ListarEstacionamientos();
                CboEstacionamientoBuscar.ValueMember = "IdEstacionamiento";
                CboEstacionamientoBuscar.DisplayMember = "Nombre";
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void Bloquear()
        {
            CboEstacionamiento.Enabled= false;
            cboCarril.Enabled= false;
            TxtFechaPago.Enabled= false;
            CboTipoCobro.Enabled= false;
            txtNumeroFactura.Enabled= false;    
            txtPrefijo.Enabled= false;
            CboUsuario.Enabled= false;
            txtTotal.Enabled= false;
            btnActualizar.Visible= false;
            btnGuardar.Enabled= false;

        }
        public void Desbloquear()
        {
            CboEstacionamiento.Enabled = true;
            cboCarril.Enabled = true;
            TxtFechaPago.Enabled = true;
            CboTipoCobro.Enabled = true;
            txtNumeroFactura.Enabled = true;
            txtPrefijo.Enabled = true;
            CboUsuario.Enabled = true;
            txtTotal.Enabled = true;
            btnActualizar.Visible = true;
            btnGuardar.Enabled = true;
        }
        public void ListarFacturasManuales()
        {
            //int total = Convert.ToInt32(txtTotal.Text.ToString());
            //int subtotal = Convert.ToInt32(Math.Round((total) / 1.19, 0));
            //int iva = Convert.ToInt32(total - subtotal);

            //FacturasManuales facturasManuales = new FacturasManuales();
            //facturasManuales.NumeroFactura = txtNumeroFactura.Text;
            //facturasManuales.IdEstacionamiento =  Convert.ToInt64(CboEstacionamiento.SelectedValue);
            //facturasManuales.FechaPago = Convert.ToDateTime(TxtFechaPago.Text);
            //facturasManuales.IdModulo = cboCarril.SelectedValue.ToString();
            //facturasManuales.Prefijo= txtPrefijo.Text;
            //facturasManuales.DocumentoUsuario = Convert.ToInt64(CboUsuario.SelectedValue);
            //facturasManuales.Total = total;
            //facturasManuales.Subtotal= subtotal;
            //facturasManuales.Iva = iva;
            DgvListado.DataSource = FacturasManualesController.ListarFacManuales(Convert.ToInt32(CboEstacionamientoBuscar.SelectedValue), TxtFechaDesde.Text,TxtFechaHasta.Text);
            if (DgvListado.Rows.Count < 1)
            {
                MensajeError("No se encontró información");
            }
            else
            {
                DgvListado.DataSource = FacturasManualesController.ListarFacManuales(Convert.ToInt32(CboEstacionamientoBuscar.SelectedValue), TxtFechaDesde.Text, TxtFechaHasta.Text);
                DgvListado.Columns[0].Visible = true;
            }
        }
        private void MensajeError(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Parquearse Tecnología", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void MensajeOk(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Parquearse Tecnología", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion

        private void FrmFacturasManuales_Load(object sender, EventArgs e)
        {
            Bloquear();
            ListarEstacionamientos();
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            ListarFacturasManuales();
        }

        private void DgvListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            FacturasManuales facturasManuales = new FacturasManuales();
            try { 
                if (e.ColumnIndex == DgvListado.Columns["Editar"].Index)
            {
                DataGridViewCheckBoxCell ChkEditar = (DataGridViewCheckBoxCell)DgvListado.Rows[e.RowIndex].Cells["Editar"];
                ChkEditar.Value = !Convert.ToBoolean(ChkEditar.Value);
                    if (Convert.ToBoolean(ChkEditar.Value) == true)
                    {
                        facturasManuales.IdModuloAntes = Convert.ToString(DgvListado.CurrentRow.Cells["IdModulo"].Value);
                        facturasManuales.IdEstacionamientoAntes = Convert.ToInt64(DgvListado.CurrentRow.Cells["IdEstacionamiento"].Value);
                        facturasManuales.FechaPagoAntes = Convert.ToDateTime(DgvListado.CurrentRow.Cells["FechaPago"].Value);
                        facturasManuales.SubtotalAntes = Convert.ToInt32(DgvListado.CurrentRow.Cells["Subtotal"].Value);
                        facturasManuales.IvaAntes = Convert.ToInt32(DgvListado.CurrentRow.Cells["Iva"].Value);
                        facturasManuales.TotalAntes = Convert.ToInt32(DgvListado.CurrentRow.Cells["Total"].Value);
                        facturasManuales.PrefijoAntes = Convert.ToString(DgvListado.CurrentRow.Cells["Prefijo"].Value);
                        facturasManuales.NumeroFacturaAntes = Convert.ToString(DgvListado.CurrentRow.Cells["NumeroFactura"].Value);
                        facturasManuales.IdTipoVehiculoAntes = Convert.ToString(DgvListado.CurrentRow.Cells["TipoVehiculo"].Value);
                        facturasManuales.DocumentoUsuarioAntes = Convert.ToString(DgvListado.CurrentRow.Cells["Documento"].Value);

                        cboCarril.SelectedValue = Convert.ToString(DgvListado.CurrentRow.Cells["IdModulo"].Value);
                        CboEstacionamiento.SelectedValue = Convert.ToInt64(DgvListado.CurrentRow.Cells["IdEstacionamiento"].Value);
                        TxtFechaPago.Text = Convert.ToString(DgvListado.CurrentRow.Cells["FechaPago"].Value);
                        txtTotal.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Total"].Value);
                        txtPrefijo.Text= Convert.ToString(DgvListado.CurrentRow.Cells["Prefijo"].Value);
                        txtNumeroFactura.Text = Convert.ToString(DgvListado.CurrentRow.Cells["NumeroFactura"].Value);
                        CboTipoCobro.SelectedValue = Convert.ToInt32(DgvListado.CurrentRow.Cells["TipoVehiculo"].Value);
                        CboUsuario.SelectedValue = Convert.ToInt64(DgvListado.CurrentRow.Cells["Documento"].Value);
                    }
                }
            }

            catch (Exception ex)
            {

                throw ex ;
            }
        }
    }
}

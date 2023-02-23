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
        FacturasManuales facturasManuales = new FacturasManuales();
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

        public void ListarSede()
        {
            try
            {
                CboEstacionamiento.DataSource = EstacionamientoController.ListarEstacionamientos();
                CboEstacionamiento.ValueMember = "IdEstacionamiento";
                CboEstacionamiento.DisplayMember = "Nombre";
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void ListarTipoCobro()
        {
            try
            {
                CboTipoCobro.DataSource = FacturasManualesController.ListarTipoCobro();
                CboTipoCobro.ValueMember = "IdTipoVehiculo";
                CboTipoCobro.DisplayMember = "TipoVehiculo";
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void ListarUsuarios()
        {
            try
            {
                CboUsuario.DataSource = FacturasManualesController.ListarUsuarios();
                CboUsuario.ValueMember = "Documento";
                CboUsuario.DisplayMember = "Nombres";
                
                
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

        public void Limpiar()
        {
            CboEstacionamiento.DataSource= null;
            CboUsuario.DataSource =null;
            TxtFechaPago.Text = Convert.ToString(DateTime.Now);
            CboTipoCobro.DataSource = null;
            txtNumeroFactura.Text = string.Empty;
            cboCarril.Text= string.Empty;
            txtPrefijo.Text = string.Empty;
            txtTotal.Text = string.Empty;
            DgvListado.Columns.Clear();


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

        public void ActuaizarFacturasManuales()
        {

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
                        cboCarril.SelectedText = string.Empty;
                        cboCarril.SelectedText = Convert.ToString(DgvListado.CurrentRow.Cells["IdModulo"].Value);
                       Int64 IdEstacionamientoTabla = Convert.ToInt64(DgvListado.CurrentRow.Cells["IdEstacionamiento"].Value);

                        Estacionamiento estacionamiento = new Estacionamiento();
                        estacionamiento.IdEstacionamiento = IdEstacionamientoTabla;

                            CboEstacionamiento.DataSource = EstacionamientoController.ListarEstacionamiento(estacionamiento);
                            CboEstacionamiento.ValueMember = "IdEstacionamiento";
                            CboEstacionamiento.DisplayMember = "Nombre";
                      

                        TxtFechaPago.Text = Convert.ToString(DgvListado.CurrentRow.Cells["FechaPago"].Value);
                        txtTotal.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Total"].Value);
                        txtPrefijo.Text= Convert.ToString(DgvListado.CurrentRow.Cells["Prefijo"].Value);
                        txtNumeroFactura.Text = Convert.ToString(DgvListado.CurrentRow.Cells["NumeroFactura"].Value);
                        string IdTipoVehiculoTabla = Convert.ToString(DgvListado.CurrentRow.Cells["TipoVehiculo"].Value);

                        facturasManuales.TipoVehiculo = IdTipoVehiculoTabla;
                        
                            CboTipoCobro.DataSource = FacturasManualesController.ListarTipoCobroNombre(facturasManuales);
                            CboTipoCobro.ValueMember = "IdTipoVehiculo";
                            CboTipoCobro.DisplayMember = "TipoVehiculo";
                      
                        Int64 documentoTabla = Convert.ToInt64(DgvListado.CurrentRow.Cells["Documento"].Value);
                        facturasManuales.DocumentoUsuario = documentoTabla;
                       
                            CboUsuario.DataSource = FacturasManualesController.ListarUsuariosPorDocumento(facturasManuales);
                            CboUsuario.ValueMember = "Documento";
                            CboUsuario.DisplayMember = "Nombres";
                        Desbloquear();
                        btnGuardar.Visible= false;
                    }
                }
            }

            catch (Exception ex)
            {

                throw ex ;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Desbloquear();
            btnActualizar.Visible= false;
        }

        private void CboEstacionamiento_MouseClick(object sender, MouseEventArgs e)
        {
            ListarSede();
        }

        private void CboTipoCobro_MouseClick(object sender, MouseEventArgs e)
        {
            ListarTipoCobro();
        }

        private void CboUsuario_MouseClick(object sender, MouseEventArgs e)
        {
            ListarUsuarios();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            Bloquear();
            Limpiar();
            btnGuardar.Visible = true;
            
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

            double total = Convert.ToInt32(txtTotal.Text.ToString());
            double subtotal = Math.Round((total) / 1.19, 0);
            double iva = Convert.ToInt32(total - subtotal);
            facturasManuales.Total = total;
            facturasManuales.Subtotal = subtotal;
            facturasManuales.Iva = iva;
            facturasManuales.IdEstacionamiento = Convert.ToInt64(CboEstacionamiento.SelectedValue);
            facturasManuales.FechaPago = Convert.ToDateTime(TxtFechaPago.Text);
            facturasManuales.IdTipoVehiculo = Convert.ToInt32(CboTipoCobro.SelectedValue);
            facturasManuales.NumeroFactura = txtNumeroFactura.Text;
            facturasManuales.IdModulo = cboCarril.Text;
            facturasManuales.Prefijo = txtPrefijo.Text;
            facturasManuales.DocumentoUsuario = Convert.ToInt64(CboUsuario.SelectedValue);
            string rta = "";
            try
            {
                rta = FacturasManualesController.ModificarFactura(facturasManuales);
                if (rta.Equals("OK"))
                {
                    MensajeOk("Registro actualizado correctamente");
                    ListarFacturasManuales();
                }
                else
                {
                    MensajeError(rta);
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string rta = "";
            double total = Convert.ToInt32(txtTotal.Text.ToString());
            double subtotal = Math.Round((total) / 1.19, 0);
            double iva = Convert.ToInt32(total - subtotal);
            facturasManuales.Total = total;
            facturasManuales.Subtotal = subtotal;
            facturasManuales.Iva = iva;
            facturasManuales.IdEstacionamiento = Convert.ToInt64(CboEstacionamiento.SelectedValue);
            facturasManuales.FechaPago = Convert.ToDateTime(TxtFechaPago.Text);
            facturasManuales.IdTipoVehiculo = Convert.ToInt32(CboTipoCobro.SelectedValue);
            facturasManuales.NumeroFactura = txtNumeroFactura.Text;
            facturasManuales.IdModulo = cboCarril.Text;
            facturasManuales.Prefijo = txtPrefijo.Text;
            facturasManuales.DocumentoUsuario = Convert.ToInt64(CboUsuario.SelectedValue);
            try
            {
                rta = FacturasManualesController.InsertarFactura(facturasManuales);
                if (rta.Equals("OK"))
                {
                    MensajeOk("Registro guardado correctamten");
                }
                else
                {
                    MensajeError(rta);
                }

            }
            catch (Exception ex )
            {

                throw ex ;
            }

        }
    }
}

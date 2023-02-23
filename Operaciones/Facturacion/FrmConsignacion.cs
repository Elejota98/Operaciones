using Controlador;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Operaciones.Facturacion
{
    public partial class FrmConsignacion : Form
    {
        Consignacion consignacion = new Consignacion();
        Estacionamiento estacionamiento = new Estacionamiento();
        public FrmConsignacion()
        {
            InitializeComponent();
        }

        private void FrmConsignacion_Load(object sender, EventArgs e)
        {
            ListarEstacionamientos();
            PanelAcciones.Visible = false;
        }

        #region Funciones
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

        public void ListarTipoDeposito()
        {
            try
            {
                cboTipoDeposito.DataSource = ConsignacionController.ListarTipoDeposito();
                cboTipoDeposito.ValueMember = "IdDeposito";
                cboTipoDeposito.DisplayMember = "Cosnignacion";
            }
            catch (Exception ex )
            {

                throw ex ;
            }
        }
        public void Limpiar()
        {
            txtIdConsignacion.Text = "";
            txtReferencia.Text = "";
            txtValor.Text = "";
            cboTipoDeposito.DataSource = null;
            cboSede.DataSource = null;
            txtUsuario.Text = "";
            txtFechaConsignacion.Text = Convert.ToString(DateTime.Now);

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

        private void cboSede_MouseClick(object sender, MouseEventArgs e)
        {
            ListarEstacionamientos();
        }

        private void DgvListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == DgvListado.Columns["Editar"].Index)
                {
                    DataGridViewCheckBoxCell ChkEditar = (DataGridViewCheckBoxCell)DgvListado.Rows[e.RowIndex].Cells["Editar"];
                    ChkEditar.Value = !Convert.ToBoolean(ChkEditar.Value);
                    if (Convert.ToBoolean(ChkEditar.Value) == true)
                    {
                        txtIdConsignacion.Text = Convert.ToString(DgvListado.CurrentRow.Cells["IdConsignacion"].Value);

                        Int64 idEstacionamiento = Convert.ToInt64(DgvListado.CurrentRow.Cells["IdEstacionamiento"].Value);
                        estacionamiento.IdEstacionamiento= idEstacionamiento;

                        cboSede.DataSource = EstacionamientoController.ListarEstacionamiento(estacionamiento);
                        cboSede.ValueMember = "IdEstacionamiento";
                        cboSede.DisplayMember = "Nombre";

                        txtFechaConsignacion.Text = Convert.ToString(DgvListado.CurrentRow.Cells["FechaConsignacion"].Value);
                        txtValor.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Valor"].Value);
                        txtReferencia.Text = Convert.ToString(DgvListado.CurrentRow.Cells["Referencia"].Value);
                        txtUsuario.Text = Convert.ToString(DgvListado.CurrentRow.Cells["DocumentoUsuario"].Value);

                        string idTipoDeposito = Convert.ToString(DgvListado.CurrentRow.Cells["IdTipoDeposito"].Value);

                        consignacion.IdTipoDeposito= idTipoDeposito;
                        cboTipoDeposito.DataSource = ConsignacionController.ListarTipoDepositoPorId(consignacion);
                        cboTipoDeposito.ValueMember = "IdDeposito";
                        cboTipoDeposito.DisplayMember = "Consignacion";

                        cboSede.Enabled = false;
                        cboTipoDeposito.Enabled = true;
                        txtValor.Enabled = true;
                        btnActualizar.Enabled = true;
                        btnGuardar.Visible = true;
                        txtReferencia.Enabled = true;
                        txtIdConsignacion.Enabled = false;
                        txtFechaConsignacion.Enabled=false;
                        txtUsuario.Enabled = false;
                        txtReferencia.Enabled = false;
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            consignacion.IdEstacionamiento = Convert.ToInt64(CboEstacionamientoBuscar.SelectedValue);
            consignacion.FechaInicio = Convert.ToDateTime(TxtFechaDesde.Text);
            consignacion.FechaHasta = Convert.ToDateTime(TxtFechaHasta.Text);

            DgvListado.DataSource = ConsignacionController.BuscarConsignacion(consignacion);
            if (DgvListado.Rows.Count < 1)
            {
                MensajeError("No se encontró información");
            }
            else
            {
                DgvListado.DataSource = ConsignacionController.BuscarConsignacion(consignacion);
                PanelAcciones.Visible = true;
            }


        }

        private void cboTipoDeposito_MouseClick(object sender, MouseEventArgs e)
        {
            ListarTipoDeposito();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string rta = "";
            consignacion.IdEstacionamiento = Convert.ToInt64(cboSede.SelectedValue);
            consignacion.IdConsignacion = Convert.ToInt64(txtIdConsignacion.Text);
            consignacion.Referencia = txtReferencia.Text;
            consignacion.Valor= Convert.ToDouble(txtValor.Text);
            consignacion.IdTipoDeposito =Convert.ToString(cboTipoDeposito.SelectedValue);
            consignacion.DocumentoUsuario = Convert.ToInt64(txtUsuario.Text);
            consignacion.FechaConsignacion = Convert.ToDateTime(txtFechaConsignacion.Text);
            rta = ConsignacionController.ModificarConsignacion(consignacion);
            if (rta.Equals("OK"))
            {
                MensajeOk("Datos modificados correctamente");
                PanelAcciones.Visible = false;
            }
            else
            {
                MensajeError(rta);
            }


        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string rta = "";
            consignacion.IdEstacionamiento = Convert.ToInt64(cboSede.SelectedValue);
            consignacion.IdConsignacion = Convert.ToInt64(txtIdConsignacion.Text);
            consignacion.Referencia = txtReferencia.Text;
            consignacion.Valor = Convert.ToDouble(txtValor.Text);
            consignacion.IdTipoDeposito = Convert.ToString(cboTipoDeposito.SelectedValue);
            consignacion.DocumentoUsuario = Convert.ToInt64(txtUsuario.Text);
            consignacion.FechaConsignacion = Convert.ToDateTime(txtFechaConsignacion.Text);
            rta = ConsignacionController.EliminarConsignacion(consignacion);
            if (rta.Equals("OK"))
            {
                MensajeOk("Se ha eliminado la consignación "+txtIdConsignacion.Text+"");
                PanelAcciones.Visible = false;
            }
            else
            {
                MensajeError(rta);
            }
        }
    }
}



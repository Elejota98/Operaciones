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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Operaciones
{
    public partial class FrmResoluciones : Form
    {
        public long IdEstacionamiento;
        public FrmResoluciones(long idEstacionamiento)
        {
            InitializeComponent();
            IdEstacionamiento = idEstacionamiento;
        }

        private void FrmResoluciones_Load(object sender, EventArgs e)
        {
            ListarEstacionamiento();
        }

        #region FUNCIONES
        public void ListarEstacionamiento()
        {
            Estacionamiento estacionamiento = new Estacionamiento();
            estacionamiento.IdEstacionamiento = IdEstacionamiento;

            try
            {
                cboEstacionamiento.DataSource = EstacionamientoController.ListarEstacionamiento(estacionamiento);
                cboEstacionamiento.ValueMember = "IdEstacionamiento";
                cboEstacionamiento.DisplayMember = "Nombre";
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void ListarResoluciones()
        {
            Resolucion resolucion = new Resolucion();
            resolucion.IdEstacionamiento = IdEstacionamiento;
                dvgListadoResolucion.DataSource = FacturacionController.ListarResoluciones(resolucion);
                dvgListadoResolucion.Columns[0].Visible = true;    
        }
        public void ActualizarResolucion()
        {
            Resolucion resolucion = new Resolucion();
            string rta = "";
            resolucion.IdFacturacion = Convert.ToInt32(TxtFacturacion.Text);
            resolucion.IdModulo = TxtModulo.Text;
            resolucion.IdEstacionamiento = Convert.ToInt64(cboEstacionamiento.SelectedValue);
            resolucion.Prefijo= TxtPrefijo.Text;
            resolucion.FacturaInicial=TxtFacInicial.Text;
            resolucion.FacturaFinal=TxtFacFinal.Text;
            resolucion.FacturaActual=TxtFacActual.Text;
            resolucion.NumeroResolucion = TxtResolucion.Text;
            resolucion.FechaResolucion = DtmResolucion.Text;
            resolucion.FechaFinResolucion = DtmFinResolucion.Text;

            try
            {
                rta = FacturacionController.ActualizarResolucion(resolucion);
                if (rta.Equals("OK"))
                {
                    MensajeOk("Registro actualizado correctamente");
                }
                else
                {
                    MensajeError("Error al actualizar la resolución");
                }
                
            }
            catch (Exception ex )
            {

                throw ex ;
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

        private void iconButton4_Click(object sender, EventArgs e)
        {
            ListarResoluciones();
        }

        private void dvgListadoResolucion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dvgListadoResolucion.Columns["Editar"].Index)
            {
                DataGridViewCheckBoxCell ChkAnular = (DataGridViewCheckBoxCell)dvgListadoResolucion.Rows[e.RowIndex].Cells["Editar"];
                ChkAnular.Value = !Convert.ToBoolean(ChkAnular.Value);
                if (Convert.ToBoolean(ChkAnular.Value))
                {
                    TxtFacturacion.Text = Convert.ToString(dvgListadoResolucion.CurrentRow.Cells["IdFacturacion"].Value);
                    TxtModulo.Text = Convert.ToString(dvgListadoResolucion.CurrentRow.Cells["IdModulo"].Value);
                    TxtPrefijo.Text = Convert.ToString(dvgListadoResolucion.CurrentRow.Cells["Prefijo"].Value);
                    TxtResolucion.Text = Convert.ToString(dvgListadoResolucion.CurrentRow.Cells["NumeroResolucion"].Value);
                    DtmResolucion.Text = Convert.ToString(dvgListadoResolucion.CurrentRow.Cells["FechaResolucion"].Value);
                    DtmFinResolucion.Text = Convert.ToString(dvgListadoResolucion.CurrentRow.Cells["FechaFinResolucion"].Value);
                    TxtFacInicial.Text = Convert.ToString(dvgListadoResolucion.CurrentRow.Cells["FacturaInicial"].Value);
                    TxtFacFinal.Text = Convert.ToString(dvgListadoResolucion.CurrentRow.Cells["FacturaFinal"].Value);
                    TxtFacActual.Text = Convert.ToString(dvgListadoResolucion.CurrentRow.Cells["FacturaActual"].Value);
                    TxtModulo.Enabled = false;
                    TxtFacturacion.Enabled = false;
                    TxtFacActual.Enabled = false;
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ActualizarResolucion();
        }
    }
}

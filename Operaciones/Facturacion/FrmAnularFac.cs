using Controlador;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Operaciones
{
    public partial class FrmAnularFac : Form
    {
        public string Cargo;
        public string Documento;
        public long IdEstacionamiento;
        Pagos pagos = new Pagos();
        public FrmAnularFac()
        {
            InitializeComponent();           
        }

        #region Funciones

        public void ListarFacturas()
        {

            pagos.NumeroFactura=txtNumeroFactura.Text;
            pagos.IdEstacionamiento = Convert.ToInt64(cboEstacionamiento.SelectedValue);
            try
            {
                if (pagos.NumeroFactura == string.Empty)
                {
                    MensajeError("Por favor ingrese un número de factura");
                }
                else
                {
                    dvgListadoFactura.DataSource = FacturacionController.ListarFacturasPorNumero(pagos);
                    if (dvgListadoFactura.Rows.Count < 1)
                    {
                        MensajeError("No se encontraron datos");
                        txtNumeroFactura.Focus();
                    }
                    else
                    {
                        if(Cargo=="CONTROL INTERNO" || Cargo == "Administrador")
                        {
                            dvgListadoFactura.DataSource = FacturacionController.ListarFacturasPorNumero(pagos);
                            dvgListadoFactura.Columns[0].Visible = true;
                        }
                        else
                        {
                            dvgListadoFactura.DataSource = FacturacionController.ListarFacturasPorNumero(pagos);
                        }
                       
                    }
                }

            }
            catch (Exception ex )
            {

                throw ex ;
            }

        }
        public void ListarEstacionamiento()
        {           
            try
            {
             cboEstacionamiento.DataSource= EstacionamientoController.ListarEstacionamientos();
                cboEstacionamiento.ValueMember = "IdEstacionamiento";
                cboEstacionamiento.DisplayMember = "Nombre";
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

        private void FrmAnularFac_Load(object sender, EventArgs e)
        {
            ListarEstacionamiento();
        }

        private void dvgListadoFactura_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dvgListadoFactura.Columns["Anular"].Index)
            {
                DataGridViewCheckBoxCell ChkAnular = (DataGridViewCheckBoxCell)dvgListadoFactura.Rows[e.RowIndex].Cells["Anular"];
                ChkAnular.Value = !Convert.ToBoolean(ChkAnular.Value);
                if (Convert.ToBoolean(ChkAnular.Value))
                {
                    DialogResult Opcion;
                    Opcion = MessageBox.Show("Desea anular la factura?", "Parquearse Tecnología", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (Opcion == DialogResult.Yes)
                    {
                        Pagos pagos= new Pagos();                        
                        string rta = "";
                        foreach (DataGridViewRow row in dvgListadoFactura.Rows)
                        {
                            if (Convert.ToBoolean(row.Cells[0].Value))
                            {
                                pagos.Anulada = Convert.ToInt32(row.Cells[0].Value);
                                pagos.IdPago = Convert.ToInt32(row.Cells[1].Value);
                                rta = FacturacionController.AnularFactura(pagos);
                                if (rta.Equals("OK"))
                                {
                                    this.MensajeOk("Se anuló la factura :" + Convert.ToString(row.Cells[2].Value));
                                    dvgListadoFactura.Columns[0].Visible = false;
                                }
                                else
                                {
                                    this.MensajeError(rta);
                                }
                            }


                        }
                    }
                    else
                    {
                        if (Cargo == "CONTROL INTERNO" || Cargo == "Administrador")
                        {
                            dvgListadoFactura.DataSource = FacturacionController.ListarFacturasPorNumero(pagos);
                            dvgListadoFactura.Columns[0].Visible = true;
                        }
                        else
                        {
                            dvgListadoFactura.DataSource = FacturacionController.ListarFacturasPorNumero(pagos);
                        }
                    }
                }
                else
                {
                    DialogResult Opcion;
                    Opcion = MessageBox.Show("Desea anular la factura?", "Parquearse Tecnología", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (Opcion == DialogResult.Yes)
                    {
                        Pagos pagos = new Pagos();
                        string rta = "";
                        foreach (DataGridViewRow row in dvgListadoFactura.Rows)
                        {
                            if (Convert.ToBoolean(row.Cells[0].Value))
                            {
                                pagos.Anulada = Convert.ToInt32(row.Cells[0].Value);
                                pagos.IdPago = Convert.ToInt32(row.Cells[1].Value);
                                rta = FacturacionController.AnularFactura(pagos);
                                if (rta.Equals("OK"))
                                {
                                    this.MensajeOk("Se desanuló la factura :" + Convert.ToString(row.Cells[2].Value));
                                    dvgListadoFactura.Columns[0].Visible = false;
                                }
                                else
                                {
                                    this.MensajeError(rta);
                                }
                            }


                        }
                    }
                    else
                    {
                        if (Cargo == "CONTROL INTERNO" || Cargo == "Administrador")
                        {
                            dvgListadoFactura.DataSource = FacturacionController.ListarFacturasPorNumero(pagos);
                            dvgListadoFactura.Columns[0].Visible = true;
                        }
                        else
                        {
                            dvgListadoFactura.DataSource = FacturacionController.ListarFacturasPorNumero(pagos);
                        }
                    }
                }
            }
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            ListarFacturas();
        }

        private void cboEstacionamiento_MouseClick(object sender, MouseEventArgs e)
        {
            ListarEstacionamiento();
        }
    }
}

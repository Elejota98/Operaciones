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
    public partial class FrmSaldoEnLinea : Form
    {
        public FrmSaldoEnLinea()
        {
            InitializeComponent();
        }

        private void FrmSaldoEnLinea_Load(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("hh:mm:ss tt");
            lblFecha.Text = DateTime.Now.ToLongDateString();
            this.ReporSaldoEnLinea.RefreshReport();
        }
    }
}

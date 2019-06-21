using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppPrincipal
{
    public partial class FormularioInformes : Form
    {
        public FormularioInformes()
        {
            InitializeComponent();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormularioInformes_Load(object sender, EventArgs e)
        {

            
        }

        private void BtnReporteVerProducto_Click(object sender, EventArgs e)
        {
            REPORTE.ReporteProducto rt = new REPORTE.ReporteProducto();
            rt.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            REPORTE.ReporteClientes rc = new REPORTE.ReporteClientes();
            rc.ShowDialog();
        }

        private void BtnReportOrdenCompra_Click(object sender, EventArgs e)
        {
            REPORTE.ReporteOrdenCompra ro = new REPORTE.ReporteOrdenCompra();
            ro.ShowDialog();
        }
    }
}

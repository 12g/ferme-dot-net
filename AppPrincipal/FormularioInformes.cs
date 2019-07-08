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
            Cursor.Current = Cursors.WaitCursor;
            REPORTE.ReporteProducto rt = new REPORTE.ReporteProducto();
            rt.ShowDialog();
            Cursor.Current = Cursors.Default;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            REPORTE.ReporteClientes rc = new REPORTE.ReporteClientes();
            rc.ShowDialog();
            Cursor.Current = Cursors.Default;
        }

        private void BtnReportOrdenCompra_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            REPORTE.ReporteOrdenCompra ro = new REPORTE.ReporteOrdenCompra();
            ro.ShowDialog();
            Cursor.Current = Cursors.Default;
        }

        private void BtnReporteProveedor_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            REPORTE.ReporteProveedor ro = new REPORTE.ReporteProveedor();
            ro.ShowDialog();
            Cursor.Current = Cursors.Default;
        }

        private void BtnReporteEmpleados_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            REPORTE.ReporteEmpleados ro = new REPORTE.ReporteEmpleados();
            ro.ShowDialog();
            Cursor.Current = Cursors.Default;
        }

        private void BtnReporteVentas_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            REPORTE.ReporteVentas ro = new REPORTE.ReporteVentas();
            ro.ShowDialog();
            Cursor.Current = Cursors.Default;
        }
    }
}

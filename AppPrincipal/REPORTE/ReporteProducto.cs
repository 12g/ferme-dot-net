using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppPrincipal.REPORTE
{
    public partial class ReporteProducto : Form
    {
        public ReporteProducto()
        {
            InitializeComponent();
        }

        private void ReporteProducto_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'ConexionFerme.DataProducto' Puede moverla o quitarla según sea necesario.
            this.DataProductoTableAdapter.Fill(this.ConexionFerme.DataProducto);

            this.reportViewer1.RefreshReport();
        }
    }
}

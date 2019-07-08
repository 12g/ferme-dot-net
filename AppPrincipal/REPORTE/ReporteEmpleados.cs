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
    public partial class ReporteEmpleados : Form
    {
        public ReporteEmpleados()
        {
            InitializeComponent();
        }

        private void ReporteEmpleados_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'ConexionFerme.TablaEmpleados' Puede moverla o quitarla según sea necesario.
            this.TablaEmpleadosTableAdapter.Fill(this.ConexionFerme.TablaEmpleados);

            this.reportViewer1.RefreshReport();
        }
    }
}

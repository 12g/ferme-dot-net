using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca;

namespace AppPrincipal
{
    public partial class RepOrdenCompra : Form
    {
        public List<Venta> vent = new List<Venta>();
        public List<DetalleOrdenCompra> detalle = new List<DetalleOrdenCompra>();
        public RepOrdenCompra()
        {
            InitializeComponent();
        }

        private int CodigoProducto { get; set; }

        private void RepOrdenCompra_Load(object sender, EventArgs e)
        {
            //TODO: esta línea de código carga datos en la tabla 'conexionFerme.DataTable1' Puede moverla o quitarla según sea necesario.
           //this.dataTable1TableAdapter.Fill(this.conexionFerme.DataTable1);

            this.reportViewer1.RefreshReport();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppPrincipal
{
    public partial class FromularioVentas : Form
    {
        public FromularioVentas()
        {
            InitializeComponent();
        }

        private void FromularioVentas_Load(object sender, EventArgs e)
        {
            TxtFecha.Text = DateTime.Now.ToShortDateString();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnBuscarProducto_Click(object sender, EventArgs e)
        {
            FormularioBuscarProducto fbp = new FormularioBuscarProducto(this);
            fbp.ShowDialog();
        }
    }
}

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
using ServiciosConexionFerme;

namespace AppPrincipal
{
    public partial class FormularioOrdenCompra : Form
    {
        public FormularioOrdenCompra()
        {
            InitializeComponent();
            ServicioOrdenCompra seroc = new ServicioOrdenCompra();
            DGlistadoOrdenCompra.DataSource = seroc.ListarOrdenCompra();
        }

        //BOTON CERRAR EL FORMULARIO DE ORDEN DE COMPRA
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //BOTON CREAR ORDEN DE COMPRA
        private void BtnCrear_Click(object sender, EventArgs e)
        {
            FormularioMantenedorOrdenCompra fmoc = new FormularioMantenedorOrdenCompra();
            fmoc.ShowDialog();
        }
    }
}

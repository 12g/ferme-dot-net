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
            try
            {
                ServicioOrdenCompra seroc = new ServicioOrdenCompra();
                DGlistadoOrdenCompra.DataSource = seroc.ListarOrdenCompra();
                this.DGlistadoOrdenCompra.Columns[0].Visible = false;
            }
            catch (Exception)
            {
                MessageBox.Show("NO SE PUEDE CARGAR LISTADO DE PROVEEDORES");
            }
           
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

        private void FormularioOrdenCompra_Load(object sender, EventArgs e)
        {
            Timer actualizar_automatico = new Timer();
            actualizar_automatico.Interval = 30000;
            actualizar_automatico.Tick += actualizar_automatico_Tick;
            actualizar_automatico.Enabled = true;
        }
        private void recargar()
        {
            ServicioOrdenCompra ser = new ServicioOrdenCompra();
            DGlistadoOrdenCompra.DataSource = ser.ListarOrdenCompra();
        }

        private void actualizar_automatico_Tick(object sender, EventArgs e)
        {
            recargar();
        }
    }
}

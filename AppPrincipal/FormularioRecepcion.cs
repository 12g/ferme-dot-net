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
    public partial class FormularioRecepcion : Form
    {
        public FormularioRecepcion()
        {
            InitializeComponent();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //BOTON NUEVA REDEPCION
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                TxtNumero.Text = "";
                TxtFechaCreacion.Text = "";
                DpFechaRecepcion.Value = DateTime.Now;
                TxtEmpleado.Text = "";
              

                DgListadoRecepcion.Rows.Clear();
                DgListadoRecepcion.Refresh();

                if (CbxEstadoRecepcion.Items.Count > 1)
                {
                    CbxEstadoRecepcion.SelectedIndex = -1;
                    CbxEstadoRecepcion.Text = "Seleccione";
                }
            }
            catch (Exception)
            {

                MessageBox.Show("ERROR AL GENERAR UNA ORDEN DE COMPRA");
            }
        }

        private void BtnBuscarOrdenCompra_Click(object sender, EventArgs e)
        {
            FormularioBuscarOrdenCompra frm = new FormularioBuscarOrdenCompra(this);
            frm.ShowDialog();
        }
    }
}

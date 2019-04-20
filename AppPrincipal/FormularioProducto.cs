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
    public partial class FormularioProducto : Form
    {
        public FormularioProducto()
        {
            InitializeComponent();
        }

        //BOTON QUE CIERRA EL FORMULARIO PRINCIPAL DE PRODUCTOS
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //BOTON QUE LLAMA AL FORMULARIO MATENEDOR DE PRODUCTO
        private void BtnCrear_Click(object sender, EventArgs e)
        {
            FormularioMantenedorProducto frp = new FormularioMantenedorProducto();
            frp.ShowDialog();
        }

        //BOTON EDITAR/METODO PARA SELECCIONAR UN PRODUCTO DE LA LISTA Y EDITARLO
        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                FormularioMantenedorProducto fmp = new FormularioMantenedorProducto();
                if (DGlistadeproductos.SelectedRows.Count > 0)
                {
                    fmp.TxtCodigo.Text = DGlistadeproductos.CurrentRow.Cells[0].Value.ToString();
                    fmp.TxtNombreProducto.Text = DGlistadeproductos.CurrentRow.Cells[1].Value.ToString();
                    fmp.CbTipoproducto.SelectedText = DGlistadeproductos.CurrentRow.Cells[2].Value.ToString();
                    fmp.TxtFamilia.Text = DGlistadeproductos.CurrentRow.Cells[3].Value.ToString();
                    fmp.CbProveedor.SelectedText = DGlistadeproductos.CurrentRow.Cells[4].Value.ToString();
                    fmp.TxtPrecio.Text = DGlistadeproductos.CurrentRow.Cells[5].Value.ToString();
                    fmp.TxtStockActual.Text = DGlistadeproductos.CurrentRow.Cells[6].Value.ToString();
                    fmp.TxtStockCritico.Text = DGlistadeproductos.CurrentRow.Cells[7].Value.ToString();
                    fmp.TxtDescripcion.Text = DGlistadeproductos.CurrentRow.Cells[8].Value.ToString();

                    fmp.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Debe seleccionar una fila");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("ERROR AL EDITAR LA FILA");
            }
        }
    }
}

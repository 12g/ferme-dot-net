using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ServiciosConexionFerme;

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
            if (frp.ShowDialog() == DialogResult.OK)
            {
                ListaProducto();
            }
        }

        //BOTON EDITAR/METODO PARA SELECCIONAR UN PRODUCTO DE LA LISTA Y EDITARLO
        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
               FormularioMantenedorProducto fmp = new FormularioMantenedorProducto();
               
                    if (DGlistadeproductos.SelectedRows.Count > 0)
                    {
                        fmp.TxtIdProducto.Text = DGlistadeproductos.CurrentRow.Cells["idProducto"].Value.ToString();
                        fmp.TxtCodigo.Text = DGlistadeproductos.CurrentRow.Cells["codigoProducto"].Value.ToString();
                        fmp.TxtNombreProducto.Text = DGlistadeproductos.CurrentRow.Cells["nombreProducto"].Value.ToString();
                        fmp.CbTipoproducto.Text = DGlistadeproductos.CurrentRow.Cells["nombreTipoProducto"].Value.ToString();
                        fmp.TxtStockActual.Text = DGlistadeproductos.CurrentRow.Cells["stockActualProducto"].Value.ToString();
                        fmp.TxtStockCritico.Text = DGlistadeproductos.CurrentRow.Cells["stockCriticoProducto"].Value.ToString();
                        fmp.TxtPrecio.Text = DGlistadeproductos.CurrentRow.Cells["precioProducto"].Value.ToString();
                        fmp.CbxFamiliaProducto.Text = DGlistadeproductos.CurrentRow.Cells["descripcionFamiliaProducto"].Value.ToString();
                    }
                if (fmp.ShowDialog() == DialogResult.OK)
                {
                    ListaProducto();
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

        private void FormularioProducto_Load_1(object sender, EventArgs e)
        {
            ListaProducto();
        }


        //CARGA LISTA DE PRODUCTO EN DATAGRIDVIEW
        public void ListaProducto()
        {
            ServicioProducto ser = new ServicioProducto();
           try
            {
                DGlistadeproductos.DataSource = ser.GetRESTData();

              //OCULTA LAS COLUMNAS
                this.DGlistadeproductos.Columns["idProducto"].Visible = false;
                this.DGlistadeproductos.Columns["idTipoProducto"].Visible = false;
                this.DGlistadeproductos.Columns["idFamiliaProducto"].Visible = false;
                //this.DGlistadeproductos.Columns["descripcionFamiliaProducto"].Visible = false;

                //DA NOMBRE A LAS COLUMNAS
                this.DGlistadeproductos.Columns["codigoProducto"].HeaderText = "CODIGO";
                this.DGlistadeproductos.Columns["nombreProducto"].HeaderText = "NOMBRE PRODUCTO";
                this.DGlistadeproductos.Columns["precioProducto"].HeaderText = "PRECIO";
                //this.DGlistadeproductos.Columns["descripcionProducto"].HeaderText = "DESCRIPCION PRODUCTO";
                this.DGlistadeproductos.Columns["stockActualProducto"].HeaderText ="STOCK ACTUAL";
                this.DGlistadeproductos.Columns["stockCriticoProducto"].HeaderText = "STOCK CRITICO";
                this.DGlistadeproductos.Columns["nombreTipoProducto"].HeaderText = "TIPO PRODUCTO";
                this.DGlistadeproductos.Columns["descripcionFamiliaProducto"].HeaderText = "FAMILIA PRODUCTO";


                DGlistadeproductos.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("NO HAY PRODUCTOS CREADOS PARA MOSTRAR");
            }
        }

        //BUSCAR
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscar.Text != "")
            {
                DGlistadeproductos.CurrentCell = null;
                foreach(DataGridViewRow r in DGlistadeproductos.Rows)
                {
                    r.Visible = false;
                }
                foreach(DataGridViewRow r in DGlistadeproductos.Rows)
                {
                    foreach (DataGridViewCell c in r.Cells)
                    {
                        if ((c.Value.ToString().ToUpper()).IndexOf(txtBuscar.Text.ToUpper()) ==0)
                        {
                            r.Visible = true;
                            break;
                        }
                    }

                }
            }
            else
            {
                ServicioProducto ser = new ServicioProducto();
                DGlistadeproductos.DataSource = ser.GetRESTData();
            }
        }


        //MANTENEDOR FAMILIA PRODUCTO
        private void BtnFamiliaProducto_Click(object sender, EventArgs e)
        {
            FormularioMantenedorFamiliaProducto fmfp = new FormularioMantenedorFamiliaProducto();
            fmfp.ShowDialog();
        }

        //MANTENEDOR TIPO PRODUCTO
        private void BtnTipoProducto_Click(object sender, EventArgs e)
        {
            FomularioTipoProducto frtp = new FomularioTipoProducto();
            frtp.ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
              

            }
            catch (Exception)
            {

                MessageBox.Show("ERROR AL ELIMINAR PRODUCTO");
            }
        }

        private void BtnRubro_Click(object sender, EventArgs e)
        {
            FormularioMantenedorRubro fmr = new FormularioMantenedorRubro();
            fmr.ShowDialog();
        }
    }
}

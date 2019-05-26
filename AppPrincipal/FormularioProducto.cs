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
                    fmp.TxtCodigo.Text = DGlistadeproductos.CurrentRow.Cells[1].Value.ToString();
                    fmp.TxtNombreProducto.Text = DGlistadeproductos.CurrentRow.Cells[2].Value.ToString();
                    fmp.CbTipoproducto.SelectedText = DGlistadeproductos.CurrentRow.Cells[7].Value.ToString();
                    fmp.TxtStockActual.Text = DGlistadeproductos.CurrentRow.Cells[4].Value.ToString();
                    fmp.TxtStockCritico.Text = DGlistadeproductos.CurrentRow.Cells[5].Value.ToString();
                    fmp.TxtDescripcion.Text = DGlistadeproductos.CurrentRow.Cells[3].Value.ToString();
                    fmp.TxtPrecio.Text = DGlistadeproductos.CurrentRow.Cells[8].Value.ToString();

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

        private void recargar()
        {
            ServicioProducto ser = new ServicioProducto();
            DGlistadeproductos.DataSource = ser.GetRESTData();
        }

        private void actualizar_automatico_Tick(object sender, EventArgs e)
        {
            recargar();
        }

        private void FormularioProducto_Load_1(object sender, EventArgs e)
        {

            ServicioProducto ser = new ServicioProducto();
            try
            {
                DGlistadeproductos.DataSource = ser.GetRESTData();

                //OCULTA LAS COLUMNAS
                this.DGlistadeproductos.Columns[0].Visible = false;
                this.DGlistadeproductos.Columns[6].Visible = false;

                //DA NOMBRE A LAS COLUMNAS
                this.DGlistadeproductos.Columns[1].HeaderText = "CODIGO";
                this.DGlistadeproductos.Columns[2].HeaderText = "NOMBRE PRODUCTO";
                this.DGlistadeproductos.Columns[3].HeaderText = "DESCRIPCION PRODUCTO";
                this.DGlistadeproductos.Columns[4].HeaderText = "STOCK ACTUAL";
                this.DGlistadeproductos.Columns[5].HeaderText = "STOCK CRITICO";
                this.DGlistadeproductos.Columns[7].HeaderText = "TIPO PRODUCTO";
                this.DGlistadeproductos.Columns[8].HeaderText = "PRECIO";

            }
            catch (Exception)
            {
                MessageBox.Show("NO SE PUEDE CARGAR LISTADO DE PRODUCTOS");
            }



            //ACTUALIZA EL DATAGRIDVIEW
            Timer actualizar_automatico = new Timer();
            actualizar_automatico.Interval = 30000;
            actualizar_automatico.Tick += actualizar_automatico_Tick;
            actualizar_automatico.Enabled = true;
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
                ser.GetRESTData();
            }
        }
    }
}

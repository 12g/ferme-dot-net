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
    public partial class FormularioBuscarOrdenCompra : Form
    {
       
        private FormularioMantenedorOrdenCompra FrmOrdenCompra;
        //inicia en formulario mantenedor de recepcion
        public FormularioBuscarOrdenCompra(FormularioMantenedorOrdenCompra parametro)
        {
            InitializeComponent();


            FrmOrdenCompra = parametro;
           try
            {
               ServicioOrdenCompra serp = new ServicioOrdenCompra();
                DgMostrarOrdenCompra.DataSource = serp.ListarOrdenCompra();

               /* //OCULTAR COLUMNA
                //this.DgMostrarOrdenCompra.Columns[6].Visible = false;
                this.DgMostrarOrdenCompra.Columns[5].Visible = false;

                //DA NOMBRE A LAS COLUMNAS
                this.DgMostrarOrdenCompra.Columns[0].HeaderText = "CODIGO";
                this.DgMostrarOrdenCompra.Columns[1].HeaderText = "COD VENDEDOR       ";
                this.DgMostrarOrdenCompra.Columns[2].HeaderText = "ESTADO";
                this.DgMostrarOrdenCompra.Columns[3].HeaderText = "FECHA CREACION     ";
                this.DgMostrarOrdenCompra.Columns[4].HeaderText = "FECHA RECEPCION    ";*/

            }
            catch (Exception)
            {
                MessageBox.Show("NO SE PUEDE CARGAR LISTADO DE ORDEN DE COMPRA");
            }
        }

        //inicia en formulario recepcion
        private FormularioRecepcion FrmRecepcion;
        public FormularioBuscarOrdenCompra(FormularioRecepcion parametro)
        {
            InitializeComponent();


            FrmRecepcion = parametro;
            try
            {
                ServicioOrdenCompra serp = new ServicioOrdenCompra();
                DgMostrarOrdenCompra.DataSource = serp.ListarOrdenCompra();


                //OCULTAR COLUMNA
                //this.DgMostrarOrdenCompra.Columns[6].Visible = false;
                this.DgMostrarOrdenCompra.Columns[5].Visible = false;

                //DA NOMBRE A LAS COLUMNAS
                this.DgMostrarOrdenCompra.Columns[0].HeaderText = "CODIGO";
                this.DgMostrarOrdenCompra.Columns[1].HeaderText = "COD VENDEDOR       ";
                this.DgMostrarOrdenCompra.Columns[2].HeaderText = "ESTADO";
                this.DgMostrarOrdenCompra.Columns[3].HeaderText = "FECHA CREACION     ";
                this.DgMostrarOrdenCompra.Columns[4].HeaderText = "FECHA RECEPCION    ";
                //this.DgMostrarOrdenCompra.Columns[7].HeaderText = "TIPO PRODUCTO";
                // this.DgMostrarProductos.Columns[8].HeaderText = "PRECIO";

           }
            catch (Exception)
            {
                MessageBox.Show("NO SE PUEDE CARGAR LISTADO DE PRODUCTOS");
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                //MessageBox.Show("DESEA CERRAR LA APLICACION ? ","",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Exclamation);

                MessageBoxButtons botones = MessageBoxButtons.YesNoCancel;
                DialogResult dr = MessageBox.Show("¿Está seguro que desea salir?", "", botones, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    this.Close();
                }

            }
            catch
            {
                MessageBox.Show("Error al cerrar Aplicacion");
            }
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (TxtBuscar.Text != "")
            {
                DgMostrarOrdenCompra.CurrentCell = null;
                foreach (DataGridViewRow r in DgMostrarOrdenCompra.Rows)
                {
                    r.Visible = false;
                }
                foreach (DataGridViewRow r in DgMostrarOrdenCompra.Rows)
                {
                    foreach (DataGridViewCell c in r.Cells)
                    {
                        if ((c.Value.ToString().ToUpper()).IndexOf(TxtBuscar.Text.ToUpper()) == 0)
                        {
                            r.Visible = true;
                            break;
                        }
                    }

                }
            }
            else
            {
                 ServicioOrdenCompra ser = new ServicioOrdenCompra();
                DgMostrarOrdenCompra.DataSource = ser.ListarOrdenCompra();
            }
        }

        private void DgMostrarOrdenCompra_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //detallar campos*******************************************
            try
             {
                 try
                 {
                    //CARGA LOS DATOS DE LA ORDEN DE COMPRA EN EL FORMULARIO DE MANTENEDOR DE ORDEN DE COMPRA
                    //SE CASTEA EL OBJETO ORDEN COMPRA
                    Orden_Compra oc = (Orden_Compra)DgMostrarOrdenCompra.CurrentRow.DataBoundItem;
                    ServicioOrdenCompra ser = new ServicioOrdenCompra();
                    BindingList<DetalleOrdenCVista> detCv = new BindingList<DetalleOrdenCVista>();
                    List<DetalleOrdenCompra> lista = ser.subdetalleOrdenCompra(oc);
  
                   foreach (DetalleOrdenCompra detoc in lista)
                  {
                     DetalleOrdenCVista ClaseDetalleCv = new DetalleOrdenCVista();
                     ClaseDetalleCv.CODIGO = detoc.codigoProducto;
                     ClaseDetalleCv.NOMBRE = detoc.nombreProducto;
                     ClaseDetalleCv.CANTIDAD = detoc.cantidadProducto;

                     detCv.Add(ClaseDetalleCv);
                   }

                    FrmOrdenCompra.DgListadoProductoOC.DataSource = detCv;
                    FrmOrdenCompra.detalleOC = lista;

                    FrmOrdenCompra.TxtNumero.Text = DgMostrarOrdenCompra.CurrentRow.Cells[0].Value.ToString();
                    FrmOrdenCompra.CbEmpleado.SelectedText = DgMostrarOrdenCompra.CurrentRow.Cells[1].Value.ToString();
                    FrmOrdenCompra.CbEstado.Text = DgMostrarOrdenCompra.CurrentRow.Cells[2].Value.ToString();
                    FrmOrdenCompra.DPfechaInicio.Text = DgMostrarOrdenCompra.CurrentRow.Cells[3].Value.ToString();
                    FrmOrdenCompra.DPfechaTermino.Text = DgMostrarOrdenCompra.CurrentRow.Cells[4].Value.ToString();
                    //FrmOrdenCompra.DgListadoProductoOC.Text = DgMostrarOrdenCompra.CurrentRow.Cells[5].Value.ToString();

                    this.Close();

           
               }
                catch (Exception)
                {

                    FrmRecepcion.TxtNumero.Text = DgMostrarOrdenCompra.CurrentRow.Cells[0].Value.ToString();
                    FrmRecepcion.TxtEmpleado.Text = DgMostrarOrdenCompra.CurrentRow.Cells[1].Value.ToString();
                    FrmRecepcion.CbxEstadoRecepcion.Text = DgMostrarOrdenCompra.CurrentRow.Cells[2].Value.ToString();
                    FrmRecepcion.DpFechaCreacion.Text = DgMostrarOrdenCompra.CurrentRow.Cells[3].Value.ToString();
                    FrmRecepcion.DpFechaRecepcion.Text = DgMostrarOrdenCompra.CurrentRow.Cells[4].Value.ToString();
                   // FrmRecepcion.DgListadoRecepcion.Text = DgMostrarOrdenCompra.CurrentRow.Cells[5].Value.ToString();

                    this.Close();
                }
            }
            catch (Exception)
            {
                //MessageBox.Show("ERROR AL AGREGAR ORDEN COMPRA");
                Console.WriteLine();
            }

        }

        //lista detalle orden compra
        private void ListaOrdenC()
        {

            try
            {
                BindingList<DetalleOrdenCompra> lista;

                DgMostrarOrdenCompra.DataSource = new BindingList<DetalleOrdenCompra>();
            }
            catch (Exception)
            {
                MessageBox.Show("NO SE PUEDE CARGAR LISTA");
            }

        }
    }
}

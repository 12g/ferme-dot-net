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
    public partial class FormularioBuscarVenta : Form
    {
        private FromularioVentas frmventas;
        public FormularioBuscarVenta(FromularioVentas parametro)
        {
            InitializeComponent();


            frmventas = parametro;
            try
            {
                ServicioVentas ser = new ServicioVentas();
                DgMostrarVentasRealizadas.DataSource = ser.ListarVenta();
                this.DgMostrarVentasRealizadas.Columns["idEmpleado"].Visible = false;
                this.DgMostrarVentasRealizadas.Columns["idCliente"].Visible = false;


                //DA NOMBRE A LAS COLUMNAS
                this.DgMostrarVentasRealizadas.Columns["idVenta"].HeaderText = "CODIGO";
                this.DgMostrarVentasRealizadas.Columns["tipoVenta"].HeaderText = "TIPO VENTA";
                this.DgMostrarVentasRealizadas.Columns["fechaVenta"].HeaderText = "FECHA VENTA";
                this.DgMostrarVentasRealizadas.Columns["nombreCompletoEmpleado"].HeaderText = "VENDEDOR";
                this.DgMostrarVentasRealizadas.Columns["nombreCompletoCliente"].HeaderText = "CLIENTE";
                this.DgMostrarVentasRealizadas.Columns["rutCliente"].HeaderText = "RUT CLIENTE";
                this.DgMostrarVentasRealizadas.Columns["subtotalVenta"].HeaderText = "SUBTOTAL";
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR AL CARGAR VENTA");
            }
        }


        //BOTON CANCELAR
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
                DgMostrarVentasRealizadas.CurrentCell = null;
                foreach (DataGridViewRow r in DgMostrarVentasRealizadas.Rows)
                {
                    r.Visible = false;
                }
                foreach (DataGridViewRow r in DgMostrarVentasRealizadas.Rows)
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
                 ServicioVentas ser = new ServicioVentas();
                 DgMostrarVentasRealizadas.DataSource = ser.ListarVenta();
            }
        }


        //SELECCIONAR UNA FILA Y LA ENVIA AL FORMULARIO VENTAS PARA VISUALIZARLA
        private void DgMostrarVentasRealizadas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
             {
             
            //CARGA LOS DATOS DE LA VENTA EN EL FORMULARIO DE MANTENEDOR DE VENTA
            //SE CASTEA EL OBJETO ORDEN COMPRA
            Venta oc = (Venta)DgMostrarVentasRealizadas.CurrentRow.DataBoundItem;

            ServicioVentas ser = new ServicioVentas();
            BindingList<DetalleVentaVista> detCv = new BindingList<DetalleVentaVista>();
            List<Detalle_Venta> lista = ser.subdetalleventa(oc);
            Producto pro = new Producto();

            foreach (Detalle_Venta detVenta in lista)
            {
                DetalleVentaVista ClaseDetalleV = new DetalleVentaVista();
                ClaseDetalleV.CODIGO = detVenta.codigoProducto;
                ClaseDetalleV.NOMBRE = detVenta.nombreProducto;
                ClaseDetalleV.CANTIDAD = detVenta.unidadesProducto;
                ClaseDetalleV.MONTO = detVenta.montoDetalleVenta;
                ClaseDetalleV.SUBTOTAL = detVenta.unidadesProducto * detVenta.montoDetalleVenta;
                    
                detCv.Add(ClaseDetalleV);
            }



                frmventas.DgVentaProducto.DataSource = detCv;
            frmventas.detalleVen = lista;


            frmventas.TxtNumeroDocumento.Text = DgMostrarVentasRealizadas.CurrentRow.Cells["idVenta"].Value.ToString();
            frmventas.CbTipoDocto.Text = DgMostrarVentasRealizadas.CurrentRow.Cells["tipoVenta"].Value.ToString();
            frmventas.DpFecha.Text = DgMostrarVentasRealizadas.CurrentRow.Cells["fechaVenta"].Value.ToString();
            frmventas.TxtTotal.Text = DgMostrarVentasRealizadas.CurrentRow.Cells["subtotalVenta"].Value.ToString();
            frmventas.CbEmpleado.Text = DgMostrarVentasRealizadas.CurrentRow.Cells["nombreCompletoEmpleado"].Value.ToString();
            frmventas.TxtIdEmpleado.Text = DgMostrarVentasRealizadas.CurrentRow.Cells["idEmpleado"].Value.ToString();
            frmventas.TxtIdCliente.Text = DgMostrarVentasRealizadas.CurrentRow.Cells["idCliente"].Value.ToString();
            frmventas.TxtNombreRazonSocial.Text = DgMostrarVentasRealizadas.CurrentRow.Cells["nombreCompletoCliente"].Value.ToString();
            frmventas.TxtRut.Text = DgMostrarVentasRealizadas.CurrentRow.Cells["rutCliente"].Value.ToString();



            this.Close();
           }
            catch (Exception)
            {
                MessageBox.Show("ERROR AL SELECCIONAR VENTA");
            }
        }

        //lista detalle orden compra
        private void ListaVentas()
        {

            try
            {
                DgMostrarVentasRealizadas.DataSource = new BindingList<Detalle_Venta>();               
            }
            catch (Exception)
            {
                MessageBox.Show("NO SE PUEDE CARGAR LISTA");
            }

        }
    }
}

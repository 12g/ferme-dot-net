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
using System.IO;
using ServiciosConexionFerme;

namespace AppPrincipal
{
    public partial class FormularioMantenedorOrdenCompra : Form
    {
        Validaciones val = new Validaciones();

        public FormularioMantenedorOrdenCompra()
        {
            InitializeComponent();
            ListaOrdenC();
        }

        private void ListaOrdenC()
        {
            List<DetalleOrdenCompra> lista;
            DgListadoProductoOC.DataSource = new List<DetalleOrdenCompra>();

            this.DgListadoProductoOC.Columns["idDetalleOrdenCompra"].Visible = false;
            this.DgListadoProductoOC.Columns["idOrdenCompra"].Visible = false;
            this.DgListadoProductoOC.Columns["idProducto"].Visible = false;

            this.DgListadoProductoOC.Columns["codigoProducto"].DisplayIndex = 0;
            this.DgListadoProductoOC.Columns["nombreProducto"].DisplayIndex = 1;
            this.DgListadoProductoOC.Columns["cantidadProducto"].DisplayIndex = 2;


            //DA NOMBRE A LAS COLUMNAS
            this.DgListadoProductoOC.Columns["codigoProducto"].HeaderText = "CODIGO";
            this.DgListadoProductoOC.Columns["cantidadProducto"].HeaderText = "CANTIDAD";
            this.DgListadoProductoOC.Columns["nombreProducto"].HeaderText = "NOMBRE PRODUCTO";
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            TxtNumero.Text = "";
            DPfechaInicio.Value = DateTime.Now;
            DPfechaTermino.Value = DateTime.Now;
            TxtIdProducto.Text = "";
            TxtCodProducto.Text = "";
            TxtNombreProducto.Text = "";
            TxtCantidad.Text = "";
            TxtEstado.Text = "";

            if (CbEmpleado.Items.Count > 1)
            {
                CbEmpleado.SelectedIndex = -1;
                CbEmpleado.Text = "Seleccione";
            }

        }
        
        //BOTON GUARDAR ORDEN COMPRA
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtNumero.Text == "" || Convert.ToInt32(TxtNumero.Text) < 1 || !val.IsNumeric(TxtNumero.Text))
                {

                    MessageBox.Show("INGRESE UN NUMERO DE ORDEN DE COMPRA");
                }
                //Comparar fechas
                else if (DPfechaInicio.Value.Date > DPfechaTermino.Value.Date)
                {
                    MessageBox.Show("La fecha TERMINO no puede ser menor a la fecha INICIO");
                }
                else if (CbEmpleado.SelectedIndex.Equals(-1))
                {
                    MessageBox.Show("SELECCIONE UN EMPLEADO");
                }
                else
                {
                    ServicioOrdenCompra ser = new ServicioOrdenCompra();
                    DetalleOrdenCompra det = new DetalleOrdenCompra();
                    Orden_Compra oc = new Orden_Compra();

                    oc.idEmpleado = CbEmpleado.SelectedIndex;
                    oc.fechaSolicitudOrdenCompra = DPfechaInicio.ToString();
                    oc.fechaRecepcionOrdenCompra = DPfechaTermino.ToString();



                    /* foreach (DataGridViewRow row in DgListadoProductoOC.Rows)
                     {


                         det.idProducto = int.Parse(DgListadoProductoOC[0, row.Index].Value.ToString());
                         //descripcion = DgListadoProductoOC[1, row.Index].Value.ToString();
                         det.cantidadProducto = int.Parse(DgListadoProductoOC[2, row.Index].Value.ToString());

                     }

                    List<DetalleOrdenCompra> lista;

                    lista = (List<DetalleOrdenCompra>)DgListadoProductoOC.DataSource;
                    oc.detallesOrdenCompra = lista;
                    //ser.subdetalleOrdenCompra(oc);
                    ser.CrearOrdenCompra(oc);
                    //ser.CrearOrdenCompra(det);*/



                    Limpiar();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("ERROR AL GUARDAR ORDEN DE COMPRA");
              
            }
          
        }

        //LIMPIAR
        private void Limpiar()
        {
            BtnEditar.Enabled = false;
            BtnBorrar.Enabled = false;
            TxtCodProducto.Text = "";
            TxtNombreProducto.Text = "";
            TxtCantidad.Text = "";
            TxtEstado.Text = "";
        }
        //BOTON AGREGAR
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
          
           try
            {
                if (TxtCantidad.Text == "" || Convert.ToInt32(TxtCantidad.Text) < 1 || !val.IsNumeric(TxtCantidad.Text))
                {
                    LblCantidadObligatoria.Visible = true;
                    MessageBox.Show("INGRESE UNA CANTIDAD EN PRODUCTO");
                }
                else if (TxtCodProducto.Text == "" || TxtNombreProducto.Text == "")
                {
                    MessageBox.Show("INGRESE UN PRODUCTO");
                }
                else
                {
                   try
                    {
                        List<DetalleOrdenCompra> detalle;
                        detalle = (List<DetalleOrdenCompra>)DgListadoProductoOC.DataSource;
                        //DgListadoProductoOC.Rows.Add(TxtCodProducto.Text, TxtNombreProducto.Text, TxtCantidad.Text);
                        //Limpiar();
                        DetalleOrdenCompra det = new DetalleOrdenCompra();
                        det.idProducto = int.Parse(TxtIdProducto.Text);
                        det.codigoProducto = long.Parse(TxtCodProducto.Text);
                        det.nombreProducto = TxtNombreProducto.Text;
                        det.cantidadProducto = int.Parse(TxtCantidad.Text);

                        DgListadoProductoOC.DataSource = det.idProducto;




                    }
                    catch (Exception)
                    {

                        MessageBox.Show("ERROR AL AGREGAR PRODUCTOS A LA LISTA");
                    }

                }
            }
            catch (Exception)
            {

                MessageBox.Show("ERROR AL AGREGAR PRODUCTO");
            }
          
        }

        //TXTNUMERO EVENTO LEAVE EL CUAL SE EJECUTA UN LEAVE EN CASO DE NO CUMPLIR CON LA CONDICION DADA
        private void TxtNumero_Leave(object sender, EventArgs e)
        {
            if (TxtNumero.Text == "" || Convert.ToInt32(TxtNumero.Text) < 1 || !val.IsNumeric(TxtNumero.Text))
            {
               
                MessageBox.Show("INGRESE UN NUMERO EN CAMPO NUMERO");
            }
           
        }

        //SE LLAMA AL EVENTO QUE VALIDA QUE INGRESEN SOLAMENTE NUMEROS
        private void TxtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.SoloNumero(e);
        }

        //SE LLAMA AL EVENTO QUE VALIDA QUE SE INGRESEN SOLAMENTE NUMEROS
        private void TxtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.SoloNumero(e);
        }

        private void LblCantidadObligatoria_Leave(object sender, EventArgs e)
        {
            if (TxtCantidad.Text =="" || Convert.ToInt32(TxtCantidad.Text) < 1 || !val.IsNumeric(TxtCantidad.Text))
            {
                LblCantidadObligatoria.Visible = true;
            }
            else
            {
                LblCantidadObligatoria.Visible = false;
            }
        }

        //BOTON BUSCAR PRODUCTO , EL CUAL ME REDIRIGE AL FORMULARIO BUSCAR PRODUCTO
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            FormularioBuscarProducto fbp = new FormularioBuscarProducto(this);
            fbp.ShowDialog();
        }

      
        private void FormularioMantenedorOrdenCompra_Load(object sender, EventArgs e)
        {
            ServicioEmpleado sere = new ServicioEmpleado();
            CbEmpleado.DataSource = sere.ListaEmpleados();
            CbEmpleado.DisplayMember = "nombreCompletoPersona";
            CbEmpleado.ValueMember = "idEmpleado";

            if (CbEmpleado.Items.Count > 1)
            {
                CbEmpleado.SelectedIndex = -1;
                CbEmpleado.Text = "Seleccione";
            }
        }


        //SELECCIONA UNA FILA Y LA ENVIA DIRECTO AL TEXTBOX PARA SER EDITADA
        private void DgListadoProductoOC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int poc = DgListadoProductoOC.CurrentRow.Index;
                TxtCodProducto.Text = DgListadoProductoOC[0, poc].Value.ToString();
                TxtNombreProducto.Text = DgListadoProductoOC[1, poc].Value.ToString();
                TxtCantidad.Text = DgListadoProductoOC[2, poc].Value.ToString();

                BtnAgregar.Enabled = false;
                BtnEditar.Enabled = true;
                BtnBorrar.Enabled = true;
            }
            catch (Exception)
            {

                MessageBox.Show("SELECCION INVALIDA");
            }
            
        }


        //BOTON EDITAR
        private void BtnEditar_Click(object sender, EventArgs e)
        {

            try
            {
                if (TxtCantidad.Text == "" || Convert.ToInt32(TxtCantidad.Text) <= 1 || !val.IsNumeric(TxtCantidad.Text))
                {
                    LblCantidadObligatoria.Visible = true;
                    MessageBox.Show("INGRESE UNA CANTIDAD EN PRODUCTO");
                }
                else if (TxtCodProducto.Text == "" || TxtNombreProducto.Text == "")
                {
                    MessageBox.Show("INGRESE UN PRODUCTO");
                }
                else
                {
                    try
                    {
                        int poc = DgListadoProductoOC.CurrentRow.Index;
                        DgListadoProductoOC[0, poc].Value = TxtCodProducto.Text;
                        DgListadoProductoOC[1, poc].Value = TxtNombreProducto.Text;
                        DgListadoProductoOC[2, poc].Value = TxtCantidad.Text;

                        Limpiar();
                        BtnAgregar.Enabled = true;
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("NO SE PUEDE AGREGAR PRODUCTOS A LA LISTA");
                    }

                }
            }
            catch (Exception)
            {

                MessageBox.Show("ERROR AL AGREGAR PRODUCTO");
            }
        }

        //BOTON ELIMINAR
        private void BtnBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                int poc = DgListadoProductoOC.CurrentRow.Index;
                DgListadoProductoOC.Rows.RemoveAt(poc);
                Limpiar();
                BtnAgregar.Enabled = true;
            }
            catch (Exception)
            {

                MessageBox.Show("ERROR AL ELIMINAR PRODUCTO");
            }
           
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnBuscarOrdenCompra_Click(object sender, EventArgs e)
        {
            FormularioBuscarOrdenCompra frm = new FormularioBuscarOrdenCompra(this);
            frm.ShowDialog();
        }
    }
}

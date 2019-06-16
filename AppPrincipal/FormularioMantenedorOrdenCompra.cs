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
using System.Reflection;


namespace AppPrincipal
{
    public partial class FormularioMantenedorOrdenCompra : Form
    {
        Validaciones val = new Validaciones();


        public FormularioMantenedorOrdenCompra()
        {
            InitializeComponent();
            CargarCbEstado();
            NumCorrelativo();

        }


        public class CargarCombobox
        {
            public string Nombre;
            public string Id;

            public CargarCombobox()
            {
            }

            public CargarCombobox(string nombre, string id)
            {
                Nombre = "";
                Id = "";
            }
            public override string ToString()
            {
                return Id;
            }
        }

        private void CargarCbEstado()
        {

            try
            {
                CbEstado.DataSource = null;

                List<CargarCombobox> lista = new List<CargarCombobox>();
                lista.Add(new CargarCombobox() { Nombre = "SOLICITADO", Id = "S" });
                lista.Add(new CargarCombobox() { Nombre = "ANULADO", Id = "A" });

                CbEstado.DataSource = lista;

                if (CbEstado.Items.Count > 0)
                {
                    CbEstado.SelectedIndex = 0;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR AL CARGAR TIPO DOCUMENTO");
            }
        }

        private void NumCorrelativo()
        {
            Random rnd = new Random(Guid.NewGuid().GetHashCode());
            TxtNumero.Text = Convert.ToString(rnd.Next(0,1000));    
        }

        private void ListaOrdenC()
        {

            try
            {
                BindingList<DetalleOrdenCompra> lista;

                DgListadoProductoOC.DataSource = new BindingList<DetalleOrdenCompra>();
            }
            catch (Exception)
            {
                MessageBox.Show("NO SE PUEDE CARGAR LISTA");
            }
           
        }

        private void LimpiarPantalla()
        {
            try
            {
      
                DPfechaInicio.Value = DateTime.Now;
                DPfechaTermino.Value = DateTime.Now;
                TxtIdProducto.Text = "";
                TxtCodProducto.Text = "";
                TxtNombreProducto.Text = "";
                TxtCantidad.Text = "";


                BtnAgregar.Enabled = true;
                BtnBorrar.Enabled = false;
                BtnEditar.Enabled = false;

                DgListadoProductoOC.Rows.Clear();
                DgListadoProductoOC.Refresh();
                NumCorrelativo();

                if (CbEmpleado.Items.Count > 1)
                {
                    CbEmpleado.SelectedIndex = -1;
                    CbEmpleado.Text = "Seleccione";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR AL LIMPIAR PANTALLA");
            }
        }

        
        private void BtnCancelar_Click(object sender, EventArgs e)
           {

            try
            {
                LimpiarPantalla();
            }
            catch (Exception)
            {

                MessageBox.Show("ERROR AL GENERAR UNA ORDEN DE COMPRA");
            }
        }

        private void fechaInicio()
        {
            DPfechaInicio.Format = DateTimePickerFormat.Custom;
            // Display the date as "Mon 26 Feb 2001".
            DPfechaInicio.CustomFormat = "dd/MM/yyyy";
        }

        private void FechaTermino()
        {
            DPfechaTermino.Format = DateTimePickerFormat.Custom;
            // Display the date as "Mon 26 Feb 2001".
            DPfechaTermino.CustomFormat = "dd/MM/yyyy";
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

                    oc.idOrdenCompra = int.Parse(TxtNumero.Text);
                    oc.estadoOrdenCompra = Convert.ToString(CbEstado.Text);
                    oc.idEmpleado = Convert.ToInt32(CbEmpleado.SelectedValue) ;
                    oc.fechaSolicitudOrdenCompra = DPfechaInicio.Text;
                    oc.fechaRecepcionOrdenCompra = DPfechaTermino.Text;

                foreach (DataGridViewRow row in DgListadoProductoOC.Rows)
                     {

                         det.idDetalleOrdenCompra = Convert.ToInt32(DgListadoProductoOC[0, row.Index].Value.ToString());
                         det.idOrdenCompra = Convert.ToInt32(DgListadoProductoOC[1, row.Index].Value.ToString());
                         det.idProducto = Convert.ToInt32(DgListadoProductoOC[2, row.Index].Value.ToString());
                         det.codigoProducto = long.Parse(DgListadoProductoOC[3, row.Index].Value.ToString());
                         det.nombreProducto = DgListadoProductoOC[4, row.Index].Value.ToString();
                         det.cantidadProducto = Convert.ToInt32(DgListadoProductoOC[5, row.Index].Value.ToString());

                     }

                    BindingList<DetalleOrdenCompra> lista;

                    lista = (BindingList<DetalleOrdenCompra>)DgListadoProductoOC.DataSource;
                    oc.detallesOrdenCompra = lista.ToList();
                   
                    ser.CrearOrdenCompra(oc);

                   


                    LimpiarPantalla();
                    MessageBox.Show("REGISTRO SE HA GUARDADO EXITOSAMENTE");
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
        }
        //BOTON AGREGAR
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
          
           try
            {
                if (TxtCantidad.Text == "" || Convert.ToInt32(TxtCantidad.Text) < 0 || !val.IsNumeric(TxtCantidad.Text))
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
                        BindingList<DetalleOrdenCompra> detalle;
                        detalle = (BindingList<DetalleOrdenCompra>)DgListadoProductoOC.DataSource;
                        //DgListadoProductoOC.Rows.Add(TxtCodProducto.Text, TxtNombreProducto.Text, TxtCantidad.Text);
                        //Limpiar();
                    
                        DetalleOrdenCompra det = new DetalleOrdenCompra();
                        det.idDetalleOrdenCompra = int.Parse(TxtNumero.Text);
                        det.idOrdenCompra = int.Parse(TxtNumero.Text);
                        det.idProducto = int.Parse(TxtIdProducto.Text);
                        det.codigoProducto = long.Parse(TxtCodProducto.Text);
                        det.nombreProducto = TxtNombreProducto.Text;
                        det.cantidadProducto = int.Parse(TxtCantidad.Text);

                        detalle.Add(det);
                        Console.WriteLine(detalle.ToString());
                        DgListadoProductoOC.DataSource = null;
                        DgListadoProductoOC.DataSource = detalle;
                        DgListadoProductoOC.Refresh();
                        
                        Limpiar();
                    }
                    catch (Exception ex)
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
            try
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

                BtnAgregar.Enabled = true;
                BtnBorrar.Enabled = false;
                BtnEditar.Enabled = false;
                fechaInicio();
                FechaTermino();
                ListaOrdenC();
            }
            catch (Exception)
            {
                MessageBox.Show("NO SE PUEDE CARGAR EMPLEADOS");
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
                MessageBox.Show("ERROR AL SELECCIONAR FILA");
            }

        }

        //ENUMERA LAS FILAS EN EL DATAGRIDVIEW AL INGRESAR PRODUCTOS
        private void DgListadoProductoOC_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DataGridView gridView = sender as DataGridView;
            if (null != gridView)
            {
                foreach (DataGridViewRow r in gridView.Rows)
                {
                    gridView.Rows[r.Index].HeaderCell.Value = (r.Index + 1).ToString();
                }
            }
        }
    }
}

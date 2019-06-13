using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca;
using ServiciosConexionFerme;

namespace AppPrincipal
{
    public partial class FromularioVentas : Form
    {
        public FromularioVentas()
        {
            InitializeComponent();
        }

        public class CargarCombobox
        {
            public string Nombre;
            public string Value;

            public  CargarCombobox(string nombre, string value)
            {
                Nombre = nombre;
                Value = value;
            }
            public override string ToString()
            {
                return Nombre;
            }
        }

       

        //CARGA DATOS EN COMBOBOX TIPO DOCTO
        private void CargarComboBoxTipoDocto()
        {
            try
            {
                CbTipoDocto.Items.Add(new CargarCombobox("Boleta","B"));
                CbTipoDocto.Items.Add(new CargarCombobox("Factura","F"));

                if (CbTipoDocto.Items.Count > 0)
                {
                    CbTipoDocto.SelectedIndex = 0;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR AL CARGAR TIPO DOCUMENTO");
            }
        }

        //CARGAR LISTADO 
        private void ListaOrdenC()
        {
            try
            {
                BindingList<Detalle_Venta> lista;

                DgVentaProducto.DataSource = new BindingList<Detalle_Venta>();
            }
            catch (Exception)
            {
                MessageBox.Show("NO SE PUEDE CARGAR LISTA");
            }

        }

        private void fechaInicio()
        {
            DpFecha.Format = DateTimePickerFormat.Custom;
            // Display the date as "Mon 26 Feb 2001".
            DpFecha.CustomFormat = "dd/MM/yyyy";
        }

        private void FromularioVentas_Load(object sender, EventArgs e)
        {
            fechaInicio();

            CargarCbEmpleado();
            TxtSubtotal.Text = "0";
            TxtIva.Text = "0";
            TxtTotal.Text = "0";
            ListaOrdenC();
            CargarComboBoxTipoDocto();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            FormularioPrincipal fm = new FormularioPrincipal();
            fm.BtnVentas = sender as Button;

            fm.BtnVentas.BackColor = Color.FromArgb(128, 0, 0);

            this.Close();
        }

        private void BtnBuscarProducto_Click(object sender, EventArgs e)
        {
            FormularioBuscarProducto fbp = new FormularioBuscarProducto(this);
            fbp.ShowDialog();
        }

        //limpias el campo de codigo , nombre y cantidad de producto
        private void Limpiar()
        {
            TxtCodigo.Text = "";
            TxtCantidad.Text = "";
            TxtNombreProducto.Text = "";
            TxtPrecio.Text = "";
        }

        //AGREGAR PRODUCTO AL DATAGRIDVIEW
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
           /* Validaciones val = new Validaciones();
            try
            {
                if (TxtCantidad.Text == "" || Convert.ToInt32(TxtCantidad.Text) < 1 || !val.IsNumeric(TxtCantidad.Text))
                {
                    LblCantidadObligatoria.Visible = true;
                    MessageBox.Show("INGRESE UNA CANTIDAD EN PRODUCTO");
                }
                else if (TxtCodigo.Text == "" || TxtNombreProducto.Text == "" || TxtPrecio.Text == "")
                {
                    MessageBox.Show("INGRESE UN PRODUCTO");
                }
                else
                {
                    try
                    {*/
                        BindingList<Detalle_Venta> detalle;
                        detalle = (BindingList<Detalle_Venta>)DgVentaProducto.DataSource;

                        Detalle_Venta vent = new Detalle_Venta();
                        vent.idDetalleVenta = int.Parse(TxtNumeroDocumento.Text);
                        vent.idProducto = int.Parse(TxtIdProducto.Text);
                        vent.idVenta = int.Parse(TxtNumeroDocumento.Text);
                        vent.codigoProducto = long.Parse(TxtCodigo.Text);
                        vent.nombreProducto = TxtNombreProducto.Text;
                        vent.unidadesProducto = int.Parse(TxtCantidad.Text);
                        vent.montoDetalleVenta = int.Parse(TxtPrecio.Text);
                        vent.Subtotal = int.Parse(TxtPrecio.Text);

                        detalle.Add(vent);
                        Console.WriteLine(detalle.ToString());
                        DgVentaProducto.DataSource = null;
                        DgVentaProducto.DataSource = detalle;
                        DgVentaProducto.Refresh();


                        cantidadprecio();

                        Limpiar();
                        BtnAgregar.Enabled = true;
                        BtnBorrar.Enabled = false;
                        BtnEditar.Enabled = false;

                        Limpiar();/*
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("ERROR AL AGREGAR PRODUCTOS A LA LISTA");
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR AL AGREGAR PRODUCTOS A LA LISTA");
            }*/
          
        }
        //BOTON EDITAR PRODUCTO
        private void BtnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                Validaciones val = new Validaciones();

                if (TxtCantidad.Text == "" || Convert.ToInt32(TxtCantidad.Text) < 1 || !val.IsNumeric(TxtCantidad.Text))
                {
                    LblCantidadObligatoria.Visible = true;
                    MessageBox.Show("INGRESE UNA CANTIDAD EN PRODUCTO");
                }
                else if (TxtCodigo.Text == "" || TxtNombreProducto.Text == "")
                {
                    MessageBox.Show("INGRESE UN PRODUCTO");
                }
                else
                {
                    try
                    {
                        int poc = DgVentaProducto.CurrentRow.Index;
                        DgVentaProducto[0, poc].Value = TxtCodigo.Text;
                        DgVentaProducto[1, poc].Value = TxtNombreProducto.Text;
                        DgVentaProducto[2, poc].Value = TxtCantidad.Text;
                        DgVentaProducto[3,poc].Value = TxtPrecio.Text;

                        cantidadprecio();

                        Limpiar();
                        BtnAgregar.Enabled = true;
                        BtnBorrar.Enabled = false;
                        BtnEditar.Enabled = false;
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

        private void BtnBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                int poc = DgVentaProducto.CurrentRow.Index;
                DgVentaProducto.Rows.RemoveAt(poc);
                cantidadprecio();

                Limpiar();
                BtnAgregar.Enabled = true;
                MessageBox.Show("PRODUCTO BORRADO");
            }
            catch (Exception)
            {

                MessageBox.Show("ERROR AL ELIMINAR PRODUCTO");
            }
        }

        private void DgVentaProducto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int poc = DgVentaProducto.CurrentRow.Index;

                TxtCodigo.Text = DgVentaProducto[0, poc].Value.ToString();
                TxtNombreProducto.Text = DgVentaProducto[1, poc].Value.ToString();
                TxtCantidad.Text = DgVentaProducto[2, poc].Value.ToString();
                TxtPrecio.Text = DgVentaProducto[3, poc].Value.ToString();

                BtnAgregar.Enabled = false;
                BtnEditar.Enabled = true;
                BtnBorrar.Enabled = true;
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR AL SELECCIONAR FILA");
            }
           
        }

        private void BtnCliente_Click(object sender, EventArgs e)
        {
            FormularioBuscarCliente frm = new FormularioBuscarCliente(this);
            frm.ShowDialog();
        }



        //CALCULA EL SUBTOTAL Y EL TOTAL AL AGREGAR UN PRODUCTO 
        private void cantidadprecio()
        {
            try
            {
                //MULTIPLICA LA CANTIDAD * PRECIO
                for (int i = 0; i < DgVentaProducto.Rows.Count; i++)
                {
                    int num1 = int.Parse(Convert.ToString(DgVentaProducto.Rows[i].Cells[5].Value));
                    int num2 = int.Parse(Convert.ToString(DgVentaProducto.Rows[i].Cells[6].Value));
                    DgVentaProducto.Rows[i].Cells[7].Value = num1 * num2;
                }



                //SUMA LA  COLUMNA SUBTOTAL Y LA MUESTRA EN EL TXTSUBTOTAL
                int suma = 0;

                foreach (DataGridViewRow row in DgVentaProducto.Rows)
                {
                    if (row.Cells[7].Value == DBNull.Value)
                        continue;

                    int valorcell = 0;
                    int.TryParse(Convert.ToString(row.Cells[7].Value), out valorcell);

                    suma += Convert.ToInt32(valorcell);
                }

                TxtSubtotal.Text = Convert.ToString(suma);
                TxtIva.Text = Convert.ToString(suma * 19 / 100);
                TxtTotal.Text = Convert.ToString(suma * 19 / 100 + suma);
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR AL CALCULAR EL NETO,IVA Y TOTAL");
            }
           
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            FormularioBuscarVenta fbv = new FormularioBuscarVenta(this);
            fbv.ShowDialog();
        }

        //CARGA EL COMBOBOX EMPLEADO
        private void CargarCbEmpleado()
        {
            try
            {
                ServicioEmpleado see = new ServicioEmpleado();
                CbEmpleado.DataSource = see.ListaEmpleados();
                CbEmpleado.DisplayMember = "nombreCompletoPersona";
                CbEmpleado.ValueMember = "idEmpleado";

                if (CbEmpleado.Items.Count > 1)
                {
                    CbEmpleado.SelectedIndex = -1;
                    CbEmpleado.Text = "Seleccione";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("NO HAY DATOS DE EMPLEADOS");
            }
           
        }

        //ENUMERA LAS FILAS EN EL DATAGRIDVIEW AL INGRESAR PRODUCTOS
        private void DgVentaProducto_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
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

        private void LimpiarPantall()
        {
            try
            {
                TxtIdProducto.Text = "";
                TxtCantidad.Text = "";
                TxtCodigo.Text = "";
                DpFecha.Text = DateTime.Now.ToShortDateString();
                TxtIva.Text = "";
                TxtNombreProducto.Text = "";
                TxtNombreRazonSocial.Text = "";
                TxtNumeroDocumento.Text = "";
                TxtPrecio.Text = "";
                TxtRut.Text = "";
                TxtSubtotal.Text = "";
                TxtTotal.Text = "";

                if (CbEmpleado.Items.Count > 1)
                {
                    CbEmpleado.SelectedIndex = -1;
                    CbEmpleado.Text = "Seleccione";
                }


                CbTipoDocto.Items.Add(new CargarCombobox("Boleta", "B"));
                CbTipoDocto.Items.Add(new CargarCombobox("Factura", "F"));

                if (CbTipoDocto.Items.Count > 0)
                {
                    CbTipoDocto.SelectedIndex = 0;
                }

                DgVentaProducto.Rows.Clear();
                DgVentaProducto.Refresh();
            }
            catch (Exception)
            {

                MessageBox.Show("ERROR");
            }
        }

        //BOTON NUEVA VENTA
        private void BtnNuevVenta_Click(object sender, EventArgs e)
        {
            LimpiarPantall();
        }


        //BOTON IMPRIMIR
        private void BtnImprimir_Click(object sender, EventArgs e)
        {
            /*try
            {
                if (TxtNumeroDocumento.Text == "")
                {
                    MessageBox.Show("INGRESE UN NUMERO DE DOCUMENTO");
                }
                else if (TxtNumeroDocumento.Text.Length < 0)
                {
                    MessageBox.Show("NUMERO DEBE SER MAYOR A CERO 0");
                }
                else if (TxtRut.Text == "" || TxtNombreRazonSocial.Text == "")
                {
                    MessageBox.Show("SELECCIONE UN CLIENTE");
                }
                else if (CbEmpleado.SelectedIndex.Equals(-1))
                {
                    MessageBox.Show("SELECCIONE UN EMPLEADO");
                }
                else
                {*/

                    ServicioVentas serVent = new ServicioVentas();
                    Detalle_Venta det = new Detalle_Venta();
                    Venta vent = new Venta();

                    vent.idVenta = int.Parse(TxtNumeroDocumento.Text);
                    vent.tipoVenta = CbTipoDocto.SelectedText;
                    vent.idEmpleado = Convert.ToInt32(CbEmpleado.SelectedValue);
                    vent.idCliente = int.Parse(TxtIdCliente.Text); ;
                    vent.fechaVenta = DpFecha.Text;
                    vent.subtotalVenta = int.Parse(TxtTotal.Text);

                    foreach (DataGridViewRow row in DgVentaProducto.Rows)
                    {

                        det.idDetalleVenta = Convert.ToInt32(DgVentaProducto[0, row.Index].Value.ToString());
                        det.idProducto = Convert.ToInt32(DgVentaProducto[1, row.Index].Value.ToString());
                        det.idVenta = Convert.ToInt32(DgVentaProducto[2, row.Index].Value.ToString());
                        det.codigoProducto = long.Parse(DgVentaProducto[3, row.Index].Value.ToString());
                        det.nombreProducto = DgVentaProducto[4, row.Index].Value.ToString();
                        det.unidadesProducto = Convert.ToInt32(DgVentaProducto[5, row.Index].Value.ToString());
                        det.montoDetalleVenta = Convert.ToInt32(DgVentaProducto[6, row.Index].Value.ToString());

                    }

                    BindingList<Detalle_Venta> lista;

                    lista = (BindingList<Detalle_Venta>)DgVentaProducto.DataSource;
                    vent.detallesVenta = lista.ToList();

                    serVent.CrearVenta(vent);
                    LimpiarPantall();
               /* }
            }
            catch (Exception)
            {

                MessageBox.Show("ERROR");
            }*/
          
        }


        private void ListaVentaDet()
        {

            try
            {
                BindingList<Detalle_Venta> lista;

                DgVentaProducto.DataSource = new BindingList<Detalle_Venta>();
            }
            catch (Exception)
            {
                MessageBox.Show("NO SE PUEDE CARGAR LISTA");
            }

        }


        //LLAMA AL METODO EL CUAL VALIDA QUE SE INGRESE SOLO NUMEROS
        private void TxtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones val = new Validaciones();
            val.SoloNumero(e);
        }

        //LLAMA AL METODO EL CUAL VALIDA QUE SE INGRESE SOLO NUMEROS
        private void TxtNumeroDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones val = new Validaciones();
            val.SoloNumero(e);
        }

        private void TxtCantidad_Leave(object sender, EventArgs e)
        {
            Validaciones val = new Validaciones();

            if (TxtCantidad.Text == "" || Convert.ToInt32(TxtCantidad.Text) < 0 || !val.IsNumeric(TxtCantidad.Text))
            {
                LblCantidadObligatoria.Visible = true;
            }
            else
            {
                LblCantidadObligatoria.Visible = false;
            }
        }
    }
}

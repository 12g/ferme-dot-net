﻿using System;
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
        private int indicefilaseleccionada;
        public List<Detalle_Venta> detalleVen;
        public List<DetalleVentaVista> detallevv;
        int x = 200;

        public FromularioVentas()
        {
            

            InitializeComponent();
            CargarCbEmpleado();
            NumeroCorrelativo();
        }

        private void NumeroCorrelativo()
        {
            
            x++;
            TxtNumeroDocumento.Text = x.ToString();
        }

        //CARGAR LISTADO 
        private void ListaVentas()
        {
            try
            {
                BindingList<DetalleVentaVista> lista = new BindingList<DetalleVentaVista>();

                DgVentaProducto.DataSource = lista;
                //
                detalleVen = new List<Detalle_Venta>();
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
            ListaVentas();
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
            Validaciones val = new Validaciones();
            
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
                    {
                    
                        BindingList<DetalleVentaVista> detalle;
                        detalle = (BindingList<DetalleVentaVista>)DgVentaProducto.DataSource;

                        DetalleVentaVista vv = new DetalleVentaVista();

                        vv.CODIGO = TxtCodigo.Text;
                        vv.NOMBRE = TxtNombreProducto.Text;
                        vv.CANTIDAD = int.Parse(TxtCantidad.Text);
                        vv.MONTO = int.Parse(TxtPrecio.Text);
                        vv.SUBTOTAL = vv.MONTO * vv.CANTIDAD;

                        detalle.Add(vv);


                        Detalle_Venta dv = new Detalle_Venta();

                        dv.idProducto = int.Parse(TxtIdProducto.Text);
                        dv.codigoProducto = TxtCodigo.Text;
                        dv.nombreProducto = TxtNombreProducto.Text;
                        dv.unidadesProducto = int.Parse(TxtCantidad.Text);
                        dv.montoDetalleVenta = int.Parse(TxtPrecio.Text);
                        dv.Subtotal = dv.montoDetalleVenta * dv.unidadesProducto;

                        
                        foreach (DataGridViewRow row in DgVentaProducto.Rows)
                        {
                            if (row.Cells["Subtotal"].Value != null) //1 es "Cantidad"
                                vv.SUBTOTAL += (Int32)row.Cells["Subtotal"].Value;
                        }

                        TxtSubtotal.Text = Convert.ToString(vv.SUBTOTAL);
                        TxtIva.Text = Convert.ToString(vv.SUBTOTAL * 19 / 100);
                        TxtTotal.Text = Convert.ToString(vv.SUBTOTAL * 19 / 100 + vv.SUBTOTAL);


                        detalleVen.Add(dv);
                        Console.WriteLine(detalle.ToString());
                        DgVentaProducto.DataSource = null;
                        DgVentaProducto.DataSource = detalle;
                        DgVentaProducto.Refresh();


                        Limpiar();
                        BtnAgregar.Enabled = true;
                        BtnBorrar.Enabled = false;
                        BtnEditar.Enabled = false;

                        Limpiar();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("ERROR AL AGREGAR PRODUCTOS A LA LISTA");
                    }  
                }
            }
           
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
                        DgVentaProducto[2, indicefilaseleccionada].Value = TxtCantidad.Text;

                        Detalle_Venta det = detalleVen.ElementAt<Detalle_Venta>(indicefilaseleccionada);
                        det.unidadesProducto = int.Parse(TxtCantidad.Text);

                       

                        
                        foreach (DataGridViewRow row in DgVentaProducto.Rows)
                        {
                            if (row.Cells["Subtotal"].Value != null) //1 es "Cantidad"
                                det.Subtotal += (Int32)row.Cells["Subtotal"].Value;
                        }

                        //CALCULA EL IVA Y EL TOTAL DE VENTAS
                        TxtSubtotal.Text = Convert.ToString(det.Subtotal);
                        TxtIva.Text = Convert.ToString(det.Subtotal * 19 / 100);
                        TxtTotal.Text = Convert.ToString(det.Subtotal * 19 / 100 + det.Subtotal);

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


        //BOTON BORRAR PRODUCTOS DEL DATAGRIDVIEW
        private void BtnBorrar_Click(object sender, EventArgs e)
        {
            try
            {

                int poc = DgVentaProducto.CurrentRow.Index;
                DgVentaProducto.Rows.RemoveAt(poc);

                Limpiar();
                BtnAgregar.Enabled = true;
                BtnBorrar.Enabled = false;
                BtnEditar.Enabled = false;
                
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
                indicefilaseleccionada = DgVentaProducto.CurrentRow.Index;

                TxtCodigo.Text = DgVentaProducto[0, indicefilaseleccionada].Value.ToString();
                TxtNombreProducto.Text = DgVentaProducto[1, indicefilaseleccionada].Value.ToString();
                TxtCantidad.Text = DgVentaProducto[2, indicefilaseleccionada].Value.ToString();
                TxtPrecio.Text = DgVentaProducto[3, indicefilaseleccionada].Value.ToString();

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
                    this.CbEmpleado.DropDownStyle = ComboBoxStyle.DropDownList;
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
                NumeroCorrelativo();

                TxtIdProducto.Text = "";
                TxtCantidad.Text = "";
                TxtCodigo.Text = "";
                DpFecha.Text = DateTime.Now.ToShortDateString();
                TxtIva.Text = "0";
                TxtNombreProducto.Text = "";
                TxtNombreRazonSocial.Text = "";
                TxtPrecio.Text = "0";
                TxtRut.Text = "";
                TxtSubtotal.Text = "0";
                TxtTotal.Text = "0";


                if (CbEmpleado.Items.Count > 1)
                {
                    CbEmpleado.SelectedIndex = -1;
                    CbEmpleado.Text = "Seleccione";
                    this.CbEmpleado.DropDownStyle = ComboBoxStyle.DropDownList;
                }

                CargarComboBoxTipoDocto();

                if (CbTipoDocto.Items.Count > 0)
                {
                    CbTipoDocto.SelectedIndex = 0;
                    this.CbTipoDocto.DropDownStyle = ComboBoxStyle.DropDownList;
                }

                BtnAgregar.Enabled = true;
                BtnBorrar.Enabled = false;
                BtnEditar.Enabled = false;

                DgVentaProducto.Rows.Clear();
                DgVentaProducto.Refresh();
            }
            catch (Exception)
            {

                MessageBox.Show("ERROR AL LIMPIAR");
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
             try
             {
                 if (TxtRut.Text == "" || TxtNombreRazonSocial.Text == "")
                 {
                     MessageBox.Show("SELECCIONE UN CLIENTE");
                 }
                 else if (CbEmpleado.SelectedIndex.Equals(-1))
                 {
                     MessageBox.Show("SELECCIONE UN EMPLEADO");
                 }
                 else
                 {
                 

                    ServicioVentas ser = new ServicioVentas();
                    Venta vent = new Venta();
                    vent.detalleventavista = null;
       
                    vent.idVenta = int.Parse(TxtNumeroDocumento.Text);
                    vent.idCliente = int.Parse(TxtIdCliente.Text);
                    vent.idEmpleado = Convert.ToInt32(CbEmpleado.SelectedValue);
                    vent.idCliente = int.Parse(TxtIdCliente.Text);
                    vent.fechaVenta = DpFecha.Text;
                    vent.tipoVenta = CbTipoDocto.Text;
                    vent.subtotalVenta = int.Parse(TxtTotal.Text);

                    vent.detallesVenta = detalleVen;

                    ser.CrearVenta(vent);
                    LimpiarPantall();
                    BtnAgregar.Enabled = true;
                    BtnBorrar.Enabled = false;
                    BtnEditar.Enabled = false;
                    MessageBox.Show("REGISTRO SE HA GUARDADO EXITOSAMENTE");
               }
             }

             catch (Exception)
             {

                MessageBox.Show("ERROR");
             }
          
        }


        private void ListaVentaDet()
        {
            try
            {
                BindingList<DetalleVentaVista> lista = new BindingList<DetalleVentaVista>();

                DgVentaProducto.DataSource = lista;
                //
                detalleVen = new List<Detalle_Venta>();
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



        //CARGA DATOS EN COMBOBOX TIPO DOCTO
        private void CargarComboBoxTipoDocto()
        {
            try
            {
                CbTipoDocto.DataSource = null;
                
                List<CargarCombobox> lista = new List<CargarCombobox>();
                lista.Add(new CargarCombobox() { Nombre = "Boleta", Id = "B" });
                lista.Add(new CargarCombobox() { Nombre = "Factura", Id = "F" });


                CbTipoDocto.DataSource = lista;

                if (CbTipoDocto.Items.Count > 0)
                {
                    CbTipoDocto.SelectedIndex = 0;
                    this.CbTipoDocto.DropDownStyle = ComboBoxStyle.DropDownList;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR AL CARGAR TIPO DOCUMENTO");
            }
        }
    }
}

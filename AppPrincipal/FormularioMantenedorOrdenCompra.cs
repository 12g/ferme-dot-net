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
            ServicioEmpleado sere = new ServicioEmpleado();
            CbEmpleado.DataSource = sere.ListaEmpleados();
            CbEmpleado.DisplayMember = "nombreCompletoPersona";
            CbEmpleado.ValueMember = "idEmpleado";
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
        
        //BOTON GUARDAR
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtNumero.Text == "" || Convert.ToInt32(TxtNumero.Text) < 1 || !val.IsNumeric(TxtNumero.Text))
                {
                    LblNumeroObligatorio.Visible = true;
                    MessageBox.Show("INGRESE UN NUMERO DE ORDEN DE COMPRA");
                }
                //Comparar fechas
                else if (DPfechaInicio.Value.Date > DPfechaTermino.Value.Date)
                {
                    MessageBox.Show("La fecha TERMINO no puede ser menor a la fecha INICIO");
                }
                else
                {
                    ServicioOrdenCompra ser = new ServicioOrdenCompra();
                    Orden_Compra oc = new Orden_Compra();

                    oc.idEmpleado = CbEmpleado.SelectedIndex;
                    oc.fechaSolicitudOrdenCompra = DPfechaInicio.ToString();
                    oc.fechaRecepcionOrdenCompra = DPfechaTermino.ToString();

                    foreach (DataGridViewRow row in DgListadoProductoOC.Rows)
                    {

                        string codigo;
                        string descripcion;
                        string cantidad;

                        codigo = DgListadoProductoOC[0, row.Index].Value.ToString();
                        descripcion = DgListadoProductoOC[1, row.Index].Value.ToString();
                        cantidad = DgListadoProductoOC[2, row.Index].Value.ToString();

                    }
                        ser.CrearOrdenCompra(oc);
                }
            }
            catch (Exception)
            {

                MessageBox.Show("ERROR AL GUARDAR ORDEN DE COMPRA");
                LblNumeroObligatorio.Visible = false;
            }
          
        }

        //LIMPIAR
        private void Limpiar()
        {
            TxtCodProducto.Text = "";
            TxtNombreProducto.Text = "";
            TxtCantidad.Text = "";
        }
        //BOTON AGREGAR
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (TxtCantidad.Text == "" || Convert.ToInt32(TxtCantidad.Text) < 1 || !val.IsNumeric(TxtCantidad.Text))
            {
                LblCantidadObligatoria.Visible = true;
                MessageBox.Show("INGRESE UNA CANTIDAD EN PRODUCTO");
            }
            else if (TxtCodProducto.Text == "" || TxtNombreProducto.Text =="")
            {
                MessageBox.Show("INGRESE UN PRODUCTO");
            }
            else
            {
                try
                {
                    DgListadoProductoOC.Rows.Add(TxtCodProducto.Text, TxtNombreProducto.Text, TxtCantidad.Text);
                    Limpiar();
                    LblCantidadObligatoria.Visible = false;
                }
                catch (Exception)
                {

                    MessageBox.Show("NO SE PUEDE AGREGAR PRODUCTOS A LA LISTA");
                }

            }
        }

        //TXTNUMERO EVENTO LEAVE EL CUAL SE EJECUTA UN LEAVE EN CASO DE NO CUMPLIR CON LA CONDICION DADA
        private void TxtNumero_Leave(object sender, EventArgs e)
        {
            if (TxtNumero.Text == "" || Convert.ToInt32(TxtNumero.Text) < 1 || !val.IsNumeric(TxtNumero.Text))
            {
                LblNumeroObligatorio.Visible = true;
                MessageBox.Show("INGRESE UN NUMERO EN CAMPO NUMERO");
            }
           
            else
            {
                LblNumeroObligatorio.Visible = false;
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
    }
}

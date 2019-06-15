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
    public partial class FormularioRecepcion : Form
    {
        Validaciones val = new Validaciones();
        public FormularioRecepcion()
        {
            InitializeComponent();
            CargarCbEstado();
            ListaOrdenC();
        }


        private void fechaInicio()
        {
            DpFechaCreacion.Format = DateTimePickerFormat.Custom;
            // Display the date as "Mon 26 Feb 2001".
            DpFechaCreacion.CustomFormat = "dd/MM/yyyy";
        }

        private void FechaTermino()
        {
            DpFechaRecepcion.Format = DateTimePickerFormat.Custom;
            // Display the date as "Mon 26 Feb 2001".
            DpFechaRecepcion.CustomFormat = "dd/MM/yyyy";
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
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
                CbxEstadoRecepcion.DataSource = null;

                List<CargarCombobox> lista = new List<CargarCombobox>();
                lista.Add(new CargarCombobox() { Nombre = "RECEPCIONADO", Id = "R" });
                lista.Add(new CargarCombobox() { Nombre = "RECHAZADO", Id = "RR" });

                CbxEstadoRecepcion.DataSource = lista;

                if (CbxEstadoRecepcion.Items.Count > 1)
                {
                    CbxEstadoRecepcion.SelectedIndex = -1;
                    CbxEstadoRecepcion.Text = "Seleccione";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR AL CARGAR TIPO DOCUMENTO");
            }
        }


        //BOTON NUEVA REDEPCION
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                TxtNumero.Text = "";
                DpFechaCreacion.Value = DateTime.Now;
                DpFechaRecepcion.Value = DateTime.Now;
                TxtEmpleado.Text = "";


                DgListadoRecepcion.Rows.Clear();
                DgListadoRecepcion.Refresh();

                if (CbxEstadoRecepcion.Items.Count > 1)
                {
                    CbxEstadoRecepcion.SelectedIndex = -1;
                    CbxEstadoRecepcion.Text = "Seleccione";
                }
            }
            catch (Exception)
            {

                MessageBox.Show("ERROR AL GENERAR UNA ORDEN DE COMPRA");
            }
        }

        private void BtnBuscarOrdenCompra_Click(object sender, EventArgs e)
        {
            FormularioBuscarOrdenCompra frm = new FormularioBuscarOrdenCompra(this);
            frm.ShowDialog();
        }

        private void ListaOrdenC()
        {

            try
            {
                BindingList<DetalleOrdenCompra> lista;

                DgListadoRecepcion.DataSource = new BindingList<DetalleOrdenCompra>();
            }
            catch (Exception)
            {
                MessageBox.Show("NO SE PUEDE CARGAR LISTA");
            }

        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtNumero.Text == "" || Convert.ToInt32(TxtNumero.Text) < 1 || !val.IsNumeric(TxtNumero.Text))
                {

                    MessageBox.Show("INGRESE UN NUMERO DE ORDEN DE COMPRA");
                }
                //Comparar fechas
                else if (DpFechaCreacion.Value.Date > DpFechaRecepcion.Value.Date)
                {
                    MessageBox.Show("La fecha TERMINO no puede ser menor a la fecha INICIO");
                }
                else
                {
                    ServicioOrdenCompra ser = new ServicioOrdenCompra();
                    DetalleOrdenCompra det = new DetalleOrdenCompra();
                    Orden_Compra oc = new Orden_Compra();

                    oc.idOrdenCompra = int.Parse(TxtNumero.Text);
                    oc.estadoOrdenCompra = Convert.ToString(CbxEstadoRecepcion.Text);
                    oc.idEmpleado = Convert.ToInt32(TxtEmpleado.Text);
                    oc.fechaSolicitudOrdenCompra = DpFechaCreacion.Text;
                    oc.fechaRecepcionOrdenCompra = DpFechaRecepcion.Text;

                    foreach (DataGridViewRow row in DgListadoRecepcion.Rows)
                    {

                        det.idDetalleOrdenCompra = Convert.ToInt32(DgListadoRecepcion[0, row.Index].Value.ToString());
                        det.idOrdenCompra = Convert.ToInt32(DgListadoRecepcion[1, row.Index].Value.ToString());
                        det.idProducto = Convert.ToInt32(DgListadoRecepcion[2, row.Index].Value.ToString());
                        det.codigoProducto = long.Parse(DgListadoRecepcion[3, row.Index].Value.ToString());
                        det.nombreProducto = DgListadoRecepcion[4, row.Index].Value.ToString();
                        det.cantidadProducto = Convert.ToInt32(DgListadoRecepcion[5, row.Index].Value.ToString());

                    }

                    BindingList<DetalleOrdenCompra> lista;

                    lista = (BindingList<DetalleOrdenCompra>)DgListadoRecepcion.DataSource;
                    oc.detallesOrdenCompra = lista.ToList();

                    ser.CrearOrdenCompra(oc);
                    LimpiarPantalla();
                    MessageBox.Show("REGISTRO SE HA GUARDADO EXITOSAMENTE");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("ERROR AL GUARDAR");
            }
        } 

        private void LimpiarPantalla()
        {
            try
            {
                DpFechaCreacion.Value = DateTime.Now;
                DpFechaRecepcion.Value = DateTime.Now;
                TxtEmpleado.Text = "";
                TxtNumero.Text = "";

                DgListadoRecepcion.Rows.Clear();
                DgListadoRecepcion.Refresh();

                if (CbxEstadoRecepcion.Items.Count > 1)
                {
                    CbxEstadoRecepcion.SelectedIndex = -1;
                    CbxEstadoRecepcion.Text = "Seleccione";
                }
            }
            catch (Exception)
            {

                MessageBox.Show("ERROR AL LIMPIAR");
            }

        }
    }
}

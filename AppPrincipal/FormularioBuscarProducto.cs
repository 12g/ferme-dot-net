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
    public partial class FormularioBuscarProducto : Form
    {
        private FormularioMantenedorOrdenCompra FrmOrdenCompra;
        private FromularioVentas FrmVentas;
        public FormularioBuscarProducto(FormularioMantenedorOrdenCompra parametro)
        {
            InitializeComponent();

            FrmOrdenCompra = parametro;
           try
            {
                ServicioProducto serp = new ServicioProducto();
                DgMostrarProductos.DataSource = serp.GetRESTData();

           //OCULTAR COLUMNA
            this.DgMostrarProductos.Columns["idProducto"].Visible = false;
            this.DgMostrarProductos.Columns["precioProducto"].Visible = false;
            this.DgMostrarProductos.Columns["stockActualProducto"].Visible = false;
            this.DgMostrarProductos.Columns["stockCriticoProducto"].Visible = false;
            this.DgMostrarProductos.Columns["idTipoProducto"].Visible = false;
            this.DgMostrarProductos.Columns["nombreTipoProducto"].Visible = false;
            this.DgMostrarProductos.Columns["idFamiliaProducto"].Visible = false;
            this.DgMostrarProductos.Columns["descripcionFamiliaProducto"].Visible = false;


            //DA NOMBRE A LAS COLUMNAS
            this.DgMostrarProductos.Columns["codigoProducto"].HeaderText = "CODIGO";
            this.DgMostrarProductos.Columns["nombreProducto"].HeaderText = "PRODUCTO";
          }
            catch (Exception)
            {
                MessageBox.Show("NO SE PUEDE CARGAR LISTADO DE PRODUCTOS");
            }

        }

        //BOTON CENCELAR BUSQUEDA DE PRODUCTO
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

        //SELECCIONAMOS UNA FILA Y LOS DATOS SE CARGAN EN EL FORMULARIO CORRESPONDIENTE
        private void DgMostrarProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                try
                {   
                    //LOS DATOS SE CARGAN EN EL FORMULARIO DE VENTAS 
                    FrmVentas.TxtIdProducto.Text = DgMostrarProductos.CurrentRow.Cells["idProducto"].Value.ToString();
                    FrmVentas.TxtCodigo.Text = DgMostrarProductos.CurrentRow.Cells["codigoProducto"].Value.ToString();
                    FrmVentas.TxtNombreProducto.Text = DgMostrarProductos.CurrentRow.Cells["nombreProducto"].Value.ToString();
                    FrmVentas.TxtPrecio.Text = DgMostrarProductos.CurrentRow.Cells["precioProducto"].Value.ToString();
                    this.Close();

                }
                catch (Exception)
                {
                    //LOS DATOS SE CARGAN EN EL FORMULARIO ORDEN DE COMPRA
                    FrmOrdenCompra.TxtIdProducto.Text = DgMostrarProductos.CurrentRow.Cells["idProducto"].Value.ToString();
                    FrmOrdenCompra.TxtCodProducto.Text = DgMostrarProductos.CurrentRow.Cells["codigoProducto"].Value.ToString();
                    FrmOrdenCompra.TxtNombreProducto.Text = DgMostrarProductos.CurrentRow.Cells["nombreProducto"].Value.ToString();
                    this.Close();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("ERROR AL AGREGAR PRODUCTO");
            }
           
        }


        //BUSCAR 
        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (TxtBuscar.Text != "")
            {
                DgMostrarProductos.CurrentCell = null;
                foreach (DataGridViewRow r in DgMostrarProductos.Rows)
                {
                    r.Visible = false;
                }
                foreach (DataGridViewRow r in DgMostrarProductos.Rows)
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
                ServicioProducto ser = new ServicioProducto();
                DgMostrarProductos.DataSource = ser.GetRESTData();
            }
        }

            //CARGA ESTE LISTADO EN FORMULARIO VENTAS
            public FormularioBuscarProducto(FromularioVentas parametro)
            {

                InitializeComponent();

                FrmVentas = parametro;
           
                try
                {
                    ServicioProducto serp = new ServicioProducto();
                    DgMostrarProductos.DataSource = serp.GetRESTData();
                //OCULTAR COLUMNA
                this.DgMostrarProductos.Columns["idProducto"].Visible = false;
                this.DgMostrarProductos.Columns["precioProducto"].Visible = false;
                this.DgMostrarProductos.Columns["stockActualProducto"].Visible = false;
                this.DgMostrarProductos.Columns["stockCriticoProducto"].Visible = false;
                this.DgMostrarProductos.Columns["idTipoProducto"].Visible = false;
                this.DgMostrarProductos.Columns["nombreTipoProducto"].Visible = false;
                this.DgMostrarProductos.Columns["idFamiliaProducto"].Visible = false;
                this.DgMostrarProductos.Columns["descripcionFamiliaProducto"].Visible = false;


                //DA NOMBRE A LAS COLUMNAS
                this.DgMostrarProductos.Columns["codigoProducto"].HeaderText = "CODIGO";
                this.DgMostrarProductos.Columns["nombreProducto"].HeaderText = "PRODUCTO";

            }
                catch (Exception)
                {
                    MessageBox.Show("NO SE PUEDE CARGAR LISTADO DE PRODUCTOS");
                }
            }
    }
}

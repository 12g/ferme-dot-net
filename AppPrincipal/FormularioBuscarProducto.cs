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
        public FormularioBuscarProducto(FormularioMantenedorOrdenCompra parametro)
        {
            InitializeComponent();

            FrmOrdenCompra = parametro;
            try
            {
                ServicioProducto serp = new ServicioProducto();
                DgMostrarProductos.DataSource = serp.GetRESTData();

                //OCULTAR COLUMNA
                this.DgMostrarProductos.Columns[0].Visible = false;
                this.DgMostrarProductos.Columns[6].Visible = false;
                this.DgMostrarProductos.Columns[8].Visible = false;

                //DA NOMBRE A LAS COLUMNAS
                this.DgMostrarProductos.Columns[1].HeaderText = "CODIGO";
                this.DgMostrarProductos.Columns[2].HeaderText = "PRODUCTO";
                this.DgMostrarProductos.Columns[3].HeaderText = "DESCRIPCION";
                this.DgMostrarProductos.Columns[4].HeaderText = "STOCK ACTUAL";
                this.DgMostrarProductos.Columns[5].HeaderText = "STOCK CRITICO";
                this.DgMostrarProductos.Columns[7].HeaderText = "TIPO PRODUCTO";
                //this.DgMostrarProductos.Columns[8].HeaderText = "PRECIO";
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


        private FormularioMantenedorOrdenCompra FrmOrdenCompra;
        private FromularioVentas FrmVentas;


        //SELECCIONAMOS UNA FILA Y LOS DATOS SE CARGAN EN EL FORMULARIO CORRESPONDIENTE
        private void DgMostrarProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                try
                {    //LOS DATOS SE CARGAN EN EL FORMULARIO DE VENTAS 
                    FrmVentas.TxtIdProducto.Text = DgMostrarProductos.CurrentRow.Cells[0].Value.ToString();
                    FrmVentas.TxtCodigo.Text = DgMostrarProductos.CurrentRow.Cells[1].Value.ToString();
                    FrmVentas.TxtNombreProducto.Text = DgMostrarProductos.CurrentRow.Cells[2].Value.ToString();
                    FrmVentas.TxtPrecio.Text = DgMostrarProductos.CurrentRow.Cells[8].Value.ToString();
                    this.Close();


                }
                catch (Exception)
                {
                    //LOS DATOS SE CARGAN EN EL FORMULARIO ORDEN DE COMPRA
                    FrmOrdenCompra.TxtIdProducto.Text = DgMostrarProductos.CurrentRow.Cells[0].Value.ToString();
                    FrmOrdenCompra.TxtCodProducto.Text = DgMostrarProductos.CurrentRow.Cells[1].Value.ToString();
                    FrmOrdenCompra.TxtNombreProducto.Text = DgMostrarProductos.CurrentRow.Cells[2].Value.ToString();
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
                    this.DgMostrarProductos.Columns[0].Visible = false;
                    this.DgMostrarProductos.Columns[6].Visible = false;
                    //this.DgMostrarProductos.Columns[8].Visible = false;

                    //DA NOMBRE A LAS COLUMNAS
                    this.DgMostrarProductos.Columns[1].HeaderText = "CODIGO";
                    this.DgMostrarProductos.Columns[2].HeaderText = "PRODUCTO";
                    this.DgMostrarProductos.Columns[3].HeaderText = "DESCRIPCION";
                    this.DgMostrarProductos.Columns[4].HeaderText = "STOCK ACTUAL";
                    this.DgMostrarProductos.Columns[5].HeaderText = "STOCK CRITICO";
                    this.DgMostrarProductos.Columns[7].HeaderText = "TIPO PRODUCTO";
                    this.DgMostrarProductos.Columns[8].HeaderText = "PRECIO";
                }
                catch (Exception)
                {
                    MessageBox.Show("NO SE PUEDE CARGAR LISTADO DE PRODUCTOS");
                }
            }
    }
}

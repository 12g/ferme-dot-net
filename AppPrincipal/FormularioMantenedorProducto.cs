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
    public partial class FormularioMantenedorProducto : Form
    {
        public FormularioMantenedorProducto()
        {
            InitializeComponent();
        }



        //EVENTO CANELAR Y SALIR DEL MENU CREAR PRODUCTO
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

        private void Limpiar()
        {
            TxtCodigo.Text = "";
            TxtDescripcion.Text = "";
            TxtNombreProducto.Text = "";
            TxtPrecio.Text = "";
            TxtStockActual.Text = "";
            TxtStockCritico.Text = "";
        }


        //BOTON GUARDAR
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
               Validaciones  val = new Validaciones();

                if (TxtCodigo.Text == "")
                {
                    MessageBox.Show("INGRESE UN CODIGO PARA EL PRODUCTO");
                }
                else if (TxtCodigo.Text.Length <= 1 || TxtCodigo.Text.Length >= 1000000000)
                {
                    MessageBox.Show("INGRESE UN CODIGO VALIDO PARA EL PRODUCTO");
                }
                else if (TxtNombreProducto.Text == "")
                {
                    MessageBox.Show("INGRESE UN NOMBRE PARA EL PRODUCTO");
                }
                else if (TxtNombreProducto.Text.Length <= 3)
                {
                    MessageBox.Show("NOMBRE DEL PRODUCTO DEBE TENER UN LARGO MINIMO DE 3 LETRAS");
                }
                else if (TxtPrecio.Text == "")
                {
                    MessageBox.Show("INGRESE UN PRECIO PARA EL PEODUCTO");
                }
                else if (TxtPrecio.Text.Length <= 1)
                {
                    MessageBox.Show("INGRESE UN VALOR MAYOR A CERO 0");
                }
                else if (TxtPrecio.Text.Length >= 1000000)
                {
                    MessageBox.Show("VALOR DEL PRODUCTO DEBE SER MENOR A 1 MILLON");
                }
                else if (TxtStockActual.Text == "")
                {
                    MessageBox.Show("INGRESE UN STOCK ");
                }
                else if (TxtStockActual.Text.Length <= 0)
                {
                    MessageBox.Show("INGRESE UN STOCK MAYOR A CERO 0");
                }
                else if (TxtStockActual.Text.Length >= 10000)
                {
                    MessageBox.Show("STOCK NO DEBE SUPERAR LAS 10.000 UNIDADES");
                }
                else if (TxtStockCritico.Text == "")
                {
                    MessageBox.Show("INGRESE UN STOCK CRITICO ");
                }
                else if (TxtStockCritico.Text.Length <= 0)
                {
                    MessageBox.Show("INGRESE UN STOCK CRITICO MAYOR A CERO O");
                }
                else if (TxtStockCritico.Text.Length >= 1000)
                {
                    MessageBox.Show("STOCK CRITICO NO DEBE SUPERAR LOS 1.000 UNIDADES");
                }
                else if (TxtDescripcion.Text == "")
                {
                    MessageBox.Show("INGRESE UNA DESCRIPCION DEL PRODUCTO");
                }
                else if (TxtDescripcion.Text.Length <= 3)
                {
                    MessageBox.Show("INGRESE UNA DESCRIPCION MAYOR A 3 LETRAS");
                }
                else if (TxtDescripcion.Text.Length >= 100)
                {
                    MessageBox.Show("DESCRIPCION SUPERA LOS 100 CARACTERES ");
                }
                else if (CbTipoproducto.SelectedIndex.Equals(-1))
                {
                    MessageBox.Show("SELECCIONE UN TIPO PRODUCTO");
                }
                else
                {
                    ServicioProducto serp = new ServicioProducto();
                    Producto pro = new Producto();



                    pro.codigoProducto = TxtCodigo.Text;
                    pro.nombreProducto = TxtNombreProducto.Text;
                    pro.idTipoProducto = CbTipoproducto.SelectedIndex;
                    pro.precioProducto = int.Parse(TxtPrecio.Text);
                    pro.descripcionProducto = TxtDescripcion.Text;
                    pro.stockActualProducto = int.Parse(TxtStockActual.Text);
                    pro.stockCriticoProducto = int.Parse(TxtStockCritico.Text);

                    CargarComBobox();
                    serp.CrearProducto(pro);

                    Limpiar();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("ERROR AL GUARDAR PRODUCTO");
            }
        }

        
        private void TxtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones val = new Validaciones();
            val.SoloNumero(e);
        }

        private void TxtStockActual_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones val = new Validaciones();
            val.SoloNumero(e);
        }

        private void TxtStockCritico_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones val = new Validaciones();
            val.SoloNumero(e);
        }

        private void FormularioMantenedorProducto_Load(object sender, EventArgs e)
        {
            ServicioProducto serpr = new ServicioProducto();
            TipoProducto tp = new TipoProducto();
            CargarComBobox();
        }

        private void CargarComBobox()
        {
            ServicioTipoProducto sertp = new ServicioTipoProducto();
            CbTipoproducto.DataSource = sertp.ListaTipoProducto();
            CbTipoproducto.DisplayMember = "nombreTipoProducto";
            CbTipoproducto.ValueMember = "idTipoProducto";

        }
    }
}

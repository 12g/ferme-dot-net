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

        private void FormularioBuscarProducto_Load(object sender, EventArgs e)
        {
            Timer actualizar_automatico = new Timer();
            actualizar_automatico.Interval = 30000;
            actualizar_automatico.Tick += actualizar_automatico_Tick;
            actualizar_automatico.Enabled = true;
        }


        private void recargar()
        {
            ServicioProducto ser = new ServicioProducto();
            DgMostrarProductos.DataSource = ser.GetRESTData();
        }

        private void actualizar_automatico_Tick(object sender, EventArgs e)
        {
            recargar();
        }

        private FormularioMantenedorOrdenCompra FrmOrdenCompra;

        private void DgMostrarProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                FrmOrdenCompra.TxtCodProducto.Text = DgMostrarProductos.CurrentRow.Cells[1].Value.ToString();
                FrmOrdenCompra.TxtNombreProducto.Text = DgMostrarProductos.CurrentRow.Cells[2].Value.ToString();
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR AL CARGAR PRODUCTO");
            }
        }
    }
}

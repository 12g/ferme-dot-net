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
    public partial class FormularioMantenedorFamiliaProducto : Form
    {
        private static int visitCounter = 0;
        public FormularioMantenedorFamiliaProducto()
        {
            InitializeComponent();
            visitCounter++; // Increase each time a form is loaded
            TxtCodigo.Text = visitCounter.ToString("01"); // 

        }



        //BOTON CANCELAR
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

        private void FormularioMantenedorFamiliaProducto_Load(object sender, EventArgs e)
        {
            //CARGA INFORMACION EN COMBOBOX RUBRO
            ServiciosRubro serRubro = new ServiciosRubro();
            CbRubro.DataSource = serRubro.ListarRubro();
            CbRubro.DisplayMember = "descripcionRubro";
            CbRubro.ValueMember = "idRubro";


            if (CbRubro.Items.Count > 0)
            {
                CbRubro.SelectedIndex = -1;
                CbRubro.Text = "Seleccione";
            }


            //CARGA INFORMACION EN COMBOBOX EN PROVEEDOR
            ServicioProveedores servProv = new ServicioProveedores();
            CbProveedor.DataSource = servProv.ListadoProveedor();
            CbProveedor.DisplayMember = "nombreCompletoPersona";
            CbProveedor.ValueMember = "idProveedor";

            if (CbProveedor.Items.Count > 0)
            {
                CbProveedor.SelectedIndex = -1;
                CbProveedor.Text = "Seleccione";
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (CbRubro.SelectedIndex.Equals(-1))
                {
                    MessageBox.Show("SELECCIONE UN RUBRO");
                }
                else if (CbProveedor.SelectedIndex.Equals(-1))
                {
                    MessageBox.Show("SELECCIONE UN PROVEEDOR");
                }
                else if (TxtDescripcion.Text =="")
                {
                    MessageBox.Show("INGRESE UNA DESCRIPCION EN FAMILIA PRODUCTO");
                }
                else
                {
                    ServicioFamiliaProducto ser = new ServicioFamiliaProducto();
                    Familia_Producto fp = new Familia_Producto();

                    fp.idFamiliaProducto = int.Parse(TxtCodigo.Text);
                    fp.descripcionFamiliaProducto = TxtDescripcion.Text;
                    fp.idRubro = int.Parse(CbRubro.SelectedValue.ToString());
                    fp.descripcionRubro = Convert.ToString(CbRubro.Text);
                    fp.idProveedor = int.Parse(CbProveedor.SelectedValue.ToString());

                    ser.CrearFamiliaProducto(fp);

                    FormularioProducto P = new FormularioProducto();
                    P.DGlistadeproductos.Refresh();

                    MessageBox.Show("FAMILIA PRODUCTO GUARDADA EXITOSAMENTE");

                    Limpiar();

                }
            }
            catch (Exception)
            {

                MessageBox.Show("ERROR AL GUARDAR FAMILIA PRODUCTO");
            }
        }


        //LIMPIAR PANTALLA
        private void Limpiar()
        {
            TxtCodigo.Text = "";
            TxtDescripcion.Text = "";
            CbProveedor.Text = "Seleccionar";
            CbRubro.Text = "Seleccionar";
        }
    }
}

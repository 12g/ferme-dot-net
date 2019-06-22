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
    public partial class FomularioTipoProducto : Form
    {
        private static int visitCounter = 0;
        public FomularioTipoProducto()
        {
            InitializeComponent();

            visitCounter++; // Increase each time a form is loaded
            TxtCodigo.Text = visitCounter.ToString("01"); // 
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

        //LIMPIAR 
        private void Limpiar()
        {
            TxtCodigo.Text = "";
            TxtDescripcion.Text = "";
            CbFamiliaProducto.Text = "Seleccione";
        }

        //BOTON GUARDAR
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (CbFamiliaProducto.SelectedIndex.Equals(-1))
                {
                    MessageBox.Show("SELECCIONE UN TIPO PRODUCTO");
                }
                else if (TxtDescripcion.Text =="")
                {
                    MessageBox.Show("INGRESE UNA DESCRIPCION PARA EL TIPO PRODUCTO");
                }
                else
                {
                    ServicioTipoProducto sertp = new ServicioTipoProducto();
                    TipoProducto tp = new TipoProducto();
                    
                    tp.idTipoProducto = int.Parse(TxtCodigo.Text);
                    tp.idFamiliaProducto = int.Parse(CbFamiliaProducto.SelectedValue.ToString());
                    tp.nombreFamiliaProducto = CbFamiliaProducto.SelectedText.ToString();
                    tp.nombreTipoProducto = TxtDescripcion.Text;

                    sertp.CrearTipoProducto(tp);
                    Limpiar();

                }
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR AL GUARDAR TIPO PRODUCTO");
            }
        }

        private void FomularioTipoProducto_Load(object sender, EventArgs e)
        {
            ServicioFamiliaProducto ser = new ServicioFamiliaProducto();
            CbFamiliaProducto.DataSource = ser.ListarFamiliaProducto();
            CbFamiliaProducto.DisplayMember = "descripcionFamiliaProducto";
            CbFamiliaProducto.ValueMember = "idFamiliaProducto";

            if (CbFamiliaProducto.Items.Count > 0)
            {
                CbFamiliaProducto.SelectedIndex = -1;
                CbFamiliaProducto.Text = "Seleccione";
            }
        }
    }
}

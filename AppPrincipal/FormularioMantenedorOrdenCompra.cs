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

namespace AppPrincipal
{
    public partial class FormularioMantenedorOrdenCompra : Form
    {
        Validaciones val = new Validaciones();

        public FormularioMantenedorOrdenCompra()
        {
            InitializeComponent();
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

        //BOTON BUSCAR QUE REDIRIGE AL FORMULARIO BURCAR PRODUCTOS
        private void button1_Click(object sender, EventArgs e)
        {
            FormularioBuscarProducto fbp = new FormularioBuscarProducto();
            fbp.ShowDialog();
        }

        
        //BOTON GUARDAR
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtNumero.Text == "" || Convert.ToInt32(TxtNumero.Text) < 1 || !val.IsNumeric(TxtNumero.Text))
                {
                    LblNumeroObligatorio.Visible = true;
                    MessageBox.Show("INGRESE UN NUMERO");
                }
                //Comparar fechas
                else if (DPfechaInicio.Value.Date > DPfechaTermino.Value.Date)
                {
                    MessageBox.Show("La fecha TERMINO no puede ser menor a la fecha INICIO");
                }
                else
                {

                }
            }
            catch (Exception)
            {

                MessageBox.Show("ERROR AL GUARDAR ORDEN DE COMPRA");
                LblNumeroObligatorio.Visible = false;
            }
          
        }


        //BOTON AGREGAR
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (TxtCantidad.Text == "" || Convert.ToInt32(TxtCantidad.Text) < 1 || !val.IsNumeric(TxtCantidad.Text))
            {
                LblCantidadObligatoria.Visible = true;
                MessageBox.Show("INGRESE UNA CANTIDAD EN PRODUCTO");
            }
            else
            {
                LblCantidadObligatoria.Visible = false;
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
    }
}

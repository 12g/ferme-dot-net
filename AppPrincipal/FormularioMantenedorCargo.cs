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
    public partial class FormularioMantenedorCargo : Form
    {
        public FormularioMantenedorCargo()
        {
            InitializeComponent();
        }

        //METODO PARA LIMPIAR PANTALLA
        private void LimpiarPantalla()
        {
            TxtCodigo.Text = "";
            TxtDescripcion.Text = "";
        }

        // BOTON GUARDAR
        private void BtnGuargar_Click(object sender, EventArgs e)
        {
            Validaciones val = new Validaciones();
            try
            {
                Cargo car = new Cargo();
                ServicioCargo ser = new ServicioCargo();

                if (TxtCodigo.Text == "" || Convert.ToInt32(TxtCodigo.Text) <=1 || !val.IsNumeric(TxtCodigo.Text))
                {
                    LblCodigoObligatorio.Visible = true;
                }
                else if (TxtDescripcion.Text == "" || val.IsNumeric(TxtDescripcion.Text))
                {
                    LblDescObligatorio.Visible = true;
                }
                else
                {
                    car.idCargo = int.Parse(TxtCodigo.Text);
                    car.descripcionCargo = TxtDescripcion.Text;

                    ser.CrearCargo(car);
                    MessageBox.Show("CARGO GUARDADO");
                    LimpiarPantalla();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("ERROR AL GUARDAR CARGO");
            }
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

        //SE CARGA LA CLASE VALIDACIONES EL CUAL SE CONTIENE EL METODO SOLONUMEROS
        private void TxtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones val = new Validaciones();
            val.SoloNumero(e);
        }

        //SE CARGA LA CLASE VALIDACIONES EL CUAL CONTIENE EL METODO SOLOLETRAS 
        private void TxtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones val = new Validaciones();
            val.SoloLetras(e);
        }

        //EN TEXTBOX CODIGO MUESTRA SIMBOLO * , EL CUAL ES UN CAMPO IBLIGATORIO
        private void LblCodigoObligatorio_Leave(object sender, EventArgs e)
        {
            Validaciones val = new Validaciones();
            if (TxtCodigo.Text == "" || Convert.ToInt32(TxtCodigo.Text) <=0 || !val.IsNumeric(TxtCodigo.Text))
            {
                LblCodigoObligatorio.Visible = false;
            }
            else
            {
                LblCodigoObligatorio.Visible = true;
            }
        }


        //EN TEXTBOX DESCRIPCION MUESTRA SIMBOLO * , EL CUAL SIGNIFICA QUE ES UN CAMPO OBLIGATORIO
        private void LblDescObligatorio_Leave(object sender, EventArgs e)
        {
            Validaciones val = new Validaciones();
            if (TxtDescripcion.Text == "" || val.IsNumeric(TxtDescripcion.Text))
            {
                LblDescObligatorio.Visible = false;
            }
            else
            {
                LblDescripcion.Visible = true;
            }
        }
    }
}

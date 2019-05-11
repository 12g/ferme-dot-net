using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca;

namespace AppPrincipal
{
    public partial class FormularioMantenedorCliente : Form
    {
        Validaciones val = new Validaciones();
        Persona per = new Persona();
        Cliente cli = new Cliente();

        public FormularioMantenedorCliente()
        {
            InitializeComponent();
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

        //BOTON GUARDAR
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtRutCliente.Text == "")
                {
                    LblRutObligatorio.Visible = true;
                }
                else if (TxtRutCliente.Text.Length <= 7 || TxtRutCliente.Text.Length >= 13)
                {
                    MessageBox.Show("EL RUT DEBE TENER MINIMO UN LARGO DE 7 DIGITOS");
                }
                else if (TxtNombre.Text == "" || val.IsNumeric(TxtNombre.Text))
                {
                    MessageBox.Show("NOMBRE NO PUEDE ESTAR EN BLANCO ");
                    lblMensajeNombre.Visible = true;
                }
                else if (TxtDireccion.Text == "" || val.IsNumeric(TxtDireccion.Text))
                {
                    MessageBox.Show("DIRECCION NO PUEDE ESTAR EN BLANCO");
                    lblMensajeDireccion.Visible = true;
                }
                else if (TxtEmail.Text == "" || val.IsNumeric(TxtEmail.Text))
                {
                    MessageBox.Show("EMAIL NO PUEDE ESTAR EN BLANCO");
                    lblMensajeEmail.Visible = true;
                }
                else
                {
                    //DATOS
                }
            }
            catch (Exception)
            {

                MessageBox.Show("NO SE PUEDE GUARDAR CLIENTE");
            }
        }

        //CASILLA TEXTBOX RUT CLIENTE
        private void TxtRutCliente_Leave(object sender, EventArgs e)
        {
            bool respuesta = false;
            string rut = TxtRutCliente.Text;
            TxtRutCliente.Text = val.formatoRut(rut);
            rut = TxtRutCliente.Text;
            respuesta = val.validarRut(rut);

            if (respuesta == false)
            {
                TxtRutCliente.Focus();
                TxtRutCliente.BackColor = Color.Red;
                MessageBox.Show("Rut Malo");
            }
            else
            {
                TxtRutCliente.ForeColor = Color.Black;
                TxtRutCliente.BackColor = Color.White; 
                LblRutObligatorio.Visible = false;
                // MessageBox.Show("Rut OK");
            }
        }

        //SE VA A BUSCAR EL METODO SOLOLETRAS EN TEXTBOX NOMBRE
        private void TxtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.SoloLetras(e);
        }

        private void TxtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.SoloLetras(e);
        }


        //APARECE EL SIGNO * SI EL NOMBRE ESTA EN BLANCO
        private void TxtNombre_Leave(object sender, EventArgs e)
        {
            if (TxtNombre.Text == "" || val.IsNumeric(TxtNombre.Text))
            {
                lblMensajeNombre.Visible = true;
            }
            else
            {
                lblMensajeNombre.Visible = false;
            }
        }


        //APARECE EL SIGNO * SI LA DIRECCION ESTA EN BLANCO
        private void TxtDireccion_Leave(object sender, EventArgs e)
        {
            if (TxtDireccion.Text == "" || val.IsNumeric(TxtDireccion.Text))
            {
                lblMensajeDireccion.Visible = true;
            }
            else
            {
                lblMensajeDireccion.Visible = false;
            }
        }


        //SE USA EN EMAIL DE CLIENTE
        //METODO PARA VALIDAR EL FORMATO DEL EMAIL
      
        //EVENTO LEAVE PARA VALIDAR EL FORMATO DEL CORREO
        private void TxtEmail_Leave(object sender, EventArgs e)
        {
            if (val.ValidarEmail(TxtEmail.Text))
            {
                lblMensajeEmail.Visible = false;
            }
            else
            {
                lblMensajeEmail.Visible = true;
                MessageBox.Show("INGRESE UNA DIRECCION DE CORREO ELECTRONICO VALIDA");
                TxtEmail.SelectAll();
                TxtEmail.Focus();
            }

        }
    }
}

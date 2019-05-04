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
                    MessageBox.Show("NOMBRE NO PUEDE ESTAR EN BLACO Y DEBE INGRESAR SOLO LETRAS");
                    lblMensajeNombre.Visible = true;
                }
                else if (TxtApellido.Text == "" || val.IsNumeric(TxtApellido.Text))
                {
                    lblMensajeApellido.Visible = true;
                }
                else
                {
                    TxtRutCliente.Text = per.Rut;
                    LblRutObligatorio.Visible = false;
                    lblMensajeNombre.Visible = false;
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

        private void TxtNombre_TextChanged(object sender, EventArgs e)
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
    }
}

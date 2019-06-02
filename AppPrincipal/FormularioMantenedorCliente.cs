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
using ServiciosConexionFerme;

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
            TxtIdCliente.Text = "0";
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

        private void Limpiar()
        {
            TxtRutCliente.Text = "";
            TxtNombre.Text = "";
            TxtDireccion.Text = "";
            TxtEmail.Text = "";
            TxtTelefeno1.Text = "0";
            TxtTelefono2.Text = "0";
            TxtTelefono3.Text = "0";
        }

        //BOTON GUARDAR
        private void BtnGuardar_Click(object sender, EventArgs e)
        {

            try
            {
                if (TxtRutCliente.Text == "")
                {
                    LblRutObligatorio.Visible = true;
                    MessageBox.Show("CAMPO RUT NO PUEDE ESTAR VACIO");
                }
                else if (TxtRutCliente.Text.Length <= 7 || TxtRutCliente.Text.Length >= 13)
                {
                    MessageBox.Show("INGRESE UN RUT VALIDO");
                    LblRutObligatorio.Visible = true;
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
                else if (val.ValidarEmail(TxtEmail.Text) == false)
                {
                    MessageBox.Show("INGRESE UN EMAIL VALIDO");
                }
                else if (!val.IsNumeric(TxtTelefeno1.Text) || TxtTelefeno1.TextLength >= 10)
                {
                    MessageBox.Show("INGRESE UN TELEFONO VALIDO EN  CAMPO TELEFONO 1");
                }
                else if (!val.IsNumeric(TxtTelefono2.Text) || TxtTelefono2.TextLength >= 10)
                {
                    MessageBox.Show("INGRESE UN TELEFONO VALIDO EN  CAMPO TELEFONO 2");
                }
                else if (!val.IsNumeric(TxtTelefono3.Text) || TxtTelefono3.TextLength >= 10)
                {
                    MessageBox.Show("INGRESE UN TELEFONO VALIDO EN  CAMPO TELEFONO 3");
                }
                else
                {
                    Cliente cli = new Cliente();
                    ServicioCliente serv = new ServicioCliente();

                    cli.idCliente = int.Parse(TxtIdCliente.Text);
                    cli.rutPersona = TxtRutCliente.Text;
                    cli.nombreCompletoPersona = TxtNombre.Text;
                    cli.direccionPersona = TxtDireccion.Text;
                    cli.emailPersona = TxtEmail.Text;
                    cli.fonoPersona1 = int.Parse(TxtTelefeno1.Text);
                    cli.fonoPersona2 = int.Parse(TxtTelefono2.Text);
                    cli.fonoPersona3 = int.Parse(TxtTelefono3.Text);

                    serv.CrearCliente(cli);

                    FormularioCliente clicli = new FormularioCliente();
                    ServicioCliente serp = new ServicioCliente();
                    clicli.DGMostrarListaCliente.DataSource = serp.ListarClientes();
                    clicli.DGMostrarListaCliente.Refresh();

                    Limpiar();
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
            try
            {
                Validaciones val = new Validaciones();
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
            catch (Exception)
            {
                MessageBox.Show("INGRESE UN RUT VALIDO");
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
                TxtNombre.CharacterCasing = CharacterCasing.Upper;//MAYUSCULAS
            }
            else
            {
                lblMensajeNombre.Visible = false;
                TxtNombre.CharacterCasing = CharacterCasing.Upper;//MAYUSCULAS
            }
        }


        //APARECE EL SIGNO * SI LA DIRECCION ESTA EN BLANCO
        private void TxtDireccion_Leave(object sender, EventArgs e)
        {
            if (TxtDireccion.Text == "" || val.IsNumeric(TxtDireccion.Text))
            {
                lblMensajeDireccion.Visible = true;
                TxtDireccion.CharacterCasing = CharacterCasing.Upper;//MAYUSCULAS
            }
            else
            {
                lblMensajeDireccion.Visible = false;
                TxtDireccion.CharacterCasing = CharacterCasing.Upper;//MAYUSCULAS
            }
        }


        //SE USA EN EMAIL DE CLIENTE
        //METODO PARA VALIDAR EL FORMATO DEL EMAIL
      
        //EVENTO LEAVE PARA VALIDAR EL FORMATO DEL CORREO
        private void TxtEmail_Leave(object sender, EventArgs e)
        {
            try
            {
                if (val.ValidarEmail(TxtEmail.Text))
                {
                    lblMensajeEmail.Visible = false;
                }
                else
                {
                    lblMensajeEmail.Visible = true;
                    TxtEmail.SelectAll();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("INGRESE UN EMAIL VALIDO");
            }
            
        }

        //EVENTO QUE VALIDA QUE EL CAMPO TELEFONO 1 NUNCA ESTE VACIO HE INICIE CON UN CERO
        private void TxtTelefeno1_Leave(object sender, EventArgs e)
        {
             if ( !val.IsNumeric(TxtTelefeno1.Text) )
                {
                    TxtTelefeno1.Text = "0";
                }
        }

        //EVENTO QUE VALIDA QUE EL CAMPO TELEFONO 2 NUNCA ESTE VACIO HE INICIE CON UN CERO
        private void TxtTelefono2_Leave(object sender, EventArgs e)
        {
            if (!val.IsNumeric(TxtTelefono2.Text))
            {
                TxtTelefono2.Text = "0";
            }
        }

        //EVENTO QUE VALIDA QUE EL CAMPO TELEFONO 3 NUNCA ESTE VACIO HE INICIE CON UN CERO
        private void TxtTelefono3_Leave(object sender, EventArgs e)
        {
            if (!val.IsNumeric(TxtTelefono3.Text))
            {
                TxtTelefono3.Text = "0";
            }
        }

        private void TxtRutCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones val = new Validaciones();
            val.SoloNumero(e);
        }
    }
}

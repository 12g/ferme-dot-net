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
            TxtIdPersona.Text = "0";
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
            TxtIdCliente.Text = "";
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
                else
                {
                    Cliente cli = new Cliente();
                    ServicioCliente serv = new ServicioCliente();

                    cli.idPersona = int.Parse(TxtIdPersona.Text);
                    cli.idCliente = int.Parse(TxtIdCliente.Text);
                    cli.rutPersona = TxtRutCliente.Text;
                    cli.nombreCompletoPersona = TxtNombre.Text;

                    serv.CrearCliente(cli);

                    this.DialogResult = DialogResult.OK;

                    MessageBox.Show("REGISTRO SE HA GUARDADO EXITOSAMENTE");

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
                    
                    MessageBox.Show("RUT INVALIDO");
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

        private void TxtRutCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones val = new Validaciones();
            val.SoloNumero(e);
        }
    }
}

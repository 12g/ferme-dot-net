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
    public partial class FormularioMantenedorProveedor : Form
    {
        public FormularioMantenedorProveedor()
        {
            InitializeComponent();
            TxtIdProveedor.Text = "0";
            TxtIdPersona.Text = "0";
        }
       

        //BOTON CANCELAR EL CUAL ENVIA UN MENSAJE PARA CONFIRMAR EL CIERRE DE LA APLICACION
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
            TxtRut.Text = "";
            TxtRazonSocial.Text = "";
            TxtIdProveedor.Text = "";
            TxtIdPersona.Text = "";
        }

        //BOTON GUARDAR
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {

                Validaciones val = new Validaciones();
                if (TxtRut.Text == "")
                {
                    LblRutObligatorio.Visible = true;
                    MessageBox.Show("CAMPO RUT NO PUEDE ESTAR VACIO");
                }
                else if (TxtRut.Text.Length <= 7 || TxtRut.Text.Length >= 13)
                {
                    MessageBox.Show("EL RUT DEBE TENER MINIMO UN LARGO DE 7 Y MAXIMO 10 DIGITOS");
                    LblRutObligatorio.Visible = true;
                }
                else if (TxtRazonSocial.Text == "")
                {
                    LblRazonSocialObligatorio.Visible = true;
                    MessageBox.Show("CAMPO RAZON SOCIAL NO PUEDE ESTAR VACIO");
                }
                else if (TxtRazonSocial.Text.Length <= 4)
                {
                    MessageBox.Show("RAZON SOCIAL DEBE TENER MINIMO 4 LETRAS");
                    LblRazonSocialObligatorio.Visible = true;
                }
                else
                {

                    Proveedor pro = new Proveedor();
                    ServicioProveedores sp = new ServicioProveedores();

                    pro.idPersona = int.Parse(TxtIdPersona.Text);
                    pro.idProveedor = int.Parse(TxtIdProveedor.Text);
                    pro.rutPersona = TxtRut.Text;
                    pro.razonSocialProveedor = TxtRazonSocial.Text;
                    pro.nombreCompletoPersona = TxtRazonSocial.Text;

                    sp.CrearProveedor(pro);

                    this.DialogResult = DialogResult.OK;

                    MessageBox.Show("PROVEEDOR GUARDARDO");

                    Limpiar();
                  
                }

            }
            catch (Exception)
            {

                MessageBox.Show("NO SE PUEDE GUARDAR PROVEEDOR");
            }
        }

        //BUSCA EL METODO QUE VALIDA EL RUT Y LE DA UN FORMATO
        private void TxtRut_Leave(object sender, EventArgs e)
        {
            try
            {
                Validaciones val = new Validaciones();
                bool respuesta = false;
                string rut = TxtRut.Text;
                TxtRut.Text = val.formatoRut(rut);
                rut = TxtRut.Text;
                respuesta = val.validarRut(rut);

                if (respuesta == false)
                {
                    MessageBox.Show("RUT INVALIDO");
                }
                else
                {
                    TxtRut.ForeColor = Color.Black;
                    TxtRut.BackColor = Color.White;
                    LblRutObligatorio.Visible = false;
                    // MessageBox.Show("Rut OK");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("INGRESE UN RUT VALIDO");
            }
           
        }


        //APARECE EL SIGNO * SI LA RAZON SOCIAL ESTA EN BLANCO
        private void LblRazonSocialObligatorio_Leave(object sender, EventArgs e)
        {
             if (TxtRazonSocial.Text == "" || TxtRazonSocial.Text.Length <= 4)
            {
                LblRazonSocialObligatorio.Visible = true;
            }
            else 
            {
                LblRazonSocialObligatorio.Visible = false;
            }
        }

        private void TxtRut_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones val = new Validaciones();
            val.SoloNumero(e);
        }


        //SE VA A BUSCAR EL METODO SOLONUMERO EN TEXTBOX TELEFONO
        private void TxtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones val = new Validaciones();
            val.SoloNumero(e);
        }
       
    }
}

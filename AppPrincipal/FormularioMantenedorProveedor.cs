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
                    LblTelefonoObligatorio.Visible = true;
                }
                else if (TxtRazonSocial.Text.Length <= 4)
                {
                    MessageBox.Show("RAZON SOCIAL DEBE TENER MINIMO 4 LETRAS");
                    LblTelefonoObligatorio.Visible = true;
                }
                else if (TxtTelefono.Text == "")
                {
                    MessageBox.Show("CAMPO TELEFONO NO PUEDE ESTAR VACIO");
                    LblTelefonoObligatorio.Visible = true;
                }
                else if (TxtTelefono.Text.Length <=7 ||  TxtTelefono.Text.Length >=10)
                {
                    MessageBox.Show("EL TELEFONO DEBE TENER MINIMO UN LARGO DE 7 Y MAXIMO 10 DIGITOS");
                    LblTelefonoObligatorio.Visible = true;
                }
                else
                {
                    
                    Proveedor pro = new Proveedor();
                    ServicioProveedores sp = new ServicioProveedores();

                     //pro.idPersona = 5;
                     pro.idProveedor = 5;
                     pro.idRubro = 1;
                     //pro.rutPersona = TxtRut.Text;
                     //pro.nombreCompletoPersona = TxtRazonSocial.Text;
                     //pro.fonoPersona1 = int.Parse(TxtTelefono.Text);
                     //pro.razonSocialProveedor = TxtRazonSocial.Text;
                     //pro.fonoPersona2 = int.Parse(TxtTelefono.Text);
                     //pro.fonoPersona3 = int.Parse(TxtTelefono.Text);
                     pro.razonSocialProveedor = TxtRazonSocial.Text;
                     //pro.emailPersona = TxtEmail.Text;
                     //pro.direccionPersona = TxtDireccion.Text;

                    

                     sp.CrearProveedor(pro);
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
            Validaciones val = new Validaciones();
            bool respuesta = false;
            string rut = TxtRut.Text;
            TxtRut.Text = val.formatoRut(rut);
            rut = TxtRut.Text;
            respuesta = val.validarRut(rut);

            if (respuesta == false)
            {
                TxtRut.Focus();
                TxtRut.BackColor = Color.Red;
                MessageBox.Show("Rut Malo");
            }
            else
            {
                TxtRut.ForeColor = Color.Black;
                TxtRut.BackColor = Color.White;
                LblRutObligatorio.Visible = false;
                // MessageBox.Show("Rut OK");
            }
        }

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

        private void TxtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones val = new Validaciones();
            val.SoloNumero(e);
        }

        private void TxtTelefono_Leave(object sender, EventArgs e)
        {
            if (TxtTelefono.Text == "" || TxtTelefono.Text.Length <= 7 || TxtTelefono.Text.Length >= 10)
            {
                LblTelefonoObligatorio.Visible = true;
            }
            else 
            {
                LblTelefonoObligatorio.Visible = false;
            }
        }
    }
}

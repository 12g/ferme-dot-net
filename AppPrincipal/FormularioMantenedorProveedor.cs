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
            TxtDireccion.Text = "";
            TxtEmail.Text = "";
            TxtTelefono1.Text = "0";
            TxtTelefono2.Text = "0";
            TxtTelefono3.Text = "0";
            TxtIdProveedor.Text = "";
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
                else if (TxtEmail.Text == "" || val.IsNumeric(TxtEmail.Text))
                {
                    MessageBox.Show("EMAIL NO PUEDE ESTAR EN BLANCO");
                    LblEmailObligatorio.Visible = true;
                }
                else if (val.ValidarEmail(TxtEmail.Text) == false)
                {
                    MessageBox.Show("INGRESE UN EMAIL VALIDO");
                }
                else if (!val.IsNumeric(TxtTelefono1.Text) || TxtTelefono1.TextLength >= 10)
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

                    Proveedor pro = new Proveedor();
                    ServicioProveedores sp = new ServicioProveedores();

                    pro.idProveedor = int.Parse(TxtIdProveedor.Text);
                    pro.rutPersona = TxtRut.Text;
                    pro.razonSocialProveedor = TxtRazonSocial.Text;
                    pro.nombreCompletoPersona = TxtRazonSocial.Text;
                    pro.direccionPersona = TxtDireccion.Text;
                    pro.emailPersona = TxtEmail.Text;
                    pro.fonoPersona1 = int.Parse(TxtTelefono1.Text);
                    pro.fonoPersona2 = int.Parse(TxtTelefono2.Text);
                    pro.fonoPersona3 = int.Parse(TxtTelefono3.Text);

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


        //EVENTO QUE VALIDA QUE EL CAMPO TELEFONO 1 NUNCA ESTE VACIO HE INICIE CON UN CERO
        private void TxtTelefono1_Leave(object sender, EventArgs e)
        {
            Validaciones val = new Validaciones();

            if (!val.IsNumeric(TxtTelefono1.Text))
            {
                TxtTelefono1.Text = "0";
            }
        }


        //EVENTO QUE VALIDA QUE EL CAMPO TELEFONO 2 NUNCA ESTE VACIO HE INICIE CON UN CERO
        private void TxtTelefono2_Leave(object sender, EventArgs e)
        {
            Validaciones val = new Validaciones();

            if (!val.IsNumeric(TxtTelefono2.Text))
            {
                TxtTelefono2.Text = "0";
            }
        }



        //EVENTO QUE VALIDA QUE EL CAMPO TELEFONO 3 NUNCA ESTE VACIO HE INICIE CON UN CERO
        private void TxtTelefono3_Leave(object sender, EventArgs e)
        {
            Validaciones val = new Validaciones();

            if (!val.IsNumeric(TxtTelefono3.Text))
            {
                TxtTelefono3.Text = "0";
            }
        }


        
        //METODO PARA VALIDAR EL FORMATO DEL EMAIL
        //EVENTO LEAVE PARA VALIDAR EL FORMATO DEL CORREO
        private void TxtEmail_Leave(object sender, EventArgs e)
        {
            try
            {

                Validaciones val = new Validaciones();

                if (val.ValidarEmail(TxtEmail.Text) )
                {
                    LblEmailObligatorio.Visible = false;
                }
                else
                {
                    LblEmailObligatorio.Visible = true;
                    TxtEmail.SelectAll();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("INGRESE UN EMAIL VALIDO");
            }
        }

        //SE VA A BUSCAR EL METODO SOLONUMERO EN TEXTBOX TELEFONO
        private void TxtTelefono2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones val = new Validaciones();
            val.SoloNumero(e);
        }

        private void FormularioMantenedorProveedor_Load(object sender, EventArgs e)
        {
            ServiciosRubro serR = new ServiciosRubro();
            CbxRubro.DataSource = serR.ListarRubro();
            CbxRubro.DisplayMember = "descripcionRubro";
            CbxRubro.ValueMember = "idRubro";

            if (CbxRubro.Items.Count > 1)
            {
                CbxRubro.SelectedIndex = -1;
                CbxRubro.Text = "Seleccione";
            }
        }
    }
}

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
    public partial class FormularioMantenedorUsuario : Form
    {
        public FormularioMantenedorUsuario()
        {
            InitializeComponent();
        }

        //BOTON CANCELAR CREAR USUARIO
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
        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                Empleado empl = new Empleado();
                ServicioEmpleado serEmp = new ServicioEmpleado();
                Validaciones val = new Validaciones();

                if (TxtRut.Text == "")
                {
                    LblRutObligatorio.Visible = true;
                }
                else if (TxtRut.Text.Length <= 7 || TxtRut.Text.Length >= 13)
                {
                    MessageBox.Show("EL RUT DEBE TENER MINIMO UN LARGO DE 7 Y MAXIMO 10 DIGITOS");
                    LblRutObligatorio.Visible = true;
                }
                else if (TxtNombre.Text == "" || val.IsNumeric(TxtNombre.Text))
                {
                    LblNombreObligatorio.Visible = true;
                }
                else if (TxtNombre.Text.Length <= 3)
                {
                    MessageBox.Show("INGRESE UN NOMBRE VALIDO");
                    LblNombreObligatorio.Visible = true;
                }
                else if (TxtDireccion.Text == "" || val.IsNumeric(TxtDireccion.Text))
                {
                    LblDireccionObligatoria.Visible = true;
                }
                else if (TxtDireccion.Text.Length <= 3)
                {
                    MessageBox.Show("INGRESE UNA DIRECCION VALIDA");
                    LblDireccionObligatoria.Visible = true;
                }
                else if (TxtEmail.Text == "")
                {
                    LblEmailObligatorio.Visible = true;
                }
                else if (val.ValidarEmail(TxtEmail.Text))
                {
                    MessageBox.Show("INGRESE UN EMAIL VALIDO");
                    LblEmailObligatorio.Visible = true;
                }
                else if (TxtTelefono1.Text == "")
                {
                    LblTelefono1Obligatorio.Visible = true;
                }
                else
                {
                    empl.idEmpleado = 1;
                    empl.idCargo = 1;
                    empl.idPersona = 2;
                    empl.rutPersona = TxtRut.Text;
                    empl.nombreCompletoPersona = TxtNombre.Text;
                    empl.direccionPersona = TxtDireccion.Text;
                    empl.emailPersona = TxtEmail.Text;
                    empl.fonoPersona1 = int.Parse(TxtTelefono1.Text);
                    empl.fonoPersona2 = int.Parse(TxtTelefono2.Text);
                    empl.fonoPersona3 = int.Parse(TxtTelefono3.Text);

                    serEmp.CrearEmpleado(empl);
                }
            }
            catch (Exception)
            {

                MessageBox.Show("ERROR AL GUARDAR USUARIO");
            }
            
        }

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
                MessageBox.Show("INGRESE UN RUT VALIDO");
            }
            else
            {
                TxtRut.ForeColor = Color.Black;
                TxtRut.BackColor = Color.White;
                LblRutObligatorio.Visible = false;
                // MessageBox.Show("Rut OK");
            }
        }

        private void TxtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones val = new Validaciones();
            val.SoloLetras(e);
        }

        private void TxtNombre_Leave(object sender, EventArgs e)
        {
            Validaciones val = new Validaciones();
            if (TxtNombre.Text == "")
            {
                LblNombreObligatorio.Visible = true;
            }
            else
            {
                LblNombreObligatorio.Visible = false;
            }
        }

        private void LblDireccionObligatoria_Leave(object sender, EventArgs e)
        {
            Validaciones val = new Validaciones();

            if (TxtDireccion.Text == "")
            {
                LblDireccionObligatoria.Visible = true;
            }
            else
            {
                LblDireccionObligatoria.Visible = false;
            }
        }

        private void LblEmailObligatorio_Leave(object sender, EventArgs e)
        {
            Validaciones val = new Validaciones();

            if (TxtEmail.Text == "" )
            {
                LblEmailObligatorio.Visible = true;
            }
            else
            {
                LblEmailObligatorio.Visible = false;
            }
        }
    }
}

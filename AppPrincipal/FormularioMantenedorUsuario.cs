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
                if (TxtRut.Text == "")
                {
                    LblRutObligatorio.Visible = true;
                }
                else if (TxtNombre.Text == "")
                {
                    LblNombreObligatorio.Visible = true;
                }
                else
                {

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
            if (TxtNombre.Text == "" || val.IsNumeric(TxtNombre.Text))
            {
                LblNombreObligatorio.Visible = true;
            }
            else
            {
                LblNombreObligatorio.Visible = false;
            }
        }
    }
}

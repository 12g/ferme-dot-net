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
    public partial class FormularioEditarUsuario : Form
    {
        public FormularioEditarUsuario()
        {
            InitializeComponent();
            TxtRut.Enabled = false;
            TxtFecha.Enabled = false;
            TxtNombre.Enabled = false;
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            FormularioBuscarUsuarioCreado fb = new FormularioBuscarUsuarioCreado(this);
            fb.ShowDialog();
        }

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

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            try
            {

                Usuario usr = new Usuario();
                ServicioUsuario user = new ServicioUsuario();
                Validaciones val = new Validaciones();

                if (TxtNombre.Text == "" || TxtRut.Text == "")
                {
                    MessageBox.Show("SELECCIONE UN USUARIO");
                }
                else if (TxtUsuario.Text == "")
                {
                    MessageBox.Show("INGRESE UN NUMBRE DE USUARIO");
                }
                else if (TxtContraseña.Text == "")
                {
                    MessageBox.Show("INGRESE UNA CONTRASEÑA ");
                }
                else
                {
                    usr.idPersona = int.Parse(TxtIdUsuario.Text);
                    usr.rutPersona = TxtRut.Text;
                    usr.nombreCompletoPersona = TxtNombre.Text;
                    usr.nombreUsuario = TxtUsuario.Text;
                    usr.claveUsuario = TxtUsuario.Text;

                    user.GuardarUsario(usr);
                }
            }


            catch (Exception)
            {

                MessageBox.Show("ERROR AL GUARDAR USUARIO");
            }
        }
    }
}

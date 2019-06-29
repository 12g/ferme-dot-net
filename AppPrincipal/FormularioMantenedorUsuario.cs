using Biblioteca;
using ServiciosConexionFerme;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace AppPrincipal
{
    public partial class FormularioMantenedorUsuario : Form
    {
        Validaciones val = new Validaciones();
        public FormularioMantenedorUsuario()
        {
            InitializeComponent();

            TxtRut.Enabled = false;
            TxtFecha.Enabled = false;
            TxtNombre.Enabled = false;

            TxtContraseña.Text = "";
            // The password character is an asterisk.  
            TxtContraseña.PasswordChar = '*';
            // The control will allow no more than 14 characters.  
            TxtContraseña.MaxLength = 50;
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
                Usuario usr = new Usuario();
                ServicioUsuario serEmp = new ServicioUsuario();
                Validaciones val = new Validaciones();

                if (TxtNombre.Text == "" || TxtRut.Text == "")
                {
                    MessageBox.Show("SELECCIONE UN USUARIO");
                }
                else if (TxtUsuario.Text == "")
                {
                    MessageBox.Show("INGRESE UN NUMBRE DE USUARIO");
                }
                else if (TxtContraseña.Text =="")
                {
                    MessageBox.Show("INGRESE UNA CONTRASEÑA ");
                }
                else
                {
                    usr.idPersona = int.Parse(txtidPersona.Text);
                    usr.rutPersona = TxtRut.Text.ToLower();
                    usr.nombreCompletoPersona = TxtNombre.Text.ToLower();
                    usr.nombreUsuario = TxtUsuario.Text;
                    usr.claveUsuario = TxtUsuario.Text;


                    serEmp.GuardarUsario(usr);
                    limpiar();
                    MessageBox.Show("REGISTRO SE HA GUARDADO EXITOSAMENTE");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("ERROR AL GUARDAR USUARIO");
            }
            
        }


        private void FormularioMantenedorUsuario_Load(object sender, EventArgs e)
        {
            TxtFecha.Text = DateTime.Now.ToShortDateString();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            FormularioBuscarUsuario usr = new FormularioBuscarUsuario(this);
            usr.ShowDialog();
        }


        private void limpiar()
        {
            TxtContraseña.Text = "";
            TxtFecha.Text = DateTime.Now.ToShortDateString();
            txtidPersona.Text = "";
            TxtNombre.Text = "";
            TxtRut.Text = "";
            TxtUsuario.Text = "";
        }
    }
}

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
                Persona pers = new Persona();
                ServicioPersona serEmp = new ServicioPersona();
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
                    pers.idPersona = int.Parse(TxtIdUsuario.Text);
                    pers.rutPersona = TxtRut.Text;
                    pers.nombreCompletoPersona = TxtNombre.Text;
                    pers.nombreUsuario = TxtUsuario.Text;
                    pers.claveUsuario = TxtContraseña.Text;

                    serEmp.GuardarCliente(pers);
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
    }
}

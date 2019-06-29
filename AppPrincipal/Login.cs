using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Biblioteca;
using ServiciosConexionFerme;

namespace AppPrincipal
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


        private void TxtUsuario_Enter(object sender, EventArgs e)
        {
            if (TxtUsuario.Text =="USUARIO")
            {
                TxtUsuario.Text = "";
                TxtUsuario.ForeColor = Color.Black;
            }
        }

        private void TxtUsuario_Leave(object sender, EventArgs e)
        {
            if (TxtUsuario.Text == "")
            {
                TxtUsuario.Text = "USUARIO";
                TxtUsuario.ForeColor = default(Color);
            }
        }

        private void TxtContraseña_Enter(object sender, EventArgs e)
        {
            if (TxtContraseña.Text =="CONTRASEÑA")
            {
                TxtContraseña.Text = "";
                TxtContraseña.ForeColor = Color.Black;
                TxtContraseña.UseSystemPasswordChar = true;
            }
        }

        private void TxtContraseña_Leave(object sender, EventArgs e)
        {
            if (TxtContraseña.Text =="")
            {
                TxtContraseña.Text = "CONTRASEÑA";
                TxtContraseña.ForeColor = default(Color);
                TxtContraseña.UseSystemPasswordChar = false;
            }
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        //BOTON ACEPTAR PARA INGRESAR AL PROGRAMA
        private void BtnAcceder_Click(object sender, EventArgs e)
        {
            LoginRequest log = new LoginRequest();

            log.usuario = TxtUsuario.Text;
            log.clave = TxtContraseña.Text;
       
            ServicioSesion se = new ServicioSesion();
            Sesion resutadoLogin = se.ConexionLogin(log);

            if (resutadoLogin != null)
            {
                Program.se = resutadoLogin;
                FormularioPrincipal form1 = new FormularioPrincipal();
                form1.ShowDialog();

                LblDatosInvalidos.Visible = false;
            }
            else
            {
                LblDatosInvalidos.Visible = true;
            }
        }
    }
}

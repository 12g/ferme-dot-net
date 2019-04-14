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

namespace AppPrincipal
{
    public partial class FormularioPrincipal : Form
    {
        public FormularioPrincipal()
        {
            InitializeComponent();
        }


        //1-SE USA ESTAS PALABRAS QUE SON RESERVADAS DE LA LIBRERIA Y SE CREA LAS FUNCIONES
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd,int wmsg,int wparam,int lparam);



        //SE CREA EL MOVIMIENTO DE MENU PARA AGRANDAR Y ACHICAR LA PANTALLA
        private void BtnDeslizarMenu_Click(object sender, EventArgs e)
        {
            if (PanelMenuVertical.Width == 250)
            {
                PanelMenuVertical.Width = 76;
            }
            else
            {
                PanelMenuVertical.Width = 250;
            }
        }


        //SE CREA INSTANCIA DE BOTON CERRAR APLICACION
        private void IconoCerrarApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        //SE CREA INSTANCIA DE BOTON MAXIMIZAR APLICACION
        private void IconoMaximizarApp_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            IconoResetearApp.Visible = true;
            IconoMaximizarApp.Visible = false;
        }


        //SE CREA INSTANCIA DE BOTON RESTAURAR APLICACION
        private void IconoResetearApp_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            IconoResetearApp.Visible = false;
            IconoMaximizarApp.Visible = true;
        }


        //SE CREA INSTANCIA DE BOTON MINIMIZAR APLICACION
        private void IconoMinimizarApp_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }



        //SE LLAMAN LAS FUNCIONES QUE SE CREARON EN LAS LIBRERIA
        private void PanelBarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle,0x112,0xf012,0);
        }
    }
}

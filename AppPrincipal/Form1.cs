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

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();



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
    }
}

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


        //METODO PARA ARRASTRAR EL FORMULARIO
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


        //SE LLAMAN LAS FUNCIONES QUE SE CREARON EN LAS LIBRERIA
        private void PanelBarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //SE CREA EL MOVIMIENTO DE MENU PARA AGRANDAR Y ACHICAR LA PANTALLA
        private void BtnDeslizarMenu_Click(object sender, EventArgs e)
        {
            if (PanelMenuVertical.Width == 250)
            {
                PanelMenuVertical.Width = 74;
            }
            else
            {
                PanelMenuVertical.Width = 250;
            }
        }


        //SE CREA INSTANCIA DE BOTON CERRAR APLICACION
        private void IconoCerrarApp_Click(object sender, EventArgs e)
        {
            
            try
            {
                //MessageBox.Show("DESEA CERRAR LA APLICACION ? ","",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Exclamation);

                MessageBoxButtons botones = MessageBoxButtons.YesNoCancel;
                DialogResult dr = MessageBox.Show("¿Está seguro que desea salir del sistema?", "",botones, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
            catch
            {
                MessageBox.Show("Error al cerrar Aplicacion");
            }
        }


        //SE CREAN VARIABLES PARA MANTENER LA PSICION DEL FORMULARIO PRINCIPAL
        int LX, LV;
        //SE CREA INSTANCIA DE BOTON MAXIMIZAR APLICACION
        private void IconoMaximizarApp_Click(object sender, EventArgs e)
        {
            LX = this.Location.X;
            LV = this.Location.Y;

            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            //this.WindowState = FormWindowState.Maximized;
            IconoResetearApp.Visible = true;
            IconoMaximizarApp.Visible = false;
        }


        //SE CREA INSTANCIA DE BOTON RESTAURAR APLICACION
        private void IconoResetearApp_Click(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Normal;
            this.Location = new Point(LX,LV);
            this.Size = new Size(1284,612);
            IconoResetearApp.Visible = false;
            IconoMaximizarApp.Visible = true;
        }


        //SE CREA INSTANCIA DE BOTON MINIMIZAR APLICACION
        private void IconoMinimizarApp_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void AbrirFormInPanel<MIForm>() where MIForm : Form, new()
        {
            Form Formulario;
            Formulario = PanelContendorFormulario.Controls.OfType<MIForm>().FirstOrDefault();//busca en la coleccion el formulario
            //si el formulario / instancia no exite

            if (Formulario == null)
            {
                Formulario = new MIForm();
                Formulario.TopLevel = false;
                Formulario.FormBorderStyle = FormBorderStyle.None;
                Formulario.Dock = DockStyle.Fill;
                PanelContendorFormulario.Controls.Add(Formulario);
                PanelContendorFormulario.Tag = Formulario;
                Formulario.Show();
                Formulario.BringToFront();
            }
            //SI EL FORMULARIO /INSTANCIA EXISTE
            else
            {
                Formulario.BringToFront();
            }
        }



        //EVENTO DEL BOTON PRODUCTO EN EL PANEL PRINCIPAL
        private void btnProducto_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel<FormularioProducto>();
            btnProducto.BackColor = Color.FromArgb(178,34,34);
            BtnProveedor.BackColor = Color.FromArgb(128, 0, 0);
            BtnOrdenCompra.BackColor = Color.FromArgb(128, 0, 0);
            BtnCliente.BackColor = Color.FromArgb(128, 0, 0);
            BtnVentas.BackColor = Color.FromArgb(128, 0, 0);
            BtnRecepcion.BackColor = Color.FromArgb(128, 0, 0);
            BtnUsuario.BackColor = Color.FromArgb(128, 0, 0);
            BtnInformes.BackColor = Color.FromArgb(128, 0, 0);

        }

        //EVENTO DEL BOTON CLIENTE EN EL PANEL PRINCIPAL
        private void BtnCliente_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel<FormularioCliente>();
            btnProducto.BackColor = Color.FromArgb(128, 0, 0);
            BtnProveedor.BackColor = Color.FromArgb(128, 0, 0);
            BtnOrdenCompra.BackColor = Color.FromArgb(128, 0, 0);
            BtnCliente.BackColor = Color.FromArgb(178, 34, 34);
            BtnVentas.BackColor = Color.FromArgb(128, 0, 0);
            BtnRecepcion.BackColor = Color.FromArgb(128, 0, 0);
            BtnUsuario.BackColor = Color.FromArgb(128, 0, 0);
            BtnInformes.BackColor = Color.FromArgb(128, 0, 0);
        }

        //BOTON ORDEN DE COMPRA EL CUAL REDIRIGE A LA VISTA PRINCIPAL DEL FORMULARIO
        private void BtnOrdenCompra_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel<FormularioOrdenCompra>();
            btnProducto.BackColor = Color.FromArgb(128, 0, 0);
            BtnProveedor.BackColor = Color.FromArgb(128, 0, 0);
            BtnOrdenCompra.BackColor = Color.FromArgb(178, 34, 34);
            BtnCliente.BackColor = Color.FromArgb(128, 0, 0);
            BtnVentas.BackColor = Color.FromArgb(128, 0, 0);
            BtnRecepcion.BackColor = Color.FromArgb(128, 0, 0);
            BtnUsuario.BackColor = Color.FromArgb(128, 0, 0);
            BtnInformes.BackColor = Color.FromArgb(128, 0, 0);
        }

        //BOTON USUARIO
        private void BtnUsuario_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel<FormularioUsuario>();
            btnProducto.BackColor = Color.FromArgb(128, 0, 0);
            BtnProveedor.BackColor = Color.FromArgb(128, 0, 0);
            BtnOrdenCompra.BackColor = Color.FromArgb(128, 0, 0);
            BtnCliente.BackColor = Color.FromArgb(128, 0, 0);
            BtnVentas.BackColor = Color.FromArgb(128, 0, 0);
            BtnRecepcion.BackColor = Color.FromArgb(128, 0, 0);
            BtnUsuario.BackColor = Color.FromArgb(178, 34, 34);
            BtnInformes.BackColor = Color.FromArgb(128, 0, 0);
        }


        //METODO PARA MOSTRAR FECHA Y HORA DEL SISTEMA
        /*private void TimehorayFecha_Tick(object sender, EventArgs e)
        {
            LblHora.Text = DateTime.Now.ToLongTimeString();
            LblFecha.Text = DateTime.Now.ToLongDateString();
        }
        */

        //BOTON PROVEEDOR EL CUAL REDIRIGE A LA VISTA PRINCIPAL DEL FORMULARIO
        private void BtnProveedor_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel<FormularioProveedor>();

            btnProducto.BackColor = Color.FromArgb(128, 0, 0);
            BtnProveedor.BackColor = Color.FromArgb(178, 34, 34);
            BtnOrdenCompra.BackColor = Color.FromArgb(128, 0, 0);
            BtnCliente.BackColor = Color.FromArgb(128, 0, 0);
            BtnVentas.BackColor = Color.FromArgb(128, 0, 0);
            BtnRecepcion.BackColor = Color.FromArgb(128, 0, 0);
            BtnUsuario.BackColor = Color.FromArgb(128, 0, 0);
            BtnInformes.BackColor = Color.FromArgb(128, 0, 0);
        }
    }
}

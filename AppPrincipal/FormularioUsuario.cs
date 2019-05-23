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
    public partial class FormularioUsuario : Form
    {
        public FormularioUsuario()
        {
            InitializeComponent();
            ServicioEmpleado sere = new ServicioEmpleado();
            try
            {
                DGlistadoUsuario.DataSource = sere.ListaEmpleados();
            }
            catch (Exception)
            {
                MessageBox.Show("NO SE PUEDE CARGAR LOS DATOS EN MODULO DE USUARIO");
            }
        }

        //BOTON QUE CIERRA EL FORMULARIO DE USUARIO
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //BOTON CREAR USUARIO EL CUAL LLAMA AL FORMULARIO MANTENEDOR DE USUARIO
        private void BtnCrear_Click(object sender, EventArgs e)
        {
            FormularioMantenedorUsuario fmu = new FormularioMantenedorUsuario();
            fmu.ShowDialog();
        }

        private void BtnCargo_Click(object sender, EventArgs e)
        {
            FormularioMantenedorCargo car = new FormularioMantenedorCargo();
            car.ShowDialog();
        }

        private void BtnCrearEmpleado_Click(object sender, EventArgs e)
        {
            FormularioMantenedorEmpleado fme = new FormularioMantenedorEmpleado();
            fme.ShowDialog();
        }
    }
}

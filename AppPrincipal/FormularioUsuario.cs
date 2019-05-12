using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppPrincipal
{
    public partial class FormularioUsuario : Form
    {
        public FormularioUsuario()
        {
            InitializeComponent();
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
    }
}

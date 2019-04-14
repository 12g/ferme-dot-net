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
    public partial class Producto : Form
    {
        public Producto()
        {
            InitializeComponent();
        }

        //EVENTO BOTON CERRAR, EL CUAL CIERRA EL MODULO DEL PRODUCTO
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

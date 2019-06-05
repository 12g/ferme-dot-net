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
    public partial class FormularioBuscarVenta : Form
    {
        public FormularioBuscarVenta()
        {
            InitializeComponent();

            ServicioVentas ser = new ServicioVentas();
            DgMostrarVentasRealizadas.DataSource = ser.ListarVentas();
            
        }


        //BOTON CANCELAR
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

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (TxtBuscar.Text != "")
            {
                DgMostrarVentasRealizadas.CurrentCell = null;
                foreach (DataGridViewRow r in DgMostrarVentasRealizadas.Rows)
                {
                    r.Visible = false;
                }
                foreach (DataGridViewRow r in DgMostrarVentasRealizadas.Rows)
                {
                    foreach (DataGridViewCell c in r.Cells)
                    {
                        if ((c.Value.ToString().ToUpper()).IndexOf(TxtBuscar.Text.ToUpper()) == 0)
                        {
                            r.Visible = true;
                            break;
                        }
                    }

                }
            }
            else
            {
                 ServicioVentas ser = new ServicioVentas();
                 DgMostrarVentasRealizadas.DataSource = ser.ListarVentas();
            }
        }
    }
}

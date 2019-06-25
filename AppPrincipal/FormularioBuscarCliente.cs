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
    public partial class FormularioBuscarCliente : Form
    {
        private FromularioVentas frmventas;
        public FormularioBuscarCliente(FromularioVentas parametro)
        {
            InitializeComponent();

            frmventas = parametro;
            try
            {
                ServicioCliente serp = new ServicioCliente();
                DgMostrarCliente.DataSource = serp.ListarClientes();

                //OCULTAR COLUMNA
                 this.DgMostrarCliente.Columns["idPersona"].Visible = false;
                 this.DgMostrarCliente.Columns["idCliente"].Visible = false;
                //this.DgMostrarProductos.Columns[8].Visible = false;

                //DA NOMBRE A LAS COLUMNAS
                 this.DgMostrarCliente.Columns["nombreCompletoPersona"].HeaderText = "NOMBRE";
                 this.DgMostrarCliente.Columns["rutPersona"].HeaderText = "RUT";
            }
            catch (Exception)
            {
                MessageBox.Show("NO SE PUEDE CARGAR LISTADO DE PRODUCTOS");
            }
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


        //BUSCAR  CLIENTE  TXTBUSCAR
        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (TxtBuscar.Text != "")
            {
                DgMostrarCliente.CurrentCell = null;
                foreach (DataGridViewRow r in DgMostrarCliente.Rows)
                {
                    r.Visible = false;
                }
                foreach (DataGridViewRow r in DgMostrarCliente.Rows)
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
                ServicioCliente ser = new ServicioCliente();
                DgMostrarCliente.DataSource = ser.ListarClientes();
            }
        }

        private void DgMostrarCliente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {  
                frmventas.TxtIdpersona.Text = DgMostrarCliente.CurrentRow.Cells["idPersona"].Value.ToString();
                frmventas.TxtIdCliente.Text = DgMostrarCliente.CurrentRow.Cells["idCliente"].Value.ToString();
                frmventas.TxtRut.Text = DgMostrarCliente.CurrentRow.Cells["rutPersona"].Value.ToString();
                frmventas.TxtNombreRazonSocial.Text = DgMostrarCliente.CurrentRow.Cells["nombreCompletoPersona"].Value.ToString();
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("NO SE PUEDE SELECCIONAR");
            }
        }
    }
}

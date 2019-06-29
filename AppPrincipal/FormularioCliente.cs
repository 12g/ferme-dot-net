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
    public partial class FormularioCliente : Form
    {
        public FormularioCliente()
        {
            InitializeComponent();
            ListarCliente();
        }

        public void ListarCliente()
        {
            try
            {
                ServicioCliente sercl = new ServicioCliente();
                DGMostrarListaCliente.DataSource = sercl.ListarClientes();

               //OCULTA LAS FILAS
                this.DGMostrarListaCliente.Columns["idPersona"].Visible = false;
                this.DGMostrarListaCliente.Columns["idCliente"].Visible = false;



                //DA NOMBRE A LAS COLUMNAS
                this.DGMostrarListaCliente.Columns["rutPersona"].HeaderText = "RUT";
                this.DGMostrarListaCliente.Columns["nombreCompletoPersona"].HeaderText = "NOMBRE";
                
            }
            catch (Exception)
            {
                MessageBox.Show("NO HAY CLIENTES PARA MOSTRAR");
            }
        }

        //boton cancelar el cual cierra el formulario de cliente 
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //boton crear nuevo cliente
        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            FormularioMantenedorCliente fmc = new FormularioMantenedorCliente();
            if (fmc.ShowDialog() == DialogResult.OK)
            {
                ListarCliente();
            }
        }

        //BOTON EDITAR/METODO PARA SELECCIONAR UN CLIENTE DE LA LISTA Y EDITARLO
        private void BtnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                FormularioMantenedorCliente fmc = new FormularioMantenedorCliente();

                if (DGMostrarListaCliente.SelectedRows.Count >0)
                {
                    fmc.TxtRutCliente.Enabled = false;
                    fmc.TxtIdPersona.Text = DGMostrarListaCliente.CurrentRow.Cells["idPersona"].Value.ToString();
                    fmc.TxtIdCliente.Text = DGMostrarListaCliente.CurrentRow.Cells["idCliente"].Value.ToString();
                    fmc.TxtRutCliente.Text = DGMostrarListaCliente.CurrentRow.Cells["rutPersona"].Value.ToString();
                    fmc.TxtNombre.Text = DGMostrarListaCliente.CurrentRow.Cells["nombreCompletoPersona"].Value.ToString();

                    if (fmc.ShowDialog() == DialogResult.OK)
                    {
                        ListarCliente();
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar una fila");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("ERROR AL EDITAR LA FILA");
            }
           
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (TxtBuscar.Text != "")
            {
                DGMostrarListaCliente.CurrentCell = null;
                foreach (DataGridViewRow r in DGMostrarListaCliente.Rows)
                {
                    r.Visible = false;
                }
                foreach (DataGridViewRow r in DGMostrarListaCliente.Rows)
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
                ServicioCliente cli = new ServicioCliente();
                DGMostrarListaCliente.DataSource = cli.ListarClientes();
            }
        }
    }
}

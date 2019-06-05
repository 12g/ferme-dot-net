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
                this.DGMostrarListaCliente.Columns[0].Visible = false;
                this.DGMostrarListaCliente.Columns[8].Visible = false;



                //DA NOMBRE A LAS COLUMNAS
                this.DGMostrarListaCliente.Columns[1].HeaderText = "NOMBRE                  ";
                this.DGMostrarListaCliente.Columns[2].HeaderText = "RUT               ";
                this.DGMostrarListaCliente.Columns[3].HeaderText = "DIRECCION                ";
                this.DGMostrarListaCliente.Columns[4].HeaderText = "EMAIL               ";
                this.DGMostrarListaCliente.Columns[5].HeaderText = "TELEFONO 1      ";
                this.DGMostrarListaCliente.Columns[6].HeaderText = "TELEFONO 2      ";
                this.DGMostrarListaCliente.Columns[7].HeaderText = "TELEFONO 3      ";

            }
            catch (Exception)
            {
                MessageBox.Show("NO SE PUEDE CARGAR LISTADO DE CLIENTES");
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
            fmc.ShowDialog();
        }

        //BOTON EDITAR/METODO PARA SELECCIONAR UN CLIENTE DE LA LISTA Y EDITARLO
        private void BtnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                FormularioMantenedorCliente fmc = new FormularioMantenedorCliente();

                if (DGMostrarListaCliente.SelectedRows.Count >0)
                {
                    fmc.TxtIdCliente.Text = DGMostrarListaCliente.CurrentRow.Cells[8].Value.ToString();
                    fmc.TxtRutCliente.Text = DGMostrarListaCliente.CurrentRow.Cells[2].Value.ToString();
                    fmc.TxtNombre.Text = DGMostrarListaCliente.CurrentRow.Cells[1].Value.ToString();
                    fmc.TxtDireccion.Text = DGMostrarListaCliente.CurrentRow.Cells[3].Value.ToString();
                    fmc.TxtEmail.Text = DGMostrarListaCliente.CurrentRow.Cells[4].Value.ToString();
                    fmc.TxtTelefeno1.Text = DGMostrarListaCliente.CurrentRow.Cells[5].Value.ToString();
                    fmc.TxtTelefono2.Text = DGMostrarListaCliente.CurrentRow.Cells[6].Value.ToString();
                    fmc.TxtTelefono3.Text = DGMostrarListaCliente.CurrentRow.Cells[7].Value.ToString();

                    fmc.ShowDialog();

                    ServicioCliente servp = new ServicioCliente();
                    DGMostrarListaCliente.DataSource = servp.ListarClientes();
                    DGMostrarListaCliente.Refresh();
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

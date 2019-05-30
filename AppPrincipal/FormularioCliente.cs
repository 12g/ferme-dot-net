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
            ServicioCliente sercl = new ServicioCliente();
            try
            {
                DGMostrarListaCliente.DataSource = sercl.ListarClientes();
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
                    fmc.TxtRutCliente.Text = DGMostrarListaCliente.CurrentRow.Cells[0].Value.ToString();
                    fmc.TxtNombre.Text = DGMostrarListaCliente.CurrentRow.Cells[1].Value.ToString();
                    fmc.TxtDireccion.Text = DGMostrarListaCliente.CurrentRow.Cells[3].Value.ToString();
                    fmc.TxtEmail.Text = DGMostrarListaCliente.CurrentRow.Cells[4].Value.ToString();
                    fmc.TxtTelefeno1.Text = DGMostrarListaCliente.CurrentRow.Cells[5].Value.ToString();
                    fmc.TxtTelefono2.Text = DGMostrarListaCliente.CurrentRow.Cells[6].Value.ToString();
                    fmc.TxtTelefono3.Text = DGMostrarListaCliente.CurrentRow.Cells[7].Value.ToString();

                    fmc.ShowDialog();
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


        //TIEMPO DE ACTUALIZAR LISTADO
        private void FormularioCliente_Load(object sender, EventArgs e)
        {
            Timer actualizar_automatico = new Timer();
            actualizar_automatico.Interval = 3500;
            actualizar_automatico.Tick += actualizar_automatico_Tick;
            actualizar_automatico.Enabled = true;
        }
        private void recargar()
        {
            ServicioCliente ser = new ServicioCliente();
            DGMostrarListaCliente.DataSource = ser.ListarClientes();
        }

        private void actualizar_automatico_Tick(object sender, EventArgs e)
        {
            recargar();
        }
    }
}

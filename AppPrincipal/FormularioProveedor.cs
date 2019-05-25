using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ServiciosConexionFerme;

namespace AppPrincipal
{
    public partial class FormularioProveedor : Form
    {
        public FormularioProveedor()
        {
            InitializeComponent();
            ServicioProveedores serp = new ServicioProveedores();
            try
            {
                DgMostrarListaProveedor.DataSource = serp.ListadoProveedor();

                //OCULTA LAS COLUMNAS DEL DATAGRIDVIEW
                this.DgMostrarListaProveedor.Columns[0].Visible = false;
                this.DgMostrarListaProveedor.Columns[1].Visible = false;
                this.DgMostrarListaProveedor.Columns[8].Visible = false;

                //DA NOMBRE A LAS COLUMNAS
                this.DgMostrarListaProveedor.Columns[2].HeaderText = "RUT";
                this.DgMostrarListaProveedor.Columns[3].HeaderText = "DIRECCION";
                this.DgMostrarListaProveedor.Columns[4].HeaderText = "EMAIL";
                this.DgMostrarListaProveedor.Columns[5].HeaderText = "TELEFONO 1";
                this.DgMostrarListaProveedor.Columns[6].HeaderText = "TELEFONO 2";
                this.DgMostrarListaProveedor.Columns[7].HeaderText = "TELEFONO 3";
                this.DgMostrarListaProveedor.Columns[9].HeaderText = "RAZON SOCIAL";
                this.DgMostrarListaProveedor.Columns[10].HeaderText = "RUBRO";


            }
            catch (Exception)
            {
                MessageBox.Show("NO SE PUEDE CARGAR LISTADO DE PROVEEDOR");
            }
        }

        //BOTON PARA CERRAR EL FORMULARIO PRINCIAL DE PROVEEDORES
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //BOTON QUE LLAMA AL FORMULARIO MANTENEDOR DE PROVEEDOR PARA CREAR
        private void BtnCrear_Click(object sender, EventArgs e)
        {
            FormularioMantenedorProveedor fmp = new FormularioMantenedorProveedor();
            fmp.ShowDialog();
        }

        //BOTON EDITAR/METODO PARA SELECCIONAR UN PRODUCTO DE LA LISTA Y EDITARLO
        private void BtnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                FormularioMantenedorProveedor fmp = new FormularioMantenedorProveedor();
                if (DgMostrarListaProveedor.SelectedRows.Count > 0)
                {
                    fmp.TxtRazonSocial.Text = DgMostrarListaProveedor.CurrentRow.Cells[1].Value.ToString();
                    fmp.TxtRut.Text = DgMostrarListaProveedor.CurrentRow.Cells[2].Value.ToString();
                    fmp.TxtDireccion.Text = DgMostrarListaProveedor.CurrentRow.Cells[3].Value.ToString();
                    fmp.TxtEmail.Text = DgMostrarListaProveedor.CurrentRow.Cells[4].Value.ToString();
                    fmp.TxtTelefono1.Text = DgMostrarListaProveedor.CurrentRow.Cells[5].Value.ToString();
                    fmp.TxtTelefono2.Text = DgMostrarListaProveedor.CurrentRow.Cells[6].Value.ToString();
                    fmp.TxtTelefono3.Text = DgMostrarListaProveedor.CurrentRow.Cells[7].Value.ToString();

                    fmp.ShowDialog();
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

        private void BtnRubro_Click(object sender, EventArgs e)
        {
            FormularioMantenedorRubro fmr = new FormularioMantenedorRubro();
            fmr.ShowDialog();
        }

        private void FormularioProveedor_Load(object sender, EventArgs e)
        {
            Timer actualizar_automatico = new Timer();
            actualizar_automatico.Interval = 30000;
            actualizar_automatico.Tick += actualizar_automatico_Tick;
            actualizar_automatico.Enabled = true;
        }
        private void recargar()
        {
            ServicioProveedores ser = new ServicioProveedores();
            DgMostrarListaProveedor.DataSource = ser.ListadoProveedor();
        }

        private void actualizar_automatico_Tick(object sender, EventArgs e)
        {
            recargar();
        }
    }
}

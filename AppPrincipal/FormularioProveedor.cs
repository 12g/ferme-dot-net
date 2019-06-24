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
            ListarProveedor();  
        }



        //MUESTRA LISTA DE PROVEEDORES EN DATAGRIDVIEW
        public void ListarProveedor()
        {
            ServicioProveedores serp = new ServicioProveedores();
            try
            {
                DgMostrarListaProveedor.DataSource = serp.ListadoProveedor();

                  //OCULTA LAS COLUMNAS DEL DATAGRIDVIEW
                   this.DgMostrarListaProveedor.Columns["idPersona"].Visible = false;
                   this.DgMostrarListaProveedor.Columns["idProveedor"].Visible = false;
                   this.DgMostrarListaProveedor.Columns["nombreCompletoPersona"].Visible = false;

                   //DA NOMBRE A LAS COLUMNAS
                   this.DgMostrarListaProveedor.Columns["rutPersona"].HeaderText = "RUT";
                   this.DgMostrarListaProveedor.Columns["razonSocialProveedor"].HeaderText = "RAZON SOCIAL";
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
            ServicioProveedores ser = new ServicioProveedores();
            DgMostrarListaProveedor.DataSource = ser.ListadoProveedor();
            DgMostrarListaProveedor.Refresh();
        }

        //BOTON QUE LLAMA AL FORMULARIO MANTENEDOR DE PROVEEDOR PARA CREAR
        private void BtnCrear_Click(object sender, EventArgs e)
        {
            FormularioMantenedorProveedor fmp = new FormularioMantenedorProveedor();
            if (fmp.ShowDialog() == DialogResult.OK)
            {
                ListarProveedor();
            }
        }

        //BOTON EDITAR/METODO PARA SELECCIONAR UN PRODUCTO DE LA LISTA Y EDITARLO
        private void BtnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                FormularioMantenedorProveedor fmp = new FormularioMantenedorProveedor();
                if (DgMostrarListaProveedor.SelectedRows.Count > 0)
                {
                    fmp.TxtIdPersona.Text = DgMostrarListaProveedor.CurrentRow.Cells["idPersona"].Value.ToString();
                    fmp.TxtRut.Text = DgMostrarListaProveedor.CurrentRow.Cells["rutPersona"].Value.ToString();
                    fmp.TxtIdProveedor.Text = DgMostrarListaProveedor.CurrentRow.Cells["idProveedor"].Value.ToString();
                    fmp.TxtRazonSocial.Text = DgMostrarListaProveedor.CurrentRow.Cells["razonSocialProveedor"].Value.ToString();
                   
                    if (fmp.ShowDialog() == DialogResult.OK)
                    {
                        ListarProveedor();
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

     
        //BUSCAR
        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (TxtBuscar.Text != "")
            {
                DgMostrarListaProveedor.CurrentCell = null;
                foreach (DataGridViewRow r in DgMostrarListaProveedor.Rows)
                {
                    r.Visible = false;
                }
                foreach (DataGridViewRow r in DgMostrarListaProveedor.Rows)
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
                ServicioProveedores ser = new ServicioProveedores();
                DgMostrarListaProveedor.DataSource = ser.ListadoProveedor();
            }
        }
    }
}

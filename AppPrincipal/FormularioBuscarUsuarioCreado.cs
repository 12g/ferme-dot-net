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
    public partial class FormularioBuscarUsuarioCreado : Form
    {
        private FormularioEditarUsuario ediusuario;
        public FormularioBuscarUsuarioCreado(FormularioEditarUsuario parametro)
        {
            InitializeComponent();

            ediusuario = parametro;
            try
            {
                ServicioUsuario serp = new ServicioUsuario();
                DgMostrarPersona.DataSource = serp.ListarUsuario();

               //OCULTAR COLUMNA
                this.DgMostrarPersona.Columns["idPersona"].Visible = false;
                this.DgMostrarPersona.Columns["idUsuario"].Visible = false;
                this.DgMostrarPersona.Columns["nombreUsuario"].Visible = false;

                //DA NOMBRE A LAS COLUMNAS
                this.DgMostrarPersona.Columns["nombreCompletoPersona"].HeaderText = "NOMBRE";
                this.DgMostrarPersona.Columns["rutPersona"].HeaderText = "RUT";
                this.DgMostrarPersona.Columns["fechaCreacionUsuario"].HeaderText = "FECHA CREACION";
            }
            catch (Exception)
            {
                MessageBox.Show("NO SE PUEDE CARGAR LISTADO DE USUARIO");
            }
        }

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

        private void DgMostrarPersona_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                ediusuario.TxtIdUsuario.Text = DgMostrarPersona.CurrentRow.Cells["idUsuario"].Value.ToString();
                ediusuario.TxtIdPersona.Text = DgMostrarPersona.CurrentRow.Cells["idPersona"].Value.ToString();
                ediusuario.TxtRut.Text = DgMostrarPersona.CurrentRow.Cells["rutPersona"].Value.ToString();
                ediusuario.TxtNombre.Text = DgMostrarPersona.CurrentRow.Cells["nombreCompletoPersona"].Value.ToString();
                ediusuario.TxtUsuario.Text = DgMostrarPersona.CurrentRow.Cells["nombreUsuario"].Value.ToString();
                ediusuario.TxtFecha.Text = DgMostrarPersona.CurrentRow.Cells["fechaCreacionUsuario"].Value.ToString();
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("NO SE PUEDE SELECCIONAR");
            }
        }
    }
}

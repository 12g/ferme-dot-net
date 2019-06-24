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
    public partial class FormularioBuscarUsuario : Form
    {
        private FormularioMantenedorUsuario frmusuario;
        public FormularioBuscarUsuario(FormularioMantenedorUsuario parametro)
        {
            InitializeComponent();

            frmusuario = parametro;
           try
            {
                ServicioUsuario serp = new ServicioUsuario();
                DgMostrarPersona.DataSource = serp.ListarPersona();

                //OCULTAR COLUMNA
                this.DgMostrarPersona.Columns["idPersona"].Visible = false;
              
                //DA NOMBRE A LAS COLUMNAS
                this.DgMostrarPersona.Columns["nombreCompletoPersona"].HeaderText = "NOMBRE";
                this.DgMostrarPersona.Columns["rutPersona"].HeaderText = "RUT";
               
                
            }
            catch (Exception)
            {
                MessageBox.Show("NO SE PUEDE CARGAR LISTADO DE EMPLEADOS");
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

        private void TxtBuscarPersona_TextChanged(object sender, EventArgs e)
        {
            if (TxtBuscarPersona.Text != "")
            {
                DgMostrarPersona.CurrentCell = null;
                foreach (DataGridViewRow r in DgMostrarPersona.Rows)
                {
                    r.Visible = false;
                }
                foreach (DataGridViewRow r in DgMostrarPersona.Rows)
                {
                    foreach (DataGridViewCell c in r.Cells)
                    {
                        if ((c.Value.ToString().ToUpper()).IndexOf(TxtBuscarPersona.Text.ToUpper()) == 0)
                        {
                            r.Visible = true;
                            break;
                        }
                    }

                }
            }
            else
            {
                ServicioUsuario ser = new ServicioUsuario();
                DgMostrarPersona.DataSource = ser.ListarPersona();
            }
        }

        private void DgMostrarPersona_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                frmusuario.txtidPersona.Text = DgMostrarPersona.CurrentRow.Cells["idPersona"].Value.ToString();
                frmusuario.TxtRut.Text = DgMostrarPersona.CurrentRow.Cells["rutPersona"].Value.ToString();
                frmusuario.TxtNombre.Text = DgMostrarPersona.CurrentRow.Cells["nombreCompletoPersona"].Value.ToString();
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("NO SE PUEDE SELECCIONAR");
            }
        }
    }
}

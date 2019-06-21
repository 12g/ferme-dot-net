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
                ServicioPersona serp = new ServicioPersona();
                DgMostrarPersona.DataSource = serp.ListarEmpleado();

                //OCULTAR COLUMNA
                this.DgMostrarPersona.Columns[3].Visible = false;
                this.DgMostrarPersona.Columns[4].Visible = false;
                this.DgMostrarPersona.Columns[5].Visible = false;
                this.DgMostrarPersona.Columns[6].Visible = false;
                this.DgMostrarPersona.Columns[7].Visible = false;
                this.DgMostrarPersona.Columns[8].Visible = false;
                //this.DgMostrarPersona.Columns[9].Visible = false;
                //this.DgMostrarPersona.Columns[10].Visible = false;
                this.DgMostrarPersona.Columns[11].Visible = false;
                this.DgMostrarPersona.Columns[12].Visible = false;

                //DA NOMBRE A LAS COLUMNAS
                this.DgMostrarPersona.Columns[1].HeaderText = "NOMBRE";
                this.DgMostrarPersona.Columns[2].HeaderText = "RUT";
                this.DgMostrarPersona.Columns[9].HeaderText = "USUARIO";
                this.DgMostrarPersona.Columns[10].HeaderText = "CLAVE";

            }
            catch (Exception)
            {
                MessageBox.Show("NO SE PUEDE CARGAR LISTADO DE PRODUCTOS");
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
                ServicioPersona ser = new ServicioPersona();
                DgMostrarPersona.DataSource = ser.ListarEmpleado();
            }
        }

        private void DgMostrarPersona_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                frmusuario.TxtIdUsuario.Text = DgMostrarPersona.CurrentRow.Cells[0].Value.ToString();
                frmusuario.TxtRut.Text = DgMostrarPersona.CurrentRow.Cells[2].Value.ToString();
                frmusuario.TxtNombre.Text = DgMostrarPersona.CurrentRow.Cells[1].Value.ToString();
                frmusuario.TxtUsuario.Text = DgMostrarPersona.CurrentRow.Cells[9].Value.ToString();
                frmusuario.TxtContraseña.Text = DgMostrarPersona.CurrentRow.Cells[10].Value.ToString();
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("NO SE PUEDE SELECCIONAR");
            }
        }
    }
}

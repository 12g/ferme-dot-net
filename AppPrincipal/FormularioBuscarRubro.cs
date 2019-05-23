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
    public partial class FormularioBuscarRubro : Form
    {
        public FormularioBuscarRubro()
        {
            InitializeComponent();

            ServiciosRubro serR = new ServiciosRubro();
            try
            {
                DGlistadoRubro.DataSource = serR.ListarRubro();
            }
            catch (Exception)
            {
                MessageBox.Show("NO SE PUEDE CARGAR LISTADO DE RUBRO");
            }
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void DGlistadoRubro_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                FormularioMantenedorRubro fmp = new FormularioMantenedorRubro();
                if (DGlistadoRubro.SelectedRows.Count > 0)
                {
                    fmp.TxtRubro.Text = DGlistadoRubro.CurrentRow.Cells[1].Value.ToString();
                    fmp.TxtDescripcion.Text = DGlistadoRubro.CurrentRow.Cells[2].Value.ToString();
                   
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
    }
}

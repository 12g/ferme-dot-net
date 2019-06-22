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
    public partial class FormularioUsuario : Form
    {
        public FormularioUsuario()
        {
            InitializeComponent();
            Listaempleado();
        }

        //CARGA LISTA EMPLEADO
        public void Listaempleado()
        {

            try
            {
                ServicioEmpleado sere = new ServicioEmpleado();
                DGlistadoUsuario.DataSource = sere.ListaEmpleados();

               ///OCULTAR COLUMNAS
                this.DGlistadoUsuario.Columns["idPersona"].Visible = false;
                this.DGlistadoUsuario.Columns["idCargo"].Visible = false;
                this.DGlistadoUsuario.Columns["idEmpleado"].Visible = false;


                //DA NOMBRE A LAS COLUMNAS
                this.DGlistadoUsuario.Columns["rutPersona"].HeaderText = "RUT";
                this.DGlistadoUsuario.Columns["nombreCompletoPersona"].HeaderText = "NOMBRE";
                this.DGlistadoUsuario.Columns["direccionPersona"].HeaderText = "DIRECCION";
                this.DGlistadoUsuario.Columns["emailPersona"].HeaderText = "EMAIL";
                this.DGlistadoUsuario.Columns["fonoPersona1"].HeaderText = "TELEFONO 1";
                this.DGlistadoUsuario.Columns["fonoPersona2"].HeaderText = "TELEFONO 2";
                this.DGlistadoUsuario.Columns["fonoPersona3"].HeaderText = "TELEFONO 3";
                this.DGlistadoUsuario.Columns["descripcionCargo"].HeaderText = "CARGO";
            }
            catch (Exception)
            {
                MessageBox.Show("NO SE PUEDE CARGAR LOS DATOS EN MODULO DE USUARIO");
            }
        }

        //BOTON QUE CIERRA EL FORMULARIO DE USUARIO
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //BOTON CREAR USUARIO EL CUAL LLAMA AL FORMULARIO MANTENEDOR DE USUARIO
        private void BtnCrear_Click(object sender, EventArgs e)
        {
            FormularioMantenedorUsuario fmu = new FormularioMantenedorUsuario();
            fmu.ShowDialog();
        }

        //CREAR CARGO
        private void BtnCargo_Click(object sender, EventArgs e)
        {
            FormularioMantenedorCargo car = new FormularioMantenedorCargo();
            car.ShowDialog();
        }

        //CREAR EMPLEADO
        private void BtnCrearEmpleado_Click(object sender, EventArgs e)
        {
            FormularioMantenedorEmpleado fme = new FormularioMantenedorEmpleado();
            if (fme.ShowDialog() == DialogResult.OK)
            {
                Listaempleado();
            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                ServicioEmpleado ser = new ServicioEmpleado();
                FormularioMantenedorEmpleado fmp = new FormularioMantenedorEmpleado();

                if (DGlistadoUsuario.SelectedRows.Count > 0)
                {
                    fmp.TxtIdPersona.Text = DGlistadoUsuario.CurrentRow.Cells["idPersona"].Value.ToString(); ;
                    fmp.TxtIdEmpleado.Text = DGlistadoUsuario.CurrentRow.Cells["idEmpleado"].Value.ToString();
                    fmp.TxtRutCliente.Text = DGlistadoUsuario.CurrentRow.Cells["rutPersona"].Value.ToString();
                    fmp.CbxCargo.Text = DGlistadoUsuario.CurrentRow.Cells["descripcionCargo"].Value.ToString();
                    fmp.TxtNombre.Text = DGlistadoUsuario.CurrentRow.Cells["nombreCompletoPersona"].Value.ToString();

                    fmp.TxtDireccion.Text = DGlistadoUsuario.CurrentRow.Cells["direccionPersona"].Value.ToString();
                    fmp.TxtEmail.Text = DGlistadoUsuario.CurrentRow.Cells["emailPersona"].Value.ToString();
                    fmp.TxtTelefeno1.Text = DGlistadoUsuario.CurrentRow.Cells["fonoPersona1"].Value.ToString();
                    fmp.TxtTelefono2.Text = DGlistadoUsuario.CurrentRow.Cells["fonoPersona2"].Value.ToString();
                    fmp.TxtTelefono3.Text = DGlistadoUsuario.CurrentRow.Cells["fonoPersona3"].Value.ToString();

                     //BLOQUEA EL CAMPO DEL RUT AL MOMENTO DE EDITAR EL EMPLEADO
                    //fmp.TxtRutCliente.Enabled = false;

                    if (fmp.ShowDialog() == DialogResult.OK)
                    {
                        Listaempleado();
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
                DGlistadoUsuario.CurrentCell = null;
                foreach (DataGridViewRow r in DGlistadoUsuario.Rows)
                {
                    r.Visible = false;
                }
                foreach (DataGridViewRow r in DGlistadoUsuario.Rows)
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
                ServicioEmpleado ser = new ServicioEmpleado();
                DGlistadoUsuario.DataSource = ser.ListaEmpleados();
            }
        }
    }
}

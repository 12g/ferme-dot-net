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
            
            try
            {
                ServicioEmpleado sere = new ServicioEmpleado();
                DGlistadoUsuario.DataSource = sere.ListaEmpleados();

                //OCULTAR COLUMNAS
                this.DGlistadoUsuario.Columns[0].Visible = false;
                this.DGlistadoUsuario.Columns[8].Visible = false;

                
                //DA NOMBRE A LAS COLUMNAS
                this.DGlistadoUsuario.Columns[1].HeaderText = "NOMBRE";
                this.DGlistadoUsuario.Columns[2].HeaderText = "RUT";
                this.DGlistadoUsuario.Columns[3].HeaderText = "DIRECCION";
                this.DGlistadoUsuario.Columns[4].HeaderText = "EMAIL";
                this.DGlistadoUsuario.Columns[5].HeaderText = "TELEFONO 1";
                this.DGlistadoUsuario.Columns[6].HeaderText = "TELEFONO 2";
                this.DGlistadoUsuario.Columns[7].HeaderText = "TELEFONO 3";
                this.DGlistadoUsuario.Columns[9].HeaderText = "CARGO";
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
            fme.ShowDialog();
        }

        //ACTUALIZA EL DATAGRIDVIEW
        private void FormularioUsuario_Load(object sender, EventArgs e)
        {
           Timer actualizar_automatico = new Timer();
           actualizar_automatico.Interval = 3500;
           actualizar_automatico.Tick += actualizar_automatico_Tick;
           actualizar_automatico.Enabled = true;
        }

        private void recargar()
        {
           ServicioEmpleado ser = new ServicioEmpleado();
           DGlistadoUsuario.DataSource = ser.ListaEmpleados();
        }

        private void actualizar_automatico_Tick(object sender, EventArgs e)
        {
          recargar();
        }
        
        private void BtnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                ServicioEmpleado ser = new ServicioEmpleado();
                FormularioMantenedorEmpleado fmp = new FormularioMantenedorEmpleado();
                if (DGlistadoUsuario.SelectedRows.Count > 0)
                {
                    fmp.TxtRutCliente.Text = DGlistadoUsuario.CurrentRow.Cells[2].Value.ToString();
                    fmp.CbxCargo.Text = DGlistadoUsuario.CurrentRow.Cells[9].Value.ToString();
                    fmp.TxtNombre.Text = DGlistadoUsuario.CurrentRow.Cells[1].Value.ToString();

                    fmp.TxtDireccion.Text = DGlistadoUsuario.CurrentRow.Cells[3].Value.ToString();
                    fmp.TxtEmail.Text = DGlistadoUsuario.CurrentRow.Cells[4].Value.ToString();
                    fmp.TxtTelefeno1.Text = DGlistadoUsuario.CurrentRow.Cells[5].Value.ToString();
                    fmp.TxtTelefono2.Text = DGlistadoUsuario.CurrentRow.Cells[6].Value.ToString();
                    fmp.TxtTelefono3.Text = DGlistadoUsuario.CurrentRow.Cells[7].Value.ToString();

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

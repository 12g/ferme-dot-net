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
    public partial class FormularioMantenedorEmpleado : Form
    {
        public FormularioMantenedorEmpleado()
        {
            InitializeComponent();
            TxtIdEmpleado.Text = "0";
            TxtIdPersona.Text = "0";
            CargarComobox();
        }

    //CASILLA TEXTBOX RUT EMPLEADO
    private void TxtRutCliente_Leave(object sender, EventArgs e)
    {
        try
        {
            Validaciones val = new Validaciones();
            bool respuesta = false;
            string rut = TxtRutCliente.Text;
            TxtRutCliente.Text = val.formatoRut(rut);
            rut = TxtRutCliente.Text;
            respuesta = val.validarRut(rut);

            if (respuesta == false)
            {

                MessageBox.Show("RUT INVALIDO");
            }
            else
            {
                TxtRutCliente.ForeColor = Color.Black;
                TxtRutCliente.BackColor = Color.White;
                LblRutObligatorio.Visible = false;
                // MessageBox.Show("Rut OK");
            }
        }
        catch (Exception)
        {

            MessageBox.Show("INGRESE UN RUT VALIDO");
        }
    }


    //SE VA A BUSCAR EL METODO SOLOLETRAS EN TEXTBOX NOMBRE
    private void TxtNombre_KeyPress(object sender, KeyPressEventArgs e)
    {
        Validaciones val = new Validaciones();
        val.SoloLetras(e);
    }


    //APARECE EL SIGNO * SI EL NOMBRE ESTA EN BLANCO
    private void TxtNombre_Leave(object sender, EventArgs e)
    {
        Validaciones val = new Validaciones();

        if (TxtNombre.Text == "" || val.IsNumeric(TxtNombre.Text))
        {
            lblMensajeNombre.Visible = true;
        }
        else
        {
            lblMensajeNombre.Visible = false;
        }
    }

    //LIMPIAR
    private void Limpiar()
    {
        TxtRutCliente.Text = "";
        TxtNombre.Text = "";
        TxtIdEmpleado.Text = "0";
        TxtIdPersona.Text = "0";
    }

    //BOTON GUARDAR
    private void BtnGuardar_Click(object sender, EventArgs e)
    {
       try
        {
            Validaciones val = new Validaciones();

            if (TxtRutCliente.Text == "")
            {
                LblRutObligatorio.Visible = true;
            }
            else if (TxtRutCliente.Text.Length <= 7 || TxtRutCliente.Text.Length >= 13)
            {
                MessageBox.Show("EL RUT DEBE TENER MINIMO UN LARGO DE 7 DIGITOS");
            }
            else if (TxtNombre.Text == "" || val.IsNumeric(TxtNombre.Text))
            {
                MessageBox.Show("NOMBRE NO PUEDE ESTAR EN BLANCO ");
                lblMensajeNombre.Visible = true;
            }
            else if (CbxCargo.SelectedIndex.Equals(-1))
            {
                MessageBox.Show("SELECCIONE UN TIPO CARGO");
            }
            else
            {

                Empleado emp = new Empleado();
                ServicioEmpleado serv = new ServicioEmpleado();

                emp.idPersona = int.Parse(TxtIdPersona.Text);
                emp.idEmpleado = int.Parse(TxtIdEmpleado.Text);
                emp.idCargo = int.Parse(CbxCargo.SelectedValue.ToString());
                emp.rutPersona = TxtRutCliente.Text.ToLower();
                emp.nombreCompletoPersona = TxtNombre.Text.ToLower();

                serv.CrearEmpleado(emp);

                this.DialogResult = DialogResult.OK;

                    MessageBox.Show("REGISTRO SE HA GUARDADO EXITOSAMENTE");

                    Limpiar();

           }
        }
        catch (Exception)
        {

            MessageBox.Show("NO SE PUEDE GUARDAR EMPLEADO");
        }
    }

    private void CargarComobox()
    {
        ServicioCargo ser = new ServicioCargo();
        CbxCargo.DataSource = ser.ListarCargo();
        CbxCargo.DisplayMember = "descripcionCargo";
        CbxCargo.ValueMember = "idCargo";

        if (CbxCargo.Items.Count > 1)
        {
            CbxCargo.SelectedIndex = -1;
            CbxCargo.Text = "Seleccione";
        }
    }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("DESEA CERRAR LA APLICACION ? ","",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Exclamation);
            try
            {

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
    }
}

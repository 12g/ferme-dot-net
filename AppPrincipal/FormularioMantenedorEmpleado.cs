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

    //APARECE EL SIGNO * SI LA DIRECCION ESTA EN BLANCO
    private void TxtDireccion_Leave(object sender, EventArgs e)
    {
        try
        {
            Validaciones val = new Validaciones();

            if (TxtDireccion.Text == "" || val.IsNumeric(TxtDireccion.Text))
            {
                lblMensajeDireccion.Visible = true;
            }
            else
            {
                lblMensajeDireccion.Visible = false;
            }
        }
        catch (Exception)
        {
            MessageBox.Show("INGRESE UNA DIRECCION VALIDA");
        }

    }

    //SE USA EN EMAIL DE CLIENTE
    //METODO PARA VALIDAR EL FORMATO DEL EMAIL

    //EVENTO LEAVE PARA VALIDAR EL FORMATO DEL CORREO
    private void TxtEmail_Leave(object sender, EventArgs e)
    {
        try
        {

            Validaciones val = new Validaciones();

            if (val.ValidarEmail(TxtEmail.Text))
            {
                lblMensajeEmail.Visible = false;
            }
            else
            {
                lblMensajeEmail.Visible = true;
                TxtEmail.SelectAll();
            }
        }
        catch (Exception)
        {
            MessageBox.Show("INGRESE UN EMAIL VALIDO");
        }
    }

    //EVENTO QUE VALIDA QUE EL CAMPO TELEFONO 1 NUNCA ESTE VACIO HE INICIE CON UN CERO
    private void TxtTelefeno1_Leave(object sender, EventArgs e)
    {
        Validaciones val = new Validaciones();

        if (!val.IsNumeric(TxtTelefeno1.Text))
        {
            TxtTelefeno1.Text = "0";
        }
    }


    //EVENTO QUE VALIDA QUE EL CAMPO TELEFONO 2 NUNCA ESTE VACIO HE INICIE CON UN CERO
    private void TxtTelefono2_Leave(object sender, EventArgs e)
    {
        Validaciones val = new Validaciones();

        if (!val.IsNumeric(TxtTelefono2.Text))
        {
            TxtTelefono2.Text = "0";
        }
    }


    //EVENTO QUE VALIDA QUE EL CAMPO TELEFONO 3 NUNCA ESTE VACIO HE INICIE CON UN CERO
    private void TxtTelefono3_Leave(object sender, EventArgs e)
    {
        Validaciones val = new Validaciones();

        if (!val.IsNumeric(TxtTelefono3.Text))
        {
            TxtTelefono3.Text = "0";
        }
    }


    //LIMPIAR
    private void Limpiar()
    {
        TxtRutCliente.Text = "";
        TxtNombre.Text = "";
        TxtDireccion.Text = "";
        TxtEmail.Text = "";
        TxtTelefeno1.Text = "0";
        TxtTelefono2.Text = "0";
        TxtTelefono3.Text = "0";
        TxtIdEmpleado.Text = "0";
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
            else if (TxtDireccion.Text == "" || val.IsNumeric(TxtDireccion.Text))
            {
                MessageBox.Show("DIRECCION NO PUEDE ESTAR EN BLANCO");
                lblMensajeDireccion.Visible = true;
            }
            else if (TxtEmail.Text == "")
            {
                MessageBox.Show("EMAIL NO PUEDE ESTAR EN BLANCO");
                lblMensajeEmail.Visible = true;
            }
            else if (val.ValidarEmail(TxtEmail.Text) == false)
            {
                MessageBox.Show("INGRESE UN EMAIL VALIDO");
            }
            else if (!val.IsNumeric(TxtTelefeno1.Text) || TxtTelefeno1.TextLength >= 10)
            {
                MessageBox.Show("INGRESE UN TELEFONO VALIDO EN  CAMPO TELEFONO 1");
            }
            else if (!val.IsNumeric(TxtTelefono2.Text) || TxtTelefono2.TextLength >= 10)
            {
                MessageBox.Show("INGRESE UN TELEFONO VALIDO EN  CAMPO TELEFONO 2");
            }
            else if (!val.IsNumeric(TxtTelefono3.Text) || TxtTelefono3.TextLength >= 10)
            {
                MessageBox.Show("INGRESE UN TELEFONO VALIDO EN  CAMPO TELEFONO 3");
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
               //emp.idEmpleado = int.Parse(TxtIdEmpleado.Text);
                emp.idCargo = int.Parse(CbxCargo.SelectedValue.ToString());
                emp.rutPersona = TxtRutCliente.Text;
                emp.nombreCompletoPersona = TxtNombre.Text;
                emp.direccionPersona = TxtDireccion.Text;
                emp.emailPersona = TxtEmail.Text;
                emp.fonoPersona1 = int.Parse(TxtTelefeno1.Text);
                emp.fonoPersona2 = int.Parse(TxtTelefono2.Text);
                emp.fonoPersona3 = int.Parse(TxtTelefono3.Text);

                serv.CrearEmpleado(emp);

                this.DialogResult = DialogResult.OK;

                 MessageBox.Show("EMPLEADO GUARDADO");

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

    private void FormularioMantenedorEmpleado_Load(object sender, EventArgs e)
    {
        CargarComobox();
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

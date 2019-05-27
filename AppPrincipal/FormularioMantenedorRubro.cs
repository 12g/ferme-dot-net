using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca;
using ServiciosConexionFerme;


namespace AppPrincipal
{
    public partial class FormularioMantenedorRubro : Form
    {
        
        

        public FormularioMantenedorRubro()
        {
            InitializeComponent();
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

        //LIMPIAR
        private void Limpiar()
        {
            TxtRubro.Text = "";
            TxtDescripcion.Text = "";
        }

        //BOTON GUARDAR
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Validaciones val = new Validaciones();
                ServiciosRubro serRub = new ServiciosRubro();
                //SI LOS VALORES NO SON NUMERICOS ENVIO UN MENSAJE DE ERROR 
                if (TxtRubro.Text == "" || Convert.ToInt32(TxtRubro.Text) < 1 || !val.IsNumeric(TxtRubro.Text))
                {
                    MessageBox.Show("DEBE INGRESAR UN NUMERO EN CAMPO CODIGO");
                    ImagenTicketBueno.Visible = false;
                    LblCodigoObligatorio.Visible = true;
                }

                //VALIDA QUE SEA PURAS LETRAS
                else if (TxtDescripcion.Text == "" || val.IsNumeric(TxtDescripcion.Text))
                {
                    MessageBox.Show("DEBE INGRESAR UNA DESCRIPCION");
                    ImagenTicketBueno.Visible = false;
                    LblDescripcionObligatoria.Visible = true;
                }
                //DESPUES CUMPLIR LAS CONDICIONES PUESTAS SE CREA EL RUBRO
                else
                {

                    Rubro RU = new Rubro();
                    RU.idRubro = int.Parse(TxtRubro.Text);
                    RU.descripcionRubro = TxtDescripcion.Text;

                    serRub.CrearRubro(RU);
                    ImagenTicketBueno.Visible = true;
                    Limpiar();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR AL GUARDAR EL RUBRO");
                ImagenTicketBueno.Visible = false;
            }
        }



        //CAJA TEXTBOX DESCRIPCION , EL CUAL SE CARGA EL METODO SOLOLETRAS
        private void TxtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones val = new Validaciones();
            val.SoloLetras(e);
        }

        //CAJA TEXTBOX IDRUBRO , EL CUAL SE CARGA EL METODO SOLONUMERO
        private void TxtRubro_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones val = new Validaciones();
            val.SoloNumero(e);
        }

        private void TxtRubro_Leave(object sender, EventArgs e)
        {
            Validaciones val = new Validaciones();
            if (TxtRubro.Text== "" ||Convert.ToInt32(TxtRubro.Text) <= 0 || !val.IsNumeric(TxtRubro.Text))
            {
                ImagenTicketBueno.Visible = false;
                LblCodigoObligatorio.Visible = true;
            }
            else
            {
                LblCodigoObligatorio.Visible = false;
            }
        }

        private void TxtDescripcion_Leave(object sender, EventArgs e)
        {
            Validaciones val = new Validaciones();
            if (TxtDescripcion.Text == "" || val.IsNumeric(TxtDescripcion.Text))
            {
                ImagenTicketBueno.Visible = false;
                LblDescripcionObligatoria.Visible = true;
            }
            else
            {
                LblDescripcionObligatoria.Visible = false;
            }
        }
    }
}

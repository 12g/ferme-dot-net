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


namespace AppPrincipal
{
    public partial class FormularioMantenedorRubro : Form
    {
        Validaciones val = new Validaciones();
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
        //BOTON GUARDAR
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                
                //SI LOS VALORES NO SON NUMERICOS ENVIO UN MENSAJE DE ERROR 
                if (Convert.ToInt32(TxtRubro.Text) < 1 || !val.IsNumeric(TxtRubro.Text))
                {
                   MessageBox.Show("DEBE INGRESAR UN NUMERO EN CAMPO CODIGO");
                    ImagenTicketBueno.Visible = false;
                }
                //VALIDA QUE SEA PURAS LETRAS
                else if (TxtDescripcion.Text == "" || val.IsNumeric(TxtDescripcion.Text))
                {
                    MessageBox.Show("DESCRIPCION DEBE INGRESAR LETRAS");
                    ImagenTicketBueno.Visible = false;
                }
                //DESPUES CUMPLIR LAS CONDICIONES PUESTAS SE CREA EL RUBRO
                else
                {
                    Rubro RU = new Rubro();
                    TxtRubro.Text = RU.IdRubro.ToString();
                    TxtDescripcion.Text = RU.Descripcion.ToUpper();
                    ImagenTicketBueno.Visible = true;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR AL GUARDAR EL RUBRO");
            }
        }


        //METODO PARA VALIDAR TEXTO
        private void SoloLetras(KeyPressEventArgs e)
        {
            try
            {
                //SE VALIDA QUE SEA UNA LETRA
                if (char.IsLetter(e.KeyChar))
                {
                    e.Handled = false;
                }

                //VALIDA SI ES UNA TECLA DE CONTROL
                else if (char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                
                //VALIDA SI ES UNA TECLA PARA DAR ESPACIO
                else if (char.IsSeparator(e.KeyChar))
                {
                    e.Handled = false;
                }
                
                //SI NO ES UNA LETRA O UNA TECLA DE CONTROL NO ME DEJARA TECLEARLA
                else
                {
                    e.Handled = true;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        //METODO PARA VALIDAR NUMERO
        private void SoloNumero(KeyPressEventArgs e)
        {
            try
            {
                //SE VALIDA QUE SEA UN NUMERO
                if (char.IsNumber(e.KeyChar))
                {
                    e.Handled = false;
                }

                //VALIDA SI ES UNA TECLA DE CONTROL
                else if (char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                //SI NO ES UNA LETRA O UNA TECLA DE CONTROL NO ME DEJARA TECLEARLA
                else
                {
                    e.Handled = true;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }


        //CAJA TEXTBOX DESCRIPCION , EL CUAL SE CARGA EL METODO SOLOLETRAS
        private void TxtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloLetras(e);
        }

        //CAJA TEXTBOX IDRUBRO , EL CUAL SE CARGA EL METODO SOLONUMERO
        private void TxtRubro_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumero(e);
        }
    }
}

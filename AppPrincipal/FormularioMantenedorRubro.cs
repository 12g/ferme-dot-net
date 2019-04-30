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


        //metodo para validar si los valores son numericos
        private bool IsNumeric(string num)
        {
            try
            {
                int x = Convert.ToInt32(num);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                //SI LOS VALORES NO SON NUMERICOS ENVIO UN MENSAJE DE ERROR 
                if (!IsNumeric(TxtRubro.Text))
                {
                    ErrorProvider.ReferenceEquals(TxtRubro, "Debe Ingresar Un Numero");
                    MessageBox.Show("Debe Ingresar Valores Numericos");   
                }
                //SI NO ENTONCES SE CREA EL RUBRO
                else
                {
                 
                    Rubro RU = new Rubro();
                    TxtRubro.Text = RU.IdRubro.ToString();
                    TxtDescripcion.Text = RU.Descripcion;
                }
            
                    
            }
            catch (Exception)
            {

                MessageBox.Show("ERROR AL GUARDAR EL RUBRO");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Biblioteca
{
   public class Validaciones
    {
        //SE ESTA OCUPANDO FORMULARIO CLIENTE
        //FORMATO PARA EL RUT
        public string formatoRut(string rut)
        {
            int cont = 0;
            string format;
            rut = rut.Replace(".", "");
            rut = rut.Replace("-", "");
            format = "-" + rut.Substring(rut.Length - 1);
            for (int i = rut.Length - 2; i >= 0; i--)
            {
                format = rut.Substring(i, 1) + format;
                cont++;
                if (cont == 3 && i != 0)
                {
                    format = "." + format;
                    cont = 0;
                }
            }
            return format;
        }

        //SE ESTA OCUPANDO FOMRULARIO CLIENTE
        //VALIDACION DEL RUT
        public bool validarRut(string rut)
        {
            bool validacion = false;
            rut = rut.ToUpper();
            rut = rut.Replace(".", "");
            rut = rut.Replace("-", "");
            int rutAux = int.Parse(rut.Substring(0, rut.Length - 1));
            char dv = char.Parse(rut.Substring(rut.Length - 1, 1));
            int m = 0, s = 1;
            for (; rutAux != 0; rutAux /= 10)
            {
                s = (s + rutAux % 10 * (9 - m++ % 6)) % 11;
            }
            if (dv == (char)(s != 0 ? s + 47 : 75))
            {
                validacion = true;
            }
            return validacion;
        }

        //SE ESTA OCUPANDO EN FORMULARIO MANTENEDOR RUBRO Y CLIENTE
        //metodo para validar si los valores son letras
        public bool IsNumeric(string num)
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

        //SE USA EN MANTENDOR RUBRO Y CLIENTE
        //METODO PARA USAR SOLAMENTE TEXTO
        public void SoloLetras(KeyPressEventArgs e)
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

        //SE USA EN MANTENDOR RUBRO Y CLIENTE
        //METODO PARA USAR SOLAMENTE NUMERO
        public void SoloNumero(KeyPressEventArgs e)
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

        //SE USA EN EMAIL DE CLIENTE
        //METODO PARA VALIDAR EL FORMATO DEL EMAIL
        public  bool ValidarEmail(string Email)
        {
            string Expression = "\\w+([-+,']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";

            if (Regex.IsMatch(Email,Expression))
            {
                if (Regex.Replace(Email, Expression, string.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}

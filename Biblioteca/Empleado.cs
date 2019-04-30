using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
   public class Empleado
    {
        private int _Id_Empleado;

        public Empleado()
        {
            this._Id_Empleado = 0;
        }

        public int Id_Empleado { get => _Id_Empleado; set => _Id_Empleado = value; }
    }
}

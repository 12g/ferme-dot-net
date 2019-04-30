using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
   public class Rubro
    {
        private int _IdRubro;
        private string _Descripcion;

        public Rubro()
        {
            this._IdRubro = 0;
            this._Descripcion = string.Empty; ;
        }

        public int IdRubro { get => _IdRubro; set => _IdRubro = value; }
        public string Descripcion { get => _Descripcion; set => _Descripcion = value; }
    }
}

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

        public Rubro(int IdRubro, string Descripcion)
        {
            _IdRubro = IdRubro;
            _Descripcion = Descripcion;
        }

        public int IdRubro { get => _IdRubro; set => _IdRubro = value; }
        public string Descripcion { get => _Descripcion; set => _Descripcion = value; }
    }
}

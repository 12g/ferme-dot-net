using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
     public class TipoProducto
    {
        private int _IdTipoProducto;
        private string _NombreTipo;

        public TipoProducto(int IdTipoProducto, string NombreTipo)
        {
            _IdTipoProducto = IdTipoProducto;
            _NombreTipo = NombreTipo;
        }

        public int IdTipoProducto { get => _IdTipoProducto; set => _IdTipoProducto = value; }
        public string NombreTipo { get => _NombreTipo; set => _NombreTipo = value; }
    }
}

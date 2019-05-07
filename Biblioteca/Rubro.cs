using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Rubro
    {
        //public int idRubro { get; set; }
        //public string descripcionRubro { get; set; }
        private int _IdRubro;
        private string _Descripcion;

        public Rubro()
        {
            _IdRubro = 0;
            _Descripcion = string.Empty;
        }

        public int idRubro { get => _IdRubro; set => _IdRubro = value; }
        public string descripcionRubro { get => _Descripcion; set => _Descripcion = value; }
    }
}


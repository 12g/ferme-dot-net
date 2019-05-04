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
        //ATRIBUTOS
        private int _IdRubro;
        private string _Descripcion;

        //CONSTRUCTOR
        public Rubro()
        {
            this.Init();
        }


        private void Init()
        {
            this._IdRubro = 0;
            this._Descripcion = string.Empty;
        }

        //GET AND SET
        public int IdRubro { get => _IdRubro; set => _IdRubro = value; }

        public string Descripcion
        {
            get => _Descripcion; set => _Descripcion = value;
        }

    }
}


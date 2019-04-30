using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Cargo
    {
        private int _Id_Cargo;
        private string _Descripcion;

        public Cargo(int Id_Cargo, string Descripcion)
        {
            _Id_Cargo = Id_Cargo;
            _Descripcion = Descripcion;
        }

        public int Id_Cargo { get => _Id_Cargo; set => _Id_Cargo = value; }
        public string Descripcion { get => _Descripcion; set => _Descripcion = value; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
     public class Usuario
    {
        private int _IdUsuario;
        private string _Nombre;
        private string _Clave;
        private DateTime _FechaCreacion;

        public Usuario(int IdUsuario, string Nombre, string Clave, DateTime FechaCreacion)
        {
            _IdUsuario = IdUsuario;
            _Nombre = Nombre;
            _Clave = Clave;
            _FechaCreacion = FechaCreacion;
        }

        public int IdUsuario { get => _IdUsuario; set => _IdUsuario = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string Clave { get => _Clave; set => _Clave = value; }
        public DateTime FechaCreacion { get => _FechaCreacion; set => _FechaCreacion = value; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Persona
    {
        private int _IdPersona;
        private string _NombreCompleto;
        private string _Rut;

        public Persona(int IdPersona, string NombreCompleto, string Rut)
        {
            _IdPersona = IdPersona;
            _NombreCompleto = NombreCompleto;
            _Rut = Rut;
        }

        public int IdPersona { get => _IdPersona; set => _IdPersona = value; }
        public string NombreCompleto { get => _NombreCompleto; set => _NombreCompleto = value; }
        public string Rut { get => _Rut; set => _Rut = value; }
    }
}

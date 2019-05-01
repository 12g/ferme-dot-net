using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Persona
    {
        //ATRIBUTOS
        private int _IdPersona;
        private string _NombreCompleto;
        private string _Rut;

        //CONSTRUCTOR
        public Persona()
        {
            this.Init();
        }

        private void Init()
        {
            this._IdPersona = 0;
            this._NombreCompleto = string.Empty;
            this._Rut = string.Empty;
        }

        //GET AND SET
        public int IdPersona { get => _IdPersona; set => _IdPersona = value; }
        public string NombreCompleto { get => _NombreCompleto; set => _NombreCompleto = value; }
        public string Rut { get => _Rut; set => _Rut = value; }
    }
}

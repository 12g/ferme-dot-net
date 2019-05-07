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
        private string _Direccion;
        private string _Email;
        private int _Fono1;
        private int _Fono2;
        private int _Fono3;

        

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
            this._Direccion = string.Empty;
            this._Email = string.Empty;
            this._Fono1 = 0;
            this._Fono2 = 0;
            this._Fono3 = 0;
        }

        //GET AND SET
        public int IdPersona { get => _IdPersona; set => _IdPersona = value; }
        public string NombreCompleto { get => _NombreCompleto; set => _NombreCompleto = value; }
        public string Rut { get => _Rut; set => _Rut = value; }
        public string Direccion { get => _Direccion; set => _Direccion = value; }
        public string Email { get => _Email; set => _Email = value; }
        public int Fono1 { get => _Fono1; set => _Fono1 = value; }
        public int Fono2 { get => _Fono2; set => _Fono2 = value; }
        public int Fono3 { get => _Fono3; set => _Fono3 = value; }
    }
}

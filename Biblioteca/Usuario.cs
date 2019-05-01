using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
     public class Usuario
    {
        //ATRIBUTOS
        private int _IdUsuario;
        private string _Nombre;
        private string _Clave;
        private DateTime _FechaCreacion;

        //CONSTRUCTOR
        public Usuario()
        {
            this.Init();
        }

        
        private void Init()
        {
            this._IdUsuario = 0;
            this._Nombre = string.Empty;
            this._Clave = string.Empty;
            this._FechaCreacion = DateTime.Now;
        }

        //GET AND SET
        public int IdUsuario { get => _IdUsuario; set => _IdUsuario = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string Clave { get => _Clave; set => _Clave = value; }
        public DateTime FechaCreacion { get => _FechaCreacion; set => _FechaCreacion = value; }
    }
}

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
        public int idPersona { get; set; }
        public string nombreCompletoPersona { get; set; }
        public string rutPersona { get; set; }
        public string direccionPersona { get; set; }
        public string emailPersona { get; set; }
        public int fonoPersona1 { get; set; }
        public int fonoPersona2 { get; set; }
        public int fonoPersona3 { get; set; }
        public int idUsuario { get; set; }
        public string nombreUsuario { get; set; }
        public string claveUsuario { get; set; }
        public string fechaCreacionUsuario { get; set; }
        public string sesion { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
   public class Cliente
    {
        //ATRIBUTOS
        private int idCliente { get; set; }
        public int idPersona { get; set; }
        public string nombreCompletoPersona { get; set; }
        public string rutPersona { get; set; }
        public string direccionPersona { get; set; }
        public string emailPersona { get; set; }
        public int fono1 { get; set; }
        public int fono2 { get; set; }
        public int fono3 { get; set; }
    }
}

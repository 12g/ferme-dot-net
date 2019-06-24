using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
   public class Empleado
    {
        //ATRIBUTOS
        public int? idPersona { get; set; }
        public string nombreCompletoPersona { get; set; }
        public string rutPersona { get; set; }
        public int idEmpleado { get; set; }
        public int idCargo { get; set; }
        public string descripcionCargo { get; set; }
    }
}

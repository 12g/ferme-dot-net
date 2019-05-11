using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Proveedor
    {
        //ATRIBUTOS
        public int idProveedor { get; set; }
        public string razonSocial { get; set; }
        public int idRubro { get; set; }
        public int idPersona { get; set; }
        public string nombreCompleto { get; set; }
        public string rut { get; set; }
        public string direccion { get; set; }
        public string email { get; set; }
        public int fono1 { get; set; }
        public int fono2 { get; set; }
        public int fono3 { get; set; }
    }
}

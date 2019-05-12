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
        public int idCliente { get; set; }
        public int id_persona { get; set; }
        public string nombre_completo { get; set; }
        public string rut { get; set; }
        public string direccion { get; set; }
        public string email { get; set; }
        public int fono1 { get; set; }
        public int fono2 { get; set; }
        public int fono3 { get; set; }
    }
}

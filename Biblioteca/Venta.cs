using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
     public class Venta
    {
        public int? idVenta { get; set; }
        public string tipoVenta { get; set; }
        public string fechaVenta { get; set; }
        
        public int idEmpleado { get; set; }
        public int idCliente { get; set; }
        public int subtotalVenta { get; set; }
        public List<Detalle_Venta> detallesVenta { get; set; }
    }
}

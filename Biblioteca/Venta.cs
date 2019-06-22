using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
     public class Venta
    {
       // [DisplayName("COD COMPRA")]
        public int? idVenta { get; set; }

        //[DisplayName("TIPOVENTA")]
        public string tipoVenta { get; set; }

        //[DisplayName("FECHA COMPRA")]
        public string fechaVenta { get; set; }

        //[DisplayName("COD VENDEDOR")]
        public int idEmpleado { get; set; }

        //[DisplayName("NOMBRE VENDEDOR")]
        public string nombreCompletoPersonaEmpleado { get; set; }

        //[DisplayName("RUT CLIENTE")]
        public string rutPersonaCliente { get; set; }

        //[DisplayName("CLIENTE")]
        public string nombreCompletoPersonaCliente { get; set; }

        //[Browsable(false)]
        public string rutPersonaEmpleado { get; set; }

        //[Browsable(false)]
        public int idCliente { get; set; }

        //[DisplayName("TOTAL")]
        public int subtotalVenta { get; set; }

        public List<Detalle_Venta> detallesVenta { get; set; }
    }
}

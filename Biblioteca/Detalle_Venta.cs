using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Detalle_Venta
    {

        //ATRIBUTOS
        public int idDetalleVenta { get; set; }
        public int idProducto { get; set; }
        public int unidadesProducto { get; set; }
        public int montoDetalleVenta { get; set; }
        public int idVenta { get; set; }

        public int codigoProducto { get; set; }
        public string nombreProducto { get; set; }
    }
}

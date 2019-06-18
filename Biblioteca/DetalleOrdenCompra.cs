using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class DetalleOrdenCompra
    {
  
        public int idOrdenCompra { get; set; }
        public int? idDetalleOrdenCompra { get; set; }
        public int idProducto { get; set; }
        public long codigoProducto { get; set; }
        public string nombreProducto { get; set; }
        public int cantidadProducto { get; set; }

    }
}

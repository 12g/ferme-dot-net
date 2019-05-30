using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class DetalleOrdenCompra
    {
        //ATRIBUTOS
        public int? idDetalleOrdenCompra { get; set; }
        public int idOrdenCompra { get; set; }
        public int idProducto { get; set; }
        public int cantidadProducto { get; set; }

    }
}

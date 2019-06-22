using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Producto
    {
        public int? idProducto { get; set; }
        public string codigoProducto { get; set; }
        public string nombreProducto { get; set; }
        public object descripcionProducto { get; set; }
        public int precioProducto { get; set; }
        public int stockActualProducto { get; set; }
        public int stockCriticoProducto { get; set; }
        public int idTipoProducto { get; set; }
        public string nombreTipoProducto { get; set; }
        public int idFamiliaProducto { get; set; }
        public string descripcionFamiliaProducto { get; set; }

    }
}

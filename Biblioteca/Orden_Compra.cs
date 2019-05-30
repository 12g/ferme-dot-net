using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Orden_Compra
    {
        public int? idOrdenCompra { get; set; }
        public int idEmpleado { get; set; }
        public string estadoOrdenCompra { get; set; }
        public string fechaSolicitudOrdenCompra { get; set; }
        public string fechaRecepcionOrdenCompra { get; set; }
        public List<DetalleOrdenCompra> detallesOrdenCompra { get; set; }
    }
}


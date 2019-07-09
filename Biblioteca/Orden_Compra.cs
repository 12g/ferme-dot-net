using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Orden_Compra
    {
        
        public int? idOrdenCompra { get; set; }
        public int idEmpleado { get; set; }
        public string nombreEmpleado { get; set; }
        public string rutEmpleado { get; set; }
        public string estadoOrdenCompra { get; set; }
        public string fechaSolicitudOrdenCompra { get; set; }
        public String fechaRecepcionOrdenCompra { get; set; }

        public List<DetalleOrdenCompra> detallesOrdenCompra { get; set; }
        public List<DetalleOrdenCVista> detallesOrdenVista { get; set; }

    }
}


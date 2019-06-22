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
        [DisplayName("COD COMPRA")]
        public int? idOrdenCompra { get; set; }

        [DisplayName("COD EMPLEADO")]
        public int idEmpleado { get; set; }

        [DisplayName("NOMBRE EMPLEADO")]
        public string nombrePersonaEmpleado { get; set; }

        [DisplayName("ESTADO")]
        public string estadoOrdenCompra { get; set; }

        [DisplayName("FECHA SOLICITUD ")]
        public string fechaSolicitudOrdenCompra { get; set; }

        [DisplayName("FECHA RECEPCION")]
        public string fechaRecepcionOrdenCompra { get; set; }

        public List<DetalleOrdenCompra> detallesOrdenCompra { get; set; }
        public List<DetalleOrdenCVista> detallesOrdenVista { get; set; }


    }
}


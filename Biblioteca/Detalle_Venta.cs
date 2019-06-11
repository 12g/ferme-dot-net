using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Detalle_Venta
    {

        //ATRIBUTOS
        [System.ComponentModel.Browsable(false)]
        public int idDetalleVenta { get; set; }

        [System.ComponentModel.Browsable(false)]
        public int idProducto { get; set; }

        [System.ComponentModel.Browsable(false)]
        public int idVenta { get; set; }

        [DisplayName("CODIGO DEL PRODUCTO")]
        public long codigoProducto { get; set; }

        [DisplayName("NOMBRE PRODUCTO")]
        public string nombreProducto { get; set; }

        [DisplayName("UNIDADES")]
        public int unidadesProducto { get; set; }

        [DisplayName("MONTO")]
        public int montoDetalleVenta { get; set; }

        [DisplayName("SUBTOTAL")]
        public int Subtotal { get; set; }

    }
}

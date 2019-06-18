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
        //[System.ComponentModel.Browsable(false)]
        public int idDetalleVenta { get; set; }

        //[System.ComponentModel.Browsable(false)]
        public int idVenta { get; set; }

        //[System.ComponentModel.Browsable(false)]
        public int idProducto { get; set; }

        //[DisplayName("CODIGO DEL PRODUCTO")]
        public long codigoProducto { get; set; }

        //[System.ComponentModel.Browsable(false)]
        //[DisplayName("NOMBRE PRODUCTO")]
        public string nombreProducto { get; set; }

        //[System.ComponentModel.Browsable(false)]
        //[DisplayName("UNIDADES")]
        public int unidadesProducto { get; set; }

        //[System.ComponentModel.Browsable(false)]
        [DisplayName("MONTO")]
        public int montoDetalleVenta { get; set; }

       // [System.ComponentModel.Browsable(false)]
       // [DisplayName("SUBTOTAL")]
        public int Subtotal { get; set; }

    }
}

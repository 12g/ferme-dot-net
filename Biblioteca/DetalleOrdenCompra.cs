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
        //ATRIBUTOS
        //DISPLAYNAME LE DA NOMBRE AL ATRIBUTO AL MOMENTO DE CARGAR EL DATAGRIDVIEW EN FORMULARIO ORDEN COMPRA
        //[System.ComponentModel.Browsable(false)] OCULTA LA FILA EN EL DATAGRIDVIEW

        //[System.ComponentModel.Browsable(false)]
        [DisplayName("COD COMPRA")]
        public int idOrdenCompra { get; set; }

        //[System.ComponentModel.Browsable(false)]
        [DisplayName("COD DETALLE")]
        public int? idDetalleOrdenCompra { get; set; }

        //[System.ComponentModel.Browsable(false)]
        [DisplayName("CODIGO")]
        public int idProducto { get; set; }

        //[DisplayName("CODIGO")]
        [DisplayName("COD PRODUCTO")]
        public long codigoProducto { get; set; }

        [DisplayName("DESCRIPCION")]
        //[DisplayName("NOMBRE PRODUCTO")]
        public string nombreProducto { get; set; }

        [DisplayName("CANTIDAD")]
        //[DisplayName("CANTIDAD")]
        public int cantidadProducto { get; set; }

    }
}

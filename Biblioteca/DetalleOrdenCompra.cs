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


        [System.ComponentModel.Browsable(false)]
        public int idDetalleOrdenCompra { get; set; }

        [System.ComponentModel.Browsable(false)]
        public int idOrdenCompra { get; set; }

        [System.ComponentModel.Browsable(false)]
        public int idProducto { get; set; }

        [DisplayName("CODIGO")]
        public long codigoProducto { get; set; }

        [DisplayName("NOMBRE PRODUCTO")]
        public string nombreProducto { get; set; }

        [DisplayName("CANTIDAD")]
        public int cantidadProducto { get; set; }



       

       

    }
}

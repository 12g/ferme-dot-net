using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class DetalleOrdenCompra
    {
        private int _Id_detalle_Orden_Compra;
        private int _Cantidad;

        public DetalleOrdenCompra(int Id_detalle_Orden_Compra, int Cantidad)
        {
            _Id_detalle_Orden_Compra = Id_detalle_Orden_Compra;
            _Cantidad = Cantidad;
        }

        public int Id_detalle_Orden_Compra { get => _Id_detalle_Orden_Compra; set => _Id_detalle_Orden_Compra = value; }
        public int Cantidad { get => _Cantidad; set => _Cantidad = value; }
    }
}

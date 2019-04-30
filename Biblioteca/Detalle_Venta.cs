using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Detalle_Venta
    {
        private int _Id_Detalle_Venta;
        private int _Unidades;
        private int _Monto_Detalle;

        public Detalle_Venta()
        {
            this._Id_Detalle_Venta = 0;
            this._Unidades = 0;
            this._Monto_Detalle = 0;
        }

        public int Id_Detalle_Venta { get => _Id_Detalle_Venta; set => _Id_Detalle_Venta = value; }
        public int Unidades { get => _Unidades; set => _Unidades = value; }
        public int Monto_Detalle { get => _Monto_Detalle; set => _Monto_Detalle = value; }
    }
}

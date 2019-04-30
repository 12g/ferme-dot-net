using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
     public class Venta
    {
        private int _IdVenta;
        private char _Tipo_Venta;
        private DateTime _Fecha;
        private int _SubTotal;

        public Venta()
        {
            this._IdVenta = 0;
            this._Tipo_Venta = 'B';
            this._Fecha = DateTime.Now;
            this._SubTotal = 0;
        }

        public int IdVenta { get => _IdVenta; set => _IdVenta = value; }
        public char Tipo_Venta1 { get => _Tipo_Venta; set => _Tipo_Venta = value; }
        public DateTime Fecha { get => _Fecha; set => _Fecha = value; }
        public int SubTotal { get => _SubTotal; set => _SubTotal = value; }
    }
}

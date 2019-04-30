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
        private char Tipo_Venta;
        private DateTime _Fecha;
        private int _SubTotal;

        public Venta(int IdVenta, char tipo_Venta, DateTime Fecha, int SubTotal)
        {
            _IdVenta = IdVenta;
            Tipo_Venta = tipo_Venta;
            _Fecha = Fecha;
            _SubTotal = SubTotal;
        }

        public int IdVenta { get => _IdVenta; set => _IdVenta = value; }
        public char Tipo_Venta1 { get => Tipo_Venta; set => Tipo_Venta = value; }
        public DateTime Fecha { get => _Fecha; set => _Fecha = value; }
        public int SubTotal { get => _SubTotal; set => _SubTotal = value; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Orden_Compra
    {
        private int _Id_Orden_Compra;
        private char _Estado;
        private DateTime _Fecha_Solicitud;
        private DateTime _Fecha_Recepcion;

        public Orden_Compra(int Id_Orden_Compra, char Estado, DateTime Fecha_Solicitud, DateTime Fecha_Recepcion)
        {
            _Id_Orden_Compra = Id_Orden_Compra;
            _Estado = Estado;
            _Fecha_Solicitud = Fecha_Solicitud;
            _Fecha_Recepcion = Fecha_Recepcion;
        }

        public int Id_Orden_Compra { get => _Id_Orden_Compra; set => _Id_Orden_Compra = value; }
        public char Estado { get => _Estado; set => _Estado = value; }
        public DateTime Fecha_Solicitud { get => _Fecha_Solicitud; set => _Fecha_Solicitud = value; }
        public DateTime Fecha_Recepcion { get => _Fecha_Recepcion; set => _Fecha_Recepcion = value; }
    }
}

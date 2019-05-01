using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Orden_Compra
    {
        //ATRIBUTOS
        private int _Id_Orden_Compra;
        private char _Estado;
        private DateTime _Fecha_Solicitud;
        private DateTime _Fecha_Recepcion;

        //CONSTRUCTOR
        public Orden_Compra()
        {
            this.Init();
        }

        
        private void Init()
        {
            this._Id_Orden_Compra = 0;
            this._Estado = 'S';
            this._Fecha_Solicitud = DateTime.Now;
            this._Fecha_Recepcion = DateTime.Now;
        }

        //GET AND SET
        public int Id_Orden_Compra { get => _Id_Orden_Compra; set => _Id_Orden_Compra = value; }
        public char Estado { get => _Estado; set => _Estado = value; }
        public DateTime Fecha_Solicitud { get => _Fecha_Solicitud; set => _Fecha_Solicitud = value; }
        public DateTime Fecha_Recepcion { get => _Fecha_Recepcion; set => _Fecha_Recepcion = value; }
    }
}

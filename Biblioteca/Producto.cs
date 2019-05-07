using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Producto
    {
        //ATRIBUTOS
        private int _IdProducto;
        private string _Nombre;
        private int _StockActual;
        private int _StockCritico;
        private int _Precio;
        private string _Descripcion;
        private DateTime _FechaVencimiento;

        //CONSTRUCTOR
        public Producto()
        {
            this.Init();
        }

        private void Init()
        {
            this._IdProducto = 0;
            this._Nombre = string.Empty;
            this._StockActual = 0;
            this._StockCritico = 0;
            this._Precio = 0;
            this._Descripcion = string.Empty;
            this._FechaVencimiento = DateTime.Now;
        }

        //GET AND SET
        public int IdProducto { get => _IdProducto; set => _IdProducto = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public int StockActual { get => _StockActual; set => _StockActual = value; }
        public int StockCritico { get => _StockCritico; set => _StockCritico = value; }
        public int Precio { get => _Precio; set => _Precio = value; }
        public string Descripcion { get => _Descripcion; set => _Descripcion = value; }
        public DateTime FechaVencimiento { get => _FechaVencimiento; set => _FechaVencimiento = value; }
    }
}

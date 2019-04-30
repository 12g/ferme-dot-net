using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Producto
    {
        private int _IdProducto;
        private int _Codigo;
        private string _Nombre;
        private int _StockActual;
        private int _StockCritico;
        private int _Precio;
        private string _Descripcion;

        public Producto(int IdProducto, int Codigo, string Nombre, int StockActual, int StockCritico, int Precio, string Descripcion)
        {
            _IdProducto = IdProducto;
            _Codigo = Codigo;
            _Nombre = Nombre;
            _StockActual = StockActual;
            _StockCritico = StockCritico;
            _Precio = Precio;
            _Descripcion = Descripcion;
        }

        public int IdProducto { get => _IdProducto; set => _IdProducto = value; }
        public int Codigo { get => _Codigo; set => _Codigo = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public int StockActual { get => _StockActual; set => _StockActual = value; }
        public int StockCritico { get => _StockCritico; set => _StockCritico = value; }
        public int Precio { get => _Precio; set => _Precio = value; }
    }
}

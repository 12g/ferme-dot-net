using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Familia_Producto
    {
        private int _IdFamiliaProducto;
        private string _Descripcion;

        public Familia_Producto()
        {
            this._IdFamiliaProducto = 0;
            this._Descripcion = string.Empty;
        }

        public int Id_Familia_Producto1 { get => _IdFamiliaProducto; set => _IdFamiliaProducto = value; }
        public string Descripcion { get => _Descripcion; set => _Descripcion = value; }
    }
}

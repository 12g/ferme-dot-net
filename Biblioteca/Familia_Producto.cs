using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Familia_Producto
    {
        private int Id_Familia_Producto;
        private string _Descripcion;

        public Familia_Producto(int id_Familia_Producto, string Descripcion)
        {
            Id_Familia_Producto = id_Familia_Producto;
            _Descripcion = Descripcion;
        }

        public int Id_Familia_Producto1 { get => Id_Familia_Producto; set => Id_Familia_Producto = value; }
        public string Descripcion { get => _Descripcion; set => _Descripcion = value; }
    }
}

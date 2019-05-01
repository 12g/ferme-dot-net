using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Familia_Producto
    {
        //ATRIBUTOS
        private int _IdFamiliaProducto;
        private string _Descripcion;

        //CONSTRUCTOR
        public Familia_Producto()
        {
            this.Init();
        }

        
        private void Init()
        {
            this._IdFamiliaProducto = 0;
            this._Descripcion = string.Empty;
        }

        //GET AND SET
        public int Id_Familia_Producto1 { get => _IdFamiliaProducto; set => _IdFamiliaProducto = value; }
        public string Descripcion { get => _Descripcion; set => _Descripcion = value; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Proveedor
    {
        //ATRIBUTOS
        private int _IdProveedor;
        private string _RazonSocial;

        //CONSTRUCTOR
        public Proveedor()
        {
            this.Init();
        }

        
        private void Init()
        {
            this._IdProveedor = 0;
            this._RazonSocial = string.Empty;
        }

        //GET AND SET
        public int IdProveedor { get => _IdProveedor; set => _IdProveedor = value; }
        public string RazonSocial { get => _RazonSocial; set => _RazonSocial = value; }
    }
}

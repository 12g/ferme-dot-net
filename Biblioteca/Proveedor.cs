using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Proveedor
    {
        private int _IdProveedor;
        private string _RazonSocial;
        private int Telefono;

        public Proveedor(int IdProveedor, string RazonSocial, int telefono)
        {
            _IdProveedor = IdProveedor;
            _RazonSocial = RazonSocial;
            Telefono = telefono;
        }

        public int IdProveedor { get => _IdProveedor; set => _IdProveedor = value; }
        public string RazonSocial { get => _RazonSocial; set => _RazonSocial = value; }
        public int Telefono1 { get => Telefono; set => Telefono = value; }
    }
}

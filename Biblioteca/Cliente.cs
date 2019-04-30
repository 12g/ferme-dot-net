using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
   public class Cliente
    {
        private int _Id_Cliente;
        private string _Direccion;
        private string _Email;
        private int _Fono1;
        private int _Fono2;
        private int _Fono3;

        public Cliente(int Id_Cliente, string Direccion, string Email, int Fono1, int Fono2, int Fono3)
        {
            _Id_Cliente = Id_Cliente;
            _Direccion = Direccion;
            _Email = Email;
            _Fono1 = Fono1;
            _Fono2 = Fono2;
            _Fono3 = Fono3;
        }

        public int Id_Cliente { get => _Id_Cliente; set => _Id_Cliente = value; }
        public string Direccion { get => _Direccion; set => _Direccion = value; }
        public string Email { get => _Email; set => _Email = value; }
        public int Fono1 { get => _Fono1; set => _Fono1 = value; }
        public int Fono2 { get => _Fono2; set => _Fono2 = value; }
        public int Fono3 { get => _Fono3; set => _Fono3 = value; }
    }
}

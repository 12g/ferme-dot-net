using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Cargo
    {
        //ATRIBUTOS
        private int _IdCargo;
        private string _Descripcion;

        //CONSTRUCTOR 
        public Cargo()
        {
            this.Init();
        }

        
        private void Init()
        {
            this._IdCargo = 0;
            this._Descripcion = string.Empty;
        }


        //GET AND SET
        public int Id_Cargo { get => _IdCargo; set => _IdCargo = value; }
        public string Descripcion { get => _Descripcion; set => _Descripcion = value; }
    }
}

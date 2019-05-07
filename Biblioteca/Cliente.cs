using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
   public class Cliente
    {
        //ATRIBUTOS
        private int _Id_Cliente;


        //CONSTRUCTOR
        public Cliente()
        {
            this.Init();
        }

        
        private void Init()
        {
            this._Id_Cliente = 0;
        }

        //GET AND SET
        public int Id_Cliente { get => _Id_Cliente; set => _Id_Cliente = value; }
    }
}

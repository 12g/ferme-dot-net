using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
   public class Empleado
    {
        //ATRIBUTOS
        private int _Id_Empleado;

        //CONSTRUCTOR
        public Empleado()
        {
            this.Init();
        }

        
        private void Init()
        {
            this._Id_Empleado = 0;
        }

        //GET AND SET
        public int Id_Empleado { get => _Id_Empleado; set => _Id_Empleado = value; }
    }
}

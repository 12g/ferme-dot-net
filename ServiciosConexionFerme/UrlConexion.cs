using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiciosConexionFerme
{
   public class UrlConexion
    {
        private static string _url = "http://localhost:8082/api/";
        public static string url
        {
            get { return _url; }
            set { _url = value; }
        }



    }
}

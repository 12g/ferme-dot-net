﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Familia_Producto
    {
        public int? idFamiliaProducto { get; set; }
        public string descripcionFamiliaProducto { get; set; }
        public int idRubro { get; set; }
        public string descripcionRubro { get; set; }
        public int idProveedor { get; set; }
    }
}

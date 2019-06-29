using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca;
using ServiciosConexionFerme;

namespace AppPrincipal
{
    static class Program
    {

        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
            //Application.Run(new FormularioPrincipal());
            //Application.Run(new RepOrdenCompra());
        }

        private static Sesion _se = null;
        public static Sesion se
        {
            get { return Program._se; }
            set { Program._se = value; }
        }

        //1 FORMULARIO USUARIO
        private static FormularioUsuario _user;
        public static FormularioUsuario user
        {
            get { return _user; }
            set { _user = value; }
        }

        //2 FORMULARIO RECEPCION
        private static FormularioRecepcion _rep;
        public static FormularioRecepcion rep
        {
            get { return _rep; }
            set { _rep = value; }
        }

        //3 FORMULARIO PROVEEDOR
        private static FormularioProveedor _prov;
        public static FormularioProveedor prov
        {
            get { return _prov; }
            set { _prov = value; }
        }

        //4 FORMULARIO PRODUCTO
        private static FormularioProducto _pro;
        public static FormularioProducto pro
        {
            get { return _pro; }
            set { _pro = value; }
        }

        //5 FOMRULARIO ORDEN COMPRA
        private static FormularioMantenedorOrdenCompra _oc;
        public static FormularioMantenedorOrdenCompra oc
        {
            get { return _oc; }
            set { _oc = value; }
        }

        //6 FORMULARIO INFORMES
        private static FormularioInformes _inf;
        public static FormularioInformes inf
        {
            get { return _inf; }
            set { _inf = value; }
        }

        //7 FORMULARIO CLIENTE
        private static FormularioCliente _cli;
        public static FormularioCliente cli
        {
            get { return _cli; }
            set { _cli = value; }
        }

        //8 FORMULARIO VENTAS
        private static FromularioVentas _vent;
        public static FromularioVentas vent
        {
            get { return _vent; }
            set { _vent = value; }
        }



     
    }
}


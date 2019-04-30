using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Web;
using System.Net;
using System.IO;

namespace Ferme.Servicios
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        string GetData(int value);



        //SE VA A BUSCAR EL METODOS CREAR A LA CLASE RUBRO
        [OperationContract]
        bool CrearCargo(int Id_cargo, string Descripcion);

        //SE VA A BUSCAR EL METODO EDITAR DE LA CLASE RUBRO
        [OperationContract]
        bool EditarCargo(int Id_Cargo, string Descripcion);

        [OperationContract]
        List<>
    }
}

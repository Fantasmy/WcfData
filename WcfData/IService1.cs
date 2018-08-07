using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WcfData.Model;

namespace WcfData
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        List<Students> GetAll();

        [OperationContract]
        Students GetById(Guid id);

        [OperationContract]
        Students Post(Students student);

        [OperationContract]
        Students Put(Guid guid, Students student);

        [OperationContract]
        bool Delete(Guid guid);
    }

}

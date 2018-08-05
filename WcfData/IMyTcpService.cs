using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WcfData
{
    [ServiceContract]
    public interface IMyTcpService
    {
        [OperationContract]
        List<Alumno> GetAll();
    }
}

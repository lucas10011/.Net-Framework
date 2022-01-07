using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Servico
{
    [ServiceContract]
    public interface IOlaMundoService
    {
        [OperationContract]
        string OlaMundo();
    }
}

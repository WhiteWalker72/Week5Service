using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Week5Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IRegisterService" in both code and config file together.
    [ServiceContract]
    public interface IRegisterService
    {
        [OperationContract]
        void Register(string username, string password);

        [OperationContract]
        Boolean AccountExists(string username);

        [OperationContract]
        String GeneratePassword();

    }
}

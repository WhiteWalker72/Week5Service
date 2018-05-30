using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Week5Service.Domain;

namespace Week5Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IUserService" in both code and config file together.
    [ServiceContract]
    public interface IUserService
    {
        [OperationContract]
        double GetMoney(string username);

        [OperationContract]
        void AddProduct(string username, string productName);

        [OperationContract]
        void RemoveProduct(string username, string productName);

        [OperationContract]
        List<ProductItem> GetProductItems(string username);

    }
}

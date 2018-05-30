using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week5Service.Domain;

namespace Week5Service.Peristence
{
    interface IPersistenceFactory
    {

        List<User> FindAllUsers();

        User FindUserByID(string name);

        void InsertOrUpdateUser(User dto);

        void DeleteUser(string identifier);

        List<Product> FindAllProducts();

        Product FindProductByID(string identifier);

        void InsertOrUpdateProduct(Product dto);

        void DeleteProduct(string identifier);

    }
}

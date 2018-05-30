using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week5Service.Domain;

namespace Week5Service.Peristence
{
    class PersistenceService
    {

        public PersistenceService(IPersistenceFactory factory)
        {
            Factory = factory;
        }

        IPersistenceFactory Factory { get; set; }

        public List<User> FindAllUsers()
        {
            return Factory.FindAllUsers();
        }

        public User FindUserByID(string identifier)
        {
            return Factory.FindUserByID(identifier);
        }

        public void InsertOrUpdateUser(User dto)
        {
            Factory.InsertOrUpdateUser(dto);
        }

        public void DeleteUser(string identifier)
        {
            Factory.DeleteUser(identifier);
        }

        public List<Product> FindAllProducts()
        {
            return Factory.FindAllProducts();
        }

        public Product FindProductByID(string identifier)
        {
            return Factory.FindProductByID(identifier);
        }

        public void InsertOrUpdateProduct(Product dto)
        {
            Factory.InsertOrUpdateProduct(dto);
        }

        public void DeleteProduct(string identifier)
        {
            Factory.DeleteProduct(identifier);
        }

    }
}

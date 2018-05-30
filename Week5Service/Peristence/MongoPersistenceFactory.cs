using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week5Service.Domain;

namespace Week5Service.Peristence
{
    class MongoPersistenceFactory : IPersistenceFactory
    {
        private readonly IMongoDBDatabase database;
        private readonly IDAO<User> userDAO;
        private readonly IDAO<Product> productDAO;

        public MongoPersistenceFactory(IMongoDBDatabase mongoDatabase)
        {
            database = mongoDatabase;
            userDAO = new UserDAOMongoImpl(mongoDatabase.GetDatabase().GetCollection<User>("users"));
            productDAO = new ProductDAOMongoImpl(mongoDatabase.GetDatabase().GetCollection<Product>("products"));
        }

        public void DeleteProduct(string identifier)
        {
            productDAO.Delete(identifier);
        }

        public void DeleteUser(string identifier)
        {
            userDAO.Delete(identifier);
        }

        public List<Product> FindAllProducts()
        {
            return productDAO.FindAll();
        }

        public List<User> FindAllUsers()
        {
            return userDAO.FindAll();
        }

        public Product FindProductByID(string identifier)
        {
            return productDAO.FindById(identifier);
        }

        public User FindUserByID(string identifier)
        {
            return userDAO.FindById(identifier);
        }

        public void InsertOrUpdateProduct(Product dto)
        {
            productDAO.InsertOrUpdate(dto);
        }

        public void InsertOrUpdateUser(User dto)
        {
            userDAO.InsertOrUpdate(dto);
        }
    }
}

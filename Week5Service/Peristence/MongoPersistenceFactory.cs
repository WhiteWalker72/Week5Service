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

        public MongoPersistenceFactory(IMongoDBDatabase mongoDatabase)
        {
            this.database = mongoDatabase;
            this.userDAO = new UserDAOMongoImpl(mongoDatabase.GetDatabase().GetCollection<User>("users"));
        }

        public void DeleteUser(string identifier)
        {
            userDAO.Delete(identifier);
        }

        public List<User> FindAllUsers()
        {
            return userDAO.FindAll();
        }

        public User FindUserById(string identifier)
        {
            return userDAO.FindById(identifier);
        }

        public void InsertOrUpdateUser(User dto)
        {
            userDAO.InsertOrUpdate(dto);
        }
    }
}

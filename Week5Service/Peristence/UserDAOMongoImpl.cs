using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week5Service.Domain;
using MongoDB.Driver;

namespace Week5Service.Peristence
{
    class UserDAOMongoImpl : IDAO<User>
    {
        private readonly IMongoCollection<User> collection;

        public UserDAOMongoImpl(IMongoCollection<User> collection)
        {
            this.collection = collection;
        }

        public void Delete(string identifier)
        {
            collection.DeleteOne(x => x.Name == identifier);
        }

        public List<User> FindAll()
        {
            return collection.Find(_ => true).ToList();
        }

        public User FindById(string identifier)
        {
            List <User> resultList = collection.Find(x => x.Name == identifier).ToList();
            if (resultList.Count < 1)
                return null;
            return resultList.First();
        }

        public void InsertOrUpdate(User dto)
        {
            collection.ReplaceOne(
                x => x.Name == dto.Name,
                dto,
                new UpdateOptions { IsUpsert = true }
            );
        }
    }
}

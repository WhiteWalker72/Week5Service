using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week5Service.Domain;

namespace Week5Service.Peristence
{
    class ProductDAOMongoImpl : IDAO<Product>
    {
        private readonly IMongoCollection<Product> collection;

        public ProductDAOMongoImpl(IMongoCollection<Product> collection)
        {
            this.collection = collection;
        }

        public List<Product> FindAll()
        {
            return collection.Find(_ => true).ToList();
        }

        public Product FindById(string identifier)
        {
            List<Product> resultList = collection.Find(x => x.Name.Equals(identifier)).ToList();
            if (resultList.Count < 1)
                return null;
            return resultList.First();
        }

        public void InsertOrUpdate(Product dto)
        {
            collection.ReplaceOne(
                x => x.Name == dto.Name,
                dto,
                new UpdateOptions { IsUpsert = true }
            );
        }

        public void Delete(string productName)
        {
            collection.DeleteOne(x => x.Name == productName);
        }

    }
}

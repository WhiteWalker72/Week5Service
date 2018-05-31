
using MongoDB.Driver;
using Week5Service.Peristence;

namespace Week5.Persistence
{
    class MlabDB : IMongoDBDatabase
    {

        private MongoClient mongo;
        private IMongoDatabase db;

        public MlabDB(string host, int port, string databaseName, string username, string password)
        {
            var credential = MongoCredential.CreateCredential(databaseName, username, password);
            var settings = new MongoClientSettings
            {
                Credential = credential,
                Server = new MongoServerAddress(host, port)
            };
            mongo = new MongoClient(settings);
            db = mongo.GetDatabase(databaseName);
        }

        public MongoClient GetMongoClient()
        {
            return mongo;
        }

        public IMongoDatabase GetDatabase()
        {
            return db;
        }

    }
}

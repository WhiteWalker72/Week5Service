using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson.Serialization.Attributes;

namespace Week5Service.Domain
{
    [BsonIgnoreExtraElements]
    class User
    {
        public User(string name, string password)
        {
            Name = name;
            Password = password;
        }

        public string Name { get; }
        public string Password { get; }
    }
}

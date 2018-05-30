using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Week5Service.Domain
{
    [BsonIgnoreExtraElements]
    public class User 
    {
        public User(string name, string password, double money, List<ProductItem> productList)
        {
            Name = name;
            Password = password;
            Money = money;
            ProductItemList = productList;
        }

        [BsonElement("name")]
        public string Name { get; set; }

        [BsonElement("password")]
        public string Password { get; set; }

        [BsonElement("money")]
        public double Money { get; set; }

        [BsonElement("product_items")]
        public List<ProductItem> ProductItemList { get; set; }

    }

}

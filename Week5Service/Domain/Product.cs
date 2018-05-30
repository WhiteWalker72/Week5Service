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
    [DataContract]
    public class Product
    {

        public Product(string name, double price, int amountInStore)
        {
            Name = name;
            Price = price;
            this.AmountInStock = amountInStore;
        }

        [BsonElement("name")]
        [DataMember]
        public string Name { get; set; }

        [BsonElement("price")]
        [DataMember]
        public double Price { get; set; }

        [BsonElement("stock")]
        [DataMember]
        public int AmountInStock { get; set; }

    }
}

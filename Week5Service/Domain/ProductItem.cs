using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Week5Service.Domain
{
    [DataContract]
    public class ProductItem
    {
        [BsonElement("product_name")]
        [DataMember]
        public string ProductName { get; set; }

        [BsonElement("amount")]
        [DataMember]
        public int Amount { get; set; }
    }
}

﻿using System;
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
    public class User 
    {
        public User(string name, string password, double money)
        {
            Name = name;
            Password = password;
            Money = money;
        }

        [BsonElement("name")]
        [DataMember]
        public string Name { get; set; }

        [BsonElement("password")]
        [DataMember]
        public string Password { get; set; }

        [BsonElement("money")]
        [DataMember]
        public double Money { get; set; }

    }
}

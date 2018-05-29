﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;


namespace Week5Service.Peristence
{
    interface IMongoDBDatabase
    {
        MongoClient GetMongoClient();

        IMongoDatabase GetDatabase();
    }
}

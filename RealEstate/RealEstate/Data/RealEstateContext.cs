﻿using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using RealEstate.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstate.Data
{
    public class RealEstateContext
    {
        public MongoDatabase Database;

        public RealEstateContext()
        {
            var client = new MongoClient("mongodb://localhost");
            var server = client.GetServer();
            Database = server.GetDatabase("RealEstate");
        }
    }
}

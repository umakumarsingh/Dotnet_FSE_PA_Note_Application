using Microsoft.Extensions.Options;
using MongoDB.Driver;
using NoteApplicationApi.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NoteApplicationApi.DataLayer.Context
{
   public class MongoDbContext : IMongoDbContext
    {
        private readonly IMongoDatabase _db;
        //Create context of Mongo DB
        public MongoDbContext(IOptions<MongoDbSetting> options)
        {
            var client = new MongoClient(options.Value.ConnectionString);
            _db = client.GetDatabase(options.Value.Database);
        }
        //Get All notes Collection from MongoDB
        public IMongoCollection<Notes> notes => _db.GetCollection<Notes>("notes");
    }
}

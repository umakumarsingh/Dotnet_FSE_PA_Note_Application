using MongoDB.Driver;
using NoteApplicationApi.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NoteApplicationApi.DataLayer.Context
{
    public interface IMongoDbContext
    {
        IMongoCollection<Notes> notes { get; }
    }
}

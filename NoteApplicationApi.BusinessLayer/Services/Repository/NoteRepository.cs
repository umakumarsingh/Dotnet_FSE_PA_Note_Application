using MongoDB.Driver;
using NoteApplicationApi.DataLayer.Context;
using NoteApplicationApi.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NoteApplicationApi.BusinessLayer.Services.Repository
{
   public class NoteRepository:INoteRepository
    {
        private readonly IMongoDbContext _context;
        public NoteRepository(IMongoDbContext context)
        {
            _context = context;
        }
        //Get call from Noteservice to read all Notes from Mongo DB
        public async Task<IEnumerable<Notes>> ReadAsync()
        {
            try
            {
                var notes = await _context.notes.Find(note => true).ToListAsync();
                return notes;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        //Get call from Noteservice to read Notes based on id from Mongo DB
        public async Task<Notes> ReadIdAsync(int id)
        {
            try
            {
                FilterDefinition<Notes> filter = Builders<Notes>.Filter.Eq(m => m.Id, id);
                var notes = await _context.notes.Find(filter).FirstOrDefaultAsync();
                return notes;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }
        //Get call from Noteservice to Create Note from Mongo DB
        public async Task<Notes> CreateAsync(Notes notes)
        {
            try
            {
                await _context.notes.InsertOneAsync(notes);
                return notes;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }
        //Get call from Noteservice to Update Note Based on Id from Mongo DB
        public async Task<Notes> UpdateAsync(int id ,Notes notes)
        {
            try
            {
                ReplaceOneResult updateResult = await _context.notes.ReplaceOneAsync(filter: g => g.Id == id, replacement: notes);

                return notes;
            }         
            catch (Exception ex)
            {
                throw (ex);
            }
        }
        //Get call from Noteservice to Create Note Based on Id from Mongo DB
        public async Task<bool> DeleteAsync(int id)
        {
            try
            {
                FilterDefinition<Notes> filter = Builders<Notes>.Filter.Eq(m => m.Id, id);
                DeleteResult deleteResult = await _context.notes.DeleteOneAsync(filter);
                bool result = deleteResult.IsAcknowledged && deleteResult.DeletedCount > 0;
                return result;
            }
            catch (Exception ex)
            {
                throw (ex);
            }

        }

    }
}

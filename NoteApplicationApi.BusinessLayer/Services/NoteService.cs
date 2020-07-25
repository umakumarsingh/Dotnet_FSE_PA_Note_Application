using NoteApplicationApi.BusinessLayer.Interface;
using NoteApplicationApi.BusinessLayer.Services.Repository;
using NoteApplicationApi.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NoteApplicationApi.BusinessLayer.Services
{
   public class NoteService : INoteService
    {
        private readonly INoteRepository _repository;
        public NoteService(INoteRepository repository)
        {
            _repository = repository;
        }
        //Get call from controller to read All Notes Data
        public async Task<IEnumerable<Notes>> ReadAsync()
        {
            //Do Code Here
            throw new NotImplementedException();
        }
        public async Task<Notes> ReadIdAsync(int id)
        {
            //Do Code Here
            throw new NotImplementedException();
        }
        //Get call from controller to Create Note 
        public async Task<Notes> CreateAsync(Notes notes)
        {
            //Do Code Here
            throw new NotImplementedException();
        }
        //Get call from controller to Update Note 
        public async Task<Notes> UpdateAsync(int id ,Notes notes)
        {
            //Do Code Here
            throw new NotImplementedException();
        }
        //Get call from controller to Delete Note 
        public async Task<bool> DeleteAsync(int id)
        {
            //Do Code Here
            throw new NotImplementedException();
        }
    }
}

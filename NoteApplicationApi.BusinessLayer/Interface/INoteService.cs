using NoteApplicationApi.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NoteApplicationApi.BusinessLayer.Interface
{
    public interface INoteService
    {
        Task<IEnumerable<Notes>> ReadAsync();
        Task<Notes> ReadIdAsync(int id);
        Task<Notes> CreateAsync(Notes notes);
        Task<Notes> UpdateAsync(int id ,Notes notes);
        Task<bool> DeleteAsync(int id);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NoteApplicationApi.BusinessLayer.Interface;
using NoteApplicationApi.Entities;

namespace NoteApplicationApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatusController : ControllerBase
    {
        private readonly INoteService _service;
        public StatusController(INoteService service)
        {
            _service = service;

        }
        // GET: api/Status
        //This Method Gets Request Call from User to Read Notes.
        [HttpGet]
        public async Task<IEnumerable<Notes>> GetAllStatus()
        {
            //Do Code Here
            throw new NotImplementedException();
        }
    }
}
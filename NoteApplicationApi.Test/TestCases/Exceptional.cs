using Moq;
using NoteApplicationApi.BusinessLayer.Interface;
using NoteApplicationApi.BusinessLayer.Services;
using NoteApplicationApi.BusinessLayer.Services.Repository;
using NoteApplicationApi.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace NoteApplicationApi.Test.TestCases
{
    public class Exceptional
    {
        private INoteService _services;
        public readonly Mock<INoteRepository> service = new Mock<INoteRepository>();
        static Exceptional()
        {
            if (!File.Exists("../../../../output_exception_revised.txt"))
                try
                {
                    File.Create("../../../../output_exception_revised.txt").Dispose();
                }
                catch (Exception)
                {

                }
            else
            {
                File.Delete("../../../../output_exception_revised.txt");
                File.Create("../../../../output_exception_revised.txt").Dispose();
            }
        }


        public Exceptional()
        {
            //    Utilities.CreatefunctionalTextfile();
            _services = new NoteService(service.Object);
        }
        [Fact]
        public async Task<bool> Testfor_validateNotesNotNull()
        {
            bool finalvalue = false;
            try
            {
                //Assigning values
                var notes = new Notes()
                {
                    Id = 123,
                    Title = "update",
                    Author = null,
                    Description = "Note applicaction",
                    Status = "done"
                };
                notes = null;
                //setup
                service.Setup(repo => repo.CreateAsync(notes)).ReturnsAsync(notes);
                var result = await _services.CreateAsync(notes);
                if (result == null)
                {
                    finalvalue = true;
                }

                //finalresult displaying in text file
                //TextFiles.AppendTextAllBoundaryText("BoundaryTestfor_validateStatusNotNull", finalvalue);
                File.AppendAllText("../../../../output_exception_revised.txt", "Testfor_validateNotesNotNull=" + finalvalue + "\n");
            }
            catch (Exception ex)
            {
                File.AppendAllText("../../../../output_exception_revised.txt", "Testfor_validateNotesNotNull=" + finalvalue +"\n");

            }
            return finalvalue;
        }
    }
}

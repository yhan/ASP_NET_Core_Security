using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using School.API.Models;
using School.API.VM;

namespace School.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly ILogger<StudentsController> _logger;

        public StudentsController(ILogger<StudentsController> logger)
        {
            _logger = logger;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Student>> Get()
        {
            IEnumerable<Student> allStudents = GetAllStudents();
            return Ok(allStudents);
        }


        // POST api/students
        [HttpPost]
        public void Post([FromBody] StudentDTO student)
        {
            var requestData = student;
            _logger.LogDebug($"Received student {JsonConvert.SerializeObject(requestData)}");

            //Save data to DB

        }


        private IEnumerable<Student> GetAllStudents()
        {
            return new List<Student>()
            {
                new Student()
                {
                    Id=1,
                    FullName = "John Smith",
                    GPA = 3.8,
                    School = new Models.School()
                    {
                        Id = 1,
                        Name = "GW School",
                        Address = "GW Street"
                    }
                },
                new Student()
                {
                    Id=1,
                    FullName = "John Smith",
                    GPA = 3.8,
                    School = new Models.School()
                    {
                        Id = 1,
                        Name = "GW School",
                        Address = "GW Street"
                    }
                }
            };
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using School.API.Models;

namespace School.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Student>> Get()
        {
            IEnumerable<Student> allStudents = GetAllStudents();
            return Ok(allStudents);
        }


        // POST api/students
        [HttpPost]
        public void Post([FromBody] Student student)
        {
            var requestData = student;
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
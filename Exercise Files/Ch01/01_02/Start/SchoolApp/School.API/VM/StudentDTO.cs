using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School.API.VM
{
    public class StudentDTO
    {
        public string FullName { get; set; }
        public double Gpa { get; set; }

        public StudentDTO(string fullName, double gpa)
        {
            FullName = fullName;
            Gpa = gpa;
        }

        public StudentDTO()
        {
        }
    }
}

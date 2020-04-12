using System;
using System.IO;
using Newtonsoft.Json;
using NUnit.Framework;
using School.API.Models;

namespace School.UnitTests
{
    public class Tests
    {
        [Test]
        public void Test1()
        {
            var student = new Student
            {
                FullName = "Yi Han",
                GPA = 99.99
            };

            Console.WriteLine(JsonConvert.SerializeObject(student));
        }
    }
}
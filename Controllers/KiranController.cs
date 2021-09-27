using FirstWebApplication.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstWebApplication.Controllers
{
    public class KiranController : Controller
    {
        public IActionResult Page()
        {
            var students = new List<Student>()
            {
                new Student
                {
                    Id = 1,
                    Name = "Kiran",
                    Marks = 90
                },
                new Student
                {
                    Id = 2,
                    Name = "Justin",
                    Marks = 95
                }

            };
            return View(students);
        }
        public IActionResult Welcome()
        {
            
            return View();
        }
    }
}

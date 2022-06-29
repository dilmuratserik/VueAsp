using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Test.Data;
using Test.Models;

namespace Test.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;
        private List<PersonModel> PersonModels = new List<PersonModel>
        {
            new PersonModel
            {
                Name = "Game Controller",
                Code = "vbb124btr",
                Category = "Electronics",
                Quantity = 2
            },
            new PersonModel
            {
                Name = "Black Watch",
                Code = "vbb124btr",
                Category = "Electronics",
                Quantity = 2
            }
        };

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public List<PersonModel> LoadData()
        {
            return PersonModels;
        }

        //[HttpPost]
        //public string GetList()
        //{
        //    return "asd";
        //}

        [HttpPost]
          public string Save(List<string> list)
          {
              return "";
          }
        //[HttpGet]
        //public string Get(Person person)
        //{
        //    var person2 = new Person()
        //    {
        //        Id = person.Id,
        //        Name = "Henry",
        //    };
        //    _context.Person.Add(person2);
        //    _context.SaveChanges();
        //    return RedirectToAction("htmlpage.html");
        //}
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

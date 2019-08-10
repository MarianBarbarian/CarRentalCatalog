using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Day_2.Models;

namespace Day_2.Controllers
{

    public class CatalogController : Controller
    {
        private DataContext Context;
        public CatalogController(DataContext context)
        {
            Context = context;

        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult GetCatalog()
        {

            List<Car> list = Context.Cars.Where(c => c.Make != null).ToList();
            return Json(list);
        }

        [HttpPost]
        public IActionResult CreateCar([FromBody]Car newCar)
        {

            Console.WriteLine("Register a Car", newCar);

            Context.Cars.Add(newCar);
            Context.SaveChanges();

            Console.WriteLine();
            Console.WriteLine("****Saved");
            Console.WriteLine();

            return Json(newCar);
        }
    }
}


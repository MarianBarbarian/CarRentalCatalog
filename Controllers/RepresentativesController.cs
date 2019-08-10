using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Day_2.Models;

namespace Day_2.Controllers
{

    /*
    Constructor 
    Index Action
    Create Action 

    send the list of representatives
    catch and save new representatives
     */

    public class RepresentativesController : Controller
    {
        private DataContext Context;
        public RepresentativesController(DataContext context)
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

        public IActionResult GetList()
        {
            List<Representative> list = Context.Representatives.ToList();

            return Json(list);
        }

        [HttpPost]
        public IActionResult Save([FromBody] Representative newRep)
        {

            Console.WriteLine("\n\n\n\n");
            Console.WriteLine(newRep.Name, newRep.LastName, newRep.PhoneNumber);
            Console.WriteLine("\n\n\n\n");

            Context.Representatives.Add(newRep); //Add to the table
            Context.SaveChanges(); // save the changes (commit the object to the database)

            return Json(newRep);
        }

    }


}
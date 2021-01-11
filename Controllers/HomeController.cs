using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using webapp.Models;

namespace webapp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly webappContext db;

        public HomeController(ILogger<HomeController> logger, webappContext _db)
        {
            _logger = logger;
            db = _db;
        }

        public IActionResult Index()
        {
            db.Database.EnsureCreated();
            db.Persons.Add(new Person() { Name = "toto" });
            db.SaveChanges();
            ViewBag.nbPersonnes = db.Persons.Count();
            return View();
        }

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

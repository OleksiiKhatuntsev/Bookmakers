using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using BLL.Db;
using Microsoft.AspNetCore.Mvc;
using Bookmakers.Models;
using BOL;

namespace Bookmakers.Controllers
{
    public class HomeController : Controller
    {
        private AllDb db;
        public HomeController(BookmakersContext context)
        {
            db = new AllDb(context);
        }
        public IActionResult Index()
        {
            db.RoleDb.FillRoles();
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

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

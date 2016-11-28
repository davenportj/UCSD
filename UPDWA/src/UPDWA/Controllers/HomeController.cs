using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UPDWA.Data;

namespace UPDWA.Controllers
{
    public class HomeController : Controller
    {
        private readonly AlertContext _context;

        public HomeController(AlertContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            ViewBag.RecentAlerts = _context.Alerts.Where(x => x.FirstPosted >= DateTime.Now.AddDays(-5));
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

        public IActionResult Error()
        {
            return View();
        }
    }
}

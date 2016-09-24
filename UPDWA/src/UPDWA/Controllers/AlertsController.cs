using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace UPDWA.Controllers
{
    public class AlertsController : Controller
    {
        public IActionResult List()
        {
            return View();
        }
    }
}

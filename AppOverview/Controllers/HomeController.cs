using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AppOverview.Models;
using AppOverview.Data;

namespace AppOverview.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["SupportEmail"] = "support@email.com";
            ViewData["SupportPhone"] = "+31 (0)12 345 67 89";

            return View(Apps.GetApps());
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

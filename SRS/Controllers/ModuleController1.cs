using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SPA_SRS.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SPA_SRS.Controllers
{
    public class ModuleController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public ModuleController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult IndexModule()
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

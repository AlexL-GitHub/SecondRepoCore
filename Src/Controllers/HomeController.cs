using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SecondRepoCore.Models;
using SecondRepoCore;
using Microsoft.Extensions.DependencyInjection;

namespace SecondRepoCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ICar _car;

        public HomeController(ILogger<HomeController> logger, ICar car)
        {
            _car = car;
            _logger = logger;
        }

        public IActionResult Index()
        {
            SecondRepoCore.ICar car = new Car();
         
            ICar car2 = HttpContext.RequestServices.GetService<ICar>();

            
                //ActivatorUtilities.GetServiceOrCreateInstance( typeof(ICar));
            return View(new IndexModel {    });
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

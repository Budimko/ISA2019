using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace EasyFlight.Controllers
{
    public class AirplaneController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
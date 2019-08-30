using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace EasyFlight.Controllers
{
    public class FlightsController : Controller
    {
        [HttpGet]
        public IActionResult Flights()
        {

            return View();
        }
    }
}
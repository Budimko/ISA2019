using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EasyFlight.Repository;
using Microsoft.AspNetCore.Mvc;

namespace EasyFlight.Controllers
{
    public class AdminController : Controller
    {
        private readonly DBContext dBContext;
        public AdminController(DBContext _dBContext)
        {
            dBContext = _dBContext;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
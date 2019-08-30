using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EasyFlight.Repository;
using Microsoft.AspNetCore.Mvc;

namespace EasyFlight.Controllers
{
    public class DestinationController : Controller
    {
        private IRepoWrapper _repoWrapper;
        public DestinationController(IRepoWrapper repoWrapper)
        {
            _repoWrapper = repoWrapper;
        }
        public IActionResult Index()
        {
            var r = _repoWrapper.Destination.getDestinations.ToList();
            return View(r);
        }
        
    }
}
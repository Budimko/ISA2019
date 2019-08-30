using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using EasyFlight.Models;
using EasyFlight.Repository;
using EasyFlight.ViewModel;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EasyFlight.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRepoWrapper _service;

        public HomeController(IRepoWrapper repoWrapper)
        {
            _service = repoWrapper;
        }

        [HttpGet]
        public IActionResult Home()
        {
            
            return View();
        }
       
        [HttpPost]
        public IActionResult Home(Airline airline)
        {
           
            var spisakAviokompanija = _service.Airline.getAirlines.ToList();


            HomeViewModel spisakAviokompanijaResult = new HomeViewModel
            {
                airlines = spisakAviokompanija
            };



            return View(spisakAviokompanijaResult);
        }

        [HttpGet]
        public IActionResult Flights(HomeViewModel model)
        {
            List<AirlineViewModel> airlines = new List<AirlineViewModel>();
            TextInfo cultInfo = new CultureInfo("en-US", false).TextInfo;

            var from = _service.Destination.getDestinations.Where(d => d.Name.Equals(cultInfo.ToTitleCase(model.From))).FirstOrDefault();
            var to = _service.Destination.getDestinations.Where(d => d.Name.Equals(cultInfo.ToTitleCase(model.To))).FirstOrDefault();
            var tupeOfFlight = _service.TypeOfFlight.getTypeOfFlights.Where(d => d.Type.Equals(model.Type)).FirstOrDefault();
            var poletanje = model.DepartureTime;
            var sletanje = model.LandingTime;

            var flights = _service.Flight.GetAllFlights().Where(f => f.DateAndTimeOfDeparture  <= poletanje && f.DateAndTimeOfLanding >= sletanje &&
                                                                f.DestinationIdFrom == from.Id && f.DestinationIdTo == to.Id && f.TypeId == tupeOfFlight.Id ).ToList();




            flights.ForEach(t => airlines.Add(new AirlineViewModel() { Name = _service.Airline.GetAirline(t.AirlineId)?.Name.ToString(),
                                                                      Price = _service.Flight.GetFlight(t.Id).Price,
                                                                      TimeOfTrevel = _service.Flight.GetFlight(t.Id).TimeOfTrevel
            }));
            
            return View(airlines);
            
        }





    }
}
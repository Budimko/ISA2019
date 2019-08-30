using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EasyFlight.Models;
using EasyFlight.Repository;
using EasyFlight.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace EasyFlight.Controllers
{
    public class AirlineController : Controller
    {
        private IRepoWrapper _repoWrapper;
        public AirlineController(IRepoWrapper repoWrapper)
        {
            _repoWrapper = repoWrapper;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var r = _repoWrapper.Airline.getAirlines.ToList();
            return View(r);
        }
        [HttpGet]
        public IActionResult Profil(Guid id)
        {
            
            List<Destination> airlines = new List<Destination>();
            //za dati id provjerava aviokompanije
            var allAirline = _repoWrapper.Airline.getAirlines.ToList(); ;
            var airline = allAirline.Where(a => a.Id.Equals(id)).ToList();
            //za datu aviokompaniju provjerava airlinedestination
            var allAirlineDestination = _repoWrapper.AirlineDestination.getAirlineDestinations.ToList();
            var airlineDstination = allAirlineDestination.Where(t => t.AirlineId == id).ToList();

            var destination = _repoWrapper.Destination.getDestinations.ToList();
            AirlineHomeViewModel airlineHomeViewModel = new AirlineHomeViewModel();
            


            foreach (var item in airlineDstination)
            {
                
                airlines.Add(new Destination()
                {
                    Name = destination.Where(mater => mater.Id == item.DestinationId).Select(mater => mater.Name).SingleOrDefault(),
                    Description = destination.Where(mater => mater.Id == item.DestinationId).Select(mater => mater.Description).SingleOrDefault(),
                    Id = destination.Where(mater => mater.Id == item.DestinationId).Select(mater => mater.Id).SingleOrDefault()

                });

            }
            
            foreach (var item in airline)
            {
                airlineHomeViewModel.Id = item.Id;
                airlineHomeViewModel.Name = item.Name;
                airlineHomeViewModel.Description = item.Description;
                airlineHomeViewModel.Address = item.Address;
                airlineHomeViewModel.Rating = item.Rating;
                airlineHomeViewModel.airlinesDestinationList = airlines;
            }
            
           

            return View(airlineHomeViewModel);

            
        }
        [HttpPost]
        public IActionResult Profil()
        {
            return View();
        }


        [HttpGet]
        public IActionResult Destinacije(Guid id)
        {
            var allAirline = _repoWrapper.Airline.getAirlines.ToList(); ;
            var airline = allAirline.Where(a => a.Id.Equals(id)).ToList();
            AirlineHomeViewModel airlineHomeViewModel = new AirlineHomeViewModel()
            {
                Id = id
            };
            return View(airlineHomeViewModel);
        }

        [HttpGet]
        public IActionResult Letovi(Guid id)
        {

            var allAirline = _repoWrapper.Airline.getAirlines.ToList(); ;
            var airline = allAirline.Where(a => a.Id.Equals(id)).ToList();

            AirlineHomeViewModel airlineHomeViewModel = new AirlineHomeViewModel()
            {
                Id = id
            };

            return View(airlineHomeViewModel);
        }
        [HttpGet]
        public IActionResult Avion(Guid id)
        {
            var allFlight = _repoWrapper.Flight.GetAllFlights().ToList();
            var aIrlineFlight = allFlight.Where(f => f.AirlineId.Equals(id)).ToList();

            AirlineHomeViewModel airlineHomeViewModel = new AirlineHomeViewModel()
            {
                Id = id
            };
            return View(airlineHomeViewModel);
        }
        [HttpGet]
        public IActionResult DodatneUsluge(Guid id)
        {
            var allFlight = _repoWrapper.Flight.GetAllFlights().ToList();
            var aIrlineFlight = allFlight.Where(f => f.AirlineId.Equals(id)).ToList();
            var allAdditionalService = _repoWrapper.AdditionalServiceAirline.getAdditionalServiceAirline.ToList();
            var airlineAdditionalService = allAdditionalService.Where(a => a.AirlineId == id).ToList();

            AirlineHomeViewModel airlineHomeViewModel = new AirlineHomeViewModel()
            {
                Id = id,
                HandBaggage = airlineAdditionalService.Select(n => n.HandBaggage).SingleOrDefault(),
                CheckedBaggage = airlineAdditionalService.Select(n => n.CheckedBaggage).SingleOrDefault(),
                Drink = airlineAdditionalService.Select(n => n.Drink).SingleOrDefault()
            };

            return View(airlineHomeViewModel);
        }
    }
}
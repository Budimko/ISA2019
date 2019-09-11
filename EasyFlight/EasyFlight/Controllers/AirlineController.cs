using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EasyFlight.Models;
using EasyFlight.Repository;
using EasyFlight.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.Web.CodeGeneration.Contracts.Messaging;

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
        [HttpGet]
        public IActionResult ProfilEdit(Guid id)
        {
            
            //za dati id provjerava aviokompanije
            var allAirline = _repoWrapper.Airline.getAirlines.ToList(); ;
            var airline = allAirline.Where(a => a.Id.Equals(id)).ToList();

            Airline airlineEdit = new Airline();
            foreach (var item in airline)
            {
                airlineEdit.Id = id;
                airlineEdit.Name = item.Name;
                airlineEdit.Description = item.Description;
                airlineEdit.Address = item.Address;
            }
            
            return View(airlineEdit);
        }
        [HttpPost]
        public IActionResult ProfilEdit(Airline airline)
        {
            Airline airlineEdit = _repoWrapper.Airline.GetAirline(airline.Id);
            airlineEdit.Name = airline.Name;
            airlineEdit.Description = airline.Description;
            airlineEdit.Address = airline.Address;

            _repoWrapper.Airline.Edit(airlineEdit);

            return RedirectToAction("Profil", "Airline", new { id = airline.Id });
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
        [HttpPost]
        public IActionResult Destinacije(AirlineHomeViewModel model)
        {
            if (ModelState.IsValid)
            {
                Guid IdDestination = Guid.NewGuid();
                Destination destination = new Destination();
                destination.Id = IdDestination;
                destination.Name = model.Name;
                destination.Description = model.Description;
                _repoWrapper.Destination.Add(destination);

                Guid id = Guid.NewGuid();
                AirlineDestination airlineDestination = new AirlineDestination();
                airlineDestination.Id = id;
                airlineDestination.DestinationId = IdDestination;
                airlineDestination.AirlineId = model.Id;
                _repoWrapper.AirlineDestination.Add(airlineDestination);
                return RedirectToAction("Profil", "Airline", new { id = model.Id });
            }
            return Ok();
        }

        [HttpGet]
        public IActionResult Letovi(Guid id)
        {
            var letovi = _repoWrapper.Flight.GetAllFlights().ToList();
            var allAirline = _repoWrapper.Airline.getAirlines.ToList(); ;
            var airline = allAirline.Where(a => a.Id.Equals(id)).ToList();
            var letAviokompanije = letovi.Where(i => i.AirlineId == id).ToList();

            AirlineHomeViewModel airlineHomeViewModel = new AirlineHomeViewModel()
            {
                Id = id,
                flight = letAviokompanije
            };

            return View(airlineHomeViewModel);
        }
        [HttpPost]
        public IActionResult Letovi (AirlineHomeViewModel model)
        {

            var allAirline = _repoWrapper.Airline.getAirlines.ToList(); ;
            var airline = allAirline.Where(a => a.Id.Equals(model.Id)).ToList();
            var airlineId = airline.Select(t => t.Id).ToList().SingleOrDefault();
            AirlineHomeViewModel airlineHomeViewModel = new AirlineHomeViewModel()
            {
                Id = airlineId
            };
            if (ModelState.IsValid)
            {
                
                var allTypeOfFlight = _repoWrapper.TypeOfFlight.getTypeOfFlights.ToList();
                var allDestination = _repoWrapper.Destination.getDestinations.ToList();
                var allAirlineDestination = _repoWrapper.AirlineDestination.getAirlineDestinations.ToList();
                var allAirplane = _repoWrapper.Airplane.getAirplane.ToList();
                var from = allDestination.Where(d => d.Name.Equals(model.From)).ToList().SingleOrDefault();
                if (from == null)
                {
                    ViewBag.Message = "Novi let nije dodat u ponudu! Polazna destinacija nije u ponudi Aviokompanije.";
                    return View(airlineHomeViewModel);
                }
                var fromAD = allAirlineDestination.Where(ad => ad.DestinationId == from.Id).SingleOrDefault();
                var to = allDestination.Where(d => d.Name.Equals(model.To)).ToList().SingleOrDefault();
                if (to == null)
                {
                    ViewBag.Message = "Novi let nije dodat u ponudu! Odredisna destinacija nije u ponudi Aviokompanije.";
                    return View(airlineHomeViewModel);
                }
                var toAD = allAirlineDestination.Where(ad => ad.DestinationId == to.Id);
                var airplain = allAirplane.Where(a => a.Name.Equals(model.Airplain)).ToList();
                var type = allTypeOfFlight.Where(t => t.Type.Equals(model.Type)).ToList();

                Flight flight = new Flight();
                Guid Id = Guid.NewGuid();
                flight.Id = Id;
                flight.TypeId = type.Select(t => t.Id).SingleOrDefault();
                flight.AirlineId = airlineId;
                //flight.DestinationIdFrom = fromAD.Select(f => f.DestinationId).SingleOrDefault();
                flight.DestinationIdFrom = fromAD.DestinationId;
                flight.DestinationIdTo = toAD.Select(f => f.DestinationId).SingleOrDefault();
                flight.DateAndTimeOfDeparture = model.DepartureTime;
                flight.DateAndTimeOfLanding = model.LandingTime;
                flight.AirplainId = airplain.Select(a => a.Id).SingleOrDefault();
                flight.Price = model.Price;
                flight.Distance = model.Distance.ToString();
                flight.TimeOfTrevel = model.Time;
                _repoWrapper.Flight.Add(flight);

                ViewBag.Message = "Uspesno ste dodali novi let u ponudu aviokompanije";
                return View(airlineHomeViewModel);

            }

            
            ViewBag.Message = "Novi let nije dodat u ponudu! Niste uneli sva potrebana polja.";
            return View(airlineHomeViewModel);
        }
       
        [HttpGet]
        public IActionResult DodatneUsluge(Guid id)
        {
            
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
        [HttpPost]
        public IActionResult DodatneUslugeEdit(AirlineHomeViewModel model)
        {
            var dodatneSuluge = _repoWrapper.AdditionalServiceAirline.getAdditionalServiceAirline.ToList();
            var daj = dodatneSuluge.Where(a => a.AirlineId == model.Id);
            var id = daj.Select(getID => getID.Id).SingleOrDefault();
            AdditionalServiceAirline additionalServiceAirlineEdit = _repoWrapper.AdditionalServiceAirline.GetAdditionalServiceAirline(id);  
            additionalServiceAirlineEdit.HandBaggage = model.HandBaggage;
            additionalServiceAirlineEdit.CheckedBaggage = model.CheckedBaggage;
            additionalServiceAirlineEdit.Drink = model.Drink;
            _repoWrapper.AdditionalServiceAirline.Edit(additionalServiceAirlineEdit);
            return RedirectToAction("DodatneUsluge", "Airline", new { id = model.Id });
        }
        [HttpGet]
        public IActionResult DodatneUslugeEdit(Guid id)
        {
            var allAdditionalService = _repoWrapper.AdditionalServiceAirline.getAdditionalServiceAirline.ToList();
            var airlineAdditionalService = allAdditionalService.Where(a => a.AirlineId == id).ToList();
            AdditionalServiceAirline additionalServiceAirline = new AdditionalServiceAirline()
            {
                AirlineId = id,
                HandBaggage = airlineAdditionalService.Select(n => n.HandBaggage).SingleOrDefault(),
                CheckedBaggage = airlineAdditionalService.Select(n => n.CheckedBaggage).SingleOrDefault(),
                Drink = airlineAdditionalService.Select(n => n.Drink).SingleOrDefault()
            };
            return View(additionalServiceAirline);
        }
    }
}
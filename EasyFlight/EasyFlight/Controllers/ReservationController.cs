using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EasyFlight.Models;
using EasyFlight.Repository;
using EasyFlight.ViewModel;
using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using static Microsoft.AspNetCore.Hosting.Internal.HostingApplication;

namespace EasyFlight.Controllers
{
    public class ReservationController : Controller
    {
        private IRepoWrapper _repoWrapper;
        public ReservationController(IRepoWrapper repoWrapper)
        {
            _repoWrapper = repoWrapper;
        }
        [HttpGet]
        public IActionResult Reservation()
        {
            var FlightId = HttpContext.Session.GetString("FlightId");
            var sesijaUser = HttpContext.Session.GetString("Test");
            var korisnik = _repoWrapper.User.getUsers.Where(u => u.Email == sesijaUser);
            ReservationViewModel reservationView = new ReservationViewModel()
            {
                Name = korisnik.Select(n => n.Name).FirstOrDefault(),
                Surname = korisnik.Select(s=>s.Surname).FirstOrDefault()
            };

            return View(reservationView);
        }
        [HttpPost]
        public IActionResult Reservation(ReservationViewModel model)
        {
            var sesijaId = HttpContext.Session.GetString("SeatId");
            var sesijaUser = HttpContext.Session.GetString("Test");
            var FlightId = HttpContext.Session.GetString("FlightId");
            if (ModelState.IsValid)
            {
                Reservation reservation = new Reservation();
                Guid Id = Guid.NewGuid();
                reservation.Id = Id;
                reservation.Name = model.Name;
                reservation.PassportSerialNumber = model.Passport;
                reservation.Surname = model.Surname;
                reservation.SeatId = new Guid(sesijaId);
                if (model.Passport == null || model.Name == null || model.Surname == null)
                {
                    
                    ViewBag.Message = "Da bi ste uspesno izmenili svoje podatke, neophodno je popuniti sva polja za unos!";
                    return View(model);
                }
                reservation.FlightId = new Guid(FlightId);
                var provjera = _repoWrapper.Seat.getSeats.ToString();
                _repoWrapper.Reservation.Add(reservation);
                ViewBag.Message = "Uspesno ste rezervisali let. Potvrta za o rezervaciji ce vam u najskorijem vremenu doc na mail";
                return View("/Views//Home/Home.cshtml");

                

            }
            
            return View(model);
        }
        [HttpGet]
        public IActionResult Hotel()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Auto()
        {
            return View();
        }
        [HttpGet]
        public IActionResult BrzaRezervacija()
        {
            return View();
        }
    }
}
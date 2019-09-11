using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EasyFlight.Repository;
using EasyFlight.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EasyFlight.Controllers
{
    public class AirplaneController : Controller
    {
        private IRepoWrapper _repoWrapper;
        public AirplaneController(IRepoWrapper repoWrapper)
        {
            _repoWrapper = repoWrapper;
        }
        [HttpGet]
        public IActionResult Index(Guid id)
        {
            
            var allSeats = _repoWrapper.Seat.getSeats.ToList();
            var resevation = _repoWrapper.Reservation.getReservations.Where(f=>f.FlightId== id).ToList();//TODO: filter po letu
            var seatInfos = _repoWrapper.SeatInfo.getSeatInfos.ToList();


            List<AdminSeatViewModel> seats = new List<AdminSeatViewModel>();

            foreach (var singleSeat in allSeats)
            {

                seats.Add(new AdminSeatViewModel()
                {
                    FlightId = id,
                    SeatId = singleSeat.Id,
                    ColumnNumber = singleSeat.ColumnNumber,
                    RowNumber = singleSeat.RowNumber,
                    Occupide = resevation.Any(n => n.SeatId == singleSeat.Id),
                    Disabled = !seatInfos.Any(n => n.SeatId == singleSeat.Id),

                });
            }
            AirlineHomeViewModel rm = new AirlineHomeViewModel()
            {
                seats = seats
            };

            return View(rm);
        }
        [HttpPost]
        public IActionResult Index(AirlineHomeViewModel model)
        {
            var allSeat = _repoWrapper.Seat.getSeats.ToList();


            var r = this.Request.Form.Keys.ToList();

            var colona = allSeat.Select(c => c.ColumnNumber).ToList();
            var red = allSeat.Select(re => re.RowNumber).ToList();
            var prvaRezervacija = r.First().ToString();
            var prviElement = prvaRezervacija.Substring(0, 1).ToString();
            var last = prvaRezervacija[prvaRezervacija.Length - 1].ToString();
            var id = allSeat.Where(r1 => r1.RowNumber == prviElement && r1.ColumnNumber == last).Select(r1 => r1.Id).FirstOrDefault();

            HttpContext.Session.SetString("SeatId", id.ToString());
            return RedirectToAction("Reservation", "Reservation");
        }
    }
}
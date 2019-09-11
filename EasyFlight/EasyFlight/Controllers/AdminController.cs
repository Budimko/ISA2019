using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EasyFlight.Models;
using EasyFlight.Repository;
using EasyFlight.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EasyFlight.Controllers
{
    public class AdminController : Controller
    {
        private IRepoWrapper _repoWrapper;
        public AdminController(IRepoWrapper repoWrapper)
        {
            _repoWrapper = repoWrapper;
        }
        public IActionResult UrediLet(Guid id)
        {
            var allSeats = _repoWrapper.Seat.getSeats.ToList();
            var resevation = _repoWrapper.Reservation.getReservations.Where(f=>f.FlightId==id).ToList();
            var seatInfos = _repoWrapper.SeatInfo.getSeatInfos.ToList();
            HttpContext.Session.SetString("flightId", id.ToString());


            List<AdminSeatViewModel> seats = new List<AdminSeatViewModel>();

            foreach (var singleSeat in allSeats)
            {

                seats.Add(new AdminSeatViewModel()
                {
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
        public IActionResult Omoguci([FromBody] SeatInfo seatInfo)
        {
            Guid Id = Guid.NewGuid();
            SeatInfo seat = new SeatInfo();
            seat.Id = Id;
            seat.FlightId = seatInfo.FlightId;
            seat.SeatId = seatInfo.SeatId;
            
            _repoWrapper.SeatInfo.Add(seat);
           // return Ok();
            //return

            return RedirectToAction("UrediLet", "Admin", new { id = seatInfo.FlightId });
        }
        [HttpPost]
        public IActionResult Onemoguci([FromBody] SeatInfo seatInfo)
        {
            
            var allSeatInfo = _repoWrapper.SeatInfo.getSeatInfos.ToList();
            var seat = seatInfo.SeatId;
            var r = allSeatInfo.Where(si => si.SeatId == seat).Select(si=>si.Id).FirstOrDefault();
            // _repoWrapper.

            // _repoWrapper.SeatInfo.Remove(r);


           _repoWrapper.SeatInfo.RemoveBySeatFlight(seatInfo.SeatId, seatInfo.FlightId);


            //return Json(seatInfo);
            return RedirectToAction("UrediLet", "Admin", new { id = seatInfo.FlightId });

            //return RedirectToAction("UrediLet", "Admin", new { id = seatInfo.FlightId });
            //return Redirect(Request.Headers["Referer"].ToString());
        }
        [HttpGet]
        public IActionResult Popust()
        {
            
            return View();
        }
        [HttpPost]
        public IActionResult Popust(AdminSeatViewModel model)
        {
            var flightID = HttpContext.Session.GetString("flightId");
            
            
            return View();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EasyFlight.Models;
using EasyFlight.Repository;
using EasyFlight.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EasyFlight.Controllers
{
    public class TestController : Controller
    {
        private readonly IRepoWrapper _service;

        public TestController(IRepoWrapper repoWrapper)
        {
            _service = repoWrapper;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(SeatViewModel model)
        {
            Guid SeatId = Guid.NewGuid();
            Guid AirplainId = new Guid("320F2833-58C2-49E8-8DA1-1EF29C47CF5B");//
            Guid TypeId = new Guid("ed44f3c7-0271-448e-9445-2806f544061c");
            Seat seat = new Seat();
            seat.Id = SeatId;
            seat.AirplaneId = AirplainId;
            seat.TypeId = TypeId;
            seat.ColumnNumber = model.ColumnNumber;
            seat.RowNumber = model.RowNumber;
            _service.Seat.Add(seat);



            return View("Index", "Test");
        }
    }
}
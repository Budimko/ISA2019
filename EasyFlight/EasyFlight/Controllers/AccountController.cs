﻿
using Microsoft.AspNetCore.Mvc;
using EasyFlight.ViewModel;
using System;
using EasyFlight.Models;
using EasyFlight.Repository;
using EasyFlight.Mapper;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;
//using System.Web.SessionState.HttpSessionState;

namespace EasyFlight.Controllers
{
    public class AccountController : Controller
    {
        private readonly IRepoWrapper _service;

        public AccountController(IRepoWrapper repoWrapper)
        {
            _service = repoWrapper;
        }
        
        [HttpGet]
        [Route("Account/Register")]
        public ViewResult Register()
        {
            return View();
        }
        
        
        [HttpPost]
        public IActionResult Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                User user = MapperToDataModel.FromUserViewModeToUser(model);
                _service.User.Add(user);

                ViewBag.Message = "Uspesno ste se registrovali na nas sajt. Mozete se ulogovari i koristiti sve funkcije sajta EasyTravel";
                return View("Views/Home/Home.cshtml");
            }
            else
            {
                ViewBag.Message = "Da bi ste se uspjesno registrovali, morate popuniti sva polja prilikom rezervacije i/ili vam se pasvordi razlikuju";
                return View(model);
            }

            //return Ok();
        }
        [HttpGet]
        [Route("Account/Login")]
        public ViewResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(LoginViewModel lModel)
        {
           
            var login = _service.User.getUsers.Where(u => u.Email == lModel.Email && u.Password == lModel.Password).Any();
            Guid roleId = new Guid("6391dfdd-a479-4ea9-bc6a-312dbd2cbbe2");
            var role = _service.User.getUsers.Where(u => u.RoleId == roleId).ToList();
            var roleLogin = role.Where(u => u.Email == lModel.Email && u.Password == lModel.Password).Any();


            if (ModelState.IsValid)
            {
                if (roleLogin == true)
                {
                    HttpContext.Session.SetString("Admin", lModel.Email.ToString());
                    ViewBag.Message = "Dobro dosli na sajt EasyTrave. Na vasoj profilnoj stranici imate link ka aviokompaniji";
                    return View("Views/Home/Home.cshtml");
                    //return RedirectToAction("Index", "User");
                }

                if (login == true)
                {

                    HttpContext.Session.SetString("Test", lModel.Email.ToString());
                    ViewBag.Message = "Dobro dosli na sajt EasyTrave.";
                    return View("Views/Home/Home.cshtml");

                }

                ViewBag.Message = "Pogresno ste uneli mail ili password";
                return View(lModel);
                

            }
            ViewBag.Message = "Niste popunili sva polja za unos.";
            return View(lModel);
           

            
        }
        [HttpGet]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Home", "Home");
        }
    }
}
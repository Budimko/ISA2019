using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EasyFlight.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using static Microsoft.AspNetCore.Hosting.Internal.HostingApplication;
using EasyFlight.Models;
using EasyFlight.ViewModel;

namespace EasyFlight.Controllers
{
    public class UserController : Controller
    {
        private IRepoWrapper _repoWrapper;
        public UserController(IRepoWrapper repoWrapper)
        {
         

            _repoWrapper = repoWrapper;

        }
        [HttpGet]
        
        public IActionResult Index()
        {
            string sesija;
            User userResult = new User();
            var user = _repoWrapper.User.getUsers.ToList();

            if (String.IsNullOrEmpty(sesija = HttpContext.Session.GetString("Test")))
            {
                sesija = HttpContext.Session.GetString("Admin");
                var res = user.Where(e => e.Email.Equals(sesija)).ToList();
                foreach (var item in res)
                {
                    userResult.Name = item.Name;
                    userResult.Surname = item.Surname;
                    userResult.Password = item.Password;
                    userResult.Email = item.Email;
                    userResult.Address = item.Address;
                    userResult.PhoneNumber = item.PhoneNumber;
                    userResult.AirlineId = item.AirlineId;

                }
                

            }
            else
            {
                sesija = HttpContext.Session.GetString("Test");
                var res = user.Where(e => e.Email.Equals(sesija)).ToList();
                foreach (var item in res)
                {
                    userResult.Name = item.Name;
                    userResult.Surname = item.Surname;
                    userResult.Password = item.Password;
                    userResult.Email = item.Email;
                    userResult.Address = item.Address;
                    userResult.PhoneNumber = item.PhoneNumber;
                    

                }
            }
            
            //
            
           

            return View(userResult);
        }
        [HttpGet]
        [Route("User/Edit")]
        public IActionResult Edit()
        {

            string sesija;
            var user = _repoWrapper.User.getUsers.ToList();

            if (String.IsNullOrEmpty(sesija = HttpContext.Session.GetString("Test")))
            {
                sesija = HttpContext.Session.GetString("Admin");
            }
            else
            {
                sesija = HttpContext.Session.GetString("Test");
            }

            var res = user.Where(e => e.Email.Equals(sesija)).ToList();


            return View(res);

        }
        [HttpPost]
        public IActionResult Edit(User model)
        {
            if (ModelState.IsValid)
            {
                if (String.IsNullOrEmpty(HttpContext.Session.GetString("Test")))
                {
                    model.RoleId = new Guid("6391dfdd-a479-4ea9-bc6a-312dbd2cbbe2");
                }
                else
                {
                    model.RoleId = new Guid("dd1239f4-2645-456f-882a-7d2ab7d336b0");
                }
                User user = _repoWrapper.User.GetUser(model.Id);
                user.Id = model.Id;
                user.RoleId = model.RoleId;
                user.Name = model.Name;
                user.Surname = model.Surname;
                user.Email = model.Email;
                user.Password = model.Password;
                user.Address = model.Address;
                user.PhoneNumber = model.PhoneNumber;
                _repoWrapper.User.Edit(user);
                return RedirectToAction("Index", "User");
            }
            ViewBag.Message = "Da bi ste uspesno izmenili svoje podatke, neophodno je popuniti sva polja za unos!";
            return Ok();
        }
        public IActionResult SpisakPrijatelja()
        {
            
            
            var r = HttpContext.Session.GetString("Test");
            var users = _repoWrapper.User.getUsers.ToList();
            var res = users.Where(e => e.Email.Equals(r)).SingleOrDefault();

            var sviPriji = _repoWrapper.Friend.getFriends().ToList();

            var friensGroup = sviPriji.Where(f => f.UserSendId == res.Id || f.UserReceivedId == res.Id).ToList();

            var friendsSendTo = friensGroup.Where(f => f.UserSendId == res.Id).Select(x => x.UserReceivedId).ToList();
            var allFriends = friensGroup.Where(f => f.UserReceivedId == res.Id).Select(x => x.UserSendId).ToList();
            allFriends.AddRange(friendsSendTo);
            List<FriendViewModel> frinds = new List<FriendViewModel>();

            foreach (var item in allFriends)
            {
                frinds.Add(new FriendViewModel()
                {
                    FIrstName = users.Where(u => u.Id == item).Select(u => u.Name).SingleOrDefault(),
                    LastName = users.Where(u => u.Id == item).Select(u => u.Surname).SingleOrDefault()
                });
            }

            return View(frinds);
        }
        [HttpGet]
        public IActionResult DodajPrijatelja()
        {
            return View();
        }
        [HttpPost]
        public IActionResult DodajPrijatelja(FriendViewModel model)
        {
            var userSession = HttpContext.Session.GetString("Test");
            var user = _repoWrapper.User.getUsers.Where(u => u.Email == userSession).ToList();
            var users = _repoWrapper.User.getUsers.ToList();
            var userName = users.Where(u => u.Name == model.FIrstName).Select(u=>u.Name).FirstOrDefault();
            var userSurname = users.Where(s => s.Surname== model.LastName).Select(u => u.Surname).FirstOrDefault();
            var firstLast = userName.ToString() + userSurname.ToString();
            Friend friend = new Friend();
            var imeIPrezime = model.FIrstName+model.LastName;
            
            
                Guid Id = Guid.NewGuid();
                friend.Id = Id;
                friend.UserSendId = user.Select(u => u.Id).SingleOrDefault();

            
            return View();
        }

    }
}
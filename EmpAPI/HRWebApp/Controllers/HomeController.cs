using HRWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using HRWebApp.Models;
using HRWebApp.Persistence;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.IO;

namespace HRWebApp.Controllers
{
    public class HomeController : Controller
    {
        List<User> USERLIST = new List<User>();

        string fileName = @"D:\CDAC\DotNet\EmpAPI\USERSLIST.json";

        private readonly ILogger<HomeController> _logger;

        public Organization TransFlower;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login() { 
        
            return View();
        }

        [HttpPost]
        public IActionResult Login(string email, string password) {

            USERLIST = Serialize.DeSerialization(fileName);

            foreach (User U in USERLIST) {

                if (U.email == email && U.password == password)
                {
                    return RedirectToAction("Welcome");
                }
            }//end of for loop

            return RedirectToAction("LoginFailure");
        }

        public IActionResult Welcome()
        {
            return View();
        }

        public IActionResult LoginFailure()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Register() {

            return View();
        }

        [HttpPost]
        public IActionResult Register(string fullname, string email, string password, string contact, string address, DateTime dob) {

            User newUser = new User(fullname, address, contact, dob, email, password);

            if (!Serialize.existenceChecking(fileName))
            {
                USERLIST.Add(newUser);

                Serialize.Serialization(USERLIST);

                return RedirectToAction("SuccesfulRegistration");

            }
            else
            { 
                USERLIST = Serialize.DeSerialization(fileName);

                USERLIST.Add(newUser);

                Serialize.Serialization(USERLIST);

                return RedirectToAction("SuccesfulRegistration");
            }


        }

        public IActionResult SuccesfulRegistration() {

            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
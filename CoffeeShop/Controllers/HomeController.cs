using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CoffeeShop.Models;
using Microsoft.AspNetCore.Session;
using System.Web;
using Microsoft.AspNetCore.Http;
namespace CoffeeShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        //need one action to load registration page another view;
        public IActionResult Register()
        {
            return View();
        }
        //need one action to take userInputs and display user name and whatever else you want and display a new view;

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddUser(Users user)
        {
            ShopDBContext db = new ShopDBContext();
            db.Add(user);
            db.SaveChanges();
            return View(user);
        }
        public IActionResult ValidateUser(Users user)
        {
            ShopDBContext db = new ShopDBContext();
            var contexted = db.Users.Where(b => b.Email == user.Email && b.Password == user.Password).FirstOrDefault();
            if (contexted != null)
            {
                TempData["current"] = "loggedin";
                TempData.Save();
                return Shop();
            }
            else
            {
                return View("LoginPage");
            }
        }
        public IActionResult Shop()
        {
            ShopDBContext db = new ShopDBContext();
            return View("Shop",db);
           
        }
        public IActionResult LoginPage()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }
        
        
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }

   
}

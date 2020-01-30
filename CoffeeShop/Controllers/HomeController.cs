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
            var validateEmail = db.Users.Where(b => b.Email == user.Email).FirstOrDefault();
            var validatePw = db.Users.Where(b => b.Email == user.Email && b.Password == user.Password).FirstOrDefault();
            if (validateEmail != null && validatePw != null)
            {
                HttpContext.Session.SetInt32("current", validatePw.Id);
                
                return RedirectToAction("Shop");
            }
            else if(validateEmail == null)
            {
                TempData["IncorrectEmail"] = true;
                return View("LoginPage");
            }
            else if (validatePw == null)
            {
                TempData["IncorrectPw"] = true;
                return View("LoginPage");
            }
            else
            {
                return View("LoginPage");
            }
        }
        public IActionResult Shop()
        {
            
            ShopDBContext db = new ShopDBContext();
            //if(TempData["current"] != null)
            //{
            //    TempData["new"] = TempData["current"];
            //}
            
            return View("Shop", db);
           
        }
        public IActionResult PurchaseItem(Items item)
        {
            ShopDBContext db = new ShopDBContext();
            Users founduser = new Users();
            Items foundItem = new Items();
            //if (TempData["new"] != null)
            //{
            //    TempData["there"] = TempData["new"];
            //}
            //int trythis = (int)TempData["there"];
            foreach (Users u in db.Users)
            {
                if (u.Id == HttpContext.Session.GetInt32("current"))
                {
                    founduser = u;
                }
            }
            foreach (Items i in db.Items)
            {
                if (i.ProductName == item.ProductName)
                {
                    foundItem = i;
                }
            }
            if (founduser.Funds > foundItem.Price)
            {
                founduser.Funds -= foundItem.Price;
                foundItem.Quantity -= 1;
                db.SaveChanges();
                return View("Shop", db);
            }
            else
            {
                return InsufficientFunds(founduser.Funds.ToString(), foundItem.Price.ToString());
            }
        }
        public IActionResult LoginPage()
        {
            return View();
        }
        public IActionResult InsufficientFunds(string funds, string price)
        {
            ViewBag.Funds = funds;
            ViewBag.Price = price;
            return View("InsufficientFunds");
        }
        public IActionResult Privacy()
        {
            return View();
        }

        //Scaffold-DbContext “Server=<ServerName>;Database=<Database Name>;Integrated Security=True” Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models -Force
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }

   
}

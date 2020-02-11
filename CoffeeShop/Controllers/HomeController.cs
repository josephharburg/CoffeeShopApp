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
        private List<Items> itemlist;
        private List<Users> userlist;
        private ShopDBContext db;

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
            else if (validateEmail == null)
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
        //[Authorize] use this for forcing user to login with Identity Framework.
        public IActionResult Shop()
        {

            ShopDBContext db = new ShopDBContext();


            return View("Shop", db);

        }
        public IActionResult UserItemsController()
        {
            return View();
        }
        public IActionResult List()
        {
            ShopDBContext db = new ShopDBContext();

            List<PurchasedItems> pI = new List<PurchasedItems>();
            foreach (PurchasedItems n in db.PurchasedItems)
            {
                if (n.UserId == HttpContext.Session.GetInt32("current"))
                {
                    pI.Add(n);
                }
            }

            return View("List", pI);
        }
        public IActionResult Details(Items s)
        {
            ShopDBContext db = new ShopDBContext();
            Items item = new Items();

            foreach (Items i in db.Items)
            {
                if (s.ProductName == i.ProductName)
                {
                    item = i;
                };
            }
            return View(item);
        }
        public IActionResult PurchaseItem(Items item)
        {
            ShopDBContext db = new ShopDBContext();
            Users founduser = new Users();
            Items foundItem = new Items();
            PurchasedItems foundPurchasedItem = new PurchasedItems();
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
            foreach (PurchasedItems d in db.PurchasedItems)
            {
                if (d.ProductName == item.ProductName && d.UserId == founduser.Id)
                {
                    foundPurchasedItem = d;
                }
            }
            if (founduser.Funds > foundItem.Price)
            {
                founduser.Funds -= foundItem.Price;
                foundItem.Quantity -= 1;
                PurchasedItems purchasedItem = new PurchasedItems() { UserId = founduser.Id, ProductName = foundItem.ProductName, Description = foundItem.Description, ItemType = foundItem.ItemType, Quantity = 1 };
                UserItems useritem = new UserItems() { ItemId = foundItem.ProductName, UserId = founduser.Id, };

                db.Add(useritem);
                if (foundPurchasedItem.ProductName != null)
                {
                    foundPurchasedItem.Quantity += 1;
                }
                else
                {
                    db.Add(purchasedItem);
                }
                db.SaveChanges();
                return View("Shop", db);
            }
            else
            {
                return InsufficientFunds(founduser.Funds.ToString(), foundItem.Price.ToString());
            }
        }
        public IActionResult ReturnPage(PurchasedItems item)
        {
            ShopDBContext db = new ShopDBContext();
            PurchasedItems returningItem = new PurchasedItems();
            foreach (PurchasedItems i in db.PurchasedItems)
            {
                if (i.Id == item.Id)
                {
                    returningItem = i;
                }
            }
            return View(returningItem);
        }
        public IActionResult DeleteItem(PurchasedItems item)
        {
            ShopDBContext db = new ShopDBContext();
            Users user = new Users();
            Items iteminfo = new Items();
            PurchasedItems returningItem = new PurchasedItems();
            foreach (PurchasedItems i in db.PurchasedItems)
            {
                if (i.Id == item.Id)
                {
                    returningItem = i;
                }
            }
            if (returningItem.ItemType != null)
            {
                foreach (Users u in db.Users)
                {
                    if (returningItem.UserId == u.Id)
                    {
                        user = u;
                    }
                }
                foreach (Items price in db.Items)
                {
                    if (returningItem.ProductName == price.ProductName)
                    {
                        iteminfo = price;
                    }
                }

                user.Funds += iteminfo.Price;
                iteminfo.Quantity += 1;
                if (returningItem.Quantity == 1)
                {
                    db.Remove(returningItem);
                }
                else
                {
                    returningItem.Quantity -= 1;
                }

                db.SaveChanges();
                return List();
            }
            else
            {
                return List();
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
            var user = User.Identity;
            var x = db.UserItems.Where(d => d.UserId == 1).ToList();
            return View();
        }
        private void GetData()
        {
            ShopDBContext db = new ShopDBContext();
            itemlist = db.Items.ToList();
            userlist = db.Users.ToList();
        }
        //Scaffold-DbContext “Server=.\sqlexpress;Database=ShopDB;Integrated Security=True” Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models -Force
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }


}

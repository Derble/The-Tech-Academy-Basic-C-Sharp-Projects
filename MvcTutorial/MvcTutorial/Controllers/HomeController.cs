using MvcTutorial.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcTutorial.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //string text = "Hello";//writes hello to a fileon the desktop whenever someone goes to index
            //System.IO.File.WriteAllText(@"C:\Users\RX-78\Desktop\log2.txt", text);

            //Random rnd = new Random(10);
            //int num = rnd.Next();

            //ViewBag.RandomNumber = num; //viewbag is like a dictionary, throw in any kind of datatype
            //if (num > 20000)
            //{
            //    return View("About");
            //}

            //return Content("hello");

            //return RedirectToAction("Contact");

            //List<string> names = new List<string>
            //{
            //    "Jesse",
            //    "Adam",
            //    "Brett"
            //};

            //int number = 5;

            User user = new User();
            user.Id = 1;
            user.FirstName = "Jesse";
            user.LastName = "Johnson";
            user.Age = 32;


            return View(user);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            //throw new Exception("Invalid page");

            return View();
        }

        public ActionResult Contact(int id = 0)
        {
            //ViewBag.Message = "Your contact page.";

            ViewBag.Message = id;

            return View();
        }
    }
}
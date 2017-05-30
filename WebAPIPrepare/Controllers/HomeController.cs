using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAPIPrepare.Models;

namespace WebAPIPrepare.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //ViewBag.Title = "Home Page";

            return View();
        }

        public ActionResult Add() {

            return View();
        }

        public ActionResult Remove(int id)
        {
            Book b = ValuesController.list.SingleOrDefault(book => book.ID == id);
            return View(b);
        }

        public ActionResult Delete()
        {

            return View();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TheStation.Models;
using TheStation.ViewModels;

namespace TheStation.Controllers
{
  //  [OutputCache(Duration = 604800)]// 1 week
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

		public ActionResult Portfolio()
		{
			return View();
		}

		public ActionResult Stylists()
		{
			var model = new Employees();
			
			return View(model.GetStaff());
		}

		public ActionResult Services()
		{
			var model = new Services();
			return View(model);
		}

		public ActionResult Contact()
		{
			return View();
		}

        public ActionResult Products()
        {
            var model = new Products();
            return View(model.GetProducts());
        }

        public ActionResult Bookings()
        {
            return View();
        }

        public ActionResult ImageGallery()
        {
            var sorter = new ImageSorter();
            return View(sorter);
        }
    }
}

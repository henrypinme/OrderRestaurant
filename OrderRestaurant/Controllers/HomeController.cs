using OrderRestaurant.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OrderRestaurant.Controllers
{
	public class HomeController : Controller
	{
		OrderRestaurantDb _db = new OrderRestaurantDb();

		public ActionResult Index()
		{
			var model = _db.Restaurants.ToList();
			return View(model);
		}

		public ActionResult About()
		{
			var model = new AboutModel();
			model.Name = "Henry";
			model.Location = "London";

			return View(model);
		}

		public ActionResult Contact()
		{
			ViewBag.Message = "Your contact page.";

			return View();
		}

		protected override void Dispose(bool disposing)
		{
			if (_db != null)
			{
				_db.Dispose();
			}
			base.Dispose(disposing);
		}
	}
}
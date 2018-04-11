using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OrderRestaurant.Controllers
{
    public class CuisineController : Controller
    {
        // GET: Cuisine
        public ActionResult Search(string name = "rolon")
        {
			var message = Server.HtmlEncode(name);
			//return Content(message);
			return Json(new { Message = message, Name = "Amalia" }, JsonRequestBehavior.AllowGet);	
        }
    }
}
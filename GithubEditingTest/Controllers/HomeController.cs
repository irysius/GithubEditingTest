using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GithubEditingTest.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			return View();
		}

		public ActionResult About()
		{
			ViewBag.Message = "Your application description page.";

			return View();
		}

		public ActionResult Contact()
		{
			ViewBag.Message = "Your contact page.";

			return View();
		}

		public ActionResult Article(string id)
		{
			int temp;
			if (Int32.TryParse(id, out temp))
			{
				if (1 <= temp && temp <= 3)
				{
					return View(String.Format("Article{0}", id));
				}
			}

			return Redirect("/");
		}
	}
}